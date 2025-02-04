using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using DAL.Entities;

namespace DAL.Repositories{

    public interface ICommentRepository{

        Comment GetById(Guid comment_id);
        IEnumerable<Comment> GetAll();
        void Add(Comment comment);
        void Delete (Guid comment_id);
    }
}