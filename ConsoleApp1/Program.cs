// See https://aka.ms/new-console-template for more information
using System;


namespace TriangleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter the coordinates of the three points
            Console.WriteLine("Enter coordinate x of dot A:");
            double ax = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter coordinate y of dot A:");
            double ay = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter coordinate x of dot B:");
            double bx = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter coordinate y of dot B:");
            double by = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter coordinate x of dot C:");
            double cx = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter coordinate y of dot C:");
            double cy = double.Parse(Console.ReadLine());

            // Compute the length of the sides using the distance formula
            double ab = Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2));
            double bc = Math.Sqrt(Math.Pow(cx - bx, 2) + Math.Pow(cy - by, 2));
            double ac = Math.Sqrt(Math.Pow(cx - ax, 2) + Math.Pow(cy - ay, 2));

            // Print the length of the sides
            Console.WriteLine("Length of AB: " + Math.Round(ab, 2));
            Console.WriteLine("Length of BC: " + Math.Round(bc, 2));
            Console.WriteLine("Length of AC: " + Math.Round(ac, 2));

            // Determine if the triangle is equilateral or isosceles
            bool isEquilateral = Math.Abs(ab - bc) < 0.0001 && Math.Abs(bc - ac) < 0.0001;
            bool isIsosceles = Math.Abs(ab - bc) < 0.0001 || Math.Abs(bc - ac) < 0.0001 || Math.Abs(ac - ab) < 0.0001;

            // Print if the triangle is equilateral or isosceles
            if (isEquilateral)
            {
                Console.WriteLine("Triangle is equilateral.");
            }
            else if (isIsosceles)
            {
                Console.WriteLine("Triangle is isosceles.");
            }
            else
            {
                Console.WriteLine("Triangle is neither equilateral nor isosceles.");
            }

            // Determine if the triangle is a right triangle
            double delta = 0.0001;
            bool isRight = Math.Abs(bc * bc - (ab * ab + ac * ac)) <= delta || Math.Abs(ab * ab - (bc * bc + ac * ac)) <= delta || Math.Abs(ac * ac - (ab * ab + bc * bc)) <= delta;

            // Print if the triangle is a right triangle
            if (isRight)
            {
                Console.WriteLine("Triangle is a right triangle.");
            }
            else
            {
                Console.WriteLine("Triangle is not a right triangle.");
            }

            // Compute the perimeter of the triangle
            double perimeter = ab + bc + ac;

            // Print the perimeter of the triangle
            Console.WriteLine("Perimeter of the triangle: " + Math.Round(perimeter, 2));

            // Print even numbers from 0 to the perimeter of the triangle
            Console.WriteLine("Even numbers from 0 to perimeter:");
            for (int i = 0; i <= perimeter; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
