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
            if (NewTable())// Margin="130,66,0,0"
            {
                Table1_btn.Visibility = Visibility.Hidden;
                Table1.Visibility = Visibility.Visible;
                vasarlo1_img.Visibility = Visibility.Visible;//Margin="21,288,0,0"
                vasarlo1_img.Margin = new Thickness(256,338,0,0);
                
            }
        }

        private void Table2_btn_Click(object sender, RoutedEventArgs e)
        {
            if (NewTable())// Margin="339,66,0,0"
            {
                Table2_btn.Visibility = Visibility.Hidden;
                Table2.Visibility = Visibility.Visible;
                vasarlo2_img.Visibility = Visibility.Visible;//Margin="21,288,0,0"
                vasarlo2_img.Margin = new Thickness(339, 66, 0, 0);
            }
        }

        private void Table3_btn_Click(object sender, RoutedEventArgs e)
        {
            if (NewTable())//Margin="548,66,0,0"
            {
                Table3_btn.Visibility = Visibility.Hidden;
                Table3.Visibility = Visibility.Visible;
                vasarlo3_img.Visibility = Visibility.Visible;//Margin="21,288,0,0"
                vasarlo3_img.Margin = new Thickness(548, 66, 0, 0);
            }
        }

        private void Table4_btn_Click(object sender, RoutedEventArgs e)
        {
            if (NewTable())//Margin="131,238,0,0"
            {
                Table4_btn.Visibility = Visibility.Hidden;
                Table4.Visibility = Visibility.Visible;
                vasarlo4_img.Visibility = Visibility.Visible;//Margin="21,288,0,0"
                vasarlo4_img.Margin = new Thickness(131, 238, 0, 0);
            }
        }

        private void Table5_btn_Click(object sender, RoutedEventArgs e)
        {
            if (NewTable())//Margin="340,238,0,0"
            {
                Table5_btn.Visibility = Visibility.Hidden;
                Table5.Visibility = Visibility.Visible;
                vasarlo5_img.Visibility = Visibility.Visible;//Margin="21,288,0,0"
                vasarlo5_img.Margin = new Thickness(340, 238, 0, 0);
            }
        }

        private void Table6_btn_Click(object sender, RoutedEventArgs e)
        {
            if (NewTable())//Margin="549,238,0,0"
            {
                Table6_btn.Visibility = Visibility.Hidden;
                Table6.Visibility = Visibility.Visible;
                vasarlo6_img.Visibility = Visibility.Visible;//Margin="21,288,0,0"
                vasarlo6_img.Margin = new Thickness(549, 238, 0, 0);
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
                newTable += 20000;
                kassaszam_lbl.Content = kassa.ToString() + " Ft";
                newTablePrice_lbl.Content = newTable.ToString() + " Ft";
                pricePerSec += 5000;
                totalTable++;
                if (totalTable == 12)
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

        private void Table1_MouseEnter(object sender, MouseEventArgs e)
        {
            if (NewTable())
            {
                vasarlo11_img.Visibility = Visibility.Visible;//Margin="21,288,0,0"
                vasarlo11_img.Margin = new Thickness(190, 66, 0, 0);
            }
            
        }

        private void Table2_MouseEnter(object sender, MouseEventArgs e)
        {
            if (NewTable())//399,65,0,0
            {
                vasarlo22_img.Visibility = Visibility.Visible;//Margin="21,288,0,0"
                vasarlo22_img.Margin = new Thickness(399, 66, 0, 0);
            }

        }
        private void Table3_MouseEnter(object sender, MouseEventArgs e)
        {
            if (NewTable())
            {
                vasarlo33_img.Visibility = Visibility.Visible;//Margin="21,288,0,0"
                vasarlo33_img.Margin = new Thickness(608, 66, 0, 0);
            }

        }
        private void Table4_MouseEnter(object sender, MouseEventArgs e)
        {
            if (NewTable())
            {
                vasarlo44_img.Visibility = Visibility.Visible;//Margin="21,288,0,0"
                vasarlo44_img.Margin = new Thickness(190, 66, 0, 0);
            }

        }
        private void Table5_MouseEnter(object sender, MouseEventArgs e)
        {
            if (NewTable())
            {
                vasarlo55_img.Visibility = Visibility.Visible;//Margin="21,288,0,0"
                vasarlo55_img.Margin = new Thickness(190, 66, 0, 0);
            }

        }

        private void Table6_MouseEnter(object sender, MouseEventArgs e)
        {
            if (NewTable())
            {
                vasarlo66_img.Visibility = Visibility.Visible;//Margin="21,288,0,0"
                vasarlo66_img.Margin = new Thickness(190, 66, 0, 0);
            }

        }
    }
}
