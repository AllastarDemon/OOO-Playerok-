using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Media3D;
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
        public AddProduct addWindow;
        public EditProduct editWindow;
        List<VideoGame> videoGames;
        int videoGameCount = 0;
        double[,] arrayDiscount = new double[,] { { 0, 100 }, { 10, 30 }, { 35, 40 }, { 45, 60 }, { 60, 100 } };
        int filterDiscount, filterCategory;     //Фильтр по скидке и категории
        string sort;          //Направление сортировки
        int countFilter;      //Количество всех записей и после фильтрации
        string searchVideoGame;      //Строка поиска
        public Catalog(Authorization authorization)
        {
            InitializeComponent();
            auth = authorization;
            sort = "ASC";
            LoadCategoryIntoComboBox();
            ShowProduct();
            if (Helper.user == null)
            {
                editProductButtonAdmin.Visibility = Visibility.Hidden;
                addProductButtonAdmin.Visibility = Visibility.Hidden;
                menuAddProductButtonUser.Visibility = Visibility.Hidden;
                menuAddProductButtonAdmin.Visibility = Visibility.Hidden;
                deleteProductButton.Visibility = Visibility.Hidden;
                collectingOrderButton.Visibility = Visibility.Hidden;
            }
            if (Helper.user != null && Helper.user.UserRole == 2)
            {
                editProductButtonAdmin.Visibility= Visibility.Hidden;
                deleteProductButton.Visibility = Visibility.Hidden;
                addProductButtonAdmin.Visibility = Visibility.Hidden;
                menuAddProductButtonUser.Visibility = Visibility.Hidden;
            }
        }
        public Catalog()
        {
            InitializeComponent();
            ShowProduct();
        }
        private void ShowProduct()
        {
            videoGames = Helper.DB.VideoGame.ToList();

            videoGameCount = videoGames.Count();

            videoGames = videoGames.Where(x => (x.VideoGameDiscount >= arrayDiscount[filterDiscount, 0]
                                    && x.VideoGameDiscount <= arrayDiscount[filterDiscount, 1])).ToList();

            if (filterCategory != 0)
                videoGames = videoGames.Where(x => x.VideoGameCategory == filterCategory).ToList();

            if (!String.IsNullOrEmpty(searchVideoGame))
                videoGames = videoGames.Where(x => x.VideoGameName.Contains(searchVideoGame)).ToList();

            if (sort == "ASC")
                videoGames = videoGames.OrderBy(x => x.VideoGamePrice).ToList();

            else
                videoGames = videoGames.OrderByDescending(x => x.VideoGamePrice).ToList();

            countFilter = videoGames.Count();
            countTextBox.Text = + countFilter + " из " + videoGameCount;
            listBoxVideoGames.ItemsSource = videoGames;

        }
        private void CollectingOrderButton(object sender, RoutedEventArgs e)
        {

        }
        private void TextBoxSearch(object sender, TextChangedEventArgs e)
        {
            searchVideoGame = textBoxSearch.Text;
            ShowProduct();
        }
        private void CategoryComboBox(object sender, SelectionChangedEventArgs e)
        {
            filterCategory = categoryComboBox.SelectedIndex;
            ShowProduct();
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
        private void AddProductButtonUser(object sender, RoutedEventArgs e)
        {

        }
        private void AddProductButtonAdmin(object sender, RoutedEventArgs e)
        {
            addWindow = new AddProduct(this);
            Close();
            addWindow.Show();
        }
        private void EditProductButton(object sender, RoutedEventArgs e)
        {
            
            VideoGame selectedVideoGame = listBoxVideoGames.SelectedItem as VideoGame;
            if (selectedVideoGame != null)
            {
                editWindow = new EditProduct(this, selectedVideoGame);
                Close();
                editWindow.Show();
            }
            else
                MessageBox.Show("Выберите сначала игру! АРА-АРА");
        }

        private void DeleteProductButton(object sender, RoutedEventArgs e)
        {
            VideoGame videogame = listBoxVideoGames.SelectedItem as VideoGame; // Получение данных о игре для последующего удаления

            Helper.DB.VideoGame.Remove(videogame);
            try
            {
                Helper.DB.SaveChanges();
                MessageBox.Show("Удалено");
            }
            catch { MessageBox.Show("Не удалено"); }
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
