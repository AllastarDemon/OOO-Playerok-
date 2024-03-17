using System.Linq;
using System.Windows;
using VideoGamesStore.Classes;
using VideoGamesStore.Views;

namespace VideoGamesStore
{
    public partial class Authorization : Window
    {
        Catalog shop;
        public Authorization()
        {
            InitializeComponent();
        }
        private void OpenCatalogHowGuest(object sender, RoutedEventArgs e)
        {
            Helper.user = null;
            shop = new Catalog(this);
            Close();
            shop.Show();
        }
        private void OpenCatalog(object sender, RoutedEventArgs e)
        {
            Helper.user = Helper.DB.User.Where(x => x.UserLogin == LoginTextBox.Text && x.UserPassword == PasswordTextBox.Password).ToList().FirstOrDefault();
            if (Helper.user != null) 
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
        }
    }
}
