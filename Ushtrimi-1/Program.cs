internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter your Array Size: ");
        int ArraySize=int.Parse(Console.ReadLine());

        int[]Numbers = new int[ArraySize];

        for (int i = 0; i < ArraySize; i++)
        {
            Console.WriteLine("Type a Number: ");
            int TypedNumbers=int.Parse(Console.ReadLine());
            Numbers[i] = TypedNumbers;
        }

 
       Program p =new Program();
       Console.WriteLine( "Numri me i vogel eshte : " + p.Min(Numbers));
    }

    public int Min(int[] numbers)
    {
        int a = numbers[0];
        for (int i = 1;i<numbers.Length; i++)
        {
            
            if (numbers[i]<a)
            {
                 a = numbers[i];
            }
        }
        return a;
    }
}