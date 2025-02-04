using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using DAL.Entities;

namespace DAL.Repositories{

    public interface ISubmissionsRepository
    {
        public Submissions GetById(Guid submission_id);
        public IEnumerable<Submissions> GetAll();
        void Add(Submissions submission);
        void Update(Submissions submission);
        void Delete(Guid submission_id);
    }

}
