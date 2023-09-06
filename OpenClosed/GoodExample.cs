/*
    Open Closed principen - Bra Exempel

    I detta program kan vi skapa olika former, och sedan skriva ut deras area.
    I detta exempel behöver vi inte ändra på koden i metoden PrintArea() om vi vill beräkna arean på en ny form.
    Vill vi lägga till en ny form lägger vi helt enkelt till en ny klass. 

    Interfacet IShape ser till att vi är öppna för att lägga till fler form (klasser), utan att påverka PrintArea().

    Nu tar varje form dessutom hand om sin egen area.
*/

public interface IShape
{
    double Area();
}


public class Triangle : IShape
{

}
public class Rectangle : IShape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public double Area()
    {
        return Width * Height;
    }
}

public class Circle : IShape
{
    public double Radius { get; set; }

    public double Area()
    {
        return Math.PI * Radius * Radius;
    }
}

public class AreaPrinter
{
    public void PrintArea(IShape shape)
    {
        Console.WriteLine(shape.Area());
    }
}

class Program
{
    static void Main(string[] args)
    {
        AreaPrinter printer = new AreaPrinter();
        Circle circle = new Circle()
        {
            Radius = 5
        };
        Rectangle rectangle = new Rectangle()
        {
            Width = 10,
            Height = 5
        };

        printer.PrintArea(circle);
        printer.PrintArea(rectangle);
    }
}