using System;

namespace Accounts.Types
{
    public record User(int Id, string Name, DateTime Birthdate, string Username);
}