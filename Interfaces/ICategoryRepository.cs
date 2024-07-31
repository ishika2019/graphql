using GraphQLProject.Model;

namespace GraphQLProject.Interfaces
{
    public interface ICategoryRepository
    {
        List<Category> getAllCategory();

       Category GetCategoryById(int id);

        Category AddCategory(Category category);
        Category updateCategory(int id, Category category);

        void DeleteCategory(int id);

    }
}
