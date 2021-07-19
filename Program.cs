using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBMI
{
    class Program
    {
        static void Main(string[] args)
        {
            double weight;
            double height;
            double bmidu;
            Console.WriteLine("Enter Your Weight (KG): ");
            weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Your Height (M): ");

            height = Convert.ToDouble(Console.ReadLine());

            double height2pow = System.Math.Pow(height, 2);

            bmidu = weight / height2pow;
           // bmidu = height / weight;

            Console.WriteLine("Answer: ");
            Console.WriteLine(Convert.ToString(bmidu));

            if (bmidu <= 18.5)
            {
                Console.WriteLine(" your Weight is Low ");
            }
            else if (bmidu <= 25 & bmidu >= 18.5)
            {
                Console.WriteLine(" Your Weight is Ideal ");

            }
            else if (bmidu <= 30 & bmidu >= 25)
            {
                Console.WriteLine(" Your Weight is Little High ");

            }
            else if (bmidu >= 30)
            {
                Console.WriteLine(" Your Weight is Certainly Fat ");

            }


            Console.ReadKey();


        }
    }
}
