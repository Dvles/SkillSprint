using System;
using System.Linq;
using DAL.Entities;

namespace DAL.Repositories
{
    public class UserRepository : IUserRepository
    {
        public User GetById(Guid user_id)
        {
            return DAL.FakeDB.FakeDB.Users.FirstOrDefault(u => u.User_Id == user_id) 
                   ?? throw new InvalidOperationException("User not found");
        }

        public IEnumerable<User> GetAll()
        {
            return DAL.FakeDB.FakeDB.Users;
        }

        public void Add(User user)
        {
            DAL.FakeDB.FakeDB.Users.Add(user);
            Console.WriteLine("User added");
        }

        public void Update(User user)
        {
            User existingUser = DAL.FakeDB.FakeDB.Users.FirstOrDefault(u => u.User_Id == user.User_Id);
            if (existingUser != null)
            {
                existingUser.First_Name = user.First_Name;
                existingUser.Last_Name = user.Last_Name;
            }
            Console.WriteLine("User updated");
        }

        public void Delete(Guid user_id)
        {
            User existingUser = DAL.FakeDB.FakeDB.Users.FirstOrDefault(u => u.User_Id == user_id);
            if (existingUser != null)
            {
                DAL.FakeDB.FakeDB.Users.Remove(existingUser);
                Console.WriteLine("User removed");
            }
        }
    }
}
