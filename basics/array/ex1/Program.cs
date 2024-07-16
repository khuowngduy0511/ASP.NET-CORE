namespace ex1;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter number of rows: ");
        int n = int.Parse(Console.ReadLine());

        int[,] pascalTriangle = new int[n, n];

        for (int i = 0; i < n; i++)
        {
            pascalTriangle[i, 0] = 1;
        }

        for (int i = 1; i < n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                pascalTriangle[i, j] = pascalTriangle[i - 1, j - 1] + pascalTriangle[i - 1, j];
            }
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                Console.Write(" ");
            }
            
            for (int j = 0; j <= i; j++)
            {
                Console.Write(pascalTriangle[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}