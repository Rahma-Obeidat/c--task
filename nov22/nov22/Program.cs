using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nov22
{ 
    internal class Program
    {
        static void Main(string[] args)
        {

            //int x = 0;
            //while (x < 5)
            //{
            //    Console.WriteLine(x);
            //    x++;
            //}

            //int y = 0;
            //while (y < 5)
            //{
            //    Console.WriteLine("enter number: ");
            //    int number=Convert.ToInt32(Console.ReadLine());
            //    if(number %2 == 0)
            //    {
            //        Console.WriteLine("even");
            //    }
            //    else
            //    {
            //        Console.WriteLine("odd");
            //    }
            //    y++;
            //}



            //int b = 0;
            //do
            //{
            //    Console.WriteLine(b);
            //    b++;
            //}while(b < 5);


            //int c= 0;
            //do
            //{
            //    Console.WriteLine("rahma");
            //    c++;
            //}while(c > 10);



            //int e= 0;
            //do
            //{
            //    Console.WriteLine("enter the number ");
            //    int num=Convert.ToInt32(Console.ReadLine());
            //    if (num > 0) {
            //        Console.WriteLine("positive");
            //            }
            //    else
            //    {
            //        Console.WriteLine("negative");
            //    }
            //    e++;        

            //}while(e <3);

            //int row = 5;
            //for(int i=1; i<row; i++)
            //{
            //    for (int p = 0; p < row-i; p++)

            //        Console.WriteLine(" ");

            //    for(int l=0 ; l<i*2-1 ; l++)

            //        Console.WriteLine("*");


            //}
            //Console.WriteLine();
            //            string[] ARR = [1, 7  9  45, ]
            //int arr2 =["Str" "alex", "moh"
            //string arr3 = 'the', 'fox' 'over' lazy, 'dog',  ]

            Console.WriteLine("task 1");
            int[] ARR = { 1, 7, 9, 45 };
            string[] arr2 = { "Str", "alex", "moh" };
            string[] arr3 = { "the", "fox", "over", "lazy", "dog" };

            Console.WriteLine("task 2");
            String[] fruits ={"Tomato", "Banana", "Watermelon"};
            for (int i = 0; i <fruits.Length; i++)
            {
                if (fruits[i]== "Tomato")
                {
                    Console.WriteLine(i);
                }
                else if (fruits[i]== "Banana")
                {
                    Console.WriteLine(i);
                }

            }

            Console.WriteLine("task3 ");
            string[] food = { "mansaf", "salat", "pizza", "pasta", "mlokhya" };
            string[] Sport = { "football", "tenise", "basketball" };
            string[] Movie = { "game of thrones", "konan", "othman", "salajeqa" };

            foreach (string foods in food)
            {
                Console.WriteLine(foods);
            }
            Console.WriteLine("-----------------------------------------");
            foreach(string sports in Sport)
            {
                Console.WriteLine(sports);
            }
            Console.WriteLine("-----------------------------------------");
            foreach (string mov in Movie) {
                Console.WriteLine(mov);
            }

            Console.WriteLine("for loop ********************************");
            for (int i = 0; i <food.Length; i++)
            {
                Console.WriteLine(food[i]);
            }
            Console.WriteLine("***************************************");

            for (int i = 0; i < Sport.Length; i++)
            {
                Console.WriteLine(Sport[i]);
            }
            Console.WriteLine("****************************************");
            for (int i = 0; i < Movie.Length; i++)
            {
                Console.WriteLine(Movie[i]);
            }
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("task 4");
            string numbers=Console.ReadLine();
            string[] authorsList = numbers.Split(',');
            int sum1 = 0;
            for (int i = 0; i <authorsList.Length; i++)
            {
                sum1+=Convert.ToInt32(authorsList[i]);  
            }
            Console.WriteLine(sum1);

            //Console.WriteLine();
            Console.WriteLine("task 5:");
            int sum = 0;
            for (int z = 1; z <=100; z++)
            {
                if(z %2 !=0) {

                    sum += z;
                }
               
            }
            Console.WriteLine(sum);

            Console.WriteLine("task 6");
            int row = 4;
            for(int b=1; b<=row; b++)
            {
                for(int s=0; s < b; s++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine( "task 7:");


            int k = 1;
            int rows = 4;
            for(int a=1; a<=rows;a++)
            {
                for(int c = 0; c < a; c++)
                {
                    Console.Write(k);
                    k++;
                }

                Console.WriteLine();
            }
        }





    }
}
