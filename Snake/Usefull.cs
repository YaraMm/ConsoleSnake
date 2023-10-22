using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Usefull
    {
        public string ArrToString(string[][] arr)
        {
            string res = "";
            for(int i = 0; i < arr.GetLength(0) - 1; i++)
            {
                for(int j = 0; j < arr.GetLength(0) - 1; j++)
                {
                    if (j != arr.GetLength(0)) res += arr[i][j];
                    else res += arr[i][j] + "\n";
                }
            }
            //foreach(var item in arr)
            //{
            //    res += item.ToString();
            //}
            return res;
        }
    }
}
