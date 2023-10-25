using System.Drawing;

namespace Snake.Model.Entities
{
    public class Food
    {
        public Point Position { get; set; }

        public Food(Point position)
        {
            Position = position;
        }
    }
}
