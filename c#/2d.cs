using System;
class arr2
{
    public static void Main()
    {
        int[,] numbers = { {1, 4, 2}, {3, 6, 8} };

      for (int i = 0; i < numbers.GetLength(0); i++) 
      { 
          for (int j = 0; j < numbers.GetLength(1); j++) 
          { 
              Console.WriteLine(numbers[i, j]); 
          } 
      }  
    }
}

