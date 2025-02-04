using System;
using System.ComponentModel.DataAnnotations;

namespace DAL.Entities
{
    public class User
    {
        public Guid User_Id { get; set; }

        
        [Required]
        [StringLength(50)]
        public string? First_Name { get; set; }

        [Required]
        [StringLength(50)]
        public string? Last_Name { get; set; }

        [Required]
        [EmailAddress] 
        [StringLength(100)] 
        public string? Email { get; set; }

        [Required]
        [StringLength(100)] 
        public string Password { get; set; }

        public DateTime Created_At { get; set; }

        public bool IsDisabled { get; set; }

        public User() 
        {
        }

        // Constructor where null values could still be allowed.
        public User(string first_Name, string last_Name, string email, string password)
        {
            // Use null-coalescing operator (??) to assign default values if null
            User_Id = Guid.NewGuid();
            First_Name = first_Name ?? string.Empty; 
            Last_Name = last_Name ?? string.Empty;  
            Email = email ?? string.Empty; 
            Password = password ?? "****"; 
            Created_At = DateTime.Now;
            IsDisabled = false; 
        }
    }
}
