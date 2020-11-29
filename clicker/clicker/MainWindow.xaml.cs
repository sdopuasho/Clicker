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


namespace clicker
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public static long point = 0;
        public static int click = 1;
        double sol_b1 = 10 + 10 * (30 + click * 0.2);
        double sol_b2 = 20 + 20 * (60 + click * 0.4);
        double sol_b3 = 30 + 30 * (90 + click * 0.6);
        double sol_b4 = 40 + 40 * (120 + click * 0.8);
        public MainWindow()
        {
            InitializeComponent();
            Update();
        }
        public void Update()
        {
            points.Content = "Points: " + point;
            pointperclick.Content = "Points for click: " + click;
            btn1.Content = (sol_b1).ToString();
            btn2.Content = (sol_b2).ToString();
            btn3.Content = (sol_b3).ToString();
            btn4.Content = (sol_b4).ToString();
        }

        private void pictureclick_MouseDown(object sender, MouseButtonEventArgs e)
        {
            point += click;
            Update();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            int b = Convert.ToInt32(point);
            buy1(b);
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {

            int b = Convert.ToInt32(point);
            buy2(b);
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {

            int b = Convert.ToInt32(point);
            buy3(b);
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {

            int b = Convert.ToInt32(point);
            buy4(b);
        }
        public  bool buy1(int pt)
        {
            point = pt;
            if (pt >= (sol_b1))
            {
                point -= Convert.ToInt64(Math.Round(sol_b1));
                click += 3;
                Update();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool buy2(int pt)
        {
            if (pt >= (sol_b2))
            {
                point -= Convert.ToInt64(Math.Round(sol_b2));
                click += 6;
                Update();
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool buy3(int pt)
        {
            if (pt >= (sol_b3))
            {
                point -= Convert.ToInt64(Math.Round(sol_b3));
                click += 9;
                Update();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool buy4(int pt)
        {
            if (pt >= (sol_b4))
            {
                point -= Convert.ToInt64(Math.Round(sol_b4));
                click += 12;
                Update();
                return true;
            }
            else
            {
                return false;
            }
        }

        private void asd_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
