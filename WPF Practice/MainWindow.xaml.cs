using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

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

            Binding binding = new Binding("Text");
            binding.Source = txtValue;
            lblValue.SetBinding(TextBlock.TextProperty, binding);
        }
    }
}
