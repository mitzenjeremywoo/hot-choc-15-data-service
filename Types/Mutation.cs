using System.Threading.Tasks;
using Accounts.Types;

public class Mutation
{
    public async Task<User> AddUser(UserRepository repository, User user)
    {
        return await repository.SaveUserAsync(user);
    }
}
