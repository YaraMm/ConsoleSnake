using System;
using System.Collections.Generic;
using System.Drawing;

namespace Snake.Model.Entities
{
    public class SnakeEntity
    {
        public int CurrentLength { get; set; }
        public List<Point> SnakeSegments {  get; set; }  


        public SnakeEntity()
        {
            CurrentLength = 3;
            SnakeSegments = new List<Point>(CurrentLength) { new Point { X =  1, Y = 2 },
                new Point { X = 2, Y = 2 },
                new Point { X = 3, Y = 2 } };
        }

        public bool CheckCollision(Border border)
        {
            //bool res = false;
            //for(int i = 0; i < border.Length; i++)
            //{
            //    if(border.Type == BorderType.Horizontal)ss
            //    {
            //        if(border.StartPosition.Y == SnakeSegments[0].Y)
            //        {
            //            border.StartPosition.
            //        }
            //    }
            //}

            throw new NotImplementedException();
        }

        public bool CheckSelfCollision()
        {
            throw new NotImplementedException();
        }
    }
}
