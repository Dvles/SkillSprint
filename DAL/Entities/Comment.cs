using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DAL.Entities
{
    public class Comment
    {
        public Guid Comment_Id { get; set; }

        [Required]
        public Guid User_Id { get; set; }

        [Required]  
        [StringLength(1000)]  
        public string Content { get; set; }

        [Required]
        public Guid Submission_Id { get; set; }

        public DateTime Comment_Date { get; set; }

       
        public Comment(Guid userId, string content, Guid submissionId)
        {
            Comment_Id = Guid.NewGuid();
            User_Id = userId;  // Must have a valid User_Id
            Content = content ?? throw new ArgumentNullException(nameof(content));  
            Submission_Id = submissionId;  
            Comment_Date = DateTime.Now;  
        }
    }
}
