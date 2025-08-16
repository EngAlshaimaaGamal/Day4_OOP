using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.overriding
{
    internal class Employee
    {
        

        #region properties

        public int ID { set; get; }
        public string? Name { set; get; }
        public int Age { set; get; }

        public double Salary { set; get; }


        #endregion

        #region Constructors
        public Employee(int iD, string? name, int age, double salary)
        {
            ID = iD;
            Name = name;
            Age = age;
            Salary = salary;
        }



        #endregion

        #region Methods

        public void GetTypeEmployee() 
        {
          Console.WriteLine("This is a employee");

        }
        public virtual void GetDataEmployee()
        { 
          Console.Write($"ID: {ID}, Name: {Name}, Age: {Age}, Salary: {Salary}");

        }



        #endregion




    }
}
