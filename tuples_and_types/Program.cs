namespace tuples_and_types;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, tuples and types!");
        var pt = (X: 1, Y: 2);
        var slope = (double)pt.X / (double)pt.Y;
        Console.WriteLine($"The line from origin to point {pt} has a slope of {slope}");

        pt.X = pt.X + 5;
        slope = (double)pt.X / (double)pt.Y;
        Console.WriteLine($"The point is now at {pt}. and the slope is {slope}.");

        var pt2 = pt with { Y = 10 };
        Console.WriteLine($"At this point 'pt2' is now at {pt2}.");
        Console.WriteLine($"And the initial 'pt' is at {pt}");
        
        var subscript = (A: 0, B: 0);
        subscript = pt;
        Console.WriteLine(subscript);
        
        var namedData = (Name: "Morning observation", Temp: 17, Wind: 4);
        var person = (FirstName: "", LastName: "");
        var order = (Product: "guitar picks", style: "triangle", quantity: 500, UnitPrice: 0.10m);

    }
}