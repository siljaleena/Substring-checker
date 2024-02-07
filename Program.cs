namespace Substring_checker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Check whether a given substring is present in the given string");

            Console.Write("Write the string: ");
            string main = Console.ReadLine();

            Console.Write("Write the substring to search: ");
            string sub = Console.ReadLine();

            bool substringPresent = Checker(main, sub);

                if (substringPresent)
                {
                    Console.WriteLine($"'{sub}' is present in the given string '{main}'.");
                }
                else
                {
                    Console.WriteLine($"'{sub}' is not present in the string '{main}'.");
                } 
            

            bool Checker(string main, string sub)
            {
                return main.Contains(sub);
            }
        }
    }
}