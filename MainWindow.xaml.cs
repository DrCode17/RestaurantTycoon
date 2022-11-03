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
using System.Threading;

namespace Restrauran_Tycoon
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int kassa = 15000;
        int newTable = 10000;
        int pricePerSec = 0;
        int totalTable = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Table1_btn_Click(object sender, RoutedEventArgs e)
        {
            if (NewTable())
            {
                Table1_btn.Visibility = Visibility.Hidden;
                Table1.Visibility = Visibility.Visible;
            }
        }

        private void Table2_btn_Click(object sender, RoutedEventArgs e)
        {
            if (NewTable())
            {
                Table2_btn.Visibility = Visibility.Hidden;
                Table2.Visibility = Visibility.Visible;
            }
        }

        private void Table3_btn_Click(object sender, RoutedEventArgs e)
        {
            if (NewTable())
            {
                Table3_btn.Visibility = Visibility.Hidden;
                Table3.Visibility = Visibility.Visible;
            }
        }

        private void Table4_btn_Click(object sender, RoutedEventArgs e)
        {
            if (NewTable())
            {
                Table4_btn.Visibility = Visibility.Hidden;
                Table4.Visibility = Visibility.Visible;
            }
        }

        private void Table5_btn_Click(object sender, RoutedEventArgs e)
        {
            if (NewTable())
            {
                Table5_btn.Visibility = Visibility.Hidden;
                Table5.Visibility = Visibility.Visible;
            }
        }

        private void Table6_btn_Click(object sender, RoutedEventArgs e)
        {
            if (NewTable())
            {
                Table6_btn.Visibility = Visibility.Hidden;
                Table6.Visibility = Visibility.Visible;
            }
        }

        private void form_loaded(object sender, RoutedEventArgs e)
        {
            kassaszam_lbl.Content = kassa.ToString() + " Ft";
            newTablePrice_lbl.Content = newTable.ToString() + " Ft";
        }

        public Boolean NewTable()
        {
            if(kassa > newTable)
            {
                kassa -= newTable;
                newTable *= 2;
                kassaszam_lbl.Content = kassa.ToString() + " Ft";
                newTablePrice_lbl.Content = newTable.ToString() + " Ft";
                pricePerSec += 1000;
                totalTable++;
                if (totalTable == 6)
                    newTablePrice_lbl.Content = "Nincs több elérhető asztal!";
                return true;
            }
            return false;
        }

        private void fizet_btn_Click(object sender, RoutedEventArgs e)
        {
            kassa += pricePerSec * 20;
            kassaszam_lbl.Content = kassa.ToString() + " Ft";
        }
    }
}
