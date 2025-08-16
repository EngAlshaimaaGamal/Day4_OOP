using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.overriding
{
    internal class ParttimeEmployee : Employee
    {
        #region Constructor

        public ParttimeEmployee(int id, string name, int age  ,double salary, int hoursWorked, int countOfHours) : base( id , name ,age ,salary )
        { 
            HoursWorked = hoursWorked;
            CountOfHours = countOfHours;    


        }
       



        #endregion



        #region Properties
        public int HoursWorked { get; set; }

        public int CountOfHours { get; set; }


        #endregion

        #region Methods

        public new void GetTypeEmployee()
        {
            Console.WriteLine("This is a part time employee");
        } 
        
        public override void GetDataEmployee()
        {
            base.GetDataEmployee();
            Console.Write($", Hours Worked: {HoursWorked}, Count of Hours: {CountOfHours}");    
        }   


        #endregion


    }
}
