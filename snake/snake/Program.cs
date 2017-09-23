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
            //Console.SetBufferSize(80, 25);
            gorizline upline = new gorizline(0, 78, 0, '+');
            gorizline dline = new gorizline(0, 78, 24, '+');
            vertline lline = new vertline(0, 24, 0, '+');
            vertline rline = new vertline(0, 24, 78, '+');
            upline.drow();
            dline.drow();
            lline.drow();
            rline.drow();
            point p = new point(4, 5, '*');
            p.draw();
            Console.ReadLine();

        }

       
    }
}
