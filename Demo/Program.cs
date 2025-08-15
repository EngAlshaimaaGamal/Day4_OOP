using System.Numerics;
using Demo.overload_Examles;
using Demo.overriding;


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
            #region Relational operator

            // MyComplex c1 = new MyComplex() { Real = 3, Img = 4 };


            //MyComplex c2 = new MyComplex() { Real = 7, Img = 8 };

            //if(c1>c2)
            //    Console.WriteLine("c1 is greater than c2"); 
            //else if (c1 < c2)   
            //    Console.WriteLine("c1 is less than c2");
            //else
            //    Console.WriteLine("c1 is equal to c2"); 


            #endregion

            #region Casting operator overloading

            #region Casting Builtin type
            //MyComplex c1 = new MyComplex() { Real = 3, Img = 4 };

            //int x = (int)c1; // Implicit conversion to int   invalid
            //Console.WriteLine(x); // Output: 3

            //string str = c1; // Implicit conversion to string
            //Console.WriteLine(str); // Output: 3 + 4i   



            #endregion

            #region user_defined DataType casting

            //User user1 = new User()
            //{
            //    Id = 1,
            //    FullName = "John Doe",
            //    Email = "John@email.com",
            //    Password = "P@ssw0rd",
            //    SecuirtyStamp = Guid.NewGuid()

            //};
            //UserViewModel userViewModel = (UserViewModel)user1; // Implicit conversion to UserViewModel    
            //                                                    // Manual Mapping  ====> AutoMapper in Entity Framework Core
            //Console.WriteLine($"Id: {userViewModel.Id}, FirstName: {userViewModel.FirstName}, LastName: {userViewModel.LastName}, Email: {userViewModel.Email}"); // Output: Id: 1, FirstName: John, LastName: Doe, Email:  



            #endregion




            #endregion


            #endregion


            #region Overriding

            //TypeA  typeA = new TypeA(5);
            //typeA.Method01(); // Output: Method01 from TypeA    
            //typeA.Method02(); // Output: Method02 from TypeA :5 

            //Console.WriteLine("=====================================");

            //TypeB typeB = new TypeB(6, 10); 
            //typeB.Method01(); // Output: Method01 from TypeB // keyword new 
            //typeB.Method02(); // Output: Method02 from TypeB :5 10 // keyWord override









            #endregion






        }
    }
}
