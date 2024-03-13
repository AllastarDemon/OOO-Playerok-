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
using VideoGamesStore.Views;

namespace VideoGamesStore
{
    /// <summary>
    /// Логика взаимодействия для Authorization.xaml
    /// </summary>
    public partial class Authorization : Window
    {
        Catalog shop;
        public Authorization()
        {
            InitializeComponent();
        }
        private void OpenCatalogHowGuest(object sender, RoutedEventArgs e)
        {
            shop = new Catalog(this);
            Close();
            shop.Show();
        }

        //private void OpenCatalog(object sender, RoutedEventArgs e)
        //{
        //    Close();
        //}
    }
}
