using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IBlogService
    {
        void BlogAdd(Blog blog);
        void BlogRemove(Blog blog);
        void BlogUpdate(Blog blog);
        List<Blog> GetAllBlog();
        List<Blog> GetAllBlogListWithCategory();
        Blog GetById(int id);

        List<Blog> GetBlogListByWriterId(int id);
    }
}
