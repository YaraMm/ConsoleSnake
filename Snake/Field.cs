using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Field
    {
        static Program _Program = new Program();
        public const int Width = 20;
        public const int Height = 10;
        public static List<List<string>> field = new List<List<string>>();

        public static List<List<string>> InitField()
        {
            var field = new List<List<string>>(Height + 2);
            for (int i = 0; i < Height + 2; i++)
            {
                var x = new List<string>(Width + 2);
                FillList(x);
                field.Add(x);
            }
            return field;
        }

        public static List<string> FillList(List<string> list)
        {
            for(int i = 0; i < Width + 2; i++)
            {
                string str = "";
                list.Add(str);
            }
            return list;
        }

        public static void ShowField(List<List<string>> list)
        {
            for(int i = 0; i < list.Count; i++)
            {
                var x = list[i];
                for(int j = 0; j < x.Count; j++)
                {
                    if (i == 0 || i == list.Count - 1)
                    {
                        Console.SetCursorPosition(j, i);
                        Console.WriteLine("+");
                    }
                    else if (j == 0 || j == x.Count - 1)
                    {
                        Console.SetCursorPosition(j, i);
                        Console.WriteLine("+");
                    }
                }
            }
        }
    }
}

