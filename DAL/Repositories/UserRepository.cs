using System;
using System.Linq;
using DAL.Entities;

namespace DAL.Repositories{

    public interface UserRepository : IUserRepository
    {
        public User GetById (Guid user_id){
            return DAL.FakeDB.FakeDB.Users.FirstOrDefault ( u  => u.User_Id == user_id);
        }

        public IEnumerable<User> GetAll(){
            return DAL.FakeDB.FakeDB.Users;
        }

        public void Add(User user){
            DAL.FakeDB.FakeDB.Users.Add(user);
        }

        public void Update(User user){
            // Finds the first user in the fake database whose User_Id matches 
            User CurrentUser = DAL.FakeDB.FakeDB.Users.FirstOrDefault(u => u.User_Id == user.User_Id);
            if (CurrentUser != null){
                CurrentUser.First_Name = user.First_Name;
                CurrentUser.Last_Name= user.Last_Name;
            }
        }

        public void Delete(User user){
            User CurrentUser = DAL.FakeDB.FakeDB.Users.FirstOrDefault(u => u.User_Id == user.User_Id);
            if (CurrentUser != null){
                DAL.FakeDB.FakeDB.Users.Remove(user);
            }
        }
    }

}
