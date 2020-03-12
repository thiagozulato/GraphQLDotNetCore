using GraphQL;
using GraphQL.Types;

namespace DotNetGraphQl
{
    public class UserMutation : ObjectGraphType
    {
        readonly UserRepository UserRepo = new UserRepository();

        public UserMutation()
        {
            Field<UserType>(
                "createUser",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<UserInputType>> { Name = "user" }
                ),
                resolve: context =>
                {
                    var user = context.GetArgument<User>("user");
                    return user;
                });
        }
    }
}