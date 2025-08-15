using System.Numerics;
using Demo.overload_Examles;


namespace Demo
{
    internal class Program
    {
        #region Methods overLoading 

        public static int SumNumbers(int z, int y) 
        {
            return z + y;   


        }

        public static double SumNumbers(double z, double y)
        {
            return z + y;


        }
        public static double SumNumbers(double z, int y)
        {
            return z + y;


        }



        public static int SumNumbers(int z, int y, int x) 
        {
            return z + y + x;
        }

        public static double SumNumbers(double z, int y, double x)
        {
            return z + y + x;
        }





        #endregion



        static void Main(string[] args)
        {

            #region Overloading

            #region Methods Overloading

            //Console.WriteLine(SumNumbers(5, 6));
            //Console.WriteLine(SumNumbers(5.5, 6.5));    
            //Console.WriteLine(SumNumbers(5.5, 6));  
            //Console.WriteLine(SumNumbers(5, 6, 7)); 
            //Console.WriteLine(SumNumbers(5.5, 6, 7.5)); 



            #endregion

            #region  operator Overloading

            // MyComplex c1 = new MyComplex () { Real = 3, Img = 4 }; 

            //Console.WriteLine(c1); // Output: 3 + 4i

            //MyComplex c2 = new MyComplex() { Real = 7, Img = 8 }; 

            //Console.WriteLine(c2); // Output: 7 + 8i
            //                       // 
            //Console.WriteLine("============================");
            //MyComplex c3 = c1 + c2;
            //Console.WriteLine(c3); // Output: 10 + 12i


            #endregion

            #region unuary overloading

            // MyComplex c1 = new MyComplex() { Real = 3, Img = 4 };

            //Console.WriteLine(c1); // Output: 3 + 4i
            //MyComplex c2 = new MyComplex() { Real = 7, Img = 8 };
            //Console.WriteLine(c2); // Output: 7 + 8i
            //MyComplex c3 = new MyComplex();
            //c3 = ++c1; // Unary plus operator
            //Console.WriteLine(c3); // Output: 3 + 4i

            //MyComplex c4 = new MyComplex();
            //c4 = --c2; // Unary minus operator  
            //Console.WriteLine(c4); // Output: 7 + 8i    

            //MyComplex c5 = new MyComplex();
            //c5 =c1++; // Unary plus operator    

            //Console.WriteLine(c5); // Output: 3 + 4i
             
            //MyComplex c6 = new MyComplex();
            //c6 = c2--; // Unary minus operator  
            //Console.WriteLine(c6); // Output: 7 + 8i    







            #endregion


            #endregion






        }
    }
}
