using System;
using System.Collections.Generic;
using System.Text;

namespace CarClassLibrary
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Colour { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }

        //public Car()
        //{
        //    Make = "nothing yet";
        //    Model = "nothing yet";
        //    Price = 0.00M;
        //}

        public Car(string make, string model, string colour, int year, decimal price)
        {
            Make = make;
            Model = model;
            Colour = colour;
            Year = year;
            Price = price; 
        }
    }
}
