using System.Linq;
using GraphQL.Server;
using GraphQL.Types;
using Microsoft.Extensions.DependencyInjection;

namespace DotNetGraphQl
{
    public static class GraphQLBuilderExtensions
    {
        public static IGraphQLBuilder AddGraphSchemas(this IGraphQLBuilder graphBuilder)
        {
            var types = typeof(GraphQLBuilderExtensions).Assembly
                                                        .GetTypes()
                                                        .Where(x => typeof(ISchema).IsAssignableFrom(x));

            foreach (var type in types)
            {
                graphBuilder.Services.AddSingleton(typeof(ISchema), type);
            }

            return graphBuilder;
        }
    }
}