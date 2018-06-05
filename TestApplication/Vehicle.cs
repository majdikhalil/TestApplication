using System;

namespace TestApplication
{
    public class Vehicle
    {
        private readonly string _registrationNumber;

        //public Vehicle ()
        //{
        //    Console.WriteLine("Vehicle is being initialized."); 
        //}
        public Vehicle(string registrationNumber)
        {
            _registrationNumber = registrationNumber;
            Console.WriteLine("The car is being initialized " + registrationNumber);
        }
    }
}
