using System;

namespace MarsRover1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter upper-right coordinater of plateau. For example: " + "5 5 ");
            string maxPoint = Console.ReadLine();

            Console.WriteLine("Please enter rover's first position. For example: " + "1 2 N");
            string firstRoverP = Console.ReadLine();

            Console.WriteLine("Please indicate how the rover will explore the plateau. For axample: " + "LMLMLMLMM");
            string firstRoverMoves = Console.ReadLine().ToUpper();

            Console.WriteLine("Please enter rover's second position. For example: " + "3 3 E");
            string secondRoverP = Console.ReadLine();

            Console.WriteLine("Please indicate how the rover will explore the plateau. For axample: " + "MMRMMRMRRM");
            string secondRoverMoves = Console.ReadLine().ToUpper();

            int maxX, maxY;
             Int32.TryParse(maxPoint.Split(" ")[0], out maxX);
             Int32.TryParse(maxPoint.Split(" ")[1], out maxY);
             

            Rover rover = new Rover(firstRoverP);
            rover.Move(firstRoverMoves);
            if(rover.x<0|| rover.x >maxX|| rover.y < 0 || rover.y > maxY)
            {
                Console.WriteLine($"Positon can not be less than (0,0) and can not be greater than ({maxX},{maxY}). ");
            }
            else {
                Console.WriteLine(rover.x + " " + rover.y + " " + rover.direction);
            }
            

            Rover rover1 = new Rover(secondRoverP);
            rover1.Move(secondRoverMoves);
            if (rover1.x < 0 || rover1.x > maxX || rover1.y < 0 || rover1.y > maxY)
            {
                Console.WriteLine($"Positon can not be less than (0,0) and can not be greater than ({maxX},{maxY}). ");
            }
            else {
                Console.WriteLine(rover1.x + " " + rover1.y + " " + rover1.direction);
            }
            
        }
    }
}
