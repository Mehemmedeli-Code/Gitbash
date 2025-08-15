using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management
{
    internal static class AppHelper
    {
        private static int _nums;
        public static int Nums
        {
            get { return _nums; }

            set { _nums = value; }

        }


        public static bool CalculateAverage(int a, int b, int c, int NumAverage)
        {
            for (int i = 0; i < _nums; i++)
            {
                if (NumAverage == 0)
                {
                    Console.WriteLine("Deyer verilmeyib");
                    return false;
                }
                else
                {
                    NumAverage = (a + b + c) / 3;
                    return true;
                }
            }
            return false;

        }
    }
}
