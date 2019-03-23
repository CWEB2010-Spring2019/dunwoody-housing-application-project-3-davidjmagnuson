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
using Project_Three_GUI.Classes;

namespace Project_Three_GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        string[] firsts = {"david", "justin", "ben"};
        string[] lasts = {"magnuson", "craswell", "fischer" };
        int[] ids = { 1, 2, 3 };
        int[] rooms = { 1, 2, 3 };
        int[] floors = { 1, 1, 1 };
        double[] rents = { 1200, 1200, 1200 };

        List<Resident> athletelist = new List<Resident>();

        private void NewResBtn_Click(object sender, RoutedEventArgs e)
        {
            //create new resident and add them to the list
        }
    }
}
