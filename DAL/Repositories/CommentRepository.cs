using System;
using System.Linq;
using DAL.Entities;

namespace DAL.Repositories{
    public interface CommentRepository: ICommentRepository {

        public Comment GetById (Guid comment_id){
            return DAL.FakeDB.FakeDB.Comments.FirstOrDefault( c => c.Comment_Id == comment_id);
        }

        public IEnumerable<Comment> GetAll(){
            return DAL.FakeDB.FakeDB.Comments;
        }

        public void Add(Comment comment){
            DAL.FakeDB.FakeDB.Comments.Add(comment);
        }

        public void Delete(Guid comment_id){
            Comment comment = DAL.FakeDB.FakeDB.Comments.FirstOrDefault(c => c.Comment_Id == comment_id);
            DAL.FakeDB.FakeDB.Comments.Remove(comment);
        }
    }
}