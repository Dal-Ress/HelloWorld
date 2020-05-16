using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;

namespace TurtleTraining
{
    using static Turtle;
    class Program
    {
        static void WriteT(int x, int y, int size)
        {
            //Буква "Т" начало
            X = x;
            Y = y;
            Angle = 0;
            Move(size);
            TurnLeft();
            Move(size / 3);
            Angle = 90;
            Move(size * 2 / 3);
            //Буква "Т" конец
        }

        static void WriteO (int x, int y, int size)
        {
            X = x;
            Y = y;
            Angle = 0;
            for (int i = 0; i < 4; i++)
            {
                Move(size);
                TurnRight();
            }
        }

        static void WriteP (int x, int y)
        {
            X = x;
            Y = y;
            Angle = 180;
            Move(30);
            Angle = 0;
            Move(60);
            TurnRight();
            for (int i = 0; i < 4; i++)
            {
                Move(30);
                TurnRight();
            }
        }
        static void Main(string[] args)
        {

            Speed = 9;

            //for(int i = 0; i < 4; i++)
            //{
            //    Move(20);
            //    TurnRight();
            //    Move(20);
            //    TurnRight();
            //    Move(20);
            //    TurnLeft();
            //    Move(20);
            //    TurnLeft();
            //}

            //int i = 0;
            //while (i < 6)
            //{
            //    Move(100);
            //    Turn(60);
            //    i++;
            //}

        

            //ТОРТ

            WriteT(200, 200, 60);

            WriteO(240,200, 30);
    
            WriteP(300, 200);
    
            WriteT(360, 200, 30);
        }
    }
}
