using System.Collections.Generic;
using HotChocolate;
using HotChocolate.Types;
using HotChocolate.Types.Relay;

namespace Accounts.Types
{
    [QueryType]
    public class Query
    {
        public IEnumerable<User> GetUsers(UserRepository repository) =>
            repository.GetUsers();

        [NodeResolver]
        public User GetUser(int id, UserRepository repository) =>
            repository.GetUser(id);
        public IEnumerable<PowerUser> GetPowerUsers(UserRepository repository) =>
            repository.GetPowerUsers();
    }
}
