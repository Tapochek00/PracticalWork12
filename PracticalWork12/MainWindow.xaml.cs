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
using System.Windows.Threading;

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

                if (point3 < point1 && point3 > point2 || point3 > point1 && point3 < point2)
                {
                    int res = Class1.SegmentLengthMultiplication(point1, point2, point3);
                    result.Text = res.ToString();

                    a.Focus();
                }
                else
                {
                    MessageBox.Show("Точка C должна быть между точками A и B");
                }
            }
            catch (Exception ex)
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
            Close();
        }

        private void btn_About_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Практическая работа №12 \n\nДунаева М.И.\n\n" +
                "Даны три точки A, B, C на числовой оси." +
                " Точка C расположена между точками A и " +
                "B. Найти произведение длин отрезков AC и BC.");
        }

        DispatcherTimer timer;
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            timer = new DispatcherTimer();
            timer.Tick += Timer_Tick;
            timer.Interval = new TimeSpan(0, 0, 0, 1, 0);
            timer.IsEnabled = true;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            DateTime d = DateTime.Now;
            datetime.Text = d.ToString("HH:mm dd.MM.yy");
        }

        private void btn_Count2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int.TryParse(number.Text, out int num);

                if (num / 1000 < 1)
                {

                    Class1.DigitSumMult(num, out int sumCount, out int multCount);
                    mult.Text = multCount.ToString();
                    sum.Text = sumCount.ToString();
                }
                else
                {
                    MessageBox.Show("Введите трёхзначное число");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_About2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Практическая работа №12 \n\nДунаева М.И.\n\n" +
                " Дано трехзначное число. Найти сумму и произведение его цифр");
        }

        private void Clear1_Click(object sender, RoutedEventArgs e)
        {
            a.Clear();
            b.Clear();
            c.Clear();
        }
    }
}
