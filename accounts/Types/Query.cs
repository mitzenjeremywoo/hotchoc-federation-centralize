using System.Collections.Generic;
using HotChocolate;
using HotChocolate.Types;
using HotChocolate.Types.Relay;

namespace Accounts.Types
{
    [QueryType]
    public class Query
    {        
        public IEnumerable<User> GetUsers([Service] UserRepository repository) =>
            repository.GetUsers();

        [NodeResolver]
        public User GetUser(int id, [Service] UserRepository repository) =>
            repository.GetUser(id);
    }
}