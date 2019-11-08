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
                if (str == "")
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

        public bool CheckDistance(int number)
        {
            bool result = false;
            if (number >= 1 && number <= 5000)
            {
                result = true;
            }
            return result;
        }

        public bool CheckDate(string date)
        {
            try {
                string[] dateArray = date.Split(' ', '.', '-', '/', ':');

                int dayInMonth;
                int dayNow = Convert.ToInt32(DateTime.Now.Day);
                int monthNow = Convert.ToInt32(DateTime.Now.Month);
                int yearNow = Convert.ToInt32(DateTime.Now.Year);
                int day = Convert.ToInt32(dateArray[0]);
                int month = Convert.ToInt32(dateArray[1]);
                int year = Convert.ToInt32(dateArray[2]);

                if (year == yearNow)
                {
                    if (month >= 1 && month <= 12 && month >= monthNow)
                    {
                        dayInMonth = Convert.ToInt32(DateTime.DaysInMonth(year, month));
                        if (day >= 1 && day <= dayInMonth && day >= dayNow)
                        {
                            return true;
                        }
                    }
                }
                else if (year > yearNow)
                {
                    if (month >= 1 && month <= 12)
                    {
                        dayInMonth = Convert.ToInt32(DateTime.DaysInMonth(year, month));
                        if (day >= 1 && day <= dayInMonth)
                        {
                            return true;
                        }
                    }
                }

                return false;
            }
            catch
            {
                return false;
            }
        }

    }
}
