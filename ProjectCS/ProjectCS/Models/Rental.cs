using System;

namespace ProjectCS.Models
{
    public class Rental
    {
        public User User { get; set; }
        public Equipment Equipment { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public decimal Penalty { get; set; }

        public Rental(User user, Equipment equipment, int days)
        {
            User = user;
            Equipment = equipment;
            RentDate = DateTime.Now;
            DueDate = RentDate.AddDays(days);
        }
    }
}