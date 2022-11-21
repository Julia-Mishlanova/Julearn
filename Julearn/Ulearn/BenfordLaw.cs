namespace ConsoleApp4
{
    public static int[] GetBenfordStatistics(string text)
    {
	    var statistics = new int[10] {0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            var words = text.Split(' ');

            foreach (var element in words)
            {
                if (char.IsDigit(element[0]))
                {
                    statistics[int.Parse(element[0].ToString())] += 1;
                }
            }
    }
}
