using System;

namespace Prime_Number_Program
{
    public class PrimeNumberExample
    {
        public static void Main(string[] args)
        {
            int n, i, m = 0, flag = 0;
            Console.Write("Enter the Number to check Prime: ");
            n = int.Parse(Console.ReadLine());
            m = n / 2;
            for (int j = 2; j <= m; j++)
            {
                if (n % j == 0)
                {
                    Console.Write("Number is not Prime.");
                    flag = 1;
                    break;
                }
            }
            if(flag==0)
                Console.WriteLine("Number is Prime. ");
        }
    }
}
