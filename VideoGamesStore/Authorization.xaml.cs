using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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
using VideoGamesStore.Classes;
using VideoGamesStore.Views;

namespace VideoGamesStore
{
    /// <summary>
    /// Логика взаимодействия для Authorization.xaml
    /// </summary>
    public partial class Authorization : Window
    {
        Catalog shop;
        private string name = "Konstantin";
        private string firstName = "Pendragon";

        private string login = "admin";
        private string password = "admin";
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

        private void OpenCatalog(object sender, RoutedEventArgs e)
        {
            if (null!= Helper.DB.Users.FirstOrDefault(u => u.UserLogin == LoginTextBox.Text && u.UserPassword == PasswordTextBox.Password)) 
            { 

                shop = new Catalog(this);
                Close();
                shop.Show();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
                Close();
            }
            Close();
            Show();
        }
    }
}
