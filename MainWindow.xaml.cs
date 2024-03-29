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

namespace WpfApp6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Reg_Admin.IsEnabled = false;
        }
        static bool avtor = false;

        private void vxod()
        {
            GLAVNAY GLAVNAY = new GLAVNAY(avtor);
            GLAVNAY.Show();
            Close();
        }
        private void proiti_Click(object sender, RoutedEventArgs e)
        {
            vxod();

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Reg_Admin.Text == "t")
            {
                avtor = true;
                vxod();
            }
        }

        private void izmen_Click(object sender, RoutedEventArgs e)
        {
            Reg_Admin.IsEnabled = true;
        }

    }
}
    