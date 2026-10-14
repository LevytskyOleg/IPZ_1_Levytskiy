using System;

namespace BeautySalonApp
{
    public class Booking
    {
        // Поля класу з методами GET та SET (як вимагає методичка)
        public string? ClientName { get; set; }
        public string? ServiceType { get; set; }
        public string? MasterName { get; set; }
        public string? PhoneNumber { get; set; }
        public DateTime BookingDate { get; set; }

        // Конструктор за замовчуванням
        public Booking()
        {
            BookingDate = DateTime.Now; // Встановлюємо поточну дату базово
        }
    }
}