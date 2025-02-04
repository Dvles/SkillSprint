using System;
using System.Linq;
using DAL.Entities;

namespace DAL.Repositories{
    public interface CommentRepository: ICommentRepository {

        public Comment GetById (Guid comment_id){
            return DAL.FakeDB.FakeDB.Comments.FirstOrDefault( c => c.Comment_Id == comment_id) ?? throw new InvalidOperationException("Comment not found");
        }

        public IEnumerable<Comment> GetAll(){
            return DAL.FakeDB.FakeDB.Comments;
        }

        public void Add(Comment comment){
            DAL.FakeDB.FakeDB.Comments.Add(comment);
            Console.WriteLine("comment added");
        }

        public void Delete(Guid comment_id){
            Comment existingComment = DAL.FakeDB.FakeDB.Comments.FirstOrDefault(c => c.Comment_Id == comment_id);
            DAL.FakeDB.FakeDB.Comments.Remove(existingComment);
            Console.WriteLine("comment deleted");
        }
    }
}