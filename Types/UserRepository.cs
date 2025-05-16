using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Accounts.Types
{
    public class UserRepository
    {
        private readonly Dictionary<int, User> _users;
        private UserContext _context;

        public UserRepository(UserContext context)
        {   
            _context = context;

            SeedDataAsync();

            _users = _context.Users.ToDictionary(t => t.Id);
        }

        public User GetUser(int id) => _users[id];

        public IEnumerable<User> GetUsers() => _users.Values;

        public IEnumerable<PowerUser> GetPowerUsers() => new PowerUser[]
        {
            new PowerUser(_users[0].Id, _users[0].Username, new DateTime(2015,11,22), "")
        }; 
        void SeedDataAsync()
        {
            if (!_context.Users.Any())
            {
                _context.Users.AddRange(
                    new User(1, "Jack", DateTime.Now, "Kai"),
                    new User(2, "Jack2", DateTime.Now, "Kai2")
                );
                _context.SaveChanges();
            }
        }
    }
}