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
            
            Point point = new Point(20, 15, '*');

            

            point.Draw();
            
            Console.ReadLine();
        }

       
    }
}
