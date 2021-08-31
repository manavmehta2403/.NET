﻿using Prism.Commands;

namespace XamlService.Commands
{
    public interface IApplicationCommands
    {
        //Toolbar
        CompositeCommand NewCommand { get; }
        CompositeCommand OpenCommand { get; }
        CompositeCommand SaveCommand { get; }
        CompositeCommand SaveAllCommand { get; }

        CompositeCommand UndoCommand { get; }
        CompositeCommand RedoCommand { get; }

        CompositeCommand CompileCommand { get; }

        //Example
        CompositeCommand ExampleCommand { get; }

        //
        CompositeCommand DropCommand { get; }
        CompositeCommand RefreshCommand { get; }
        CompositeCommand HelpCommand { get; }
        CompositeCommand CloseAllCommand { get; }
        CompositeCommand CloseAllButThisCommand { get; }
    }

    public class ApplicationCommands : IApplicationCommands
    {
        private CompositeCommand _newCommand = new CompositeCommand();
        public CompositeCommand NewCommand
        {
            get { return _newCommand; }
        }

        private CompositeCommand _openCommand = new CompositeCommand();
        public CompositeCommand OpenCommand
        {
            get { return _openCommand; }
        }

        private CompositeCommand _saveCommand = new CompositeCommand();
        public CompositeCommand SaveCommand
        {
            get { return _saveCommand; }
        }

        private CompositeCommand _saveAllCommand = new CompositeCommand();
        public CompositeCommand SaveAllCommand
        {
            get { return _saveAllCommand; }
        }

        private CompositeCommand _undoCommand = new CompositeCommand(true);
        public CompositeCommand UndoCommand
        {
            get { return _undoCommand; }
        }

        private CompositeCommand _redoCommand = new CompositeCommand(true);
        public CompositeCommand RedoCommand
        {
            get { return _redoCommand; }
        }

        private CompositeCommand _compileCommand = new CompositeCommand(true);
        public CompositeCommand CompileCommand
        {
            get { return _compileCommand; }
        }

        private CompositeCommand _exampleCommand = new CompositeCommand();
        public CompositeCommand ExampleCommand
        {
            get { return _exampleCommand; }
        }

        private CompositeCommand _dropCommand = new CompositeCommand();
        public CompositeCommand DropCommand
        {
            get { return _dropCommand; }
        }

        private CompositeCommand _refreshCommand = new CompositeCommand();
        public CompositeCommand RefreshCommand
        {
            get { return _refreshCommand; }
        }

        private CompositeCommand _helpCommand = new CompositeCommand();
        public CompositeCommand HelpCommand
        {
            get { return _helpCommand; }
        }

        private CompositeCommand _closeAllCommand = new CompositeCommand();
        public CompositeCommand CloseAllCommand
        {
            get { return _closeAllCommand; }
        }

        private CompositeCommand _closeAllButThisCommand = new CompositeCommand();
        public CompositeCommand CloseAllButThisCommand
        {
            get { return _closeAllButThisCommand; }
        }
    }
}
