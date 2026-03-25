using System;
using System.Collections.Generic;
using System.Linq;
using ProjectCS.Enums;
using ProjectCS.Models;

namespace ProjectCS.Services
{
    public class RentalService
    {
        private List<Rental> rentals = new();
        public void RentEquipment(User user, Equipment equipment, int days)
        {
            if (equipment.Status != EquipmentStatus.Available)
                throw new Exception("Sprzęt niedostępny");

            int active = rentals.Count(r => r.User == user && r.ReturnDate == null);
            if (active >= user.MaxRentals)
                throw new Exception("Limit przekroczony");

            var rental = new Rental(user, equipment, days);
            rentals.Add(rental);

            equipment.Status = EquipmentStatus.Rented;
        }
        public void ReturnEquipment(Rental rental)
        {
            rental.ReturnDate = DateTime.Now;
            if (rental.ReturnDate > rental.DueDate)
            {
                int daysLate = (rental.ReturnDate.Value - rental.DueDate).Days;
                rental.Penalty = daysLate * 10;
            }
            rental.Equipment.Status = EquipmentStatus.Available;
        }
    }
}