using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nov21
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int x_int = 10;
            //double x_double =x_int;
            //Console.WriteLine(x_double);



            //double y_double = 20.5;
            //int y_int= (int)y_double;
            //Console.WriteLine(y_int);



            //Console.WriteLine("***********************************");
            //int myInt = 10;
            //double myDouble = 5.25;
            //bool myBool = true;
            //string rahma = "r";

            //Console.WriteLine(Convert.ToString(myInt));    // convert int to string
            //Console.WriteLine(Convert.ToDouble(myInt));    // convert int to double
            //Console.WriteLine(Convert.ToInt32(myDouble));  // convert double to int
            //Console.WriteLine(Convert.ToString(myBool));   // convert bool to string
            //Console.WriteLine(Convert.ToInt32(myBool));
            //Console.WriteLine(Convert.ToChar(rahma));



            //Console.WriteLine("**********************************");

            //Console.WriteLine("Enter your age:");
            //int age=Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Your age : "+age);


            //Console.WriteLine("***************");
            //Console.WriteLine("enter your grade");
            //double grade=Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("your grade : "+grade);

            //string num = "20";
            //int num2 = Convert.ToInt32(num);
            //long num3 = Convert.ToInt64(num);


            //string name = "Rahma Obeidat";
            //Console.WriteLine(name.ToUpper());
            //Console.WriteLine(name[4]);
            //Console.WriteLine(name.IndexOf('h'));
            //Console.WriteLine(name.ToLower());

            //for (int i = 0; i <name.Length; i++)
            //{
            //    Console.WriteLine(name[i]);
            //}


            //for (int i = 0; i < 10; i++)

            //{
            //    //Console.WriteLine("enter the number:");
            //    //int number = Convert.ToInt32(Console.ReadLine());
            //    //Console.WriteLine(number + " ");
            //    Console.Write(i+" ");
            //}
            //Console.WriteLine();
            //int sum = 0;
            //for (int i = 1; i <=10; i++)
            //{

            //    sum += i;

            //}
            //Console.WriteLine(sum);
            //Q1
            Console.WriteLine("Task1");
            Console.WriteLine("enter num1: ");
            int num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter num2 : ");
            int num2=Convert.ToInt32(Console.ReadLine());
            if(num1 < num2) {
                Console.WriteLine("the smaller : " +num1);
            }
            else
            {
                Console.WriteLine("the smaller : " +num2);
            }

            //Q2

            Console.WriteLine("Task2 :");
            Console.WriteLine("enter the number : ");
            string number=Console.ReadLine();
            if (number[0] == '-')
            {
                Console.WriteLine("the sign is -");
            }
            else if (number[0] == '+')
            {
                Console.WriteLine("the sign is +");
            }
            else if (number[0] == '/')
            {

                Console.WriteLine("the sign is /");
            }
            else if (number[0] == '*')
            {

                Console.WriteLine("the sign is *");
            }
            else if (number[0] == '%')
            {

                Console.WriteLine("the sign is %");
            }
            //Q3
            Console.WriteLine("Task 3");
            Console.WriteLine("enter number 1 :");
            int n1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number 2 :");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number 3 :");
            int n3 = Convert.ToInt32(Console.ReadLine());


            if(n1 > n2 && n1> n3 && n2<n3)
            {
                Console.WriteLine(n1 + " "+ n3 +" "+ n2);
            }
            else if(n2>n1 && n2>n3 && n1>n3)
            {
                Console.WriteLine(n2 + " " + n1 + " " + n3);
            }

            else if (n3>n1 && n3> n2 && n1 > n2)
            {
                Console.WriteLine(n3 + " " + n1 + " " + n2);
            }
            else if (n3 > n1 && n3 > n2 && n1 < n2)
            {
                Console.WriteLine(n3 + " " + n2 + " " + n1);
            }
            else if(n1 > n2 && n1 > n3 && n2 > n3)
            {

                Console.WriteLine(n1 + " " + n2 + " " + n3);
            }

            //Q4:
            Console.WriteLine("Task 4");

            Console.WriteLine("enter num one :");
            int one = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter num tow :");
            int tow = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter num three :");
            int three = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter num four :");
            int four = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter num five :");
            int five = Convert.ToInt32(Console.ReadLine());

            if(one< tow && one < three && one<four && one<five)
            {
                Console.WriteLine(one);

            }
            else if (tow < one && tow < three && tow < four && tow < five)
            {
                Console.WriteLine(tow);

            }
            else if (three < one && three < tow && three < four && three < five)
            {
                Console.WriteLine(three);

            }
            else if (four < one && four < three && four < tow && four < five)
            {
                Console.WriteLine(four);

            }
            else if (five < one && five < three && five < four && five < tow)
            {
                Console.WriteLine(five);

            }
            //Q5
            Console.WriteLine("Task 5 :");
            Console.WriteLine("enter kilometers per hour: ");
            int Kilo= Convert.ToInt32(Console.ReadLine());
            double meils = Kilo * 0.621371;
            Console.WriteLine(meils+" "+ "miles per hour");
            //Q6
            Console.WriteLine("Task 6 :");
            Console.WriteLine("enter hours : ");
            int hours= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter minutes : ");
            int minutes = Convert.ToInt32(Console.ReadLine());

            int total = (hours * 60) + minutes;
            Console.WriteLine("Total: "+total + " minutes");


            //Q7:
            Console.WriteLine("Task 7");
            Console.WriteLine("enter minutes : ");
            int min= Convert.ToInt32(Console.ReadLine());
            int hour = min / 60;
            int mint = min % 60;
            Console.WriteLine(hour+ " "+ "Hours,"+mint + " Minutes");


            //Q8:
            Console.WriteLine("Task 8:");
            string[] names = { "rahma", "batool", "mayyas", "ahmad", "aya" };
            Console.WriteLine(names[0].Substring(0,3));
            Console.WriteLine(names[1].Substring(0, 3));
            Console.WriteLine(names[2].Substring(0, 3));
            Console.WriteLine(names[3].Substring(0, 3));
            Console.WriteLine(names[4].Substring(0, 3));

        }
    }
}
