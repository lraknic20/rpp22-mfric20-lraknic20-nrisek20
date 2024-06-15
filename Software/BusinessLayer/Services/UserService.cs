using DataAccessLayer;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    // Autor: nrisek
    public class UserService
    {
        private int generatedCode;
        public User GetUser(string username, string password)
        {
            using (var repo = new UserRepository())
            {
                List<User> user = repo.GetUser(username, password).ToList();
                if(user.Count > 0) return user[0];
                return null;
            }
        }

        public User GetUser(string _username)
        {
            using (var repo = new UserRepository())
            {
                List<User> user = repo.GetUser(_username).ToList();
                if (user.Count > 0) return user[0];
                return null;
            }
        }

        public int CheckUser(string _email, string _username)
        {
            using (var repo = new UserRepository())
            {
                List<User> userByEmail = repo.GetUserByEmail(_email).ToList();
                if (userByEmail.Count > 0) return 1;
                List<User> userByUsername = repo.GetUserByUsername(_username).ToList();
                if (userByUsername.Count > 0) return 2;
                return 0;
            }
        }

        public bool CreateUserAccount(User _newUser)
        {
            using (var repo = new UserRepository())
            {
                int affectedRows = repo.CreateUser(_newUser);
                return affectedRows > 0;
            }
        }

        public bool SaveUserData(User _editedUser)
        {
            using (var repo = new UserRepository())
            {
                int affectedRows = repo.UpdateUser(_editedUser);
                return affectedRows > 0;
            }
        }

        public bool SendWelcomeMail(string email)
        {
            var subject = "Winatječaj - Dobrodošli";
            var body = "Dobrodošli na sustav Winatječaj! Molimo Vas, pričekajte da se Vaš korisnički račun odobri kako biste se mogli prijaviti u sustav. Hvala na razumijevanju.";
            try
            {
                MailMessage msg = new MailMessage("winatjecaj@gmail.com", email);
                msg.Subject = subject;
                msg.Body = body;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;

                NetworkCredential nc = new NetworkCredential("winatjecaj@gmail.com", "wonj iqig csfc ucai");
                smtp.Credentials = nc;
                smtp.EnableSsl = true;
                smtp.Send(msg);

                return true;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public bool SendCode(User _user)
        {
            generatedCode = GenerateCode();
            var subject = "Winatječaj - Kod za prijavu";
            var body = "Vaš kod za prijavu: " + generatedCode;
            try
            {
                MailMessage msg = new MailMessage("winatjecaj@gmail.com", _user.email);
                msg.Subject = subject;
                msg.Body = body;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;

                NetworkCredential nc = new NetworkCredential("winatjecaj@gmail.com", "wonj iqig csfc ucai");
                smtp.Credentials = nc;
                smtp.EnableSsl = true;
                smtp.Send(msg);

                return true;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        private int GenerateCode()
        {
            Random random = new Random();
            return random.Next(100000, 1000000);
        }

        public bool CheckCode(int _code)
        {
            return generatedCode == _code ? true : false;
        }

        public bool SendEmailToAdmin(User newUser)
        {
            //var admin = GetUser("iadminovic");
            var subject = "Winatječaj - Nova registracija";
            var body = "Kreiran je novi korisnički račun s korisničkim imenom "+newUser.username+" i email adresom "+newUser.email;
            try
            {
                MailMessage msg = new MailMessage("winatjecaj@gmail.com", "ivan.admi123@gmail.com");
                msg.Subject = subject;
                msg.Body = body;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;

                NetworkCredential nc = new NetworkCredential("winatjecaj@gmail.com", "wonj iqig csfc ucai");
                smtp.Credentials = nc;
                smtp.EnableSsl = true;
                smtp.Send(msg);

                return true;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public List<User> GetDeactivatedAccounts()
        {
            using (var repo = new UserRepository())
            {
                List<User> deactivatedAccounts = repo.GetDeactivatedAccounts().ToList();
                return deactivatedAccounts;
            }
        }

        public bool ActivateAccount(User account)
        {
            using (var repo = new UserRepository())
            {
                int affectedRows = repo.ActivateAccount(account);
                return affectedRows > 0;
            }
        }

        public bool SendEmail(User account, string subject, string body)
        {
            try
            {
                MailMessage msg = new MailMessage("winatjecaj@gmail.com", account.email);
                msg.Subject = subject;
                msg.Body = body;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;

                NetworkCredential nc = new NetworkCredential("winatjecaj@gmail.com", "wonj iqig csfc ucai");
                smtp.Credentials = nc;
                smtp.EnableSsl = true;
                smtp.Send(msg);

                return true;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }
    }
}
