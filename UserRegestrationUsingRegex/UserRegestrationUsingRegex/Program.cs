namespace UserRegestrationUsingRegex
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Hello, World!");
            Pattern pattern = new Pattern();
            if (pattern.validatePassword("Prachiii1234&"))
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }

           
        }

    }
}