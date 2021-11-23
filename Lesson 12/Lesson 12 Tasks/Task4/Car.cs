using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class Car : IVehicle
    {
        private int _amountOfGasoline;

        public Car(int amountOfGasoline)
        {
            _amountOfGasoline = amountOfGasoline;
        }

        public void Drive()
        {
            if (_amountOfGasoline > 0)
            {
                Console.WriteLine("The car is driving.");
            }
            else
            {
                Console.WriteLine("Not fuel.");
            }
        }

        public bool Refuel(int amountOfGasoline)
        {
            _amountOfGasoline += amountOfGasoline;

            return true;
        }
    }
}
