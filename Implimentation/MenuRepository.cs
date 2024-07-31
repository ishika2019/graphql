using GraphQLProject.Data;
using GraphQLProject.Interfaces;
using GraphQLProject.Model;

namespace GraphQLProject.Implimentation
{
    public class MenuRepository : IMenuRepository
    {
        private readonly AppDbContext appDbContext;

        public MenuRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public Menu AddMenu(Menu menu)
        {
           appDbContext.menus.Add(menu);
            appDbContext.SaveChanges();
            return menu;
        }

        public void DeleteMenu(int id)
        {
            var result= appDbContext.menus.Find(id);
            appDbContext.menus.Remove(result);
            appDbContext.SaveChanges();
        }

        public List<Menu> getAllMenu()
        {
            return appDbContext.menus.ToList();
        }

        public Menu GetMenuById(int id)
        {
            return appDbContext.menus.Find(id);
        }

        public Menu updateMenu(int id, Menu menu)
        {
           appDbContext.menus.Update(menu);
            appDbContext.SaveChanges();
            return menu;
        }
    }
}
