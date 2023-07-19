using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFrameWork;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
     public class CategoryManager : ICategoryService
    {
        ICategotyDal categotyDal;
        public CategoryManager(ICategotyDal categoty)
        {
            categotyDal= categoty;
        }
        public void CategoryAdd(Category category)
        {
            categotyDal.Insert(category);
        }

        public void CategoryRemove(Category category)
        {

            categotyDal.Delete(category);

        }

        public void CategoryUpdate(Category category)
        {
            categotyDal.Updater(category);
        }

        public List<Category> GetAllCategories()
        {
            return categotyDal.GetListAll();
        }

        public Category GetById(int id)
        {
            return categotyDal.GetById(id);
        }
    }
}
