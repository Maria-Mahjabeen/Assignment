using System;

class Example 
{
    public string name;
    public int age;
    
    public Example (string name,int age)
    
    {
        this.name = name;
        this.age = age;
        
    }
    
    public Example (Example x)
    {
        name = x.name;
        age = x.age;
    }
    
    public void Print ()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
    }
}

    class Program
    {
        static void Main ()
        {
            Example e1 = new Example ("Mahjabeen",22);
            Example e2 = new Example (e1);
            e1.age = 32;//here,changing the value of object e1 does'n affect object e2
            e1.Print();
            e2.Print();
        }
    }












