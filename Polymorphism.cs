using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UdemyPolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>
            {
                new Audi(160,"blue","Q4 e-tron"),
                new BMW(200,"blue","X5 (G05)"),
            };
            foreach (var car in cars)
            {
                car.ShowDetials();
                car.Repaired();
            }
            Thread.Sleep(35000);
        }
    }
     class Car
    {
        public int HP { get; set; }
        public string Color { get; set; }
        public Car(int HP,string Color)
        {
            this.HP = HP;
            this.Color = Color;
        }
        public void ShowDetials()
        {
            Console.WriteLine("the horse power of car is: " + HP + " the color of car is: " + Color);
        }
        public virtual void Repaired()
        {
            Console.WriteLine("the cas is repaired!");
        }
    }
    class Audi:Car
    {
        private string Model { get; set; }
        private string Brand = "Audi";
        public Audi(int hp,string color,string Model):base(hp, color)
        {
            this.Model = Model;
        }
        public void ShowDetails()
        {
            Console.WriteLine("the car brand is: " + Brand + " the car hp is: " + HP +
                 " the car color is: " + Color);
        }
        public override void Repaired()
        {
            Console.WriteLine("the BMW {0} was repaired " , Model);
        }

    }
    class BMW:Car
    {
        private string Model { get; set; }
        private string Brand="BMW";
        public BMW(int hp,string color,string Model):base(hp,color)
        {
            this.Model = Model;
        }
        public void ShowDetails()
        {
            Console.WriteLine("the car brand is: " + Brand + " the car hp is: " + HP +
                " the car color is: " + Color);
        }
        public override void Repaired()
        {
            Console.WriteLine("the Audi {0} was repaired" , Model);
        }
       
    }
}
