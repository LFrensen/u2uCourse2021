using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace U2UPeople
{
    public class Excercise_4
    {
        public static string CapitalizeEachWord(string input)
        {
            CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cultureInfo.TextInfo;

            char[] charArray = input.ToCharArray();
            foreach (var item in charArray)
            {
                if(item == charArray[0])
                {
                    char.ToUpper(item);
                }
                string s = new string(item.ToString());
                Console.WriteLine(s);
            }
            return "";
        }
    }
}
