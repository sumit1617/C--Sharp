namespace WhileLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 1;

            // Exit when x becomes greater than 4
            while (x <= 10)
            {
                Console.WriteLine(x);

                // Increment the value of x for
                // next iteration
                x++;
            }
        }
    }
}
