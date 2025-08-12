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


            //Console.WriteLine(SumNumbers(5, 6));
            //Console.WriteLine(SumNumbers(5.5, 6.5));    
            //Console.WriteLine(SumNumbers(5.5, 6));  
            //Console.WriteLine(SumNumbers(5, 6, 7)); 
            //Console.WriteLine(SumNumbers(5.5, 6, 7.5)); 





        }
    }
}
