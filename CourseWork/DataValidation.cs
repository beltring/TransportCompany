using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{
    public class DataValidation
    {
        
        public bool CheckEmptyFields(params string[] fields)
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

        public bool CheckLenghtPassword(string password)
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

        public bool CheckLenghtLogin(string login)
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

        public bool CheckPasswordMatch(string password1, string password2)
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

        public bool CheckNegativeNumber(params int[] fields)
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

        public bool CheckCost(int number) {
            bool result = false;
            if(number >= 1 && number <= 10000)
            {
                result = true;
            }
            return result;
        }

        public bool CheckWeight(int number)
        {
            bool result = false;
            if (number >= 1 && number <= 38)
            {
                result = true;
            }
            return result;
        }
        public bool CheckVolume(int number)
        {
            bool result = false;
            if (number >= 1 && number <= 120)
            {
                result = true;
            }
            return result;
        }

    }
}
