using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp1
{
    public class Address
    {
        public string _country { get; private set; }
        public string _city { get; private set; }

        public string _street { get; private set; }

        public int _house_number { get; private set; }

        public Address(string country, string city, string street, int house_number)
        {
            _country = country;
            _city = city;
            _street = street;
            _house_number = house_number;

        }

        public Address()
        {
            Console.WriteLine("Input country: ");
            _country = Console.ReadLine();
            Console.WriteLine("Input city: ");
            _city = Console.ReadLine();
            Console.WriteLine("Input street: ");
            _street = Console.ReadLine();
            string house_numberStr = Console.ReadLine();
            int num;
            int.TryParse(house_numberStr, out num);
            _house_number = num;
        }
        public void GetInfo()
        {
            Console.WriteLine("Country: " + _country + " City: " + _city + " Street: " + _street + " Number of house: " + _house_number);


        }
    }
}