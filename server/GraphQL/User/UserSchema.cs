using System;
using GraphQL.Types;
using GraphQL.Utilities;

namespace DotNetGraphQl
{
    public class UserSchema : Schema
    {
        public UserSchema(IServiceProvider provider) : base(provider)
        {
            Query = provider.GetRequiredService<UserQuery>();
            Mutation = provider.GetRequiredService<UserMutation>();
        }
    }
}