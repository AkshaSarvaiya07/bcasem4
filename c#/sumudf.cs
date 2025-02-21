using System;
class sumudf
{
	public static int sum(int a, int s)
	{
		
		return a+s; 
	}
	public static void Main()
	{
		Console.Write("Enter value of a: ");
       int a = Convert.ToInt32(Console.ReadLine());
		Console.Write("Enter value of s: ");
        int s = Convert.ToInt32(Console.ReadLine());
		
	
		int ans=sum(a,s);
		Console.WriteLine("answer is:" +ans);
		Console.ReadLine();
	}
}
