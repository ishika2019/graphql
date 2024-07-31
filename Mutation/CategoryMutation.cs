using GraphQL;
using GraphQL.Types;
using GraphQLProject.Interfaces;
using GraphQLProject.Model;
using GraphQLProject.Type;

namespace GraphQLProject.Mutation
{
    public class CategoryMutation :ObjectGraphType
    {
        public CategoryMutation(ICategoryRepository categoryRepository)
        {
            Field<CategoryType>("CreateCategory").Arguments(new QueryArguments(new QueryArgument<CategoryInputType> { Name = "Category" })).Resolve(context =>
            {
                return categoryRepository.AddCategory(context.GetArgument<Category>("Category"));
            });

            Field<CategoryType>("UpdateCategory").Arguments(new QueryArguments(new QueryArgument<MenuInputType> { Name = "Category" }, new QueryArgument<IntGraphType> { Name = "categoryId" })).Resolve(context =>
            {
                return categoryRepository.updateCategory(context.GetArgument<int>("categoryId"), context.GetArgument<Category>("Category"));
            });
            Field<StringGraphType>("DeleteMenu").Arguments(new QueryArguments(new QueryArgument<IntGraphType> { Name = "categoryId" })).Resolve(context =>
            {
               categoryRepository.DeleteCategory(context.GetArgument<int>("categoryId"));
                return "ok";
            });


        }
    }
}
