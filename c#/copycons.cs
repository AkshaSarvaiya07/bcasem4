using System;
class xyz
{
	int a;
	public xyz()
	{
		
	}
	public xyz(xyz cpy)
	{
		a=cpy.a;
		Console.WriteLine("constructar called");
		
	}
	public static void Main()
	{
		xyz obj1=new xyz();
		obj1.a=Convert.ToInt32(Console.ReadLine());
		xyz obj2=new xyz(obj1);
		Console.WriteLine("value of obj1.a:" +obj1.a);
		Console.WriteLine("value of obj2.a:" +obj2.a);
		Console.WriteLine();
	}
}