using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace UserRegistrationRegex
{
    public class Program
    {
        #region Taking Inputs from Console & Storing them on the list.
        static void Main(string[] args)
        {
            string chooseOptionForEnteringUserDetails = string.Empty;
            List<UserDetails> usersList = new List<UserDetails>();
            do
            {
                UserDetails userDetails = new UserDetails();
                userDetails.ContactDetailsTakenFromConsole();
                usersList.Add(userDetails);
                Console.WriteLine("Do you want to enter more users details? \n\"Y\" or \"N\"");
                chooseOptionForEnteringUserDetails = Console.ReadLine();
            } while (chooseOptionForEnteringUserDetails.ToUpper() != "N");
        }
        #endregion
    }
}
