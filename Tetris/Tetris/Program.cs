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

            FigureGenerator generator = new FigureGenerator(20, 0, '*');
            Figure s = null;
            while (true)
            {
                FigureFall(s, generator);
            }

            Console.ReadLine();
        }

        static void FigureFall(Figure fig, FigureGenerator generator)
        {

            fig = generator.GetNewFigure();
           
            for (int i = 0; i < 5; i++)
            {  
                fig.Hide();
                fig.Move(Direction.DOWN);
                fig.Draw();
                Thread.Sleep(500);
            }


        }
    }
}
