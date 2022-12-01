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

namespace PracticalWork12
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

        private void btn_Count_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int point1 = Convert.ToInt32(a.Text);
                int point2 = Convert.ToInt32(b.Text);
                int point3 = Convert.ToInt32(c.Text);
                int ac, bc, dupl;

                if (point3 < point1)
                {
                    dupl = point3;
                    point3 = point1;
                    point1 = dupl;
                    a.Text = point1.ToString();
                    c.Text = point3.ToString();
                }
                else if (point3 > point2)
                {
                    dupl = point3;
                    point3 = point2;
                    point2 = dupl;
                    a.Text = point2.ToString();
                    c.Text = point3.ToString();
                }

                ac = point3 - point1;
                bc = point2 - point3;
                result.Text = Convert.ToString(ac * bc);

                a.Focus();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TextChanged(object sender, TextChangedEventArgs e)
        {
            result.Clear();
        }

        private void btn_Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btn_About_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Практическая работа №12 \n\nДунаева М.И.\n\n" +
                "Даны три точки A, B, C на числовой оси." +
                " Точка C расположена между точками A и " +
                "B. Найти произведение длин отрезков AC и BC.");
        }
    }
}
