using System;
class indexer
{
	private string[] val=new string[3];
	public string this[int index]
	{
		get
		{
			return val[index];
		}
		set
		{
			val[index]=value;
		}
	}
}
class main
{
	public static void Main(String[] args)
	{
		indexer ic=new indexer();
		ic[0]="c";
		ic[1]="cpp";
		ic[3]="c#";
		Console.WriteLine("printing value store in object uses as array");
		Console.WriteLine("first value {0}",ic[0]);
		Console.WriteLine("first value {1}",ic[1]);
		Console.WriteLine("first value {2}",ic[2]);		


	}
}

