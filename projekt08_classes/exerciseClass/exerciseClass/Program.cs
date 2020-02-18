using System;

namespace exerciseClass
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Exercise 1*/
            //Stopwatch stoper = new Stopwatch();

            //stoper.Start();
            //for (int i = 0; i < 1000; i++)
            //{
            //    Console.WriteLine();
            //}
            //stoper.Stop();
            //Console.WriteLine("Duration:" + stoper.Duration);

            //stoper.Start();
            //for (int i = 0; i < 1000; i++)
            //{
            //    Console.WriteLine();
            //}
            //stoper.Stop();
            //Console.WriteLine("Duration: " + stoper.Duration);

            /*Exercise 2*/
            Post post = new Post("Jimmy Hoffa is missing.", "We don't know what happened last weekend.");
            post.DownVote();
            post.DownVote();
            post.DownVote();
            post.UpVote();
            post.UpVote();
            post.Voting();
        }
    }
}
