using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Storage
    {
        public static bool AddPassword(string password, List<string> passwords)
        {
            bool IsValidPassword(string password)
            {
                bool IsNumber = password.Any(char.IsDigit);

                if (IsPrimeNumber(password)) { return true; }
                if (passwords.Contains(password)) { return false; }
                
                if (password == "admin" || password == "mod")
                {
                    return true;
                }
                if (!IsNumber || password.Contains('6')) { return false; }
                if (password.Contains(' '))
                {
                    return false;
                }
                if (password.Length < 7 || password.Length > 12)
                { return false;
                }
                if (password.Length>=7 && password.Length <12)
                {
                    return true;

                }
                int vowelsCount = password.Count(p => "AEIOUY".Contains(p));
                if (vowelsCount < 2) { return false; }
                
                return true;
                
            }
            bool IsPrimeNumber(string password)
            {
                if (password == "2") { return true; }
                if (!int.TryParse(password,out int num)||num<2||password.Contains("6"))
                {
                    return false;
                }
                if (num % 2 == 0) return false;
                for (int i =2;i<=Math.Sqrt(num);i++)
                {
                    if (num%i==0)
                    {
                        return false;
                    }

                }
                return true;
            }
            
            if (IsValidPassword(password))
            {
                passwords.Add(password);
                return true;
            }
            return false;
        }
        
    }
}
