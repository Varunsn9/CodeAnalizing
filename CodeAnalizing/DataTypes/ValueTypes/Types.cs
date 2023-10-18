using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAnalizing.DataTypes.ValueTypes
{
    class Types
    {
        public static void Integer()
        {
            int intDefault = 10;
            Console.WriteLine($"Int32 is the default int {intDefault}");
            Int16 int16 = 10;
            Console.WriteLine($"Int16 {int16}");
            Int64 int64 = 10;
            Console.WriteLine($"Int64 {int64}");
            Int32 int32 = 10;
            Console.WriteLine($"Int32 {int32}");
            short shortType= 10;
            Console.WriteLine($"short is nothing but Int16 ={shortType}");
            long longType= 10;
            Console.WriteLine($"long is nothing but Int64 ={longType}");
            byte byteType= 10;
            Console.WriteLine($"byte is an 8 bit ={byteType}");
        }
        public static void FloatingPoint() 
        {
            double doubleType = 100.11111111;
            Console.WriteLine($"{doubleType}");
            //The precision of float is only six or seven decimal digits,
            //while double variables have a precision of about 15 digit
            float floatType = 100.011111111f;
            Console.WriteLine($"{floatType}");
        }
        public static void BooleanType()
        {
            bool falseType = false;
            Console.WriteLine($"{falseType}");

            bool trueType = true;
            Console.WriteLine($"{trueType}");
        }
        public static void CharacterType()
        {
            char charType = 'a';
            Console.WriteLine($"{charType} ");
        }

        public static void EnumType()
        {
            Console.WriteLine(Days.Sunday);
            Console.WriteLine(Days.Monday);
            Console.WriteLine(Days.Tuesday);
            Console.WriteLine(Days.Wednesday);
            Console.WriteLine(Days.Thursday);
            Console.WriteLine(Days.Friday);
            Console.WriteLine(Days.Saturday);
        }
    }
    public enum Days
    {
        Sunday=1,
        Monday=2, 
        Tuesday=3, 
        Wednesday=4,
        Thursday=5,
        Friday=6,
        Saturday=7
    }
}
