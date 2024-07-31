

using GraphQLProject.Mutation;
using GraphQLProject.Query;

namespace GraphQLProject.Schema
{
    public class rootSchema: GraphQL.Types.Schema
    {
        public rootSchema(IServiceProvider serviceProvider):base(serviceProvider) 
        {
            Query = serviceProvider.GetRequiredService<RootQuery>();
            Mutation=serviceProvider.GetRequiredService<RootMutation>();
        }
    }
}
