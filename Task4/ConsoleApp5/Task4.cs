using System;
using System.Collections.Generic;

class HelloWorld
{
    static void Main()
    {
        string Romenumber = Console.ReadLine();
        int N = Romenumber.Length;
        int answer = 0;
        List<int> number = new List<int>();
        for (int i = 0; i < N; i++)
        {
            switch (Romenumber[i])
            {
                case 'I':
                    number.Add(1);
                    break;
                case 'V':
                    number.Add(5);
                    break;
                case 'X':
                    number.Add(10);
                    break;
                case 'L':
                    number.Add(50);
                    break;
                case 'C':
                    number.Add(100);
                    break;
                case 'D':
                    number.Add(500);
                    break;
                case 'M':
                    number.Add(1000);
                    break;
            }
        }

        for (int i = 0; i < N - 1; i++)
        {
            if (number[i] < number[i + 1])
            {
                number[i] = number[i] * (0 - 1);
            }
        }

        for (int i = 0; i < N; i++)
        {
            answer = answer + number[i];
        }

        Console.WriteLine(answer);
    }
}