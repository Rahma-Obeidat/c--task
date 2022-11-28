using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace nov28
{
    internal class Program
    {
        class person
        {
            public string name;
            public string Name {
                get; set;
            }
            public int age2 { private get; set; }

            int age;
            public int Age
            {
                get { return age; }
                set { age = value; }
            }
            int id;

            public int Id
            {
                get { return id; }
            }
        }
        class Car
        {
            int year;
            public int Year {
                get { return year; }
                set { year = value; }


            }
            string type;
            public string Type
            {
                get { return type; }
                set { type = value; }
            }
            double price;
            public double Price
            {
                get { return price; }
                set { price = value; }
            }
            string modle;
            public string Modle
            {
                get { return modle; }
                set
                {
                    modle = value;
                }
            }
            long Pallet_No;
            public long pallet_No
            {
                get { return Pallet_No; }
                set
                {
                    Pallet_No = value;
                }
            }
            string color;
            public string Color
            {
                get { return color; }
                set
                {
                    color = value;
                }
            }

            public Car(int year, string type, double price, string modle, long Pallet_No, string color) {
                this.year = year;
                this.type = type;
                this.price = price;
                this.modle = modle;
                this.Pallet_No = Pallet_No;
                this.color = color;



            }
            public Car()
            {

            }
            public void start()
            {
                Console.WriteLine("the car is started");
            }
            public void stop()
            {
                Console.WriteLine("the car is stoped");
            }
            public void print()
            {
                Console.WriteLine(year);
                Console.WriteLine(type);
                Console.WriteLine(price);
                Console.WriteLine(modle);
                Console.WriteLine(color);
                Console.WriteLine(Pallet_No);

            }
        }
        class toyota : Car
        {
            //public test() { }
            public toyota(int year, string type, double price, string modle, long Pallet_No, string color) : base(year, type, price, modle, Pallet_No, color)
            {
                Console.WriteLine("class test");


            }


        }
        static void Main(string[] args)
        {
            toyota t = new toyota(2022, "marcedes", 70.000, "e400", 2258522, "black");
            t.print();
            t.start();
            t.stop();
            

            //Car c = new Car(2022, "marcedes", 70.000, "e400", 2258522, "black");
            //Console.WriteLine(c.Year);
            //Console.WriteLine(c.Type);
            //Console.WriteLine(c.Price);
            //Console.WriteLine(c.Modle);
            //Console.WriteLine(c.pallet_No);
            //Console.WriteLine(c.Color);
          //c.start();
          //  c.stop();
            //test t=new test();
            //Console.WriteLine(t.Year);
            //Console.WriteLine(t.Type);
            //Console.WriteLine(t.Price);
            //Console.WriteLine(t.Modle);
            //Console.WriteLine(t.pallet_No);
            //Console.WriteLine(t.Color);
            //    person p=new person();
            //    p.name = "rahma";
            //    p.Age = 23;
            //p.age2= 23;
            //Console.WriteLine(p.age2);
            //  p.Id= 1;
            //p.age = 90;
            //Console.WriteLine(p.name);
            //Console.WriteLine(p.Age);
            // Console.WriteLine(p.Id);


        }
    }
}
