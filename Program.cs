using System.Runtime.CompilerServices;

namespace Room_Calculater
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Asking and storing User Input for lenth and width
            Console.WriteLine("What is the length of the classroom by feet?");
            double length = double.Parse(Console.ReadLine());
            Console.WriteLine("What is the width of the classroom by feet?");
            double width = double.Parse(Console.ReadLine());
            Console.WriteLine("What is the height of the room");
            double height = double.Parse(Console.ReadLine());
            // Calculating room area, volume, surface area perimeter
            double area = length * width;
            double perimeter = length * 2 + width * 2;
            double volume = length * width * height;
            double surfaceArea = 2 * length * width + 2 * length * height + 2 * height * width;  
            Console.WriteLine($" The class room's area is {area}, perimter is {perimeter}.");

            //Determining if the room is small, medium, or large
            if (area <= 250)
            {
                Console.WriteLine("This is a small room.");
            }
            else if (area > 250 && area < 650)
            {
                Console.WriteLine("This is a medium room");
            }
            else 
            { 
                Console.WriteLine("This is a large room");
            }
        }
    }


}
