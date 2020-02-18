using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_stringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            //var builder = new StringBuilder("Hello Paweł");
            //builder
            //    .AppendLine()
            //    .Append('-', 10)
            //    .AppendLine()
            //    .Append("Siemanko");
            //Console.WriteLine(builder);

            /*exercise 1*/
            //Console.WriteLine("Your numbers:");
            //string input = Console.ReadLine();
            //var numbers = input.Split('-');
            //var output = new int[numbers.Count()];

            //for (int i = 0; i < numbers.Count(); i++)
            //{
            //    output[i] = Convert.ToInt32(numbers[i]);
            //}

            //Array.Sort(output);

            //bool ifConsecutive = true;

            //for (int i = 1; i < output.Count(); i++)
            //{
            //    if (output[i-1] != (output[i]-1))
            //    {
            //        ifConsecutive = false;
            //        break;
            //    }
            //}

            //if(ifConsecutive)
            //    Console.WriteLine("Consecutive");
            //else
            //    Console.WriteLine("Not Consecutive");

            /*exercise 2*/
            //while (true)
            //{
            //    Console.WriteLine("Your numbers:");
            //    var input = Console.ReadLine();

            //    if (String.IsNullOrWhiteSpace(input))
            //        break;

            //    var numbers = input.Split('-');
            //    var output = numbers.Distinct();
            //    if (numbers.Length != output.Count())
            //        Console.WriteLine("Duplicate");
            //    else
            //        Console.WriteLine("No duplicate");
            //}

            /*exercise 3*/
            //while (true)
            //{
            //    Console.WriteLine("Your time:");
            //    var userTime = Console.ReadLine();

            //    if (String.IsNullOrWhiteSpace(userTime))
            //        break;

            //    if(userTime.Length != 5)
            //        Console.WriteLine("Invalid Time");
            //    if(userTime[2] != ':')
            //        Console.WriteLine("Invalid Time");
            //    else
            //    {
            //        var timeParts = userTime.Split(':');
            //        var hours = Convert.ToInt32(timeParts[0]);
            //        var minutes = Convert.ToInt32(timeParts[1]);

            //        if (hours >= 0 && hours<=23)
            //            if(minutes>=0 && minutes<=59)
            //                Console.WriteLine("Ok");
            //        else
            //            Console.WriteLine("Invalid Time");
            //    }
            //}

            /*exercise 4*/
            //while(true)
            //{
            //    Console.WriteLine("Your text:");
            //    var input = Console.ReadLine();
            //    if (String.IsNullOrWhiteSpace(input))
            //        break;

            //    var text = input.ToLower().Split(' ');
            //    for(int i=0; i<text.Length; i++)
            //    {
            //        char firstChar = text[i][0];
            //        firstChar = Convert.ToChar(Convert.ToInt32(firstChar) - 32);
            //        text[i]=text[i].Remove(0,1);
            //        text[i] = firstChar + text[i];
            //    }

            //    input = String.Join("", text);
            //    Console.WriteLine(input);
            //}

            /*exercise 5*/
            while (true)
            {
                Console.WriteLine("Your word:");
                var word = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(word))
                    break;

                word = word.ToLower();
                var vowels = "aeoui";
                var numberOfVowels = 0;
                for (int i = 0; i < word.Length; i++)
                {
                    for (int j = 0; j < vowels.Length; j++)
                    {
                        if (word[i] == vowels[j])
                            numberOfVowels++;
                    }

                }
                Console.WriteLine("Numbers of vowels: " + numberOfVowels);
            }

        }
    }
}
