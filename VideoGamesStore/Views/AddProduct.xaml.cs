﻿using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;
using VideoGamesStore.Classes;
using VideoGamesStore.Database;
using System;

namespace VideoGamesStore.Views
{
    public partial class AddProduct : Window
    {
        private Catalog formCatalog;
        public AddProduct(Catalog catalog)
        {
            InitializeComponent();
            formCatalog = catalog;

            developerComboBox.ItemsSource = Helper.DB.Developer.ToList();
            developerComboBox.DisplayMemberPath = "DeveloperName";
            developerComboBox.SelectedValuePath = "DeveloperID";

            categoryComboBox.ItemsSource = Helper.DB.Category.ToList();
            categoryComboBox.DisplayMemberPath = "CategoryName";
            categoryComboBox.SelectedValuePath = "CategoryID";
        }
        private void SaveEditForm(object sender, RoutedEventArgs e)
        {
            VideoGame addVideoGame = new VideoGame();
            addVideoGame.VideoGameName = TitleTextBox.Text;
            addVideoGame.VideoGamePrice = Convert.ToDouble(PriceTextBox.Text);
            addVideoGame.VideoGameDiscount = Convert.ToDouble(DiscountTextBox.Text);
            addVideoGame.VideoGameDescription = DescriptionTextBox.Text;
            addVideoGame.VideoGameDeveloper = (developerComboBox.SelectedItem as Developer).DeveloperID;
            addVideoGame.VideoGameCategory = (categoryComboBox.SelectedItem as Category).CategoryID;
            Helper.DB.VideoGame.Add(addVideoGame);
            try
            {
                Helper.DB.SaveChanges();
                MessageBox.Show("Получилось");
            }
            catch (Exception ex) { MessageBox.Show("Не получилось"); }
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
