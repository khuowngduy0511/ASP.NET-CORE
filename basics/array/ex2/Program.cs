namespace ex2;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the size of the matrix: ");
        int n = int.Parse(Console.ReadLine());
        int[, ] matrix = new int[n, n];

        for(int i = 0; i < n; i++){
            for(int j = 0; j < n; j++){
                if(i == j){
                    matrix[i, j] = 0;
                }
                else if(i > j){
                    matrix[i, j] = -1;
                }
                else 
                    matrix[i, j] = 1;
            }
        }

        for(int i = 0; i < n; i++){
            for(int j = 0; j < n; j++){
                Console.Write(matrix[i, j] +" ");
            }
            Console.WriteLine();
        }
    }
}
