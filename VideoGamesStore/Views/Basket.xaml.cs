using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using VideoGamesStore.Database;

namespace VideoGamesStore.Views
{
    public partial class Basket : Window
    {
        List<VideoGame> videogames;
        Random random = new Random();
        private Catalog formCatalog;
        public Basket(Catalog catalog, List<VideoGame> videogames)
        {
            InitializeComponent();
            this.videogames = videogames;
            formCatalog = catalog;
            textBoxCodeOfOrder.Text = "Код заказа: " + random.Next(100, 999);

            ShowProducts();
        }
        private void DeleteButtonBasket(object sender, RoutedEventArgs e)
        {
            VideoGame videogame = (sender as Button).DataContext as VideoGame;
            videogames.Remove(videogame);
            MessageBox.Show("Продукт удалён!");
            ShowProducts();
        }
        private void ShowProducts()
        {
            // Обновление списка выбранных продуктов
            int count = 0;
            double amount = 0, amountWithDiscount = 0, discount = 0;
            foreach (VideoGame videogame in videogames)
            {
                count += 1;
                amount += videogame.VideoGamePrice;
                amountWithDiscount += videogame.VideoGameCostWithDiscount;
            }
            discount = amount - amountWithDiscount;

            textBoxSum.Text = "Итоговая сумма заказа:" + amountWithDiscount;

            listBoxBasket.ItemsSource = null;
            listBoxBasket.ItemsSource = videogames;
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

        private void ButtonOrder(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Заказ успешно выполнен и скоро вам будет отправлен на почту чек! Или не будет...");
            Close();
        }
    }
}
