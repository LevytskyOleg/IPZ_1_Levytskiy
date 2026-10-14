using System;
using System.Windows;

namespace BeautySalonApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Дія при натисканні на кнопку "Створити новий запис"
        private void BtnNewBooking_Click(object sender, RoutedEventArgs e)
        {
            // Ми створимо це вікно на наступному кроці
            BookingWindow bookingWindow = new BookingWindow();
            bookingWindow.Show();
            this.Close(); // Закриваємо поточне вікно
        }

        // Дія при натисканні на кнопку "Вихід"
        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}