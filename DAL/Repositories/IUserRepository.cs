using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using DAL.Entities;

namespace DAL.Repositories{

    public interface IUserRepository
    {
        User GetById(Guid user_id);
        IEnumerable<User> GetAll();
        void Insert(User user);
        void Update(User user);
        void Delete(Guid user_id);
    }

}
