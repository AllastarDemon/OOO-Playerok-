using System;
using System.Collections.Generic;
using System.Windows;
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
