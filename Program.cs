using System;

namespace UnderstandingMethodOverloading
{
    public static class Shape
    {
        // Area of parallelogram
        public static double Area(double b, double h)
        {
            double area = b * h;
            return area;
        }

        // Area of trapezoid
        public static double Area(in double b, double h, double a)
        {
            double area = 0.5 * (a + b) * h;
            return area;
        }

        // Area of triangle
        public static double Area(in double b, in double h)
        {
            double area = b * h * 0.5;
            return area;
        }

        // Cannot define overloaded methods that differ only on ref and out.
        //public static double Area(ref double b, ref double h)
        //{ return 5; }

        // Area of square
        public static double Area(double s)
        {
            double area = s * s;
            return area;
        }

        // Area of circle
        public static double Area(in double r)
        {
            double area = Math.PI * r * r;
            return area;
        }


        // Method overloading can be done by changing the order of the parameters
        // Area of rhombus
        public static double Area(int d1, double d2)
        {
            double area = d1 * d2 * 0.5;
            return area;
        }

        // Area of pentagon
        public static double Area(double p, int a)
        {
            double area = p * a * 0.5;
            return area;
        }
    }

    class Program
    {
        static void Main()
        {
            double b = 7;
            double h = 2;
            Console.WriteLine($"Area of parallelogram where base = {b} and height = {h} is: {Shape.Area(b, h)}");

            double b1 = 7;
            double h1 = 2;
            Console.WriteLine($"Area of triangle where base = {b1} and height = {h1} is: {Shape.Area(in b1, in h1)}");

            int d1 = 20;
            double d2 = 40;
            Console.WriteLine($"Area of rhombus where diagonal1 = {d1} and diagonal2 = {d2} is: {Shape.Area(d1, d2)}");

            int a = 280;
            double p = 60;
            Console.WriteLine($"Area of pentagon where perimeter = {p} and apothem = {a} is: {Shape.Area(p, a)}");

            // Error
            //Shape.Area(5, (int)5.5);

            Console.ReadLine();
        }
    }
}