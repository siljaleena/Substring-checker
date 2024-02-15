namespace Substring_checker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //asks the user for the main string
            Console.WriteLine("Check whether a given substring is present in the given string");
            Console.Write("Write the string: ");
            //stores the users answer in 'main'
            string main = Console.ReadLine();
            //asks the user for the substring
            Console.Write("Write the substring to search: ");
            //stores the users answer in 'sub'
            string sub = Console.ReadLine();

            //calls the 'Checker' method to determine if the substring is present in the main string
            bool substringPresent = Checker(main, sub);
                //displays the result based on whether the substring is present or not
                if (substringPresent)
                {
                    Console.WriteLine($"'{sub}' is present in the given string '{main}'.");
                }
                else
                {
                    Console.WriteLine($"'{sub}' is not present in the string '{main}'.");
                } 
            
            //this is the method that gets called
            bool Checker(string main, string sub)
            {
                //uses the 'Contains' method of the string class to check if the substring is present in the main string
                return main.Contains(sub);
            }
        }
    }
}