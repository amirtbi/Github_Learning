using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace review_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Program Mypj = new Program();//Creating a sample from my Program
            int summation = Mypj.sum(4, 5);//Defining input for Function
            Console.WriteLine("The summation of 4 and 5 is :{0}",summation);
            //...........

            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your lastname :");
            string lastname = Console.ReadLine();
            Console.WriteLine("Enter your age :");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your nationality:");
            string nation = Console.ReadLine();
            string info = Mypj.info(name, lastname, age, nation);//Using Function
            Console.WriteLine("........");
            Console.WriteLine(info);
            ///...............
            string[] sports = { "football", "volleyball", "basketball", "swimming" };
            int[] ages = new int[4];
            ages[0] = 23;
            ages[1] = 25;
            ages[2] = 56;

            object[] data = { "math", "football", "23", 55 };
            foreach (object item in data)
            {
                Console.WriteLine(item);
            }

            
            



            //for (int i = 0; i < sports.Length; i++)
            //{
            //    Console.WriteLine("The {0}th sport is {1}",i+1,sports[i]);


            //}

            foreach (string item in sports )
            {
                Console.WriteLine("The  sport is {0}",item);

            }


            Console.WriteLine(Mypj.test(ages,2));



            Console.ReadKey();

        }
        //..............................................................................
        //Functions:


        int sum(int a, int b)
        {
            return a + b;
        }
        double Div(double a, double b)
        {
            return a / b;
        }

        string info(string name, string lname, int age, string nationality)
        {
            return "The fullname is :" + name + " " + lname + " " + "and the age is :" + age + " from " + nationality;
        }

        int test(int[] array, int index)
        {
            
                for (int i = 0; i < array.Length; i++)
                {

                    array[i] = array[i] * 2;
                                     
                

                }

                return array[index]; //Returning the specific element of array.
                
            
            

        }


    }
}
