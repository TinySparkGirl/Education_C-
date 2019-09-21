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
        //static void WriteT(int size)
        //{
        //    Turtle.Angle = 0;
        //    Turtle.Move(size);
        //    Turtle.Angle = 270;
        //    Turtle.Move(20);
        //    Turtle.Angle = 90;
        //    Turtle.Move(40);
        //}

        static void WriteB()
        {
            Turtle.Angle = 0;
            Turtle.Move(100);
            Turtle.Angle = 90;
            Turtle.Move(40);
            Turtle.Angle = 180;
            Turtle.Move(30);
            Turtle.Angle = 270;
            Turtle.Move(40);
            Turtle.Angle = 90;
            Turtle.Move(50);
            Turtle.Angle = 180;
            Turtle.Move(70);
            Turtle.Angle = 270;
            Turtle.Move(50);
        }


        static void Main(string[] args)
        //{
        //    {
        //        // пишем слово ТОРТ

        //        Turtle.Speed = 9;
        //        Turtle.X = 200;
        //        Turtle.Y = 200;

        //        WriteT(100);

        //        Turtle.X = 260;
        //        Turtle.Y = 200;

        //        Turtle.Angle = 0;
        //        for (int i = 0; i < 4; i++ )
        //        {
        //            Turtle.Move(60);
        //            Turtle.TurnRight();                    
        //        }

        //        Turtle.X = 380;
        //        Turtle.Y = 200;

        //        Turtle.Angle = 0;
        //        Turtle.Move(60);
        //        for (int j = 0; j < 3; j++ )
        //        {
        //            Turtle.TurnRight();
        //            Turtle.Move(30);                    
        //        }

        //        Turtle.X = 480;
        //        Turtle.Y = 200;

        //        WriteT(60);
        //    }
        //}
        {
            //пишем имя Вова
            Turtle.Speed = 9;
            Turtle.X = 200;
            Turtle.Y = 200;

            WriteB();

            Turtle.X = 280;
            Turtle.Y = 200;

            Turtle.Angle = 0;
            for (int i = 0; i < 2; i++)
            {
                Turtle.Move(100);
                Turtle.TurnRight();
                Turtle.Move(50);
                Turtle.TurnRight();                
            }

            Turtle.X = 360;
            Turtle.Y = 200;
            WriteB();

            Turtle.X = 440;
            Turtle.Y = 200;

            Turtle.Angle = 0;
            Turtle.Move(100);
            Turtle.Angle = 90;
            Turtle.Move(50);
            Turtle.Angle = 180;
            Turtle.Move(30);
            Turtle.Angle = 270;
            Turtle.Move(50);
            Turtle.Angle = 90;
            Turtle.Move(50);
            Turtle.Angle = 180;
            Turtle.Move(70);
        }


    }
}
