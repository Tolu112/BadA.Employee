using System;
namespace BadA.Employee

//Person 1: Create an employee class and give it the following properties
//-string name
//-double salary
//-string position
//and a constructor that fills those values
{
    

    public class Employees

    {
        //properties
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Position { get; set; }

        //Constructor
        public Employees(string _name, double _salary, string _position)
        {
            Name = _name;
            Salary = _salary;
            Position = _position;
        }
    }
}

