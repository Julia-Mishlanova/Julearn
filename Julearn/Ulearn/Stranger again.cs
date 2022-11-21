namespace ConsoleApp4
{
    private static string ApplyCommands(string[] commands)
    {
			var sB = new StringBuilder();
            for (int i = 0; i < commands.Length; i++)
            {
                if (commands[i].StartsWith("push"))
                {
                    sB.Append(commands[i].Replace("push ", string.Empty));
                }
                else if (commands[i].StartsWith("pop"))
                {
                    int trimCount = int.Parse(commands[i].Replace("pop ", string.Empty));
                    var startIndex = sB.Length - trimCount;
                    sB.Remove(startIndex, trimCount); //где начинается, сколько вырезать
                }
            }
            return sB.ToString();
    }
}