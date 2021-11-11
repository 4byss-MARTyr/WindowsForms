using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp1
{
    public enum Sex
    {
        Male,
        Female
    }
    public class Human
    {

        public Address address;
        public string _name;
        public string _surname;
        public int _age;
        public Sex Sex;

        public Human(string name, string surname, int age, Sex sex, Address addres)
        {
            _name = name;
            _surname = surname;
            _age = age;
            Sex = sex;
            address = addres;
        }

       
    }
}