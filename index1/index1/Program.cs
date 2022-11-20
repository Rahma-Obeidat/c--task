using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace index1
{
    internal class Program
    {
        static void Main(string[] args)


        {

            //Q1:

            Console.WriteLine("Task1");
            
            Console.WriteLine("Enter username:");

            
            string userName = Console.ReadLine();

    
            Console.WriteLine("Name is: " + userName);

            //Q2:
            Console.WriteLine("Task2");
            double num1 = 10.5;
            string name = "rahma";
            char c = 'R';
            bool b= true;

            int num2 = 20;
            const string lastName = "obeidat";

            Console.WriteLine(num1);
            Console.WriteLine(name);
            Console.WriteLine(c);
            Console.WriteLine(b);
            Console.WriteLine(num2);
            Console.WriteLine(lastName);


            //Q3:
            Console.WriteLine("Task 3");
            string[] cars= { "Volvo", "BMW", "Ford", "Mazda","oudi" };
            Console.WriteLine(cars[0]);
            Console.WriteLine(cars[1]);
            Console.WriteLine(cars[2]);
            Console.WriteLine(cars[3]);
            Console.WriteLine(cars[4]);
            Console.WriteLine(cars.Length);


            //Q4:
            Console.WriteLine("Task 4");
            Console.WriteLine("enter first name:");
            string fName=Console.ReadLine();
            Console.WriteLine("enter last name: ");
            string lName=Console.ReadLine();
            Console.WriteLine("your year of birth:");
          string birth=Console.ReadLine();

            Console.Write(fName +" "+ lName+" "+ birth);
            Console.WriteLine();

            // q5:
            Console.WriteLine("Task5:");

            int[] array = { 1, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine(array[0]);
            Console.WriteLine(array[1]);
            Console.WriteLine(array[2]);

            Console.WriteLine(array[3]);
            Console.WriteLine(array[4]);
            Console.WriteLine(array[5]);
            Console.WriteLine(array[6]);
            Console.WriteLine(array[7]);
            Console.WriteLine(array[8]);
            Console.WriteLine(array[9]);

            //Q6:
            Console.WriteLine("Task 6:");
            int[] arr = { 1, 2, 5, 10 };
            int sum = arr[0] + arr[1] + arr[2] + arr[3];
            Console.WriteLine(sum);




        }
    }
}
