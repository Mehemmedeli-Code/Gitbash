using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management
{
    internal class StringExtension
    {
        public static string Word { get; set; }




        public static string Capitalize(string word)
        {
            word = word.Substring(0,1).ToUpper() + word.Substring(1).ToLower();
            return word;
        }

        public static void ToUpper(string word)
        {
            word = word.Trim();
            if(word.Length < 1)
            {
                Console.WriteLine(" ");
            }
            else
            {
                word = word.Substring(0, 1).ToUpper() + word.Substring(1).ToLower();
            }
        }

    }
}
