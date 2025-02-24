using System;
class cons
{
    int a;
    int b;
    public cons()
    {}
    public cons(int a,int b)
    {
        a=20;
        b=30;
    } 
    public static int sum(int a, int b)
    {
        return a+b;
    }
    public static void Main()
    {
        cons o1=new cons();
        cons o2=new cons(o1.a,o1.b);
        cons o3=new cons();
       int ans= o3.sum();
        Console.WriteLine("sum is: "+ans);
    }
}