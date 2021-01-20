using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WpfAppOljaApteka
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Tovars = new ObservableCollection<Tovar>()
            {
                new Tovar(){ Id=1, Name ="доктор мом", FileName="doctormom.jpg"},
                new Tovar(){ Id=2, Name ="боро плюс"},
                new Tovar(){ Id=3, Name ="флеминга"},
                new Tovar(){ Id=4, Name ="аква марис"},
                new Tovar(){ Id=5, Name ="ромашка засушенная"},
                new Tovar(){ Id=6, Name ="валерянка"},
                new Tovar(){ Id=7, Name ="витамин Д"},
                new Tovar(){ Id=8, Name ="мирамистин"},
            };
        }

        public ObservableCollection<Tovar> Tovars { get; set; }
    


    }
}
