using GraphQLProject.Model;

namespace GraphQLProject.Interfaces
{
    public interface IMenuRepository
    {
        List<Menu> getAllMenu();

        Menu GetMenuById(int id);

        Menu AddMenu(Menu menu);
        Menu updateMenu(int id, Menu menu);

        void DeleteMenu(int id);

    }
}
