namespace UserRegestrationUsingRegex
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Hello, World!");
            Pattern pattern = new Pattern();
            if (pattern.validatePhoneNumber("91 7894561235ff"))
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