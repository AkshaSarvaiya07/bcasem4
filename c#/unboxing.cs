using System;
class uboxxing
{
    public static void Main()
    {
        int n=12;
        object obj=n;

        int i=(int)obj;
        
        Console.WriteLine("n value" +n);
        Console.WriteLine("obj value" +obj);
        Console.WriteLine(i);


    }
}