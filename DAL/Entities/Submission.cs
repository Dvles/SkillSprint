using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAL.Entities {

    public class Submissions {

        public Guid Submission_Id {get;set;}
        public string UserName {get;set;}
        public string Url {get;set;}
        public string Description {get;set;}
        public Guid Challenge_Id {get;set;}


        public Submissions(string userName, string url, string description, Guid challengeId)
        {
            Submission_Id = Guid.NewGuid();  
            UserName = userName;              
            Url = url;                      
            Description = description;       
            Challenge_Id = challengeId;      
        }
    }
}