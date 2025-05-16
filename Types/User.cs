using System;

namespace Accounts.Types
{
    public record User(int Id, string Name, string Username);

    public record EndUser(int Id, string Name, string Username);

    public record PowerUser(int Id, string Name, string Username);
}