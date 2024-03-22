using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using VideoGamesStore.Classes;
using VideoGamesStore.Database;

namespace VideoGamesStore.Views
{
    public partial class EditProduct : Window
    {
        private Catalog formCatalog;
        VideoGame videogame;
        string filePath;
        string fileName;
        public EditProduct(Catalog catalog, VideoGame videogame)
        {
            InitializeComponent();
            formCatalog = catalog;
            LoadDevelopersIntoComboBox();
            LoadCategoryIntoComboBox();

            this.videogame = videogame;

            TitleTextBox.Text = videogame.VideoGameName;
            PriceTextBox.Text = videogame.VideoGamePrice.ToString();
            DiscountTextBox.Text = videogame.VideoGameDiscount.ToString();
            DescriptionTextBox.Text = videogame.VideoGameDescription.ToString();
            developerComboBox.ItemsSource = Helper.DB.Developer.ToList();
            developerComboBox.DisplayMemberPath = "DeveloperName";
            developerComboBox.SelectedValuePath = "DeveloperID";
            developerComboBox.SelectedIndex = videogame.VideoGameDeveloper - 1;

            categoryComboBox.ItemsSource = Helper.DB.Category.ToList();
            categoryComboBox.DisplayMemberPath = "CategoryName";
            categoryComboBox.SelectedValuePath = "CategoryID";
            categoryComboBox.SelectedIndex = videogame.VideoGameCategory - 1;
        }
        private void SaveEditForm(object sender, RoutedEventArgs e)
        {
            
            VideoGame editVideoGame = Helper.DB.VideoGame.FirstOrDefault(x => x.VideoGameID == videogame.VideoGameID);
            editVideoGame.VideoGameName = TitleTextBox.Text;
            editVideoGame.VideoGamePrice = Convert.ToDouble(PriceTextBox.Text);
            editVideoGame.VideoGameDiscount = Convert.ToDouble(DiscountTextBox.Text);
            editVideoGame.VideoGameDescription = DescriptionTextBox.Text;
            editVideoGame.VideoGameDeveloper = (developerComboBox.SelectedItem as Developer).DeveloperID;
            editVideoGame.VideoGameCategory = (categoryComboBox.SelectedItem as Category).CategoryID;
            try
            {
                Helper.DB.SaveChanges();
                MessageBox.Show("Получилось");
            }
            catch (Exception ex) { MessageBox.Show("Не получилось"); }
        }
        private void ButtonOpenDialog(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.PNG)|*.PNG";

            bool? result = openFileDialog.ShowDialog();

            // Проверяем, был ли выбран файл
            if (result == true)
            {
                // Получаем путь к выбранному файлу
                filePath = openFileDialog.FileName;
                fileName = openFileDialog.SafeFileName.Replace(".png", "");

                videogame.VideoGameImage = fileName;

                // Создаем новый путь и новое имя файла
                string newFilePath = Environment.CurrentDirectory + @"\..\..\Resources\" + videogame.VideoGameImage + ".png";

                if (File.Exists(newFilePath))
                {
                    MessageBox.Show("Изображение с таким названием уже существует!");
                    return;
                }
                try
                {
                    // Копируем файл в новое место с новым именем
                    File.Copy(filePath, newFilePath);

                    // Выводим сообщение об успешном сохранении
                    Console.WriteLine("Файл успешно сохранен как: " + newFilePath);
                }
                catch (Exception ex)
                {
                    // Выводим сообщение об ошибке, если что-то пошло не так
                    Console.WriteLine("Ошибка при сохранении файла: " + ex.Message);
                }
            }
        }
        private void LoadDevelopersIntoComboBox()
        {
            // Загрузка данных из базы данных
            List<Developer> developers = Helper.DB.Developer.ToList();

            // Связывание данных с комбобоксом
            developerComboBox.ItemsSource = developers;
            developerComboBox.DisplayMemberPath = "DeveloperName"; // Устанавливаем свойство для отображения имени разработчика
            developerComboBox.SelectedValuePath = "DeveloperID";
        }
        private void LoadCategoryIntoComboBox()
        {
            // Загрузка данных из базы данных
            List<Category> categories = Helper.DB.Category.ToList();

            // Связывание данных с комбобоксом
            categoryComboBox.ItemsSource = categories;
            categoryComboBox.DisplayMemberPath = "CategoryName"; // Устанавливаем свойство для отображения имени разработчика
            categoryComboBox.SelectedValuePath = "CategoryID";
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
