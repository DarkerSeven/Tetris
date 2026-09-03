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
            
            Point point = new Point();

            point.x = 20;
            point.y = 15;
            point.c = '*';
            point.Draw();
            
            Console.ReadLine();
        }

       
    }
}
