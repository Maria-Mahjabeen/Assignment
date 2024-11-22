using System;

class Program
{
    static void Main()
    {
        Show ("hello world");
        Show (123);
        Show ('M');
    }
    static void Show(string S )
    {
        Console.WriteLine("the text is: " + S);
    }
    static void Show(int num)
    {
        Console.WriteLine("the number is: " + num);
    }
    static void Show(char m)
    {
        Console.WriteLine("the character is: " + m);
    }
}
