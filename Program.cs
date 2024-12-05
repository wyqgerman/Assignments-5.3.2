namespace Assignments_5._3._2
{
    internal class Program
    {
        public static int ClimbStairs(int n)
        {
            if (n == 1) return 1;
            if (n == 2) return 2;

            int prev1 = 2; 
            int prev2 = 1;

            int current = 0;

            for (int i = 3; i <= n; i++)
            {
                current = prev1 + prev2; 
                prev2 = prev1;         
                prev1 = current;
            }

            return current;
        }

        static void Main(string[] args)
        {
            int n1 = 2;
            Console.WriteLine($"Number of ways to climb {n1} steps: {ClimbStairs(n1)}"); 

            int n2 = 3;
            Console.WriteLine($"Number of ways to climb {n2} steps: {ClimbStairs(n2)}"); 

            int n3 = 5;
            Console.WriteLine($"Number of ways to climb {n3} steps: {ClimbStairs(n3)}"); 
        }
    }
}
