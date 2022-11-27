using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace nov23
{
    internal class Program
    {
        //static void oddNumber()
        //{
        //    Console.WriteLine("enter the number:");
        //    for (int i = 0; i <3; i++)
        //    {
        //        int number = Convert.ToInt32(Console.ReadLine());
        //        if(number %2== 0)
        //        {
        //            Console.WriteLine("the number is even");
        //        }
        //        else
        //        {
        //            Console.WriteLine("the number is odd");
        //        }

                
        //    }

        //}

       
        //static void positive_number()
        //{
        //    Console.WriteLine("--------------------------------------------------");
        //    Console.WriteLine("enter the num: ");
        //    for (int i = 0; i < 3; i++)
        //    {
        //        int num = Convert.ToInt32(Console.ReadLine());
        //        if (num > 0)
        //        {
        //            Console.WriteLine("number is positive");
        //        }
        //        else
        //        {
        //            Console.WriteLine("number is negative");
        //        }
        //    }

        //}
        //static void numberOfIndex()
        //{
        //    string[] name = { "rahma", "aya", "batool" };
        //    for (int i = 0; i < name.Length; i++)
        //    {
        //        if (name[i] == "rahma")
        //        {
        //            Console.WriteLine("the index of rahma is : "+ i);
        //        }
        //        else if (name[i] == "aya")
        //        {
        //            Console.WriteLine("the index of aya is : " + i);
        //        }
        //        else 
        //        {
        //            Console.WriteLine("the index of batool is : " + i);
        //        }

        //    }

        //}
        
        static void sumAndAvg(double[] arr)
        {
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            double avg = sum / arr.Length;
            Console.WriteLine("sum = "+ sum);
            Console.WriteLine("avg = "+avg);
        }

        static void cube(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                 Console.WriteLine("Number is : "+array[i]+ " and cube of the "+array[i] +" is : " + array[i] * array[i] * array[i]);
                //Console.WriteLine("Number is : " + array[i] + " and cube of the " + array[i] + " is : " + Math.Pow(array[i],3));
            }

        }

        static void getYears(int[] year)
        {
            for (int i = 0; i < year.Length; i++)
            {
                if (year[i] > 1950)
                {
                    Console.WriteLine(year[i]);
                }
            }

        }
        static int day(int D)
        {
            int days = D * 365;
            return days;
        }

        static void countLegs(string[] ani)
        {
            int sum1 = 0;
            int sum2 = 0;
            int sum3 = 0;
            for (int i = 0; i < ani.Length; i++)
            {
                if (ani[i]== "chickens")
                {
                    sum1 += 4;

                }
                else if(ani[i] == "cows")
                {
                    sum2 += 12;
                }
                else if (ani[i] == "pigs")
                {
                    sum3 +=20;
                }
             

            }
            int sumall = sum1 + sum2 + sum3;
           
            Console.WriteLine(sumall);


        }
        static void login(string[,] log)
        {
            for (int i = 0; i < log.Length; i++)
            {
                if (log[i,i] == "rahma" && log[i,i] == "ra13")
                {
                    Console.WriteLine("pass"); 
                }
                else
                {
                    Console.WriteLine("fail");
                   
                }

            }
        }
       static int powNumber(int n)
        {
            return n * n;
        }
        static void leapYear()
        {
            for (int i = 1900; i <=2024 ; i+=4)
            {
                Console.WriteLine(i);
            }
        }

        //static void primeNumbers()
        //{

        //    for (int i = 1; i <=10; i++)
        //    {
        //        if(i%2 != 0)
        //        {
        //            Console.WriteLine(i);
        //        }
        //    }


        //}


        static bool check_prime(int n)
        {
            bool is_prime = true;

            // 0 and 1 are not prime numbers
            if (n == 0 || n == 1)
            {
                is_prime = false;
            }

            for (int i = 2; i <= n / 2; ++i)
            {
                if (n % i == 0)
                {
                    is_prime = false;
                    break;
                }
            }

            return is_prime;
        }

        static void sentence(string s)
        {
            string[] info2 = s.Split(' ');
            Console.WriteLine(info2.Length);
        }
        static void Main(string[] args)
        {
            //oddNumber();
            //positive_number();
            //numberOfIndex();
            Console.WriteLine("task 1");
            double[] number = { 10, 50, 60, 80, 40, 70, 50, 90, 50, 88 };
            sumAndAvg(number);
            Console.WriteLine("task 2");
            int[] cube_number = { 1, 2, 3, 4, 5 };
            cube(cube_number);

            Console.WriteLine("Task 3");
            int[] years = { 1763, 1972, 1925, 1916, 1984, 1124, 1950, 2020 };
            getYears(years);

            Console.WriteLine("task 4");
            Console.WriteLine(day(5));

            Console.WriteLine("task 5");
            string[] animals = { "chickens", "cows", "pigs" };
            countLegs(animals);

            //Console.WriteLine("task 6");
            //string[,] array2D = new string[3,2] { { "rahma", " ra123" }, {"haya","12345" }, { "rama", "12355" } };
            ////string[] log = { "rahma", " ra123" };
            //login(array2D);


            Console.WriteLine("task 7");
            Console.WriteLine(powNumber(10));

            Console.WriteLine("task 8");
            leapYear();

            Console.WriteLine("task 9");

            Console.WriteLine("please enter prime number");
            int y1 = Convert.ToInt32(Console.ReadLine());
            if (check_prime(y1))
                Console.WriteLine(y1 + " is a prime number.");
            else
                Console.WriteLine(y1 + " is not a prime number.");

            Console.WriteLine("task 10");

            string informatiom = "rahma aktham obeidat";
            sentence(informatiom);


        }
    }
}
