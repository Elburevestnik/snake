using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(1, 1);
            Console.SetBufferSize(80, 25);
            Console.SetWindowSize(80, 25);
            gorizline upline = new gorizline(0, 78, 0, '+');
            gorizline dline = new gorizline(0, 78, 24, '+');
            vertline lline = new vertline(0, 24, 0, '+');
            vertline rline = new vertline(0, 24, 78, '+');
            upline.drow();
            dline.drow();
            lline.drow();
            rline.drow();
            point p = new point(4, 5, '*');
    
            snake sn = new snake(p, 4, direction.RIGHT);
            sn.drow();
            sn.Move();
            Thread.Sleep(300);
         
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    sn.handlykey(key.Key);
                }
                
                Thread.Sleep(100);
                sn.Move();
            }
            //Console.ReadLine();

        }

       
    }
}
