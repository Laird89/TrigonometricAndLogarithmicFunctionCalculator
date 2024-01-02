using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laird_Chris_Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            double lowerTheta, upperTheta, step;
            int space;
            string resume;
            bool promptUser = true;
            Program program = new Program();

            while (promptUser)
            {
                Console.WriteLine("Enter the lower value for theta: ");
                lowerTheta = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter the upper value for theta: ");
                upperTheta = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter the equally spaced values of theta: ");
                space = int.Parse(Console.ReadLine());

                step = upperTheta / space;

                Console.WriteLine("Theta  ||  Sin(2theta)  ||  Log(theta)");
                for(int i = 0; i < space; i++) 
                { 
                    double currentTheta = lowerTheta + i * step;
                    double resultF = program.f(currentTheta);
                    double resultG = program.g(currentTheta);

                    display(currentTheta, resultF, resultG);
                }


                Console.WriteLine("Would you like to try again (y/n): ");
                resume = Console.ReadLine();
                if(resume != "y")
                {
                    promptUser = false;
                }
            }
        }

        double f(double theta) 
        { 
            return 2 * Math.Sin(theta);
        }

        double g(double theta) 
        {
            return Math.Log(theta, 2);
        }

        static void display(double theta, double x, double y) 
        { 
            Console.WriteLine(theta + "  ||  " + x + "  ||  " +  y);
        }
    }
}
