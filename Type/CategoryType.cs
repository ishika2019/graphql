using GraphQL;
using GraphQL.Types;
using GraphQLProject.Implimentation;
using GraphQLProject.Interfaces;
using GraphQLProject.Model;

namespace GraphQLProject.Type
{
    public class CategoryType : ObjectGraphType<Category>
    {

        public CategoryType(IMenuRepository menuRepository)
        {
            Field(m => m.Id);
            Field(m => m.Name);
            Field(m => m.ImageUrl);

            Field<MenuType>("menu").Arguments(new QueryArguments(new QueryArgument<IntGraphType> { Name = "menuId" })).Resolve(context =>
            {
                return menuRepository.GetMenuById(context.GetArgument<int>("menuId"));
            });
            Field<ListGraphType<MenuType>>("menus").Resolve(context =>
            {
                return menuRepository.getAllMenu();
            });
        }
    }
}
