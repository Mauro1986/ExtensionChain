using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMetodUseful
{
    class Program
    {
        static void Main(string[] args)
        {
            if (ExtensionMethods.Between(new DateTime(2021, 01, 19), DateTime.Now, DateTime.Now.AddDays(10)))
            {
                Console.WriteLine("Inside the range");
            }
            else
            {
                Console.WriteLine("outside the range");
            }


            int age = ExtensionMethods.CalculateAge(new DateTime(1961, 05, 29));
            Console.WriteLine($"The person's age is {age}");


            string str = null;
            str = ExtensionMethods.RemoveFirstCharacter("Kenan");
            Console.WriteLine(str);

            str = ExtensionMethods.RemoveFirstX("Kenan", 4);
            Console.WriteLine(str);

            str = ExtensionMethods.RemoveLastCharacter("Kenan");
            Console.WriteLine(str);

            str = ExtensionMethods.RemoveLastX("Kenan", 3);
            Console.WriteLine(str);
        }
    }

    public static class ExtensionMethods
    {
        public static bool Between(this DateTime dt, DateTime rangeBegin, DateTime rangeEnd)
        {
            return dt.Ticks >= rangeBegin.Ticks && dt.Ticks <= rangeEnd.Ticks;
        }

        public static int CalculateAge(this DateTime dateTime)
        {
            var age = DateTime.Now.Year - dateTime.Year;
            if (DateTime.Now < dateTime.AddYears(age))
                age--;
            return age;
        }

        public static string RemoveLastCharacter(this String instr)
        {
            return instr.Substring(0, instr.Length - 1);
        }
        public static string RemoveLastX(this String instr, int number)
        {
            return instr.Substring(0, instr.Length - number);
        }
        public static string RemoveFirstCharacter(this String instr)
        {
            return instr.Substring(1);
        }
        public static string RemoveFirstX(this String instr, int number)
        {
            return instr.Substring(number);
        }
    }
}