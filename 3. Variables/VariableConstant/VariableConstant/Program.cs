namespace VariableConstant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a; //variable declaration
            a = 10; //intializing value to variable
            Console.WriteLine(a);

            int b = 20;
            b = 30; //changig the value of existing variable
            Console.WriteLine(b);

            const double pi = 3.14159; 
            //pi = 3.142 we can't the change the value of constant variable
            Console.WriteLine(pi);

            Console.WriteLine(100 + 200); // Literals
        }
    }
}
