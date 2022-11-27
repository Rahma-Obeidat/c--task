using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nov27
{
    class wellcome
    {


        static void Welcome(string name)
        {
            Console.WriteLine("welcome " + name);
        }
        static void Goodbye(string name)
        {
            Console.WriteLine("Goodbye " + name);
        }


    }
    internal class Math
    {
        static double sum(double a, double b)
        {
            return a + b;
        }
        static double sub(double a, double b)
        {
            return a - b;
        }
        static double mul(double a, double b)
        {
            return a * b;
        }

        static double div(double a, double b)
        {
            return a / b;
        }

    }
        class math2
        {
          public double a
            {
                set; get;
            }
           public double b
            {
                set; get;
            }

            public void setValue(double a1, double b1)
            {
                a = a1;
                b = b1;
            }
            public double sum()
            {
               
 
                return a + b;
            }
            public double div()
            {
                return a / b;
            }
            public double sub()
            {
                return a - b;
            }
            public double mul()
            {
                return a * b;
            }

        }

        class information
        {
            int age;
            string gender;
            string name;
            string email;
            int id;
            string phone;

            public information()
            {
            }

            public information(string name)
            {
                Console.WriteLine("defoult");

            }
          public information(int age, string gender, string name, string email, int id, string phone)
            {
                this.age = age;
                this.gender = gender;
                this.name = name;
                this.email = email;
                this.id = id;
                this.phone = phone;

            if (age < 18 && age > 60)
            {
                string status = "under age";
                Console.WriteLine(status); ;
            }
            else
            {
                string status2 = "your age Ok";
                // return status2;
                Console.WriteLine(status2);
            }
            if (phone[0] == '0' && phone[1] == '7' && phone[2] == '7')
            {
                string orange = "orange number ok";
                //return orange;
                Console.WriteLine(orange);
            }
            if (phone[0] == '0' && phone[1] == '7' && phone[2] == '8')
            {
                string umniya = "umniya number ok";
                //return umniya;
                Console.WriteLine(umniya);
            }
            if (phone[0] == '0' && phone[1] == '7' && phone[2] == '9')
            {
                string zain = "zain number ok";
                Console.WriteLine(zain);
                //return zain;
            }
            else
            {
                string non = "in valid number";
                //return non;
                Console.WriteLine(non);
            }
        }

        public string getAge(int age) { 
            if(age < 18 && age > 60)
                {
                    string status = "under age";
                    return status;
                }
                else
                {
                    string status2 = "Ok";
                    return status2;
                }
            
            }

            public string getPhone(string phone) {

                if (phone[0]=='0' && phone[1]=='7' && phone[2] == '7')
                {
                    string orange = "orange number ok";
                    return orange;
                }
                if (phone[0] == '0' && phone[1] == '7' && phone[2] == '8')
                {
                    string umniya = "umniya number ok";
                    return umniya;
                }
                if (phone[0] == '0' && phone[1] == '7' && phone[2] == '9')
                {
                    string zain = "zain number ok";
                    return zain;
                }
                else
                {
                    string non = "in valid number";
                    return non;
                }

            }
        
        static void Main(string[] args)
        {
            
           
            Console.WriteLine("enter your name : ");
            string name = Console.ReadLine();

            Console.WriteLine("enter your gender : ");
            string gender = Console.ReadLine();

            Console.WriteLine("enter your email : ");
            string email = Console.ReadLine();
            Console.WriteLine("enter your id : ");
            int id =Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("enter your age : ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter your phone : ");
            string phone = Console.ReadLine();

            information info=new information(age, gender, name,email,id,phone);
            Console.WriteLine("your age : "+info.age);
            Console.WriteLine("your gender : " + info.gender);
            Console.WriteLine("your name : " + info.name);
            Console.WriteLine("your eamil : " + info.email);
            Console.WriteLine("your id : " + info.id);
            Console.WriteLine("your phone : " + info.phone);

            //information information1 = new information();
            //Console.WriteLine("enter your age : ");

          
            //Console.WriteLine(information1.getAge(Convert.ToInt32(Console.ReadLine())));

            //Console.WriteLine("enter phone number: ");
            //Console.WriteLine(information1.getPhone(Console.ReadLine()));

           
           

           // information information2 = new information(23, "female","rahma", "rahjkkm",123966,"0771234567") ;
           // Console.WriteLine(information2);


            // math2 s = new math2();
            // s.setValue(10, 20); 

            //Console.WriteLine("sum =" + s.sum());
            // Console.WriteLine("sub =" + s.sub());
            // Console.WriteLine("mul =" + s.mul());
            // Console.WriteLine("div =" + s.div());
            //Console.WriteLine("sum = "+sum());
            //Console.WriteLine("sub= "+sub(10,2));
            //Console.WriteLine("mul = "+mul(10,2));
            //Console.WriteLine("div = "+div(50,2));
            //Welcome("rahma");
            // Goodbye("rahma");


        }
    }
   
}
