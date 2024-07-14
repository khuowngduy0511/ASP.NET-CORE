namespace Ex_2;

class Program
{
    static void Main(string[] args)
    {
        int first = 0, second = 1, fibonacci;
        string ans = "";
        Console.Write("Enter the number of the range : ");
        int range = int.Parse(Console.ReadLine());

        for(int i = 0; i <= range; i++){
            
            if(i <= 1){
                fibonacci = i;
                ans += fibonacci.ToString();
            } else{
                fibonacci = first + second;
                first = second;
                second = fibonacci;
                ans += fibonacci.ToString();
            }

            if(i != (range - 1)){
                ans += " ";
            }
        }

        Console.WriteLine("Fibonacci Series upto {0} Terms: {1}",range, ans );
    }
}
