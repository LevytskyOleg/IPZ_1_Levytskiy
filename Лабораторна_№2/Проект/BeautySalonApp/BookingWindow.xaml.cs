using System;
using System.Windows;

namespace BeautySalonApp
{
    public partial class BookingWindow : Window
    {
        // Створюємо змінну нашого класу для прив'язки даних
        public Booking CurrentBooking { get; set; }

        public BookingWindow()
        {
            InitializeComponent();

            // Ініціалізуємо клас і підключаємо його до вікна (Data Binding)
            CurrentBooking = new Booking();
            this.DataContext = CurrentBooking;
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            // Використання конструкції try...catch згідно з вимогою методички
            try
            {
                // Штучно генеруємо помилку, якщо клієнт не ввів своє ім'я
                if (string.IsNullOrWhiteSpace(CurrentBooking.ClientName))
                {
                    throw new Exception("Помилка: Поле 'Ім'я клієнта' не може бути порожнім!");
                }

                // Штучно генеруємо помилку, якщо клієнт не ввів телефон
                if (string.IsNullOrWhiteSpace(CurrentBooking.PhoneNumber))
                {
                    throw new Exception("Помилка: Будь ласка, вкажіть контактний номер телефону!");
                }

                // Якщо помилок немає, показуємо успішне повідомлення
                MessageBox.Show($"Успішно! Клієнта {CurrentBooking.ClientName} записано на процедуру: {CurrentBooking.ServiceType}.",
                                "Підтвердження", MessageBoxButton.OK, MessageBoxImage.Information);

                // Повертаємось на головне меню
                MainWindow main = new MainWindow();
                main.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                // Відловлення можливих помилок і виведення їх на екран
                MessageBox.Show(ex.Message, "Помилка вводу", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }
    }
}