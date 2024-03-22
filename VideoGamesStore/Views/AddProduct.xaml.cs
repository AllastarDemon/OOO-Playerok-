using System.Windows;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Controls;
using VideoGamesStore.Classes;
using VideoGamesStore.Database;

namespace VideoGamesStore.Views
{
    public partial class AddProduct : Window
    {
        private Catalog formCatalog;
        public AddProduct(Catalog catalog)
        {
            InitializeComponent();
            formCatalog = catalog;
            LoadDevelopersIntoComboBox();
            LoadCategoryIntoComboBox();
        }

        private void LoadDevelopersIntoComboBox()
        {
            // Загрузка данных из базы данных
            List<Developer> developers = Helper.DB.Developer.ToList();

            // Связывание данных с комбобоксом
            DeveloperComboBox.ItemsSource = developers;
            DeveloperComboBox.DisplayMemberPath = "DeveloperName"; // Устанавливаем свойство для отображения имени разработчика
            DeveloperComboBox.SelectedValuePath = "DeveloperID";
        }
        private void LoadCategoryIntoComboBox()
        {
            // Загрузка данных из базы данных
            List<Category> categories = Helper.DB.Category.ToList();

            // Связывание данных с комбобоксом
            CategoryComboBox.ItemsSource = categories;
            CategoryComboBox.DisplayMemberPath = "CategoryName"; // Устанавливаем свойство для отображения имени разработчика
            CategoryComboBox.SelectedValuePath = "CategoryID";
        }

        private void LoadDevelopersIntoComboBox(object sender, SelectionChangedEventArgs e)
        {
            // Ваша логика обработки события SelectionChanged
            // Этот метод остается нетронутым и используется для обработки события SelectionChanged комбо бокса
        }
        private void LoadCategoryIntoComboBox(object sender, SelectionChangedEventArgs e)
        {
            // Ваша логика обработки события SelectionChanged
            // Этот метод остается нетронутым и используется для обработки события SelectionChanged комбо бокса
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
