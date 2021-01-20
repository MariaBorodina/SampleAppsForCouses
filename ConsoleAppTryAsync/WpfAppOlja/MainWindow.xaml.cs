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

namespace WpfAppOlja
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
            if(rad2.IsChecked ?? false)
                r1.Fill = (Brush)Resources["OljaYel"];

            if (rad1.IsChecked ?? false)
                theGrid.Background = (Brush)Resources["OljaYel"];
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (rad2.IsChecked ?? false)
                r1.Fill = (Brush)Resources["OljaTurq"];

            if (rad1.IsChecked ?? false)
                theGrid.Background = (Brush)Resources["OljaTurq"];
        }

        List<Rectangle> _rects = new List<Rectangle>();
        Random rand = new Random(DateTime.Now.Second);
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var rNew = new Rectangle();
            rNew.Width = rand.Next(10, 100);
            rNew.Height = rand.Next(10, 100);
            rNew.Fill = new SolidColorBrush(Color.FromRgb((byte)rand.Next(10, 250), (byte)rand.Next(10, 250), (byte)rand.Next(10, 250)));

            theGrid.Children.Add(rNew);
            rNew.Margin = new Thickness(
                rand.Next((int)(theGrid.ActualWidth-rNew.Width)), 
                rand.Next((int)(theGrid.ActualHeight - rNew.Height)), 0, 0);
            rNew.HorizontalAlignment = HorizontalAlignment.Left;
            rNew.VerticalAlignment = VerticalAlignment.Top;

            _rects.Add(rNew);
        }


        List<Ellipse> _rounds = new List<Ellipse>();
        private void Button_Click_round(object sender, RoutedEventArgs e)
        {
            var rNew = new Ellipse();
            rNew.Width = rand.Next(10, 100);
            rNew.Height = rNew.Width;
            rNew.Fill = new SolidColorBrush(Color.FromRgb((byte)rand.Next(10, 250), (byte)rand.Next(10, 250), (byte)rand.Next(10, 250)));

            rNew.Margin = new Thickness(
                rand.Next((int)(theGrid.ActualWidth - rNew.Width)),
                rand.Next((int)(theGrid.ActualHeight - rNew.Height)), 0, 0);
            rNew.HorizontalAlignment = HorizontalAlignment.Left;
            rNew.VerticalAlignment = VerticalAlignment.Top;
            theGrid.Children.Add(rNew);

            _rounds.Add(rNew);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            foreach (var r in _rects)
                theGrid.Children.Remove(r);

            _rects.Clear();

            foreach (var r in _rounds)
                theGrid.Children.Remove(r);

            _rounds.Clear();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Brush b = (Brush)Resources["OljaPurple"];

            if (rad2.IsChecked ?? false)
                r1.Fill = b;

            if (rad1.IsChecked ?? false)
                theGrid.Background = b;
        }
    }
}
