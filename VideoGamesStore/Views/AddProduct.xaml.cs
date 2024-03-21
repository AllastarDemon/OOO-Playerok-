using System.Windows;

namespace VideoGamesStore.Views
{
    public partial class AddProduct : Window
    {
        private Catalog formCatalog;
        public AddProduct(Catalog catalog)
        {
            InitializeComponent();
            formCatalog = catalog;
        }
        private void BackToCatalog(object sender, RoutedEventArgs e)
        {
            // проверка на открытия окна авторизации для избежания System.OperationException
            if (formCatalog == null || !formCatalog.IsVisible)
            {
                formCatalog = new Catalog();
            }
            formCatalog.Show();
            Close();
        }

        private void AddProductButton(object sender, RoutedEventArgs e)
        {

        }
    }
}
