using System;
using DAL.Repositories;
using DAL.Entities;
using System.Linq;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Testing Get All Users
            Console.WriteLine("All Users:");
            var userRepo = new UserRepository();
            var users = userRepo.GetAll();
            foreach (var user in users)
            {
                Console.WriteLine($"User: {user.First_Name} {user.Last_Name}");
            }

            // Testing Get User by Id
            var userId = users.FirstOrDefault()?.User_Id;
            if (userId != null)
            {
                var user = userRepo.GetById(userId.Value);
                Console.WriteLine($"\nUser Found: {user.First_Name} {user.Last_Name}");
            }

            // Testing Add New User
            var newUser = new User("Test", "User", "testuser@gmail.com", "1234");
            userRepo.Add(newUser);
            Console.WriteLine("\nNew user added.");

            // Verifying if the new user was added
            var allUsers = userRepo.GetAll();
            Console.WriteLine("Users after addition:");
            foreach (var user in allUsers)
            {
                Console.WriteLine($"{user.First_Name} {user.Last_Name}");
            }

            // Testing Update User
            var firstUser = allUsers.FirstOrDefault();
            if (firstUser != null)
            {
                firstUser.First_Name = "UpdatedName";
                userRepo.Update(firstUser);
                Console.WriteLine("\nUser updated.");
            }

            // Testing Delete User
            if (firstUser != null)
            {
                userRepo.Delete(firstUser.User_Id);
                Console.WriteLine("\nUser deleted.");
            }

            // Verifying the deletion
            var finalUserList = userRepo.GetAll();
            Console.WriteLine("Users after deletion:");
            foreach (var user in finalUserList)
            {
                Console.WriteLine($"{user.First_Name} {user.Last_Name}");
            }
        }
    }
}
