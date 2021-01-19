using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseFullMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = Extensions.CalculateAge(new DateTime(1986, 12, 18));
            Console.WriteLine($"You age is: {age}");
        }
    }

    public static class Extensions
    {
        public static int CalculateAge(this DateTime datetime)
        {
            var age = DateTime.Now.Year - datetime.Year;
            if (DateTime.Now < datetime.AddYears(age))
            {
                age--;
            }
            return age;
        }
    }
}
