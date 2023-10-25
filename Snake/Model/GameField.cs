using Snake.Model.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace Snake.Model
{
    public class GameField
    {
        public List<Border> Borders { get; set; }
        public Food Food { get; set; }
        public SnakeEntity Snake { get; set; }

        public Size Size { get; set; }

        public void TurnLeft()
        {
            
        }

        public void TurnRight()
        {

        }

        public void TurnUp()
        {

        }

        public void TurnDown()
        {

        }

        public void Tick()
        {

        }

        private Food GenerateNewFood()
        {
            throw new NotImplementedException();
        }
    }
}
