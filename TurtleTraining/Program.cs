using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;

namespace TurtleTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Turtle.Speed = 7;
                int i = 0;
                while (i < 3)
                {
                    int h = 0;
                    while (h < 2)
                    {
                        Turtle.Move(100);
                        Turtle.TurnRight();
                        h++;
                    }
                    int g = 0;
                    while (g < 2)
                    {
                        Turtle.Move(100);
                        Turtle.TurnLeft();
                        g++;
                    }
                    i++;
                }

                Turtle.Speed = 7;
                int k = 0;
                while (k < 8)
                {
                    Turtle.Move(100);
                    Turtle.Turn(45);
                    k++;
                }

            }
        }
    }
}
