using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover1
{
    public class Rover
    {
        public int x; //x cordinate
        public int y; //y cordinate
        public string direction; // variable of rover direction


        public Rover(string location)
        {
            Int32.TryParse(location.Split(" ")[0], out x);
            Int32.TryParse(location.Split(" ")[1], out y);
            direction = location.Split(" ")[2].ToUpper();
            
        }
        public void SpinLeft()
        {
            if (direction == "N")
            {
                direction = "W";
            }
            else if (direction == "E")
            {
                direction = "N";
            }
            else if (direction == "S")
            {
                direction = "E";
            }
            else if (direction == "W")
            {
                direction = "S";
            }
        }

        public void SpinRight()
        {

            if (direction == "N")
            {
                direction = "E";
            }
            else if (direction == "E")
            {
                direction = "S";
            }
            else if (direction == "S")
            {
                direction = "W";
            }
            else if (direction == "W")
            {
                direction = "N";
            }
        }

        public void StepFoward()
        {

            if (direction == "N") { y++; }
            else if (direction == "E") { x++; }
            else if (direction == "S") { y--; }
            else if (direction == "W") { x--; }

        }

        public void Move(string roverCommand) // "LMLMLMLMM" OR "MMRMMRMRRM"
        {
            char[] moves = roverCommand.ToCharArray();        
            for (int i = 0; i < moves.Length; i++)
            {
                if (moves[i] == 'L')
                    { SpinLeft(); }
                else if(moves[i] =='R')
                    { SpinRight(); }
                else if(moves[i] =='M')
                    { StepFoward(); }
            }
        }
    }
}
