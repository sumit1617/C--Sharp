namespace BinaryOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5, b;
            b = a++;
            Console.WriteLine("Post Increment: a={0} and b={1}",a,b);

            int c = 5,d;
            d = ++c;
            Console.WriteLine("Pre Increment: c={0} and d={1}",c,d);

            int e = 5,f;
            f = e--;
            Console.WriteLine("Post Decrement: e={0} and f={1}", e, f);

            int g = 5,h;
            h = --g;
            Console.WriteLine("Pre Decrement: g={0} and h={1}",g,h);
        }
    }
}
