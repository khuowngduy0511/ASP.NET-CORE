namespace Ex_1;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter rows: ");
        int rows = int.Parse(Console.ReadLine());
         for(int i = 1; i <= rows; ++i){
            for(int j = 1; j <= i; ++j){
                Console.Write("a");
                if(j != i ){
                    Console.Write(" ");
                }
         }
            if(i != rows){
                Console.Write("\n");
            }
        }
    }
}