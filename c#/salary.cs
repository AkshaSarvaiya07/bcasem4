using System;
class emp
{
	void salary(double basicsalary)
	{
		double ta=0,da=0,hra=0,pf=0;
		double gs;//grosssalary
		
		if(basicsalary>=35000 && basicsalary <=45000)
		{
			ta=basicsalary*0.05;//travelling allowence
			da=basicsalary*0.05;//dinner allowence
			hra=basicsalary*0.15;//house rent alliwence
			pf=basicsalary*0.085;//provident fund
		}
		gs= basicsalary +ta +da + hra -pf;
		Console.WriteLine("basic salary is:" +basicsalary);
		Console.WriteLine("ta is:" +ta);
		Console.WriteLine("da is:"+da);
		Console.WriteLine("hra is:"+hra);
		Console.WriteLine("pf is:" +pf);
		Console.WriteLine("gross salary is:" +gs);
		
	}
	public static void Main()
	{
		emp s=new emp();
		Console.WriteLine("enter a basic salary:");
		double basicsalary=Convert.ToDouble(Console.ReadLine());
		s.salary(basicsalary);
		
	}
		
		
}