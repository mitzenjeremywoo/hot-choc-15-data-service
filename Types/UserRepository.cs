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

            _users = _context.Users.ToDictionary(t => t.Id);
        }

        public User GetUser(int id) => _users[id];

        public IEnumerable<User> GetUsers() => _users.Values;

        public IEnumerable<PowerUser> GetPowerUsers() => new PowerUser[]
        {
            new PowerUser(_users[0].Id, _users[0].Username, "")
        };

        public async Task<User> SaveUserAsync(User user)
        {
            //var user = new User(id, name, DateTime.Now, username);
            _context.Users.Add(user);
            _context.SaveChanges();
            return user;
        }
    }
}