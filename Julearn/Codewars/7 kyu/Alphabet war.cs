using System.Collections.Generic;

public class Kata
 {
    public static string AlphabetWar(string fight)
    {
            Dictionary<string, int> anotherLett = new Dictionary<string, int>();
            var keyAnoth = "acefghijklnortuvxy";
            var value = 0;

            Dictionary<string, int> leftLett = new Dictionary<string, int>();
            var keyLeft = "sbpw";
            var valueLeft = 1;

            Dictionary<string, int> rightLett = new Dictionary<string, int>();
            var keyRigth = "zdqm";
            var valueRigth = 1;

            for (int i = 0; i < 4; i++)
            {
                leftLett.Add(keyLeft[i].ToString(), valueLeft++);
                rightLett.Add(keyRigth[i].ToString(), valueRigth++);
                anotherLett.Add(keyAnoth[i].ToString(), value);
            }

            int sumLeft = 0;
            int sumRight = 0;
            for (int i = 0; i < fight.Length; i++)
            {
                if (leftLett.ContainsKey(fight[i].ToString())) sumLeft += leftLett[fight[i].ToString()];
                else if (rightLett.ContainsKey(fight[i].ToString())) sumRight += rightLett[fight[i].ToString()];
                else if (anotherLett.ContainsKey(fight[i].ToString())) sumLeft += 0;
            }

            if (sumLeft > sumRight) return "Left side wins!";
            else if (sumRight > sumLeft) return "Right side wins!";
            else return "Let's fight again!";
    }
 }