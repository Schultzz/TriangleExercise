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

            /*Test if triangle is NOT a triangle
             * Input: 0, 0, 1
             * Expected output: Error
             */
            Console.WriteLine(program.AnalyzeTriangle(0, 0, 1));
            //Test if triangle is Equilateral
            Console.WriteLine(program.AnalyzeTriangle(30, 30, 30));
            //Test if triangle is Isosceles
            Console.WriteLine(program.AnalyzeTriangle(30, 50, 30));
            //Test if triangle is Scalene
            Console.WriteLine(program.AnalyzeTriangle(30, 40, 50));

            Console.ReadKey();
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