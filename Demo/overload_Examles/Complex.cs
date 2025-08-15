using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Demo.overload_Examles
{
    public class MyComplex
    {

        #region Properities

        public double Real { get; set; }
        public double Img { get; set; }


        #endregion
        #region Constructor

        //public MyComplex(double real, double img)
        //{
        //    Real = real;
        //    Img = img;
        //}
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"{Real} + {Img}i";
        }


        #endregion


        #region operators

        public static MyComplex operator + (MyComplex left, MyComplex right)
        {

            return new MyComplex()
            {
                Real = (left?.Real ?? 0) + (right?.Real ?? 0),
                Img = (left?.Img ?? 0) + (right?.Img ?? 0)


            };

            //MyComplex result = new MyComplex( )
            //{
            //    Real = (left?.Real ?? 0)+ (right?.Real ?? 0),
            //    Img = (left?.Img ?? 0) + ( right?.Img??0 )


            //};
            // return result;




        }

        public static MyComplex operator - (MyComplex left, MyComplex right)
        {

            return new MyComplex()
            {
                Real = (left?.Real ?? 0) - (right?.Real ?? 0),
                Img = (left?.Img ?? 0) - (right?.Img ?? 0)


            }; // more readiable way to write it    

            //MyComplex result = new MyComplex( )
            //{
            //    Real = (left?.Real ?? 0)- (right?.Real ?? 0),
            //    Img = (left?.Img ?? 0) - ( right?.Img??0 )


            //};
            // return result;




        }


        public static MyComplex operator ++(MyComplex c)
        {

            if (c is not null)
            {
                return new MyComplex()
                {
                    Real = (c.Real) + 1,
                    Img = c.Img
                };

            }
            else
                return new MyComplex();

         }


        public static MyComplex operator --(MyComplex c)
        {
            return new MyComplex()
            {
                Real = (c?.Real ?? 0) - 1,
                Img = c?.Img ?? 0

            };
         

        }

        public static bool operator <(MyComplex c1, MyComplex c2)
        {
            if(c1?.Real == c2?.Real)
                return c1?.Img < c2?.Img;
            else
                return c1?.Real < c2?.Real;   

        }


        public static bool operator >(MyComplex c1, MyComplex c2)
        {
            if (c1?.Real == c2?.Real)
                return c1?.Img > c2?.Img;
            else
                return c1?.Real > c2?.Real;
        }   




    }

        #endregion


    
}
