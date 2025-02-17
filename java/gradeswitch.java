import java.util.Scanner;
class gradeswitch
{
	public static void main(String[] args)
	{
		Scanner scanner=new Scanner(System.in);
		
		System.out.println("enter your percntage:");
		int percentage=scanner.nextInt();
		String grade;
		switch(percentage/10)
		{
			case 0:
			case 1:
				grade="A";
				break;
			case 2:
				grade="B";
				break;
			case 3:
				grade="C";
				break;
			case 4:
				grade="D";
				break;
			case 5:
				grade="E";
				break;
			default:
				grade="FAIL";
				
			
		}
		System.out.println("your grade is:" + grade);
		scanner.close();
	}
}