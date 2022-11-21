public static int[] GetFirstEvenNumbers(int count)
{
        {
            int[] even;
            even = new int[count];

            for (int i = 0; i < count; i++)
            {
                int g = (i + 1) * 2;
                even[i] = g;               
            }

            return even;
        }
}
