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

namespace WpfApp6
{
    /// <summary>
    /// Логика взаимодействия для GLAVNAY.xaml
    /// </summary>
    public partial class GLAVNAY : Window
    {
        bool avtor1;
        public GLAVNAY(bool avtor)
        {
            InitializeComponent();
            if (avtor == false)
            {
                change.IsEnabled = false;
            }
            else if (avtor == true)
            {
                change.IsEnabled = true;
            }
            avtor1 = avtor;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<CLASS_FOR_TASK> zadanias = CLASS_TO_Serialization_AND_Deserialization.Desir<List<CLASS_FOR_TASK>>("testaa.json") ?? new List<CLASS_FOR_TASK>() ?? new List<CLASS_FOR_TASK>();
            if (zadanias.Count > 0)
            {
                PageFrame.Content = new PROCESS_TO_TAKE_TEST_COMPLETE();
            }
            else
            {
                PageFrame.Content = new THERE_IS_NO_TEST_FOUND();
            }

        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
            if (avtor1 == false)
            {
                change.IsEnabled = false;
            }
            else if (avtor1 == true)
            {
                change.IsEnabled = true;
            }
        }

        private void change_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new CREATE_YOUR_OWN_TEST();
        }
    }
}


