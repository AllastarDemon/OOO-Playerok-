using System.Windows;

namespace VideoGamesStore.Views
{
    /// <summary>
    /// Логика взаимодействия для Catalog.xaml
    /// </summary>
    public partial class Catalog : Window
    {
        private Authorization auth;
        public AddProduct addWindow;
        public EditProduct editWindow;
        public Catalog(Authorization authorization)
        {
            InitializeComponent();
            auth = authorization;
        }
        public Catalog()
        {
            InitializeComponent();
        }
        private void BackToAuth(object sender, RoutedEventArgs e)
        {
            // проверка на открытия окна авторизации для избежания System.OperationException
            if (auth == null || !auth.IsVisible)
            {
                auth = new Authorization();
            }
            auth.Show();
            Close();
        }
        private void AddProductButton(object sender, RoutedEventArgs e)
        {
            addWindow = new AddProduct(this);
            Close();
            addWindow.Show();
        }

        private void EditProductButton(object sender, RoutedEventArgs e)
        {
            editWindow = new EditProduct(this);
            Close();
            editWindow.Show();
        }
    }
}
