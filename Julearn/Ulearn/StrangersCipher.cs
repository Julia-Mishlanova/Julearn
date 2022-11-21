using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public static class StringExt
    {
        public static void Main()
        {
            // не забывай смотреть error list.
            string[] lines = { "reshIla nE Yproshat i zashifROVAt Vse poslaNIE", "dAze ne Staraisa nICHEGO u tEba nE poluchitsa s RASHIFROVKOI"};
            DecodeMessage(lines);

        }
        private static string DecodeMessage(string[] lines)
        {
            string str = "";
            for (int i = 0; i < lines.Length; i++)
            {
                str += lines[i] + " ";
            }

            List<string> result = new List<string>();
            string[] message = str.Split(' ');
            for (int i = 0; i < message.Length; i++)
            {
                if (message[i] == "ХОРОШИЙ") result.Add(message[i]);
                if (message[i] == "НЕ") result.Add(message[i]);
                if (message[i].Length > 1 &&  Char.IsUpper(message[i][0]) && Char.IsLower(message[i][1]))
                {
                    result.Add(message[i]);
                }
            }

            StringBuilder sb = new StringBuilder();
            for (int i = result.Count - 1; i >= 0; i--)
            {
                if (i == 0) sb.Append(result[i]);
                else sb.Append(result[i] + " ");
            }
            return sb.ToString();
        }

    }
}
