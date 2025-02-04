using System;
using System.Linq;
using DAL.Entities;

namespace DAL.Repositories{

        public interface SubmissionsRepository : ISubmissionsRepository {
            
            
            public Submissions GetById (Guid submission_id){
                return DAL.FakeDB.FakeDB.Submissions.FirstOrDefault(s => s.Submission_Id == submission_id);
            }

            public IEnumerable<Submissions> GetAll(){
                return DAL.FakeDB.FakeDB.Submissions;
            }

            public void Add(Submissions submission){
                DAL.FakeDB.FakeDB.Submissions.Add(submission);
                Console.WriteLine("Submission added");
            }

            public void Update (Submissions submission){
                Submissions existingSubmission = DAL.FakeDB.FakeDB.Submissions.FirstOrDefault( s => s.Submission_Id ==  submission.Submission_Id);
                if (existingSubmission !=null){
                    existingSubmission.Url = submission.Url;                    existingSubmission.Description = submission.Description;  
                }
                Console.WriteLine("Submission updated");
            }

            public void Delete (Guid submission_id){
                Submissions existingSubmission = DAL.FakeDB.FakeDB.Submissions.FirstOrDefault(s => s.Submission_Id == submission_id);
                if (existingSubmission != null){
                    DAL.FakeDB.FakeDB.Submissions.Remove(existingSubmission);
                }
                Console.WriteLine("Submission deleted");

            }
        }
}