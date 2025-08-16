using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.overriding
{
    internal class FulltimeEmployee : Employee  
    {
        public FulltimeEmployee(int id, string name, int age, double salary) : base(id, name, age, salary) { }


        #region Methods

        public new void GetTypeEmployee()
        {
            Console.WriteLine("This is a full time employee");
        }   
        public override void GetDataEmployee()
        {
            base.GetDataEmployee();
            Console.Write(", Type: Full Time");
        }   


        #endregion




    }
}
