using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourseSync.Domain.Models;
public class User
{
    [Key]
    public Guid UserId { get; set; } // Primary Key

    [Required]
    [MaxLength(100)]
    public string Username { get; set; }

    [Required]
    [MaxLength(100)]
    public string Email { get; set; }

    [Required]
    [MaxLength(50)]
    public string Role { get; set; } // e.g., "Student", "Mentor", "Admin"

    // Navigation Property
    public ICollection<CommunityUser> CommunityUsers { get; set; }
}
