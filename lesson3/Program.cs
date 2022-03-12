using System;
class HelloWorld
{
    static void Main()
    {
        int next_string = 0;
        int[,] array = new int[5, 5];
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = next_string + 1;
                Console.WriteLine($"{new string(' ', next_string)}{array[i, j]}");
                next_string++;
            }
        }
    }

}




