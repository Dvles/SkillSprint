using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DAL.Entities{

    public class Comment{

        public Guid Comment_Id {get;set;}
        public Guid User_Id {get;set;}
        public string Content {get;set;}
        public Guid Submission_Id {get;set;}
        public DateTime Comment_Date {get;set;}

        public Comment(Guid userId, string content, Guid submissionId)
        {
            Comment_Id = Guid.NewGuid();      
            User_Id = userId;                 
            Content = content;                
            Submission_Id = submissionId;     
            Comment_Date = DateTime.Now;      
        }
    }
}