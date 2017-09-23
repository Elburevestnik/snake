using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            point p1 = new point();
            p1.x = 1;
            p1.y = 2;
            p1.sym = '*';
          
            p1.draw(p1.x, p1.y, p1.sym);

            //int x1 = 1;
            //int y1 = 3;
            //char symb = '*';
            /*int x2 = 4;
            int y2 = 5;
            char symb2 = '#';
            draw(x2, y2, symb2);
            */
            point p2 = new point();
            p2.x = 5;
            p2.y = 2;
            p2.sym = '#';

            p2.draw(p2.x, p2.y, p2.sym);

            Console.ReadLine();

        }

        /*static void draw(int a, int b, char s)
        {
            Console.SetCursorPosition(a, b);
            Console.Write(s);
        }*/
    }
}
