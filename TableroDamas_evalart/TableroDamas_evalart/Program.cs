using System;

public class Program
{
    static int n = 5;

    public static void Main()
    {
        if (n < 1 || n > 10)
        {
            n = 5;
        }


        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if ((i + j) % 2 == 0)
                {
                    Console.Write("X ");
                }
                else
                {
                    Console.Write("_ ");
                }

            }
            Console.WriteLine();
        }

    }

}

