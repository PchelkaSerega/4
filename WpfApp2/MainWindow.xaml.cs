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

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(txt1.Text);
                int b = Convert.ToInt32(txt2.Text);
                int c = Convert.ToInt32(txt3.Text);
                int d = Convert.ToInt32(txt4.Text);

                double dist = Math.Sqrt(Math.Pow(a - c, 2) + Math.Pow(b - d, 2));
                lbl1.Content = "Расстояние между a,b и c,d: " + dist;
            }
            catch
            {
                MessageBox.Show("данные введены неправильно");
            }
        }
    }
    }
