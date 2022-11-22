using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class ListFilterer
{
   public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
   {
            List<int> integers = new List<int>();
            foreach (object item in listOfItems)
            {
                if (item is int)
                {
                    integers.Add((int)item);
                }
            }
            return integers;
   }
}