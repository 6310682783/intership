using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Car
    {
        //property
        private string brand { get; set; } 
        private string model { get; set; }
        private double price { get; set; }
        private int year { get; set; }

        //constructor
        public Car(string brand, string model, double price, int year)
        {
            this.brand = brand;
            this.model = model;
            this.price = price;
            this.year = year;
        }

        //method
        public void Whoami() {
            //do it
            Console.WriteLine($"This is a {brand} : {model}");
        }
        public double Getprice() { 
            return price;
        }
        public double Gettax()
        {
            return (price * 7)/100;
        }
    }
}
