using GraphQL.Types;

namespace DotNetGraphQl
{
    public class UserInputType : InputObjectGraphType<User>
    {
        public UserInputType()
        {
            Name = "UserInput";

            Field(f => f.Name);
            Field(f => f.Email);
            Field(f => f.LoginName);
        }
    }
}