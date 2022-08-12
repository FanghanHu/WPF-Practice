using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace WPF_Practice
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class NameInputDialog : Window
    {
        public NameInputDialog()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

        private void Window_ContentRendered(Object sender, EventArgs e)
        {
            txtName.SelectAll();
            txtName.Focus();
        }

        public string Result
        {
            get { return txtName.Text; }
        }
    }
}
