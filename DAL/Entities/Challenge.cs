using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DAL.Entities
{
    public class Challenge
    {
        
        public Guid Challenge_Id { get; set; }

        [Required]  
        [StringLength(100)]  
        public string Title { get; set; }

        [StringLength(500)]  
        public string Description { get; set; }

        [Required] 
        public DateTime StartDate { get; set; }

        [Required] 
        public DateTime EndDate { get; set; }

        [Required] 
        public ChallengeCategory Category { get; set; }

        public Challenge(string title, string description, DateTime startDate, DateTime endDate, ChallengeCategory category)
        {
            Challenge_Id = Guid.NewGuid();
            Title = title ?? throw new ArgumentNullException(nameof(title));  
            Description = description ?? string.Empty;  
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
