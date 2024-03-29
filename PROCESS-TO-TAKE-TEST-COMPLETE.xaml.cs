using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
    /// Логика взаимодействия для PROCESS_TO_TAKE_TEST_COMPLETE.xaml
    /// </summary>
    public partial class PROCESS_TO_TAKE_TEST_COMPLETE : Page
    {
        List<CLASS_FOR_TASK> task = CLASS_TO_Serialization_AND_Deserialization.Desir<List<CLASS_FOR_TASK>>("testaa.json") ?? new List<CLASS_FOR_TASK>() ?? new List<CLASS_FOR_TASK>();
        int i = 0;
        int prav = 0;

        private void vivod()
        {
            Name.Text = task[i].Name;
            Opic.Text = task[i].Opic;
            odin.Content = task[i]._1Var;
            dva.Content = task[i]._2Var;
            tri.Content = task[i]._3Var;
        }
        public PROCESS_TO_TAKE_TEST_COMPLETE()
        {
            InitializeComponent();
            vivod();
        }

        private void _1var_Click(object sender, RoutedEventArgs e)
        {
            if ((sender as Button).Name == task[i].Pravil.ToString())
            {
                prav++;
            }
            i++;
            if (i > task.Count - 1)
            {
                Name.Text = "Ты прошел тест";
                Opic.Text = $"Ты набрал {prav} правильных ответов из {i} вопросов ";
                odin.Content = null;
                dva.Content = null;
                tri.Content = null;
                odin.IsEnabled = false;
                dva.IsEnabled = false;
                tri.IsEnabled = false;
            }
            else
            {
                vivod();
            }
        }
    }
}


   