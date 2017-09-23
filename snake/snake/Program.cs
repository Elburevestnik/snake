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
            point p1 = new point(1, 2, '!');
                    
            p1.draw(p1.x, p1.y, p1.sym);

          
            point p2 = new point(2,4, '#');
            
            p2.draw(p2.x, p2.y, p2.sym);

            Console.ReadLine();

        }

       
    }
}
