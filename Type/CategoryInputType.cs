using GraphQL.Types;

namespace GraphQLProject.Type
{
    public class CategoryInputType :ObjectGraphType
    {

        public CategoryInputType()
        {
            Field<IntGraphType>("Id");
            Field<StringGraphType>("Name");
            Field<StringGraphType>("ImageUrl");

        }

    }
}
