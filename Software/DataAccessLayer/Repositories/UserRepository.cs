using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataAccessLayer
{
    // Autor: nrisek
    public class UserRepository : IDisposable
    {
        private WinatjecajModel Context { get; set; }
        private DbSet<User> Entities { get; set; }

        public UserRepository()
        {
            Context = new WinatjecajModel();
            Entities = Context.Set<User>();
        }

        public IQueryable<User> GetUser(string username, string password)
        {
            var query = from u in Entities
                        where u.username == username && u.password == password
                        select u;
            return query;
        }

        public IQueryable<User> GetUser(string username)
        {
            var query = from u in Entities
                        where u.username == username
                        select u;
            return query;
        }

        public IQueryable<User> GetUserByEmail(string _email)
        {
            var query = from u in Entities
                        where u.email == _email
                        select u;
            return query;
        }

        public IQueryable<User> GetUserByUsername(string _username)
        {
            var query = from u in Entities
                        where u.username == _username
                        select u;
            return query;
        }

        public int CreateUser(User _newUser)
        {
            var role = Context.Roles.FirstOrDefault(r => r.id == _newUser.roles_id);
            User newUser = new User
            {
                oib = _newUser.oib,
                first_name = _newUser.first_name,
                last_name = _newUser.last_name,
                adress = _newUser.adress,
                phone = _newUser.phone,
                email = _newUser.email,
                username = _newUser.username,
                password = _newUser.password,
                roles_id = _newUser.roles_id, // 1 = korisnik, 2 = admin
                Role = role,
            };
            Entities.Add(newUser);
            return Context.SaveChanges();
        }

        public int UpdateUser(User _editedUser)
        {
            var loggedInUser = Context.Users.FirstOrDefault(u => u.username == _editedUser.username);
            Context.Users.Attach(loggedInUser);

            loggedInUser.first_name = _editedUser.first_name;
            loggedInUser.last_name = _editedUser.last_name;
            loggedInUser.adress = _editedUser.adress;
            loggedInUser.phone = _editedUser.phone;
            loggedInUser.password = _editedUser.password;
            
            return Context.SaveChanges();
        }

        public IQueryable<User> GetDeactivatedAccounts()
        {
            var query = from u in Entities
                        where u.roles_id == 6
                        select u;
            return query;
        }

        public void Dispose()
        {
            Context.Dispose();
        }

        public int ActivateAccount(User _account)
        {
            var account = Context.Users.FirstOrDefault(u => u.username == _account.username);
            Context.Users.Attach(account);

            account.roles_id = 1;

            return Context.SaveChanges();
        }
    }
}
