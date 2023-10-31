using Snake.Model.Entities;
using Snake.View;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Program
    {
        public static Field _fieldTools;

        static void Main(string[] args)
        {
            Size size = new Size() { Width = 10, Height = 20 };
            Frame frame = new Frame(size);
            TextViewer viewer = new TextViewer();
            SnakeEntity snake = new SnakeEntity();
            viewer.Draw(frame, snake);
            //var border = new Border(BorderType = BorderType.Horizontal,
            //    var startPosition = new Point(0, 0), length = 3);
            viewer.Draw(frame, new Border(BorderType.Horizontal, new Point(0, 0), 4));
            Console.WriteLine(frame.ToString());


        }
    }
}
