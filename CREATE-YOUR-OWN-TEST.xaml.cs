using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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
using static System.Net.Mime.MediaTypeNames;

namespace WpfApp6
{
    /// <summary>
    /// Логика взаимодействия для CREATE_YOUR_OWN_TEST.xaml
    /// </summary>
    public partial class CREATE_YOUR_OWN_TEST : Page
    {
        List<CLASS_FOR_TASK> zadanias = CLASS_TO_Serialization_AND_Deserialization.Desir<List<CLASS_FOR_TASK>>("testaa.json") ?? new List<CLASS_FOR_TASK>() ?? new List<CLASS_FOR_TASK>();

        public CREATE_YOUR_OWN_TEST()
        {
            InitializeComponent();
            Gridik.ItemsSource = zadanias;
        }
        private void dobav_Click(object sender, RoutedEventArgs e)
        {
            Gridik.ItemsSource = null;
            zadanias.Add(new CLASS_FOR_TASK("Название вопроса", "Описание вопроса", "0", "0", "0", ENUM_CLASS.odin));
            CLASS_TO_Serialization_AND_Deserialization.Serialize(zadanias, "testaa.json");
            Gridik.ItemsSource = zadanias;

        }

        private void Gridik_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CLASS_TO_Serialization_AND_Deserialization.Serialize(zadanias, "testaa.json");
        }
    }
}
