using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tetris
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.SetWindowSize(40,30);
            Console.SetBufferSize(40,30);

            Test();

            Console.ReadLine();
        }

        static void Test()
        {
            Square square = new Square(2, 5, '*');
            square.Draw();
            Thread.Sleep(500);
            square.Hide();
            square.Move(Direction.LEFT);
            square.Draw();
        }
    }
}
