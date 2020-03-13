using System;
using GraphQL;
using GraphQL.Types;

namespace DotNetGraphQl
{
    public class UserQuery : ObjectGraphType
    {
        readonly UserRepository UserRepo = new UserRepository();

        public UserQuery()
        {
            Field<ListGraphType<UserType>>("users",
                            resolve: context =>
                            {
                                return UserRepo.GetAllUsers();
                            });

            Field<UserType>("user",
                            arguments: new QueryArguments(
                                new QueryArgument(typeof(IdGraphType)) { Name = "id" }
                            ),
                            resolve: context =>
                            {
                                var id = context.GetArgument<Guid>("id");
                                return UserRepo.GetUserById(id);
                            });
        }
    }
}