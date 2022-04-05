using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationRegex
{
    public class UserDetails
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string phoneNo { get; set; }
        public string password { get; set; }

        public void ContactDetails()
        {
            User_Registration_Regex user_Registration_Regex = new User_Registration_Regex();
            Console.Write("Enter first name: ");
            firstName = Console.ReadLine();
            Console.WriteLine(user_Registration_Regex.ValidatefirstName(firstName));
            Console.Write("Enter last name: ");
            lastName = Console.ReadLine();
            Console.WriteLine(user_Registration_Regex.ValidatelastName(lastName));
            Console.Write("Enter email: ");
            email = Console.ReadLine();
            Console.WriteLine(user_Registration_Regex.ValidateEmail(email));
            Console.Write("Enter Phone No: ");
            phoneNo = Console.ReadLine();
            Console.WriteLine(user_Registration_Regex.ValidateMobileNo(phoneNo));
            Console.Write("Enter password: ");
            password = Console.ReadLine();
            Console.WriteLine(user_Registration_Regex.ValidatePassword(password));
        }
    }
}
