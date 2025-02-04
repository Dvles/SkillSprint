using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAL.Entities
{
    public class Submissions
    {
        public Guid Submission_Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3)] 
        public string UserName { get; set; }

        [Required]
        [Url]  
        [StringLength(200)]  
        public string Url { get; set; }

        [StringLength(500)]  
        public string? Description { get; set; }

        [Required]
        public Guid Challenge_Id { get; set; }

        public Submissions(string userName, string url, string description, Guid challengeId)
        {
            Submission_Id = Guid.NewGuid();
            UserName = userName ?? throw new ArgumentNullException(nameof(userName));  // Ensure UserName isn't null
            Url = url ?? throw new ArgumentNullException(nameof(url));  
            Description = description;  
            Challenge_Id = challengeId;
        }
    }
}
