namespace Regix_problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Problems Statement Using REGEX");
            UsersValidation userValidation = new UsersValidation();
            Console.WriteLine("Enter The First Name: ");
            string firstname = Console.ReadLine();
            userValidation.ValidationFirstName(firstname);

            Console.WriteLine("Enter The Last Name: ");
            string lastname = Console.ReadLine();
            userValidation.ValidationLastName(lastname);

            Console.WriteLine("Enter Email: ");
            string email = Console.ReadLine();
            userValidation.ValidationFirstName(email);
        }
    }
}