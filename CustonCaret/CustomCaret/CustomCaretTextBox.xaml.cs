using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CustomCaret
{
    /// <summary>
    /// Interaction logic for CustomCaretTextBox.xaml
    /// </summary>
    public partial class CustomCaretTextBox : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomCaretTextBox"/> class.
        /// </summary>
        public CustomCaretTextBox()
        {
            InitializeComponent();

            // Move custom caret whenever the selection has changed. (this includes typing, arrow keys, clicking)
            //
            this.CustomTextBox.SelectionChanged += (sender, e) => MoveCustomCaret();

            // Keep custom caret collpased until the text box has gained focus
            //
            this.CustomTextBox.LostFocus += (sender, e) => Caret.Visibility = Visibility.Collapsed;

            // Show custom caret as soon as text box has gained focus
            //
            this.CustomTextBox.GotFocus += (sender, e) => Caret.Visibility = Visibility.Visible;
        }

        /// <summary>
        /// Moves the custom caret on the canvas.
        /// </summary>
        private void MoveCustomCaret()
        {
            var caretLocation = CustomTextBox.GetRectFromCharacterIndex(CustomTextBox.CaretIndex).Location;

            if (!double.IsInfinity(caretLocation.X))
            {
                Canvas.SetLeft(Caret, caretLocation.X);
            }

            if (!double.IsInfinity(caretLocation.Y))
            {
                Canvas.SetTop(Caret, caretLocation.Y);
            }
        }
    }
}
