using System;
public class student
{
    int id;
    string name;
    public void fun()
    {
         id=102;
         name="iqra";
    }
     public static void Main()
        {

            student s1=new student();
            student s2=new student();

            
            s1.id=101;
            s1.name="aksha sarvaiya";
            Console.WriteLine(s1.id);
            Console.WriteLine(s1.name);
            s2.fun();
           Console.WriteLine(s2.id);
            Console.WriteLine(s2.name);
            Console.ReadLine();
        }
}       