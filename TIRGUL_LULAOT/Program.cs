using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIRGUL_LULAOT
{
    class Program
    {
        static void Main(string[] args)
        {
            //ex 3
            //for (int i = 0; i < 20; i++)
            //{
            //    int num1, num2;// מספרים שלם
            //    Console.WriteLine("enter 2 numbers");
            //    num1 = int.Parse(Console.ReadLine());
            //    num2 = int.Parse(Console.ReadLine());
            //    if (num1 > 0 && num2 > 0 && num1 % 2 != 0 && num2 % 2 != 0)
            //    {
            //        Console.WriteLine(num1 + num2);

            //    }
            //            enter 2 numbers
            //22
            //54
            //enter 2 numbers
            //23
            //53
            //76



            //ex4
            //int num1, num2;
            //Console.WriteLine("enter how many tasks");
            //num1 = int.Parse(Console.ReadLine());

            //for (int i = 0; i < 30; i++)
            //{
            //    Console.WriteLine("enter how many tasks you did");
            //    num2 = int.Parse(Console.ReadLine());
            //    if (num2 == num1)
            //    {
            //        Console.WriteLine("you did all the work");
            //    }
            //    if (num1 > num2 && num2 > 0)
            //    {
            //        Console.WriteLine("you did some of the work");
            //    }
            //    if (num2 == 0)
            //    {
            //        Console.WriteLine("you didnt do any work");
            //    }


            //}
            //enter how many tasks
            //6
            //enter how many tasks you did
            //6
            //you did all the work
            //enter how many tasks you did

            //ex5
            //int c1 = 0, c2 = 0, c3 = 0;//counter 
            //char num1, num2, num3;//אוהב או לא אוהב
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("do u love thriller movies");
            //    num1 = char.Parse(Console.ReadLine());
            //    Console.WriteLine("do u love comedy movies");
            //    num2 = char.Parse(Console.ReadLine());
            //    Console.WriteLine("do u love drama movies");
            //    num3 = char.Parse(Console.ReadLine());
            //    if (num1 == 'Y')
            //        c1++;
            //    if (num2 == 'Y')
            //        c2++;
            //    if (num3 == 'Y')
            //        c3++;
            //}
            //Console.WriteLine(c1);
            //Console.WriteLine(c2);
            //Console.WriteLine(c3);






            //ex6 


            //int N = int.Parse(Console.ReadLine());//מספר תלמידים
            //int errF = 0;// מספר תלמידים שנכשלו 
            //for (int i = 0; i < N; i++)
            //{

            //    int tamrur, err;//מספר נכשלים בתמרורים ומספר נכשל כללי
            //    Console.WriteLine("how many failes in tamrur ? ");
            //    tamrur = int.Parse(Console.ReadLine());
            //    Console.WriteLine("how many failes in err ? ");
            //    err = int.Parse(Console.ReadLine());
            //    if (tamrur > 0 || err > 3)
            //        errF++;
            //}
            //Console.WriteLine("{0} F ",errF);
            //Console.WriteLine("{0} F precent ",errF/N);




            //ex7
            //int max = int.MinValue;
            //int min = int.MaxValue;
            //int num;
            //for (int i = 0; i < 10; i++)

            //{
            //    num = int.Parse(Console.ReadLine());
            //    max = Math.Max(max, num);
            //    min = Math.Min(min, num);
            //}
            //Console.WriteLine("max is {0} min is {0}",max,min);



            //ex8
            //int age;//גילאים
            //int counter = 0;//counter
            //for (int i = 0; i < 30; i++)
            //{
            //    Console.WriteLine("enter ages"  ); 
            //    age = int.Parse(Console.ReadLine());
            //    if (age <=40 && age >= 22)
            //    {
            //        counter ++;
            //    }
            //    Console.WriteLine(counter);
            //}
            //enter ages
            //13
            //0
            //enter ages
            //43
            //0
            //enter ages
            //24
            //1
            //enter ages
            //26
            //2



            //ex9
            //int num1;//מספר טיולים בו השתתף
            //int num2;//מספר מסיבות בו השתתף
            //int num3;//מספר סרטי טלוויזיה בהם צפה
            //int c1 = 0, c2 = 0, c3 = 0, c4 = 0;//counter
            //for (int i = 0; i < 100; i++)
            //{
            //    Console.WriteLine("number of trips");
            //    num1 = int.Parse(Console.ReadLine());
            //    Console.WriteLine("number of parties");
            //    num2 = int.Parse(Console.ReadLine());
            //    Console.WriteLine("number of movies");
            //    num3 = int.Parse(Console.ReadLine());
            //    if (num1 > 0 && num2 > 0 && num3 > 0)
            //    {
            //        c1++;
            //    }
            //    if (num1 > 0 && num2 > 0 && num3 == 0)
            //    {
            //        c2++;
            //    }
            //    if (num2 > 0 && num3 > 0 && num1 == 0)
            //    {
            //        c2++;
            //    }
            //    if (num1 > 0 && num3 > 0 && num2 == 0)
            //    {
            //        c2++;
            //    }
            //    if (num3 > 3 || num2 > 3 || num1 > 3)
            //        c3++;
            //    if (num1 > num2)
            //        c4++;
            //}
            //Console.WriteLine("number of students participates all the sugei biluy {0}", c1);
            //Console.WriteLine("number of students participates two sugei biluy {0}", c2);
            //Console.WriteLine("number of students participates one of the sugei biluy more than three time {0}", c3);
            //Console.WriteLine("number of students that participates more trips than parties {0}", c4);




            //ex10
            //int num1,num2,num3 ;//מופע 1 מופע 2 מופע 3
            //int c1=0, c2=0;
            //for (int i = 0; i < 2000; i++)
            //{
            //    Console.WriteLine("buy the first show");
            //    num1 = int.Parse(Console.ReadLine());
            //    Console.WriteLine("buy the second show");
            //    num2 = int.Parse(Console.ReadLine());
            //    Console.WriteLine("buy the third show");
            //    num3 = int.Parse(Console.ReadLine());
            //    if (num1 > 0 && num2 > 0 && num3 > 0) 
            //    {
            //        c1++;
            //    }
            //    if (num1 > 0)
            //    {
            //        c2++;
            //    }
            //    else if (num2 > 0) 
            //    {
            //        c2++;
            //            }
            //    else if(num3>0) 
            //        {
            //        c2++;
            //    }
            //    Console.WriteLine("number of students buy all the tickets {0}", c1);
            //    Console.WriteLine("number of students buy only one ticket {0}", c2);


            }
 
       }
        }

    }

    


