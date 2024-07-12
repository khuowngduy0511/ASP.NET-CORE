namespace operators;

class Program
{
    static void Main(string[] args)
    {
        double pi = 3.14159;
        Console.Write("Please enter a value for the radius: ");
        double r = double.Parse(Console.ReadLine());
        double area = pi*r*r;
        Console.WriteLine("The area of circle with radius " + r + " is " + area);
    }
}
