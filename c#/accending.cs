

using System;
class my
{
    public static void Main()
    {
        int b,a;
        Console.Write("enter a value:");
        a=Convert.ToInt32(Console.ReadLine());
        for(b=1;b<=a;b++)
        {
            Console.Write(b +"\n");
        }
        Console.Read();
    }
}