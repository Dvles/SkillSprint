using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using Bogus;
using DAL.Entities;

namespace DAL.Repositories{
    public static class FakeDB{
        
        private static Faker faker = new Faker();
        public static List<User> Users = new List<User>{

            new User("Sabrina", "Manhilo", "user1@gmail.com", "0000"),
            new User("Kelly", "Grander", "user2@gmail.com", "0000"),
            new User("Devota", "Twagyra", "user3@gmail.com", "0000"),
            new User("Ben", "Delcroix", "user4@gmail.com", "0000"),
            new User("Moesha", "Surimi", "user5@gmail.com", "0000"),
            new User("Fanny", "Bouillon-Paul", "user6@gmail.com", "0000"),
            new User("Lerato", "Ndlovu", "user7@gmail.com", "0000")
        };

        
        public static List<Challenge> Challenges = new List<Challenge>{
            new Challenge("Ocean Plague", faker.Lorem.Sentence(), DateTime.Now, DateTime.Now.AddMonths(6), ChallengeCategory.Design),
            new Challenge("Me, Myself and I", faker.Lorem.Sentence(), DateTime.Now, DateTime.Now.AddMonths(3), ChallengeCategory.Poetry),
            new Challenge("Internal Revolution", faker.Lorem.Sentence(), DateTime.Now, DateTime.Now.AddMonths(3), ChallengeCategory.Design),
            new Challenge("Only 3 words", faker.Lorem.Sentence(), DateTime.Now, DateTime.Now.AddMonths(3), ChallengeCategory.Music),
            new Challenge("Duotones", faker.Lorem.Sentence(), DateTime.Now, DateTime.Now.AddMonths(3), ChallengeCategory.Design),
            new Challenge("DownUpTempo", faker.Lorem.Sentence(), DateTime.Now, DateTime.Now.AddMonths(3), ChallengeCategory.Music)
        };

        public static List<Submissions> Submissions = new List<Submissions>{
            new Submissions(Users[0].First_Name, "https://asset.cloudinary.com/dzqge7ico/3d1d7ed90c35bc75cb437eba12510c0e", faker.Lorem.Sentence(), Challenges[0].Challenge_Id),
            new Submissions(Users[1].First_Name, "https://asset.cloudinary.com/dzqge7ico/62e7b7b893c13bfe02fd4cde3cdf6bf1", faker.Lorem.Sentence(), Challenges[0].Challenge_Id),
            new Submissions(Users[2].First_Name, "https://asset.cloudinary.com/dzqge7ico/06807efe318c695fd5700f321ef8412f", faker.Lorem.Sentence(), Challenges[0].Challenge_Id),
            new Submissions(Users[4].First_Name, "https://asset.cloudinary.com/dzqge7ico/3578eda9778ffa7927fbd59acc9c6bf6", faker.Lorem.Sentence(), Challenges[1].Challenge_Id),
            new Submissions(Users[1].First_Name, "https://asset.cloudinary.com/dzqge7ico/62e7b7b893c13bfe02fd4cde3cdf6bf1", faker.Lorem.Sentence(), Challenges[1].Challenge_Id),
            new Submissions(Users[4].First_Name, "https://asset.cloudinary.com/dzqge7ico/b9e441eadf787769833d43d97fa68057", faker.Lorem.Sentence(), Challenges[2].Challenge_Id),
            new Submissions(Users[0].First_Name, "https://asset.cloudinary.com/dzqge7ico/3d1d7ed90c35bc75cb437eba12510c0e", faker.Lorem.Sentence(), Challenges[0].Challenge_Id),
            new Submissions(Users[1].First_Name, "https://asset.cloudinary.com/dzqge7ico/62e7b7b893c13bfe02fd4cde3cdf6bf1", faker.Lorem.Sentence(), Challenges[5].Challenge_Id),
            new Submissions(Users[2].First_Name, "https://asset.cloudinary.com/dzqge7ico/06807efe318c695fd5700f321ef8412f", faker.Lorem.Sentence(), Challenges[5].Challenge_Id)




        };

        public static List<Comment> Comments = new List<Comment>{

            new Comment( Users[3].User_Id, faker.Lorem.Sentence(), Submissions[0].Submission_Id),
            new Comment( Users[4].User_Id, faker.Lorem.Sentence(), Submissions[0].Submission_Id),
            new Comment( Users[5].User_Id, faker.Lorem.Sentence(), Submissions[0].Submission_Id),
            new Comment( Users[3].User_Id, faker.Lorem.Sentence(), Submissions[4].Submission_Id),
            new Comment( Users[2].User_Id, faker.Lorem.Sentence(), Submissions[4].Submission_Id),
            new Comment( Users[0].User_Id, faker.Lorem.Sentence(), Submissions[4].Submission_Id)

        };
    }
}