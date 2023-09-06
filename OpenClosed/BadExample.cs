// /*
//     Open Closed principen - Dåligt Exempel

//     I detta program kan vi skapa olika former, och sedan skriva ut deras area.
//     Detta är ett exempel på dålig kod, eftersom vi måste ändra på koden i metoden PrintArea() 
//     varje gång vi lägger till en ny form.

//     Dessutom kan vi tänka på Single Responsibility principen. PrintArea kanske inte ska räkna ut areor?
// */


// public class Rectangle
// {
//     public double Width { get; set; }
//     public double Height { get; set; }
// }

// public class Circle
// {
//     public double Radius { get; set; }
// }

// public class AreaPrinter
// {
//     public void PrintArea(object shape)
//     {
//         double area = 0;
//         if (shape is Rectangle rectangle)
//         {
//             area = CalculateRectangleArea(rectangle);
//         }
//         else if (shape is Circle circle)
//         {
//             area = CalculateCircleArea(circle);
//         }
//         else
//         {
//             throw new ArgumentException("Invalid shape type");
//         }
//         Console.WriteLine(area);
//     }

//     private double CalculateRectangleArea(Rectangle rectangle)
//     {
//         return rectangle.Width * rectangle.Height;
//     }
//     private double CalculateCircleArea(Circle circle)
//     {
//         return Math.PI * circle.Radius * circle.Radius;
//     }

// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         Rectangle rectangle = new Rectangle
//         {
//             Width = 10,
//             Height = 5
//         };

//         Circle circle = new Circle
//         {
//             Radius = 5
//         };

//         AreaPrinter areaPrinter = new AreaPrinter();
//         areaPrinter.PrintArea(rectangle);
//         areaPrinter.PrintArea(circle);
//     }
// }



