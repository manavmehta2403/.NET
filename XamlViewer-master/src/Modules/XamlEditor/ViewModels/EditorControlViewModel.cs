﻿using System;
using System.Windows;
using System.Collections.Generic;
using System.Threading.Tasks;

using Prism;
using Prism.Mvvm;
using Prism.Events;
using Prism.Regions;
using Prism.Commands;
using XamlService.Events;
using XamlService.Commands;
using XamlService.Payloads;
using XamlTheme.Controls;
using XamlEditor.Views;
using XamlService.Utils;
using Prism.Ioc;

namespace XamlEditor.ViewModels
{
    public class EditorControlViewModel : BindableBase, IDisposable, IActiveAware
    {
        private string _fileGuid = null;
        private bool _isReseting = false;

        private TextEditorEx _textEditor = null;
        private XsdParser _xsdParser = null;

        private IEventAggregator _eventAggregator = null;
        private IApplicationCommands _appCommands = null;

        private SettingChangedEvent _settingChangedEvent = null;
        private LoadTextEvent _loadTextEvent = null;
        private UpdateTabStatusEvent _updateTabStatusEvent = null;
        private SelectTabEvent _selectTabEvent = null;

        public DelegateCommand<RoutedEventArgs> LoadedCommand { get; private set; }
        public DelegateCommand DelayArrivedCommand { get; private set; }
        public DelegateCommand TextChangedCommand { get; private set; }

        public DelegateCommand<string> SaveCommand { get; private set; }
        public DelegateCommand CompileCommand { get; private set; }
        public DelegateCommand RedoCommand { get; private set; }
        public DelegateCommand UndoCommand { get; private set; }

        public EditorControlViewModel(IContainerExtension container, IEventAggregator eventAggregator, IApplicationCommands appCommands)
        {
            _xsdParser = container.Resolve<XsdParser>();
            _eventAggregator = eventAggregator;
            _appCommands = appCommands;

            InitEvent();
            InitCommand();
        }

        #region Init

        private void InitEvent()
        {
            //event
            _settingChangedEvent = _eventAggregator.GetEvent<SettingChangedEvent>();
            _settingChangedEvent.Subscribe(OnSettingChanged, ThreadOption.PublisherThread, false, info => string.IsNullOrEmpty(info.Guid) || info.Guid == _fileGuid);

            _loadTextEvent = _eventAggregator.GetEvent<LoadTextEvent>();
            _loadTextEvent.Subscribe(OnLoadText, ThreadOption.UIThread, false, tab => tab.Guid == _fileGuid);

            _updateTabStatusEvent = _eventAggregator.GetEvent<UpdateTabStatusEvent>();
            _updateTabStatusEvent.Subscribe(OnUpdateTabStatus, ThreadOption.PublisherThread, false, tab => tab.Guid == _fileGuid);

            _selectTabEvent = _eventAggregator.GetEvent<SelectTabEvent>();
            _selectTabEvent.Subscribe(OnSelectTab, ThreadOption.PublisherThread, false, info => info.Guid == _fileGuid);
        }

        private void InitCommand()
        {
            //Command
            LoadedCommand = new DelegateCommand<RoutedEventArgs>(Loaded);
            DelayArrivedCommand = new DelegateCommand(DelayArrived);
            TextChangedCommand = new DelegateCommand(TextChanged);

            SaveCommand = new DelegateCommand<string>(Save, CanSave);
            _appCommands.SaveCommand.RegisterCommand(SaveCommand);

            CompileCommand = new DelegateCommand(Compile, CanCompile);
            _appCommands.CompileCommand.RegisterCommand(CompileCommand);

            RedoCommand = new DelegateCommand(Redo, CanRedo);
            _appCommands.RedoCommand.RegisterCommand(RedoCommand);

            UndoCommand = new DelegateCommand(Undo, CanUndo);
            _appCommands.UndoCommand.RegisterCommand(UndoCommand);
        }

        #endregion

        #region Property

        private bool _isSelected = false;
        public bool IsSelected
        {
            get { return _isSelected; }
            set
            {
                if (SetProperty(ref _isSelected, value))
                {
                    if (_isSelected)
                    {
                        _textEditor?.Focus();
                        CaretPosChanged();
                    }
                }
            }
        }

        private bool _isShowEditor = false;
        public bool IsShowEditor
        {
            get { return _isShowEditor; }
            set
            {
                if (SetProperty(ref _isShowEditor, value))
                {
                    CompileCommand.RaiseCanExecuteChanged();
                }
            }
        }

        private bool _isReadOnly = false;
        public bool IsReadOnly
        {
            get { return _isReadOnly; }
            set
            {
                if (SetProperty(ref _isReadOnly, value))
                {
                    SaveCommand.RaiseCanExecuteChanged();
                }
            }
        }

        private int _caretLine = 0;
        public int CaretLine
        {
            get { return _caretLine; }
            set
            {
                if (SetProperty(ref _caretLine, value))
                    CaretPosChanged();
            }
        }

        private int _caretColumn = 0;
        public int CaretColumn
        {
            get { return _caretColumn; }
            set
            {
                if (SetProperty(ref _caretColumn, value))
                    CaretPosChanged();
            }
        }

        private bool _isModified;
        public bool IsModified
        {
            get { return _isModified; }
            set
            {
                if (SetProperty(ref _isModified, value))
                {
                    RedoCommand.RaiseCanExecuteChanged();
                    UndoCommand.RaiseCanExecuteChanged();

                    if (!_isReseting)
                    {
                        _eventAggregator.GetEvent<TextChangedEvent>().Publish(new EditorInfo
                        {
                            Guid = _fileGuid,
                            IsModified = _isModified,
                        });
                    }
                }
            }
        }

        private string _fontFamily = "Calibri";
        public string FontFamily
        {
            get { return _fontFamily; }
            set { SetProperty(ref _fontFamily, value); }
        }

        private double _fontSize = 10d;
        public double FontSize
        {
            get { return _fontSize; }
            set { SetProperty(ref _fontSize, value); }
        }

        private bool _wordWrap = false;
        public bool WordWrap
        {
            get { return _wordWrap; }
            set { SetProperty(ref _wordWrap, value); }
        }

        private bool _showLineNumber = true;
        public bool ShowLineNumber
        {
            get { return _showLineNumber; }
            set { SetProperty(ref _showLineNumber, value); }
        }

        private bool _autoCompile = true;
        public bool AutoCompile
        {
            get { return _autoCompile; }
            set { SetProperty(ref _autoCompile, value); }
        }

        private double _autoCompileDelay = 1d;
        public double AutoCompileDelay
        {
            get { return _autoCompileDelay; }
            set { SetProperty(ref _autoCompileDelay, value); }
        }

        private bool _codeCompletion = false;
        public bool CodeCompletion
        {
            get { return _codeCompletion; }
            set { SetProperty(ref _codeCompletion, value); }
        }

        private Func<string, string, string, List<string>> _generateCompletionDataFunc = null;
        public Func<string, string, string, List<string>> GenerateCompletionDataFunc
        {
            get
            {
                if (_generateCompletionDataFunc == null)
                    _generateCompletionDataFunc = (parentElement, element, attribute) =>
                    {
                        if (_xsdParser == null || !CodeCompletion)
                            return null;

						try
						{
							if (!string.IsNullOrWhiteSpace(parentElement))
								return _xsdParser.GetChildElements(parentElement);

							if (!string.IsNullOrWhiteSpace(element))
							{
								if (!string.IsNullOrWhiteSpace(attribute))
									return _xsdParser.GetValues(element, attribute);

								return _xsdParser.GetAttributes(element);
							}

							return _xsdParser.GetElements();	
						}
						catch(Exception ex)
						{
							return null;
						}
                    };

                return _generateCompletionDataFunc;
            }
        }

        #endregion

        #region Command

        private void Loaded(RoutedEventArgs e)
        {
            var editorControl = e.OriginalSource as EditorControl;

            _textEditor = editorControl.XamlTextEditorEx;

            var selectInfo = (TabSelectInfo)(RegionContext.GetObservableContext(editorControl).Value);
            if (selectInfo != null)
            {
                _fileGuid = selectInfo.Guid;

                IsActive = selectInfo.IsSelected;
                IsSelected = selectInfo.IsSelected;

                _eventAggregator.GetEvent<RequestSettingEvent>().Publish(_fileGuid);
                _eventAggregator.GetEvent<RequestTextEvent>().Publish(new TabInfo { Guid = _fileGuid });
            }
        }

        private void DelayArrived()
        {
            if (AutoCompile)
                Compile();
        }

        private void TextChanged()
        {
            UndoCommand.RaiseCanExecuteChanged();
            RedoCommand.RaiseCanExecuteChanged();
        }

        private bool CanSave(string fileGuid)
        {
            return !IsActive || !IsReadOnly;
        }

        //fileGuid == null && IsActive == true for Global SaveCommand, just save current actived tab
        //fileGuid != null && fileGuid == _fileGuid for Global SaveAllCommand, save all tabs
        private void Save(string fileGuid)
        {
            var isNullOrEmpty = string.IsNullOrEmpty(fileGuid);
            if (isNullOrEmpty && IsActive || !isNullOrEmpty && fileGuid == _fileGuid)
            {
                Reset();

                if (!_textEditor.CheckAccess())
                {
                    _textEditor.Dispatcher.BeginInvoke((Action)(() =>
                    {
                        _eventAggregator?.GetEvent<SaveTextEvent>().Publish(new TabInfo { Guid = _fileGuid, FileContent = _textEditor.Text });
                    }));
                }
                else
                {
                    _eventAggregator?.GetEvent<SaveTextEvent>().Publish(new TabInfo { Guid = _fileGuid, FileContent = _textEditor.Text });
                }
            }
        }

        private bool CanCompile()
        {
            return IsShowEditor;
        }

        private void Compile()
        {
            Compile(null);
        }

        private bool CanRedo()
        {
            return _textEditor != null && _textEditor.CanRedo;
        }

        private void Redo()
        {
            _textEditor?.Redo();
        }

        private bool CanUndo()
        {
            return _textEditor != null && _textEditor.CanUndo;
        }

        private void Undo()
        {
            _textEditor?.Undo();
        }

        #endregion

        #region Event

        private void OnSettingChanged(ValueWithGuid<EditorSetting> valueWithGuid)
        {
            if (!string.IsNullOrEmpty(valueWithGuid.Guid) && valueWithGuid.Guid != _fileGuid)
                return;

            FontFamily = valueWithGuid.Value.FontFamily;
            FontSize = valueWithGuid.Value.FontSize;
            ShowLineNumber = valueWithGuid.Value.ShowLineNumber;
            WordWrap = valueWithGuid.Value.WordWrap;
            CodeCompletion = valueWithGuid.Value.CodeCompletion;

            AutoCompile = valueWithGuid.Value.AutoCompile;
            AutoCompileDelay = valueWithGuid.Value.AutoCompileDelay;
        }

        private void OnLoadText(TabInfo tabInfo)
        {
            if (tabInfo.Guid != _fileGuid || _textEditor == null)
                return;

            Reset(() =>
            {
                IsReadOnly = tabInfo.IsReadOnly;
                IsShowEditor = tabInfo.IsShowEditor;

                _fileGuid = tabInfo.Guid;
                _textEditor.Text = tabInfo.FileContent;
            });

            if (IsSelected)
            {
                CompileCommand.RaiseCanExecuteChanged();
                RedoCommand.RaiseCanExecuteChanged();
                UndoCommand.RaiseCanExecuteChanged();

                _textEditor.Focus();
                CaretPosChanged();

                if (AutoCompile || IsReadOnly)
                    Compile(tabInfo.FileContent);
            }
        }

        private void OnUpdateTabStatus(TabFlag tabFlag)
        {
            if (tabFlag.Guid != _fileGuid)
                return;

            IsReadOnly = tabFlag.IsReadOnly;
            IsShowEditor = tabFlag.IsShowEditor;
        }

        private void OnSelectTab(TabSelectInfo info)
        {
            if (info.Guid != _fileGuid)
                return;

            IsActive = info.IsSelected;
            IsSelected = info.IsSelected;
        }

        #endregion

        #region IActiveAware

        private bool _isActive = false;
        public bool IsActive
        {
            get { return _isActive; }
            set
            {
                if (SetProperty(ref _isActive, value))
                    OnIsActiveChanged();
            }
        }

        public event EventHandler IsActiveChanged;

        private void OnIsActiveChanged()
        {
            SaveCommand.RaiseCanExecuteChanged();

            CompileCommand.IsActive = IsActive;
            CompileCommand.RaiseCanExecuteChanged();

            RedoCommand.IsActive = IsActive;
            RedoCommand.RaiseCanExecuteChanged();

            UndoCommand.IsActive = IsActive;
            UndoCommand.RaiseCanExecuteChanged();

            IsActiveChanged?.Invoke(this, new EventArgs());
        }

        #endregion

        #region IDisposable

        public void Dispose()
        {
            //Events
            _settingChangedEvent.Unsubscribe(OnSettingChanged);
            _loadTextEvent.Unsubscribe(OnLoadText);
            _updateTabStatusEvent.Unsubscribe(OnUpdateTabStatus);
            _selectTabEvent.Unsubscribe(OnSelectTab);

            //Command
            _appCommands.SaveCommand.UnregisterCommand(SaveCommand);
            _appCommands.CompileCommand.UnregisterCommand(CompileCommand);
            _appCommands.RedoCommand.UnregisterCommand(RedoCommand);
            _appCommands.UndoCommand.UnregisterCommand(UndoCommand);

            _textEditor?.Dispose();
            _textEditor = null;

            _xsdParser = null;
        }

        #endregion

        #region Func

        private void Compile(string content)
        {
            if (_eventAggregator != null && _textEditor != null)
                _eventAggregator.GetEvent<RefreshDesignerEvent>().Publish(new TabInfo { Guid = _fileGuid, IsReadOnly = IsReadOnly, IsShowEditor = IsShowEditor, FileContent = string.IsNullOrEmpty(content) ? _textEditor.Text : content });
        }

        private void Reset(Action reset = null)
        {
            _isReseting = true;

            reset?.Invoke();

            IsModified = false;

            _isReseting = false;
        }

        private void CaretPosChanged()
        {
            if (_eventAggregator != null && IsActive)
                _eventAggregator.GetEvent<CaretPositionEvent>().Publish(new CaretPosition() { Line = CaretLine, Column = CaretColumn });
        }

        #endregion
    }
}
