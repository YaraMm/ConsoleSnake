using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Test
{
    public class Program
    {
        private const int Width = 20;
        private const int Height = 10;

        public static void OutputPoints(Point[] points)
        {
            
        }

        public static void Main(string[] args)
        {
            OutputPoints(new Point[]
            {
                new Point(6, 3),
                new Point(8, 3),
                new Point(7, 4),
                new Point(7, 5),
                new Point(7, 6)
            });
            Console.ReadKey();
        }
    }
}