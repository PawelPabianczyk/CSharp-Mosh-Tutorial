using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random1
{
    class Program
    {
        static void Main(string[] args)
        {
            //const int passwdlength = 10;
            //var random = new Random();
            //var bufor = new char[passwdlength];

            //for (int i = 0; i < passwdlength; i++)
            //{
            //    bufor[i] = (char)('a' + random.Next(0, 26));
            //}

            //var wyraz = new string(bufor);

            //Console.WriteLine(wyraz);
            //Console.WriteLine();

            //var random = new Random();

            //for(int i=0; i<10; i++)
            //{
            //    Console.Write(random.Next(1,20)+"\t");
            //}


            /*zadanie1*/
            //int podzielne = 0;
            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 3 == 0)
            //        podzielne++;
            //}
            //Console.WriteLine(podzielne);


            /*zadanie 2*/
            //bool ifOK = false;
            //string number;
            //int sum = 0;
            //do
            //{
            //    Console.WriteLine("Number or OK: ");
            //    number = Console.ReadLine();
            //    number = number.ToLower();
            //    if (number == "ok")
            //        ifOK = true;
            //    else
            //        sum += Convert.ToInt32(number);
            //    Console.WriteLine("Sum: {0}", sum);
            //}
            //while (!ifOK);

            /*zadanie 3*/
            //Console.WriteLine("Number: ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //int factorial = 1;
            //while(number>=1)
            //{
            //    factorial *= number;
            //    number--;
            //}
            //Console.WriteLine("Factorial: {0}", factorial);

            /*zadanie 4*/
            //var random = new Random();

            //int luckyNumber = random.Next(1, 10);

            //bool badAnswer = true;
            //int chances = 4;

            //while(badAnswer && chances>0)
            //{
            //    Console.WriteLine("Your chances: {0} \nYour answer:", chances);
            //    Console.WriteLine(luckyNumber);
            //    int answer = Convert.ToInt32(Console.ReadLine());
            //    if (answer == luckyNumber)
            //        badAnswer = false;
            //    chances--;
            //}
            //if(chances!= 0)
            //    Console.WriteLine("You won!");
            //else
            //    Console.WriteLine("You lost!");

            /*zadanie 5*/
            //string numbers;
            //Console.WriteLine("Your numbers: ");
            //numbers = Console.ReadLine();
            //string[] nums = new string[numbers.Length];
            //nums = numbers.Split(',');
            //int[] numsINT = new int[nums.Length];
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    numsINT[i] = Convert.ToInt32(nums[i]);
            //}

            //Console.WriteLine("Max: {0}", numsINT.Max());

        }
    }
}
