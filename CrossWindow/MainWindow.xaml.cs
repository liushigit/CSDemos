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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CrossWindow
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        StudentsViewModel viewModel;
        public MainWindow()
        {

            InitializeComponent();
            viewModel = new StudentsViewModel();
            rootGrid.DataContext = viewModel;
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            var tb = sender as TextBox;
            if (tb == null) { return; }

            // https://social.msdn.microsoft.com/Forums/zh-CN/911441f7-df8b-4f54-b7eb-ebfd40e88813/textbox-how-do-i-update-the-text-source-binding-on-enter?forum=wpf
            var be = tb.GetBindingExpression(TextBox.TextProperty);
            be.UpdateSource();
        }
    }
}
