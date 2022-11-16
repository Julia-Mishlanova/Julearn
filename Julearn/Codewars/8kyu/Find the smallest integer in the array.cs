public class Kata 
{
    public static int FindSmallestInt(int[] args) 
    {
            
            int surv = args[0];

            for (int i = 0; i < args.Length; i++)
            { 
                if (surv > args[i])
                {
                    surv = args[i];
                }
            }
            return surv;
    }
}