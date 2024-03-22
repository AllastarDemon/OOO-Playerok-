using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using VideoGamesStore.Classes;
using VideoGamesStore.Database;

namespace VideoGamesStore.Views
{
    /// <summary>
    /// Логика взаимодействия для Catalog.xaml
    /// </summary>
    public partial class Catalog : Window
    {
        private Authorization auth;
        private string sort = string.Empty;
        public AddProduct addWindow;
        public EditProduct editWindow;
        public Catalog(Authorization authorization)
        {
            InitializeComponent();
            auth = authorization;
            sort = "ASC";
            LoadCategoryIntoComboBox();
        }
        public Catalog()
        {
            InitializeComponent();
        }
        private void ShowProduct()
        {
            
        }

        private void LoadCategoryIntoComboBox()
        {
            // Загрузка данных из базы данных
            List<Category> categories = Helper.DB.Category.ToList();
            categories.Insert(0, new Category { CategoryName = "Все категории" });
            // Связывание данных с комбобоксом
            categoryComboBox.ItemsSource = categories;
            categoryComboBox.DisplayMemberPath = "CategoryName"; // Устанавливаем свойство для отображения имени разработчика
            categoryComboBox.SelectedValuePath = "CategoryID";
        }
        private void LoadCategoryIntoComboBox(object sender, SelectionChangedEventArgs e)
        {
            // Ваша логика обработки события SelectionChanged
            // Этот метод остается нетронутым и используется для обработки события SelectionChanged комбо бокса
        }
        private void PriceComboBox(object sender, SelectionChangedEventArgs e)
        {
            if (priceComboBox.SelectedIndex == 0) sort = "ASC";
            else sort = "DESC";
            ShowProduct();

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
    }
}
