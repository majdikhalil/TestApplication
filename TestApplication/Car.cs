using System;

namespace TestApplication
{
    public class Car : Vehicle
    {
        public Car(string regNumber)
            :base(regNumber)
        {
            Console.WriteLine("Car is being initialized");
        }

    }
}
