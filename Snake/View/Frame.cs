using System.Drawing;

namespace Snake.View
{
    public class Frame
    {
        public Size Size { get; set; }
        public char[,] Pixels { get; set; }

        public Frame(Size size)
        {
            Size = size;
            Pixels = new char[size.Height, size.Width];

            for (var y = 0; y < Size.Height; y++)
            {
                for (var x = 0; x < Size.Width; x++)
                {
                    Pixels[y, x] = ' ';
                }
            }
        }

        public override string ToString()
        {
            var result = "";
            for (var y = 0; y < Size.Height; y++)
            {
                for (var x = 0; x < Size.Width; x++)
                {
                    result += Pixels[y, x];
                }
                result += "\n";
            }

            return result;
        }
    }
}
