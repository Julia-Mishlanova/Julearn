using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Julearn.Ulearn
{
    public static class PluralizeRubles
    {
        public static string Start(int count)
        {
            int lastTwoNumber = (count) % 100;
            if (lastTwoNumber == 11 || lastTwoNumber == 12 || lastTwoNumber == 13 || lastTwoNumber == 14)
            {
                return "рублей";
            }
            else//
            {
                int lastNumber = (count) % 10;
                if (lastNumber == 1)
                {

                    return "рубль";

                }
                else
                {
                    string r = lastNumber == 2 || lastNumber == 3 || lastNumber == 4 ? ("рубля") : ("рублей");
                    return r;
                }
            }

        }
    }
}
