namespace UserRegestrationUsingRegex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            string firstName = "Prachi";
           
            if (Pattern.ValidateString(firstName))
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