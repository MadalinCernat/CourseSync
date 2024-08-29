using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourseSync.Domain.Models;
public class CommunityUser
{
    [Key]
    public Guid CommunityUserId { get; set; } // Primary Key

    [Required]
    [ForeignKey("User")]
    public Guid UserId { get; set; } // Foreign Key

    [Required]
    [ForeignKey("Community")]
    public Guid CommunityId { get; set; } // Foreign Key

    [Required]
    [MaxLength(50)]
    public string RoleInCommunity { get; set; } // e.g., "Member", "Mentor", "Admin"

    // Navigation Properties
    public User User { get; set; }
    public Community Community { get; set; }
}
