using System.Linq;
using System.Windows;
using VideoGamesStore.Classes;
using VideoGamesStore.Views;
using EasyCaptcha.Wpf;
using System;

namespace VideoGamesStore
{
    public partial class Authorization : Window
    {
        Catalog shop;
        String captchaText;
        public Authorization()
        {
            InitializeComponent();

            const int lengthCaptcha = 4; 
            captcha.CreateCaptcha(Captcha.LetterOption.Alphanumeric, lengthCaptcha);
            captchaText = captcha.CaptchaText;
        }
        private void RegenerateCaptcha(object sender, RoutedEventArgs e)
        {
            const int lengthCaptcha = 4;
            captcha.CreateCaptcha(Captcha.LetterOption.Alphanumeric, lengthCaptcha);
            captchaText = captcha.CaptchaText;
            // Обновляем текст капчи в вашем интерфейсе
        }
        private void OpenCatalogHowGuest(object sender, RoutedEventArgs e)
        {
            Helper.user = null;
            shop = new Catalog(this);
            Close();
            shop.Show();
        }
        private void OpenCatalog(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(LoginTextBox.Text) || string.IsNullOrWhiteSpace(PasswordTextBox.Password))
            {
                MessageBox.Show("Заполните все поля логина и пароля.");
            }
            else
            {
                Helper.user = Helper.DB.User.Where(x => x.UserLogin == LoginTextBox.Text && x.UserPassword == PasswordTextBox.Password).ToList().FirstOrDefault();
                if (Helper.user != null)
                {
                    if (captchaTextBox.Text == captcha.CaptchaText)
                    {
                        MessageBox.Show("Captcha введёна успешно");

                        MessageBox.Show("Вы вошли как: " + Helper.user.UserFullName);
                        shop = new Catalog(this);
                        Close();
                        shop.Show();
                    }
                    else
                    {
                        MessageBox.Show("Captcha введена не успешно");

                    }
                    
                }
                else
                    MessageBox.Show("Неверный логин или пароль");
            }
            
        }
    }
}
