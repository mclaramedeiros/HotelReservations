using HotelSolution.Entities;
using HotelSolution.Entities.Exceptions;

namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.Write("Room Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Check-in date (dd/MM/yyyy):");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy):");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                Reservation reservation = new Reservation(number, checkIn, checkOut);

                Console.WriteLine(reservation.ToString());
                Console.Write("Enter data to update the reservation");
                Console.Write("Check-in date (dd/MM/yyyy):");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy):");
                checkOut = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(checkIn, checkOut);
                Console.WriteLine(reservation.ToString());
            }
            catch (DomainExceptions ex)
            {
                Console.WriteLine($"Error {ex.Message}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Format Error {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error{ex.Message}");
            }
        }
    }
}