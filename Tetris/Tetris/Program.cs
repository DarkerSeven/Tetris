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

            Figure[] figures = new Figure[2];
            figures[0] = new Stick(1,1,'*');
            figures[1] = new Square(5, 5, '#');
            foreach (Figure f in figures)
            {
                f.Draw();
            }
            Console.ReadLine();
        }

       
    }
}
