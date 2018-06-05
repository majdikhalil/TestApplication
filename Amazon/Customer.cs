using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Customer
    {
        public int Id;
        public string Name;
        public readonly List<Order> Orders = new List<Order>();

        public void Promote()
        {
            var rating = CalculateRating(excludeOrders: true);
            if (rating == 0 )
            {
                Console.WriteLine("Promoted to level 1 ");
            }
            else
            {
                Console.WriteLine("Promoted to level 2");
            }

        }

        private int CalculateRating(bool excludeOrders)
        {
            return 0;

        }

        public Customer(int id)
        {
            this.Id = id;

        }

        public Customer(int id, string name)
            :this(id)
        {
            this.Name = name;

        }

    }


}
