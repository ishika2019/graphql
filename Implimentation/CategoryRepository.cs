using GraphQLProject.Data;
using GraphQLProject.Interfaces;
using GraphQLProject.Model;

namespace GraphQLProject.Implimentation
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext appDbContext;

        public CategoryRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public Category AddCategory(Category category)
        {
            appDbContext.categories.Add(category);
            appDbContext.SaveChanges();
            return category;
        }

        public void DeleteCategory(int id)
        {
            var category = appDbContext.categories.FirstOrDefault(c => c.Id == id);
            appDbContext.categories.Remove(category);
            appDbContext.SaveChanges();

        }

        public List<Category> getAllCategory()
        {
            return appDbContext.categories.ToList();    
        }

        public Category GetCategoryById(int id)
        {
            return appDbContext.categories.Find(id);
        }

        public Category updateCategory(int id, Category category)
        {
            appDbContext.categories.Update(category);
            appDbContext.SaveChanges();
            return category;
        }
    }
}
