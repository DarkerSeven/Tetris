using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.SetWindowSize(40,30);
            Console.SetBufferSize(40,30);
            
            int x1 = 20;
            int y1 = 15;
            char c1 = '*';
            draw(x1, y1, c1);
            
            Console.ReadLine();
        }

        private static void draw(int x1, int y1, char c1)
        {
            Console.SetCursorPosition(x1, y1);
            Console.Write(c1);
        }
    }
}
