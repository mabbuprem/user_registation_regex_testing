using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserRegistrationRegex
{
    public class Program
    {
        static void Main(string[] args)
        {
            string chooseOptionForEnteringUserDetails = string.Empty;
            List<UserDetails> usersList = new List<UserDetails>();
            do
            {
                UserDetails userDetails = new UserDetails();
                userDetails.ContactDetails();
                usersList.Add(userDetails);
                Console.WriteLine("Do you want to enter more users details? \n\"Y\" or \"N\"");
                chooseOptionForEnteringUserDetails = Console.ReadLine();
            } while (chooseOptionForEnteringUserDetails.ToUpper() != "N");
        }
    }
}
