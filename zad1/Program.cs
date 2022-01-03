using lab2_lab3;
using System;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Shape> shape = new List<Shape>();
            Rectangle r1 = new Rectangle();
            Triangle t1 = new Triangle();
            Circle c1 = new Circle();
            shape.Add(r1);
            shape.Add(t1);
            shape.Add(c1);

            shape[0].Draw();
            shape[1].Draw();
            shape[2].Draw();
        }
    }
}
