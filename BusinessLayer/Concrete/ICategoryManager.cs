using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public interface ICategoryManager
    {
        void CategoryAdd(Category category);
        void CategoryRemove(Category category);
        void CategoryUpdate(Category category);
        List<Category> GetAllCategories();
        Category GetById(int id);
    }
}