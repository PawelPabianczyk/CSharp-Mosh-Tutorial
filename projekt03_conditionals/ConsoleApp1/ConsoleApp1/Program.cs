using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number between 1 to 10: ");

            try
            {
                int number = Convert.ToInt32(Console.ReadLine());

                if (1 <= number && number <= 10)
                    Console.WriteLine("Valid");
                else
                    Console.WriteLine("Invalid");
            }
            catch (Exception)
            {
                Console.WriteLine("Inproper variable");
            }

            Console.WriteLine("Enter two numbers: ");

            try
            {
                int[] nums = new int[2];
                nums[0] = Convert.ToInt32(Console.ReadLine());
                nums[1] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Maximum of two numbers: ");
                Console.WriteLine(nums.Max());
            }
            catch (Exception)
            {
                Console.WriteLine("Inproper variable");
            }

            Console.WriteLine("Enter the width and height of an image:");

            try
            {
                int width = Convert.ToInt32(Console.ReadLine());
                int height = Convert.ToInt32(Console.ReadLine());

                if (width > height)
                    Console.WriteLine("It is portrait");
                else
                    Console.WriteLine("It is landscape");
            }
            catch (Exception)
            {
                Console.WriteLine("Inproper variable");                                            
            }

            Console.WriteLine("Enter the speed of car:");

            try
            {
                int speedLimit = Convert.ToInt32(Console.ReadLine());
                int carSpeed = Convert.ToInt32(Console.ReadLine());
                int demeritPoints = 0;
                if(carSpeed > speedLimit)
                {
                    demeritPoints = (carSpeed - speedLimit) / 5;
                }
                
                if(demeritPoints == 0)
                    Console.WriteLine("It is okey");
                else if(demeritPoints < 12)
                    Console.WriteLine("Numbers of demerit points: {0}", demeritPoints);
                else
                    Console.WriteLine("License Suspended");
            }
            catch (Exception)
            {
                Console.WriteLine("Inproper variable");
            }
        }
    }
}
