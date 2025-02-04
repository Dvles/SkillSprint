using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace DAL.Entities {

    public class Challenge{

        public Guid Challenge_Id {get;set;}
        public string Title {get;set;}
        public string Description {get;set;}
        public DateTime StartDate {get;set;}
        public DateTime EndDate {get;set;}
        public ChallengeCategory Category {get;set;}

        public Challenge(string title, string description, DateTime startDate, DateTime endDate, ChallengeCategory category)
        {
            Challenge_Id = Guid.NewGuid();      
            Title = title;                      
            Description = description;         
            StartDate = startDate;             
            EndDate = endDate;                  
            Category = category;                
        }
    }


    public enum ChallengeCategory
    {
        [Description("Create music pieces")]
        Music,
        
        [Description("Write beautiful poetry")]
        Poetry,
        
        [Description("Design creative works")]
        Design
    }

}