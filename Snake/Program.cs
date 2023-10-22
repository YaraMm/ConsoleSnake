using System;
using System.Collections.Generic;
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
            var field = Field.InitField();
            Field.ShowField(field);
        }
    }
}
