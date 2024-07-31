using GraphQL;
using GraphQL.Types;
using GraphQLProject.Interfaces;
using GraphQLProject.Type;

namespace GraphQLProject.Query
{
    public class CategoryQuery: ObjectGraphType
    {
        public CategoryQuery(ICategoryRepository categoryRepository)
        {

            Field<ListGraphType<CategoryType>>("categories").Resolve(context =>
            {
                return categoryRepository.getAllCategory();
            }
            );


            Field<ListGraphType<CategoryType>>("category").Arguments(new QueryArguments(new QueryArgument<IntGraphType> { Name = "categoryId" })).Resolve(context =>
            {
                return categoryRepository.GetCategoryById(context.GetArgument<int>("categoryId"));
            }
           );


        }

    }
}
