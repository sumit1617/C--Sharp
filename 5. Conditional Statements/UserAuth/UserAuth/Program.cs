namespace UserAuth
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String username = "sumit";
            String password = "123456";

            if(username.Equals("sumit") && password.Equals("123456")){
                Console.WriteLine("User authentication succeed");
            }
            else
            {
                Console.WriteLine("User authenication failed");
            }
        }
    }
}
