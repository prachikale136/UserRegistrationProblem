namespace UserRegestrationUsingRegex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
           // string firstName = "Prachi";
            string lastName = "kale";
            if (Pattern.ValidateString(lastName))
            {
                Console.WriteLine("valid");
            }
            else
            {
                Console.WriteLine("invalid");
            }
            Console.ReadKey();




        }

    }
}