using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace nov29
{
    internal class Program
    {
        class DivNumbers 
        {
            int result;

          public DivNumbers()
            {
                result = 0;
            }
            public void division(int num1, int num2)
            {
                try
                {
                    result = num1 / num2;
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine("Exception caught: {0}", e);
                }
                finally
                {
                    Console.WriteLine("Result: {0}", result);
                }
            }
        }
       
        class Employee
        {
            string name;
            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            int birthOfDate;
            public int BirthOfDate
            {
                get { return birthOfDate; }
                set { birthOfDate = value; }
            }

            int Eid;
            public int EId
            {
                get { return Eid; }
                set { Eid = value; }
            }
          public Employee(string name , int birthOfDate,int Eid) {
            this.name = name;
                this.birthOfDate = birthOfDate;
                this.Eid = Eid;
            
            }
            public virtual void Age(int year) { }

            public void print()
            {
                Console.WriteLine("your name is : "+name);
                Console.WriteLine("your birth is : "+birthOfDate);
                Console.WriteLine("your id is : " + Eid);

            }
        }
      


        class Manager : Employee
        {
            public Manager(string name, int birthOfDate, int Eid):base(name, birthOfDate, Eid) {
            
            
            
            }

            public override void Age(int year)
            {
                int age = 2022 - year;
                Console.WriteLine("your age is : "+age);
            }


        }
        static void Main(string[] args)
        {

            Console.WriteLine("enter the name: ");
            string name = Console.ReadLine();
            Console.WriteLine("enter id: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter year: ");
            int year = Convert.ToInt32(Console.ReadLine());
            Manager e = new Manager(name, id, year);
            e.print();
            e.Age(year);
            //DivNumbers d = new DivNumbers();
            //d.division(25, 0);
            //Console.ReadKey();

            // try
            // {
            //     Console.WriteLine("Enter a number: ");

            //     var num = int.Parse(Console.ReadLine());

            //     Console.WriteLine(num * num);
            // }
            //catch
            // {

            //     Console.WriteLine("Error info:");
            // }

            // finally { 
            //     Console.Write("Re-try with a different number.");
            // }

        }


    }
}
