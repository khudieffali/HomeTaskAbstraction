using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskAbstraction
{
    internal class User:IAccount
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public User(string fullName,string email,string password) 
        {
            FullName= fullName;
            Email = email;
            Password= password;
        }

        public bool PasswordChecker(string password)
        {
            int upperCount = 0;
            int lowerCount = 0;
            int digitCount = 0;
            if (Password.Length > 7)
            {
                foreach (var item in password)
                {
                    if (char.IsUpper(item)) upperCount++;
                    else if (char.IsLower(item)) lowerCount++;
                    else if(char.IsDigit(item)) digitCount++;
                }
                if(upperCount > 0 && lowerCount>0 && digitCount>0) return true;
            }
            else
            {
                Console.WriteLine("Parolun uzunlugu 7 den kicikdir");
            }
            return false;
        }

        public void ShowInfo()
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Ad,Soyad - "+FullName+"\n"+"Email - " +Email);
        }
    }
}
