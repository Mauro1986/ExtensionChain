using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ExtensionChain
{
    class Program
    {
        static void Main(string[] args)
        {
            //Car car = new Car();
            //car.Refuel(5);
            //car.Drive();
            //car.Empty();
            //Console.WriteLine("---------------------");

            Car car = new Car();
            car.Refuel(3).Drive().Empty().Refuel(5).Drive().Empty() ;       //Dit is MEthod-Chain en kan het zelfde doen als bovenstaande lijnen
        }
    }

    public class Car
    {
        public int Refuel { get; set; }
        public int Drive { get; set; }
        public int Empty { get; set; }
    }

    public static class Ext
    {
        public static Car Refuel(this Car car, int liter)
        {
            Console.WriteLine("Your car is being refuled...please wait!");
            car.Refuel += liter;
            Console.WriteLine($"Car refueled with {liter} liter");
            return car;
        }
        public static Car Drive(this Car car)
        {
            if (car.Refuel > 0)
            {
                for (int i = 0; i < car.Refuel; i++)
                {
                 Console.WriteLine("Driving");
                    Thread.Sleep(800);
                }
            }
            else
            {
                Console.WriteLine("Car has stopped because there is nu fuel\nPlease refuel");
            }
            return car;
        }
        public static Car Empty(this Car car)
        {
            car.Refuel = 0;
            return car;
        }
    }
}
