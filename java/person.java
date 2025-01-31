class person
{
	static void check()
	{
		System.out.println("non static");

	}
	void checktwo()
	{
			System.out.println("checktwo");

	}
	public static void main(String args[])
	{
		person a=new person();
		//a.check();
		a.checktwo();
			System.out.println("successfully");

	}
}