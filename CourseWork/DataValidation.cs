using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{
    public class DataValidation
    {
        /*public static bool CheckEmptyFields(string str1,string str2, string str3)
        {
            if(str1.Length != 0 && str2.Length != 0 && str3.Length != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool CheckEmptyFields(string str1, string str2)
        {
            if (str1.Length != 0 && str2.Length != 0)
            {
                return true;
            }
            else {
                return false;
            }
        }*/
        public static bool CheckEmptyFields(params string[] fields)
        {
            foreach (string str in fields)
            {
                if (str.Length == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static bool CheckLenghtPassword(string password)
        {
            if(password.Length >= 6 && password.Length <= 25)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool CheckLenghtLogin(string login)
        {
            if(login.Length >= 4 && login.Length <= 25)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool CheckPasswordMatch(string password1, string password2)
        {
            if (password1.Equals(password2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool CheckNegativeNumber(params int[] fields)
        {
            foreach(int number in fields)
            {
                if(number < 1)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
