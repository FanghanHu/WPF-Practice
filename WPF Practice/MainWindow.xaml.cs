using Microsoft.Win32;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Windows;

namespace WPF_Practice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public string Result { set; get; }

        public MainWindow()
        {
            InitializeComponent();
            Result = "[No Name]";
            DataContext = this;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NameInputDialog dialog = new NameInputDialog();
            if(dialog.ShowDialog() == true)
            {
                Result = dialog.Result;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Result"));
            }
        }
    }
}
