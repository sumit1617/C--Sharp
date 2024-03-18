namespace SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string commandName = "start";

            switch (commandName)
            {
                case "start":
                    Console.WriteLine("Starting service...");
                    break;
                case "stop":
                    Console.WriteLine("Stopping service...");
                    break;
                default:
                    Console.WriteLine(String.Format("Unknown command: {0}", commandName));
                    break;
            }

        }
    }
}
