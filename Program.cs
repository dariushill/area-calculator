
using System.Formats.Asn1;

Console.WriteLine("what shape would you like to find the area of? Please enter 'r' for rectangle or any other key for circle");

string answer = Console.ReadLine();

if( answer == "r") {
    float width;
    float length;
    float area;
    Console.WriteLine("What is the width of the rectangle: ");
    width = float.Parse(Console.ReadLine());
    System.Console.WriteLine("What is the length of the rectangle: ");
    length = float.Parse(Console.ReadLine());

    area = width * length;

    Console.WriteLine("The area of the rectangle is: " + area);

} else if( answer != "r") {
    double area;
    double radius;

    Console.WriteLine("What is the radius of the circle: ");
    radius = double.Parse(Console.ReadLine());
    area = Math.PI * (radius * radius);

    Console.WriteLine(" the area of the circle is: " + area);
}