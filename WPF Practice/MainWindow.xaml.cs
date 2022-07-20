using System;
using System.Windows;
using System.Windows.Controls;

namespace WPF_Practice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_SelectionChanged(object sender, RoutedEventArgs e)
        {
            if(sender != null)
            {
                TextBox textBox = sender as TextBox;
                if (txtStatus != null)
                {
                    txtStatus.Text = "Selection starts at character #" + textBox.SelectionStart + Environment.NewLine;
                    txtStatus.Text += "Selection is " + textBox.SelectionLength + " character(s) long" + Environment.NewLine;
                    txtStatus.Text += "Selection text: '" + textBox.SelectedText + "'.";
                }
            }
        }
    }
}
