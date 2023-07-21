using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{

    public class BlogManager : IBlogService
    {
        IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public void BlogAdd(Blog blog)
        {
            throw new NotImplementedException();
        }

        public void BlogRemove(Blog blog)
        {
            throw new NotImplementedException();
        }

        public void BlogUpdate(Blog blog)
        {
            throw new NotImplementedException();
        }

        public List<Blog> GetAllBlog()
        {
            return _blogDal.GetListAll();
        }

        public List<Blog> GetAllBlogListWithCategory()
        {
            return _blogDal.GetListWithCategory();
        }
        public List<Blog> GetBlogById(int id)
        {
            return _blogDal.GetListAll(x=>x.BlogId == id);
        }

		public List<Blog> GetBlogListByWriterId(int id)
		{
            return _blogDal.GetListAll(x => x.WriterID == id);
		}

		public Blog GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
