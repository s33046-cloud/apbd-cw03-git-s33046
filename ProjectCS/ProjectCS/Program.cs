using System;
using System.Linq;
using ProjectCS.Models;
using ProjectCS.Services;

namespace ProjectCS
{
    class Program
    {
        static void Main()
        {
            var service = new RentalService();
            
            var laptop1 = new Laptop(1, "Dell", 16, "i7");
            var laptop2 = new Laptop(2, "HP", 8, "i5");
            var camera = new Camera(3, "Canon", 24, true);
            var projector = new Projector(4, "Epson", 3000, true);
            
            var student = new Student(1, "Jakub", "Fudala");
            var student2 = new Student(2, "Anna", "Nowak");
            var employee = new Employee(3, "Piotr", "Zielinski");
            
            service.RentEquipment(student, laptop1, 2);
            
            try
            {
                service.RentEquipment(employee, laptop1, 3);
            }
            catch (Exception e)
            {
                Console.WriteLine("Błąd: " + e.Message);
            }
            
            var rental1 = service.GetActiveRentals(student).First();
            service.ReturnEquipment(rental1);
            
            service.RentEquipment(student2, laptop2, 1);
            var rental2 = service.GetActiveRentals(student2).First();
            
            rental2.DueDate = DateTime.Now.AddDays(-2);

            service.ReturnEquipment(rental2);
            Console.WriteLine($"Kara: {rental2.Penalty}");
            Console.WriteLine("System działa poprawnie.");
        }
    }
}