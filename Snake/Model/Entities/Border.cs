using System.Drawing;

namespace Snake.Model.Entities
{
    public class Border
    {
        public BorderType Type { get; set; }
        public Point StartPosition { get; set; }
        public int Length { get; set; }

        public Border(BorderType type, Point startPosition, int length)
        {
            Type = type;
            StartPosition = startPosition;
            Length = length;
        }
    }
}
