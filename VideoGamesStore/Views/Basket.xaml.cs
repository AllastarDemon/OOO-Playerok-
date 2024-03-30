using System;
using System.Collections.Generic;
using System.IO;
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
        DocumentPage pdfFile;
        string pathToPdfFile = "@F:\\Programming\\VideoGamesStore\\VideoGamesStore\\Documents";
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

            // Создание PDF документа
            PdfWriter.GetInstance(pdfFile, new FileStream(pathToPdfFile, FileMode.Create));
            pdfFile.Open();

            // Добавление данных заказа в PDF
            Paragraph paragraph = new Paragraph("Данные заказа:");
            pdfFile.Add(paragraph);

            pdfFile.Add(new Paragraph($"Название видеоигры: {gameTitle}"));
            pdfFile.Add(new Paragraph($"Цена: {price}")); // Можно форматировать цену по вашим требованиям
            // Добавьте другие данные заказа по вашему усмотрению

            pdfFile.Close();

            Close();
        }
    }
}
