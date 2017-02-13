using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();

            while (true)
            {
                Console.WriteLine("Input three numbers, one at a time");

                try
                {
                    int a = int.Parse(Console.ReadLine());
                    int b = int.Parse(Console.ReadLine());
                    int c = int.Parse(Console.ReadLine());

                    Console.WriteLine(program.AnalyzeTriangle(a, b, c));
                }
                catch (Exception)
                {
                    Console.WriteLine("Error");
                }

                
            }

        }


        private string AnalyzeTriangle(int a, int b, int c)
        {
            int[] triangleArr = new[] {a, b, c};

            if (triangleArr.Any(e => e == 0))
            {
                return "Error";
            }
            switch (triangleArr.Distinct().Count())
            {
                case 1:
                    return "Equilateral";
                case 2:
                    return "Isosceles";
                case 3:
                    return "Scalene";
                default:
                    return "Error";
            }
        }
    }
}