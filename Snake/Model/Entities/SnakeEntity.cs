using System;
using System.Collections.Generic;
using System.Drawing;

namespace Snake.Model.Entities
{
    public class SnakeEntity
    {
        public int CurrentLength { 
            get
            {
                return SnakeSegments.Count;
            }
        }
        public List<Point> SnakeSegments {  get; set; }  
        public SnakeEntity()
        {
        }

        public bool CheckCollision(Border border)
        {
            throw new NotImplementedException();
        }

        public bool CheckSelfCollision()
        {
            throw new NotImplementedException();
        }
    }
}
