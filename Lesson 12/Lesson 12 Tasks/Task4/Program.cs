using System;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(0);

            Console.Write("Enter amount of fuel : ");
            int fuel = Convert.ToInt32(Console.ReadLine());

            if (car.Refuel(fuel))
            {
                car.Drive();
            }
        }
    }
}
