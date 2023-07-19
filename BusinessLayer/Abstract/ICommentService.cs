using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface ICommentService 
	{
		void CommentAdd(Comment comment);
		//void CommentRemove(Comment category);
		//void CommentUpdate(Comment category);
		List<Comment> GetAllComment(int id);
		//Comment GetById(int id);

	}
}
