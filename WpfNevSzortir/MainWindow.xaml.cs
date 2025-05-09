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

namespace WpfNevSzortir
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> Nevek = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_nevKiir_Click(object sender, RoutedEventArgs e)
        {
            if (tbx_nevekbeir.Text != "")
            {
                lb_nevekkiir.Items.Clear();
                Nevek.Clear();
                string Nevszovegdoboz = tbx_nevekbeir.Text;
                string[] kecske = Nevszovegdoboz.Split(',');
                foreach (string s in kecske)
                {
                    Nevek.Add(s);
                    lb_nevekkiir.Items.Add(s);

                }
            }
            else
            {
                MessageBox.Show("Adjon meg egy nevet", "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
            }


        }

        private void btn_nevsorbaRendez_Click(object sender, RoutedEventArgs e)
        {
            if (tbx_nevekbeir.Text != "")
            {
                lb_neveksorbarendez.Items.Clear();
                Nevek.Clear();
                string Nevszovegdoboz = tbx_nevekbeir.Text;
                string[] kecske = Nevszovegdoboz.Split(',');
                Array.Sort(kecske);
                foreach (string s in kecske)
                {
                    Nevek.Add(s);
                    lb_neveksorbarendez.Items.Add(s);
                }
                MessageBox.Show("A lista sorba lett rendezve", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Adjon meg egy nevet", "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        
    }
}
