using System;

namespace Accounts.Types
{
    public record User(int Id, string Name, string Username, DateTime birthday);

    public record EndUser(int Id, string Name, string Username);

    public record PowerUser(int Id, string Name, string Username);
}