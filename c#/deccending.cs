using System;
class my
{
    public static void Main()
    {
        int a;
        Console.Write("enter a value:");
        a=Convert.ToInt32(Console.ReadLine());
        
        while(a>=1)
        {
            Console.Write(a +"\n");
            a--;
        }
        Console.Read();
    }
}
