using System;

class Car
{
    public string colour;
    public string brand;
    public long license_no;

    public Car ( string _brand, string _colour, long _license_no)
    {
        brand = _brand;
        colour = _colour;
        license_no = _license_no;
    }

    public void Print ()
    {
        Console.WriteLine("Car's brand: " + brand);
        Console.WriteLine("Colour of the car: " + colour);
        Console.WriteLine("License no: " + license_no);
        Console.WriteLine("--------------------");
    }
}

class Program
{
    static void Main ()
    {
        Car car1 = new Car ("Honda","Red",28509471);
        car1.Print();

        Car car2 = new Car ("Skoda","Black",3877945);
        car2.Print();

        Car car3 = new Car ("Toyota","Brown",74698812);
        car3.Print();
       
        Car car4 = new Car ("BMW","Black",97023004);
        car4.Print();

        Car car5 = new Car ("Ford","Blue",42897100);
        car5.Print();
    }
}
