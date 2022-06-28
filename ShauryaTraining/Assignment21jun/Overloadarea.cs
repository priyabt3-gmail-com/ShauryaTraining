using System;
using System.Collections.Generic;
using System.Text;

namespace ShauryaTraining.Assignment21jun
{
    class Overloadarea
    {
        void area(int r)

        {
            Console.WriteLine("Area of circle = " + (3.14 * r * r));
        }
        void area(float l, float w)

        {
            Console.WriteLine("Area of ractangle = " + (l * w));
        }
        void area(int side, int side2)
        {
            Console.WriteLine("Area of square = " + (side * side2));
        }
        void area(double b, double h)
        {
            Console.WriteLine("Area of triangle = " + (1 / 2 * (b * h)));
        }
        static void Main(string[] args)
        {
            Overloadarea m = new Overloadarea();
            m.area(3);
            m.area(2.5f, 1.5f);
            m.area(3, 5);
            m.area(5.5, 7.5);


        }
    }
}
