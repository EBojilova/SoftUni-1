using System;

namespace Point3D
{
    class Program
    {
        static void Main()
        {
            Point3D newPoint = new Point3D(0, 1, 2);
            Console.WriteLine("Point 1: {0}", newPoint.ToString());
            Console.WriteLine(new string('=', 30));

            Point3D center = Point3D.GetCoordinateCenter;
            Console.WriteLine("Starting Point: {0}", center.ToString());
            Console.WriteLine(new string('=', 30));

            Console.WriteLine("Distance between points = {0:F2}", Distance.Calculate(newPoint, center));
            Console.WriteLine(new string('=', 30));
        }
    }
}
