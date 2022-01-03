using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_lab3
{
    class Shape
    {
        double x, y, height, width;
        public virtual void Draw() 
        {
            Console.WriteLine("Rysuje");
        }

    }
}
