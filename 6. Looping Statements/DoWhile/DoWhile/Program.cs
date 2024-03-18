namespace DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 18;
            do
            {
                // The line will be printed even
                // if the condition is false
                Console.WriteLine("hello sumit");
                x++;
            }
            while (x < 20);
        }
    }
    }

