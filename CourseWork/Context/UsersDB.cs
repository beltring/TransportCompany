using System;
using System.Linq;
using System.Windows.Forms;

namespace CourseWork.Context
{
    public class UsersDB
    {
        public static void AddUser(string login, string password)
        {
            try
            {
                using (TransportCompanyContext db = new TransportCompanyContext())
                {
                    User newUser = new User { Login = login, Password = password };
                    db.Users.Add(newUser);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void UpdateFavourites(string cargoId, string login)
        {
            try
            {
                using (TransportCompanyContext db = new TransportCompanyContext())
                {
                    var users = db.Users.ToList();
                    foreach (var user in users)
                    {
                        if(user.Login == login)
                        {
                            user.CargoId = cargoId;
                        }
                    }

                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static string SelectCargoId(string login)
        {
            string result = null;
            try
            {
                using (TransportCompanyContext db = new TransportCompanyContext())
                {
                    var users = db.Users.ToList();
                    foreach (var user in users)
                    {
                        if (user.Login == login)
                        {
                            result = user.CargoId;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }

        public static bool CheckUserInDB(string login)
        {
            try
            {
                using (TransportCompanyContext db = new TransportCompanyContext())
                {
                    var users = db.Users.ToList();
                    foreach (var user in users)
                    {
                        if (user.Login == login)
                        {
                            return false;
                        }
                    }
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
