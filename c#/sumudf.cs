using System;
class ask
{
	public static void sum()
	{
		Console.WriteLine("hello");
		int a, s, sum;
        Console.Write("Enter value of a: ");
        a = Convert.ToInt32(Console.ReadLine());
		Console.Write("Enter value of s: ");
        s = Convert.ToInt32(Console.ReadLine());

		sum = a + s;
		Console.WriteLine("answer is: " + sum);
	}
	public static void Main()
	{
	
		sum();
		Console.ReadLine();
	}
}