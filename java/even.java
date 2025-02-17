public class even
{
	public static void main(String[] args)
	{
		int sum=0;//for store the sum
		int num=2;//start for the even number
		
		while(num<=20)
		{
			sum+=num;
			num+=2;
		}
		System.out.println("sum of even number of 1to20:" +sum);
		
	}
}