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
    public class CommentManager : ICommentService
    {
        ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public void AddComment(Comment comment)
        {
            throw new NotImplementedException();
        }

        public List<Comment> GetList(int id) //derste buraya id vermiş ancak ben yazınca implement hatası veriyor.
        {
            var values = _commentDal.GetListAll(x => x.BlogId == 4);
            return (values);
        }
    }
}
