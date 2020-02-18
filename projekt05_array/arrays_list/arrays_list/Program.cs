using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays_list
{
    class Program
    {
        static void Main(string[] args)
        {
            /*zadanie 1*/
            //string name = "";
            //bool ifEnd = false;
            //var names = new List<string>();
            //do
            //{
            //    Console.WriteLine("Friend's name: ");
            //    name = Console.ReadLine();
            //    names.Add(name);
            //    if (name == "")
            //        ifEnd = true;
            //    else if (names.Count == 0);
            //    else if (names.Count == 1)
            //    {
            //        Console.WriteLine("{0} likes your post.", names.First());
            //    }
            //    else if(names.Count == 2)
            //    {
            //        Console.WriteLine("{0} and {1} like your post.", names.First(), names.ElementAt(1));
            //    }
            //    else if(names.Count > 2)
            //    {
            //        Console.WriteLine("{0}, {1} and {2} others like your post.", names.First(), names.ElementAt(1), (names.Count-2));
            //    }

            //} while (!ifEnd);

            /*zadanie 2*/
            //Console.WriteLine("What is your name?");
            //string name;
            //name = Console.ReadLine();
            //var array = new char[name.Length];
            //for(int i=0; i<name.Length; i++)
            //{
            //    array[i] = name[i];
            //}
            //Array.Reverse(array);
            //Console.WriteLine("Your reverse name:");
            //for (int i = 0; i < name.Length; i++)
            //{
            //    Console.Write(array[i]);
            //}
            //Console.WriteLine();

            /*zadanie 3*/
            //var numbers = new int[5];
            //int howMany = 5;
            //int userNum;

            //while (howMany > 0)
            //{
            //    bool ifRepeat = false;
            //    Console.WriteLine("Your number:");

            //    userNum = Convert.ToInt32(Console.ReadLine());

            //    if (numbers.Length == 0)
            //    {
            //        numbers[0] = userNum;
            //    }
            //    else
            //    {
            //        foreach (var num in numbers)
            //        {
            //            if (userNum == num)
            //                ifRepeat = true;
            //        }

            //        if (!ifRepeat)
            //        {
            //            numbers[5 - howMany] = userNum;
            //            howMany--;
            //        }
            //    }
            //}

            //Console.WriteLine("Sorted numbers:");
            //Array.Sort(numbers);
            //foreach (var num in numbers)
            //{
            //    Console.WriteLine(num);
            //}

            /*zadanie 4*/
            //var numbers = new List<int>();

            //while (true)
            //{
            //    Console.Write("Enter a number (or 'Quit' to exit): ");
            //    var input = Console.ReadLine();

            //    if (input.ToLower() == "quit")
            //        break;

            //    numbers.Add(Convert.ToInt32(input));
            //}

            //var uniques = new List<int>();
            //foreach (var number in numbers)
            //{
            //    if (!uniques.Contains(number))
            //        uniques.Add(number);
            //}

            //Console.WriteLine("Unique numbers:");
            //foreach (var number in uniques)
            //    Console.WriteLine(number);

            /*zadanie 5*/
            //bool ifInvalid = false;
            //while(!ifInvalid)
            //{
            //    Console.WriteLine("Your number: ");
            //    string input = Console.ReadLine();
            //    var numbers = input.Split(',');
            //    var output = new int[numbers.Count()];

            //    for(int i=0; i<numbers.Count(); i++)
            //    {
            //        output[i] = Convert.ToInt32(numbers[i]);
            //    }

            //    if (output.Count() >= 5)
            //    {
            //        Array.Sort(output);

            //        for (int i = 0; i < 3; i++)
            //        {
            //            Console.Write("{0} ", output[i]);
            //        }
            //    }
            //    else
            //        ifInvalid = true;

            //}
        }
    }
}
