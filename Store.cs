using System;
using System.Collections.Generic;
using System.Text;

namespace CarClassLibrary
{
    public class Store
    {
        public List<Car> CarCatalogue { get; set; }
        public List<Car> Cart { get; set; }

        public Store()
        {
            CarCatalogue = new List<Car>();
            Cart = new List<Car>();
        }

        public decimal Checkout()
        {
            //Initializing the total cost
            decimal totalCost = 0;

            foreach (var car in Cart)
            {
                totalCost += car.Price;
            }

            Cart.Clear();
            return totalCost;
        }
    }
}
