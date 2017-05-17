using System;

public class Class1
{
    public Class1()
    {
        void Staircase(int num)
        {
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.WriteLine("#");
                }
            }
        }
        Staircase(7);
        Staircase(3);
    }
}
