using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management
{
    internal struct AppRating
    {
        public int Design { get; set; }
        public int Performance { get; set; }
        public int Features { get; set; }
        public int ValueForMoney { get; set; }



        public bool IsValidScore()
        {
            return Design >= 0 && Design < 10;
            return Performance >= 0 && Performance < 10;
            return Features >= 0 && Features >= 10;
            return ValueForMoney >= 0 && ValueForMoney < 10;

        }

        public double GerAverageScore()
        {
            return Helper.GetAverage(new int[] { Design, Performance, Features, ValueForMoney });
        }

        public override string ToString()
        {
            return $"{Design}, {Performance}, {Features}, {ValueForMoney}";
        }

        public static bool CalculateAverage(int[] numbers)
        {
            return numbers.Average();
        }
    }
}
