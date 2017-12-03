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

namespace WpfApp1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox.Text != "appel" && TextBox.Text != "")
            {
                Label.Content = "Nope, raad nog eens";
            }
            else
            {
                Label.Content = "correct";
            }
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            Label2.Content = Convert.ToInt32(Slider.Value);
            Label2.Content = Slider.Value;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Ellipse po = new Ellipse();
            po.Height = 400;
            po.Width = 400;
            po.Margin = new Thickness(10, 10, 10, 10);
            po.Stroke = new SolidColorBrush(Colors.Blue);
            Canvas.Children.Add(po);

            Ellipse po1 = new Ellipse();
            po1.Height = 200;
            po1.Width = 200;
            po1.Stroke = new SolidColorBrush(Colors.BlueViolet);
            Canvas.Children.Add(po1);
        }

        private void TextBox2_TextChanged(object sender, TextChangedEventArgs e)
        {
            Line line = new Line();
            line.X1 = 300;
            line.X2 = 400;
            line.Y1 = 200;
            line.Y2 = 200;
            line.Stroke = new SolidColorBrush(Colors.BlueViolet);
            Canvas.Children.Add(line);
        }
    }
}
