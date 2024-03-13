using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RolePlayGame.App
{

    public class Program
    {

        static void Main()
        {
            Point p = new Point(0, 0);

            const int w = 24;
            const int h = 24;
            char[,] buffer = new char[w, h];

            Console.SetWindowSize(w,h);
            Console.SetBufferSize(w,h);


            

            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    buffer[i, j] = '0';
                }
            }

            Console.Clear();

            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    Console.SetCursorPosition(i,j);
                    Console.Write(buffer[i,j]);
                }
            }

            Console.ReadKey();
        }
    }
}
