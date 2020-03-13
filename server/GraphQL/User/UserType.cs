using GraphQL.Types;

namespace DotNetGraphQl
{
    public class UserType : ObjectGraphType<User>
    {
        public UserType()
        {
            Name = "User";

            Field(c => c.Id, type: typeof(GuidGraphType)).Description("User Id");
            Field(c => c.Name).Description("User Full Name");
            Field(c => c.Email).Description("User Email");
            Field(c => c.LoginName).Description("Alias to access the App");
        }
    }
}