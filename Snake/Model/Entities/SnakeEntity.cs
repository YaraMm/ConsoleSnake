using System;

namespace Snake.Model.Entities
{
    public class SnakeEntity
    {
        public int CurrentLength { get; set; }

        public SnakeEntity()
        {
            CurrentLength = 3;
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
