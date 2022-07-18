using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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
            double num = 123456789.12345;
            usNumber.Content = num.ToString("N2", new CultureInfo("en-US"));
            deNumber.Content = num.ToString("N2", new CultureInfo("de-DE"));
            svNumber.Content = num.ToString("N2", new CultureInfo("sv-SE"));
        }
    }
}
