using System;


namespace buoi_2
{
    class Program
    {
        static void Main(string[] args)
        {
            bai1 b1 = new bai1();
            bai1 origin = new bai1();
            bai1 point = new bai1(5, 10, "Point");
            Console.WriteLine("Origin: " + origin);
            Console.WriteLine("Point: " + point);
        }
    }
}