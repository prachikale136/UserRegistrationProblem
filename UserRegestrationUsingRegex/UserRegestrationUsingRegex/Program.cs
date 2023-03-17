namespace UserRegestrationUsingRegex
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Hello, World!");
            Pattern pattern = new Pattern();
            if (pattern.validateEmail("abc.xyz@bl.co.in"))
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