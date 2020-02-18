using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Persist
{
    public static int Persistence(long n)
    {
        if (n < 10)
            return 0;
        else
        {
            string wyraz = Convert.ToString(n);
            bool czyPojedynczna = false;
            int powtarzalnosc = 1;

            do
            {
                int liczba = 1;

                foreach (char item in wyraz)
                {
                    liczba *= (int)char.GetNumericValue(item);
                }

                if (liczba < 10)
                    czyPojedynczna = true;
                else
                {
                    powtarzalnosc++;
                    wyraz = Convert.ToString(liczba);
                }
                    
                
            }
            while (!czyPojedynczna);

            return powtarzalnosc;
        }
     
    }
}

public static class Kata
{
    /*
     public static int find_it(int[] seq) 
      {
        return seq.GroupBy(x => x).Single(g => g.Count() % 2 == 1).Key;
      }
     */
    /*
    public static int find_it(int[] seq)
    {
        Array.Sort(seq);
        int prev = seq[0];
        int counter = 1;

        for(int i=1; i< seq.Length; i++)
        {
            if (prev == seq[i])
                counter++;
            else if (counter % 2 != 0)
                return prev;
            else
            {
                prev = seq[i];
                counter = 1;
            }
        }
        return prev;
    }
    */

    /*
      public static int DescendingOrder(int num)
      {
        return int.Parse(string.Concat(num.ToString().OrderByDescending(x => x)));
      }
    */
    /*
    public static int DescendingOrder(int num)
    {
        string napis = Convert.ToString(num);
        int[] tablica = new int[napis.Length];
        for (int i = 0; i < napis.Length; i++)
            tablica[i] = (int)char.GetNumericValue(napis[i]);

        Array.Sort(tablica);

        int zwracana = 0;
        for (int i = tablica.Length - 1; i > 0; --i)
            zwracana += ((int)Math.Pow(10, i))* tablica[i];

        zwracana += tablica[0];

        return zwracana;
    }
    */
    /*
    public static int FindShort(string s)
    {
        var words = s.Split(' ').ToArray();

        string min = "";

        foreach (var item in words)
        {
            if (min == "" || min.Length > item.Length)
                min = item;
        }

        return min.Length;
    }
    */
    /*
    public static string HighAndLow(string numbers)
    {
        var nums = numbers.Split(' ').Select(Int32.Parse).ToArray();
        return $"{nums.Max()} {nums.Min()}";
    }
    */
    /*
    public static string HighAndLow(string numbers)
    {
        int? min = null;
        int? max = null;
        string liczba =  "";
        int liczbaK;
        foreach(char item in numbers)
        {
            if (item != ' ')
                liczba = liczba + item;
            else
            {
                liczbaK = int.Parse(liczba);

                if (min == null || min > liczbaK)
                    min = liczbaK;

                if (max == null || max < liczbaK)
                    max = liczbaK;

                liczba = "";
            }
        }

        liczbaK = int.Parse(liczba);

        if (min == null || min > liczbaK)
            min = liczbaK;

        if (max == null || max < liczbaK)
            max = liczbaK;

        return string.Join(" ", max, min);
    }
    */
}

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Kata.HighAndLow("1 2 3 4 5"));
            //Console.WriteLine(Kata.HighAndLow("1 9 -3 4 5"));

            //Console.WriteLine(Kata.FindShort("bitcoin take over thea world maybe whoa knows perhaps"));

            //Console.WriteLine(Kata.DescendingOrder(841267));

            //Console.WriteLine(Kata.find_it(new[] { 20, 1, -1, 2, -2, -2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5 }));
            //Console.WriteLine(Kata.find_it(new[] { 1}));

            Console.WriteLine(Persist.Persistence(999));

            Console.ReadKey();

        }
    }
}
