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

namespace HMI
{
    public partial class MainWindow : Window
    {
        BeckhoffVM beckhoffVM = null;

        public MainWindow()
        {
            InitializeComponent();
            beckhoffVM=new BeckhoffVM();
        }

        #region Event
        private void Page_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Function_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Control_Click(object sender, RoutedEventArgs e)
        {

        }
        #endregion
    }
}
