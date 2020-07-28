using System;
using TreinandoEstruturaTryCatch.Entities;
using TreinandoEstruturaTryCatch.Entities.Exceptions;

namespace TreinandoEstruturaTryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Room number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Check-in date (dd/MM/yyyy): ");
                DateTime dateIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                DateTime dateOut = DateTime.Parse(Console.ReadLine());
                Reservation reservation = new Reservation(number, dateIn, dateOut);
                Console.WriteLine(reservation);

                Console.WriteLine();

                Console.WriteLine("Enter data to update the reservation: ");
                Console.Write("Check-in date (dd/MM/yyyy): ");
                dateIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                dateOut = DateTime.Parse(Console.ReadLine());
                reservation.UpdatesDates(dateIn, dateOut);
                Console.WriteLine(reservation);
            }
            catch (DomainException e)
            {
                Console.WriteLine("Error in reservation: " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format error: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }
        }
    }
}
