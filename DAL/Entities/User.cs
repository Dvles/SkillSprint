using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAL.Entities{
    public class User{
        public Guid User_Id {get;set;}
        public string First_Name {get;set;}
        public string Last_Name {get;set;}
        public string Email {get;set;}
        public string Password {get;set;}

        public DateTime Created_At {get;set;}
        public bool IsDisabled {get;set;}


        public User() { }

        public User(string first_Name, string last_Name, string email, string password)
        {
            User_Id = Guid.NewGuid();
            First_Name = first_Name;
            Last_Name = last_Name;
            Email = email;
            Password = password;
            Created_At = DateTime.Now;
            IsDisabled = false;
        }
        
        
            
        
    }
}