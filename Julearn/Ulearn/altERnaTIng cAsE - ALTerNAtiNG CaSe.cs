using System;
using System.Text;

namespace Extensions
{
  public static class StringExt
  {
    public static string ToAlternatingCase (this string s)
    {
            string str = s;
            string checkChar = str.ToLower();
            StringBuilder sB = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                if ((byte)checkChar[i] < 97 || (byte)checkChar[i] > 122) sB.Insert(i, str[i]);
                else if  (Char.IsNumber(str[i])) sB.Insert(i, str[i]);
                else if (Char.IsUpper(str[i]))
                {
                    string low = str[i].ToString().ToLower();
                    sB.Insert(i, low);
                }
                else if (Char.IsLower(str[i]))
                {
                    string up = str[i].ToString().ToUpper();
                    sB.Insert(i, up); //because the space doesn't count
                } 
            }
            return sB.ToString();
    }
  }
}