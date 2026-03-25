using System;
using ProjectCS.Models;
using ProjectCS.Services;

namespace ProjectCS
{
    class Program
    {
        static void Main()
        {
            var service = new RentalService();

            var student = new Student(1, "Jakub", "Fudala");
            var laptop = new Laptop(1, "Dell", 16, "i7");
            service.RentEquipment(student, laptop, 2);
            try
            {
                service.RentEquipment(student, laptop, 2);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Done");
        }
    }
}