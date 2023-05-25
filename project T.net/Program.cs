using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectT.net
{

    public class Car
    {
        public string Name;
        public string Color;
        public string model;
        public int year;



        public void DisplayCar()
        {

            Console.WriteLine("the car prop is :" + Name + "\n" + Color + "\n" + model + "\n" + year);

        }

    }




    internal class Program
    {



         static void Main(string[] args)
        {

            Car car = new Car();
            car.Name = "Toyota";
            car.Color = "blue";
            car.model = "camery";
            car.year = 2022;

            car.DisplayCar();

            
        }
    }
}
