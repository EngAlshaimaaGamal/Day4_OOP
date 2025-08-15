using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.overriding
{
    internal class TypeB : TypeA    
    {
        #region Properties
        public int B { get; set; }

        #endregion
        #region Construtor

        public TypeB(int a, int b) : base(a)
        {
            B= b;   

        }

        #endregion

        #region Methods
        public new void Method01()
        {
            Console.WriteLine("Method01 from TypeB");
        }

        public override void Method02()
        {
            Console.WriteLine($"Method02 from TypeB :{A} {B}");
        }   




        #endregion




    }
}
