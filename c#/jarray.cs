using System;

class jagged
{
    static void Main()
    {
        // Declaration  
        int[][] jarr = new int[3][];
      
          // Initialization
        jarr[0] = new int[] { 1, 2 };
        jarr[1] = new int[] { 3, 4, 5 };
        jarr[2] = new int[] { 6, 7, 8, 9 };

          // Iterating the elements
        for (int i = 0; i < jarr.Length; i++) 
        {
            Console.Write("Row " + i + ": ");
             for (int j = 0; j < jarrs[i].Length; j++) // Access each element in the row
            {
                Console.Write(jarr[i][j] + " ");
            }
          
            Console.WriteLine();
        }
    }
}


