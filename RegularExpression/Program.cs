// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;

public class Program
{
    public static void Main(String[]args)
    {
        Console.WriteLine("Regular Exprassion");

        // For a First Name Validation

        Console.Write("Enter First Name:");
        var name = Console.ReadLine();
        String fnamePattern = "^[A-Z][a-z]{3,}$";
        Regex reg = new Regex(fnamePattern);

        if (reg.IsMatch(name))
        {
            Console.WriteLine("Valid");
        }
        else
        {
            Console.WriteLine("Not Valid");
        }


        // For Last Name Validation
        Console.Write("Enter Last Name:");
        var Lname = Console.ReadLine();
        String LnamePattern = "^[A-Z][a-z]{3,}$";
        Regex reg2 = new Regex(LnamePattern);
        if (reg2.IsMatch(Lname))
        {
            Console.WriteLine("Valid");
        }
        else
        {
            Console.WriteLine("Not Valid");
        }

        // For Email Validation
        Console.Write("Enter Email:");
        var email = Console.ReadLine();
        String emailPattern = "^abc.[A-Za-z]{3}@bl.co.[a-zA-Z]{3}$";
        Regex reg3 = new Regex(emailPattern);
        if (reg3.IsMatch(email))
        {
            Console.WriteLine("valid");
        }
        else
        {
            Console.WriteLine("Not Valid");
        }

        // For Phone Number Validation
        Console.Write("Enter Phone Number:");
        var Pho = Console.ReadLine();
        String PhoPattern = "^91[ ][7-9]{2}[0-9]{8}$";
        Regex reg4 = new Regex(PhoPattern);
        if (reg4.IsMatch(Pho))
        {
            Console.WriteLine("valid");
        }
        else
        {
            Console.WriteLine("Not Valid");
        }

        // For Password Validation
        Console.Write("Enter a Password:");
        var Pass = Console.ReadLine();
        String PassPattern = "^((?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%]).{8,})$";
        /*
          (?=.*[0-9])   :   must contains one digit from 0-9
          (?=.*[a-z])   :   must contains one lowercase characters
          (?=.*[A-Z])   :   must contains one uppercase characters
          (?=.*[@#$%])  :   must contains one special symbols in the list "@#$%"
        */

        Regex reg5 = new Regex(PassPattern);
        if (reg5.IsMatch(Pass))
        {
            Console.WriteLine("valid");
        }
        else
        {
            Console.WriteLine("Not Valid");
        }
    }
}
