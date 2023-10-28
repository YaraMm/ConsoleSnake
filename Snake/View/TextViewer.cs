using Snake.Model.Entities;
using System;
using System.Collections.Generic;

namespace Snake.View
{
    public class TextViewer
    {
        public Frame GetFrame(Field field)
        {
            throw new NotImplementedException();
        }

        public void Draw(Frame frame, Border border)
        {
            if(border.Type == BorderType.Horizontal)
            {
                var x = border.StartPosition.X;
                for (int i = x; i < x + border.Length; i++)
                {
                    frame.Pixels[border.StartPosition.Y, i] = CharIcons.BorderIcon;
                }
            }
            else
            {
                var y = border.StartPosition.Y;
                for (int i = y; i < y + border.Length; i++)
                {
                    frame.Pixels[i, border.StartPosition.X] = CharIcons.BorderIcon;
                }
            }
        }

        public void Draw(Frame frame, Food food)
        {
            var x = food.Position.X;
            var y = food.Position.Y;
            frame.Pixels[y, x] = CharIcons.FoodIcon;
        }

        public void Draw(Frame frame, SnakeEntity snake)
        {
            var s = snake.SnakeSegments;
            for(int i = 0; i < snake.CurrentLength; i++)
            {
                var x = s[i].X; 
                var y = s[i].Y;
                frame.Pixels[y, x] = CharIcons.SnakeIcon;
            }
        }
    }
}
