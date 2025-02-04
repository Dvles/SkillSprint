using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using DAL.Entities;

namespace DAL.Repositories{
    public static class FakeDB{
        public static List<User> Users = new List<User>{

            new User (
                
                "Sabrina",
                "Manhilo",
                "user1@gmail.com",
                "0000"
               
            ),

            new User (
                
                "Kelly",
                "Grander",
                "user2@gmail.com",
                "0000"
               
            ),

            new User (
                
                "Devota",
                "Twagyra",
                "user3@gmail.com",
                "0000"
               
            ),

            new User (
                
                "Ben",
                "Delcroix",
                "user4@gmail.com",
                "0000"
               
            ),



        };
    }
}