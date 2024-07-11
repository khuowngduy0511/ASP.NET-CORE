namespace first_program;

class Program
{
    static void Main(string[] args)
    {
        //write to console
        Console.WriteLine("Please enter your name:");
        //read from console
        string name = Console.ReadLine();
        //write the string and additional argument to console
        Console.WriteLine("Hello, {0}", name);
        //keep program running till user clicks run
        Console.ReadLine();
    }
}
