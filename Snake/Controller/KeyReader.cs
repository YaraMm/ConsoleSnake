using System;
using System.Threading;

namespace Snake.Controller
{
    public class KeyReader
    {
        public Action GetAction()
        {
            if(Console.KeyAvailable == true)
            {
                var key = Console.ReadKey(true).Key;
                switch (key)
                {
                    case ConsoleKey.A:
                        return Action.Left;

                    case ConsoleKey.S:
                        return Action.Down;

                    case ConsoleKey.D:
                        return Action.Right;

                    case ConsoleKey.W:
                        return Action.Up;
                    default:
                        return Action.None;
                }
            }
            return Action.None;
        }
    }
}

