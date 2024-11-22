using System;

class Movie
{
    public string name;
    public int year;
    public string duration;
    
    public Movie()
    {
        this.name = "Unknown";
        this.year = 00;
        this.duration = "Unknown";
    }
    
    public Movie(string name)
    {
       this.name = name;
       this.year = 00;
       this.duration = "Unknown";
    }
    
    public Movie(string name,int year,string duration)
    
    {
        this.name = name;
        this.year = year;
        this.duration = duration;
    }
    
    public void Show()
    {
        Console.WriteLine("Movie's name: " + name);
        Console.WriteLine("Movie's release year: " + year);
        Console.WriteLine("Movie's duration: " + duration);
        Console.WriteLine("\n");
    }
    
}
class Program
{
    static void Main()
    {
        Movie movie1 = new Movie();
        movie1.Show();
        Movie movie2 = new Movie("PK",2009,"");
        movie2.Show();
        Movie movie3 = new Movie("life of pi",2003,"2 hour 35 min");
        movie3.Show();
        Movie movie4 = new Movie("3 idiots",2005,"2 hour 40 min");
        movie4.Show();
    }
}
