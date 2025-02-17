import java.util.Scanner;

public class Maximum
 {
    public static void main(String[] args)
	{
        Scanner scanner = new Scanner(System.in);

        // Taking three numbers as input
        System.out.print("Enter value of a: ");
        int a = scanner.nextInt();

        System.out.print("Enter value of s: ");
        int s = scanner.nextInt();

        System.out.print("Enter value of k: ");
        int k = scanner.nextInt();

        int max;

        // Using nested if statements to find the maximum number
        if (a>=s) 
		{
            if (a>=k) 
			{
                max = a;
            }
			else
			{
                max =k;
            }
        } else
			{
				if (s>=k)
				{
					max =k;
				} 
				else 
				{
					max =k;
				}
			}

        // Printing the maximum number
        System.out.println("The maximum number is: " + max);

        scanner.close();
    }
}