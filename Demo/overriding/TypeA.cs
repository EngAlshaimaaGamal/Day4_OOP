using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.overriding
{
    internal class TypeA
    {
        #region Properties
        public int A { get; set; }

        #endregion
        #region Constructor

        public TypeA(int a)
        {
            A = a;
        }


        #endregion

        #region Methods

        public void Method01() 
        {
            Console.WriteLine("Method01 from TypeA");   
        }
        public virtual void Method02() 
        {
            Console.WriteLine($"Method02 from TypeA :{A}");
        }   



        #endregion


    }
}
