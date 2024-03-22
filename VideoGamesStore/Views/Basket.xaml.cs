using System.Windows;

namespace VideoGamesStore.Views
{
    /// <summary>
    /// Логика взаимодействия для Basket.xaml
    /// </summary>
    public partial class Basket : Window
    {
        private Catalog formCatalog;
        public Basket(Catalog catalog)
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
    }
}
