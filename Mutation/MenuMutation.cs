using GraphQL;
using GraphQL.Types;
using GraphQLProject.Interfaces;
using GraphQLProject.Model;
using GraphQLProject.Type;

namespace GraphQLProject.Mutation
{
    public class MenuMutation :ObjectGraphType
    {
        public MenuMutation(IMenuRepository menuRepository)
        {

            Field<MenuType>("CraeteMenu").Arguments(new QueryArguments(new QueryArgument<MenuInputType> { Name = "menu" })).Resolve(context =>
                {
                    return menuRepository.AddMenu(context.GetArgument<Menu>("menu"));
                });

            Field<MenuType>("UpdateMenu").Arguments(new QueryArguments(new QueryArgument<MenuInputType> { Name = "menu" }, new QueryArgument<IntGraphType> { Name = "menuId" })).Resolve(context =>
            {
                return menuRepository.updateMenu(context.GetArgument<int>("menuId"), context.GetArgument<Menu>("menu"));
            });
            Field<StringGraphType>("DeleteMenu").Arguments(new QueryArguments(new QueryArgument<IntGraphType> { Name = "menuId" })).Resolve(context =>
            {
                 menuRepository.DeleteMenu(context.GetArgument<int>("menuId"));
                return "ok";
            });


        }
    }
}
