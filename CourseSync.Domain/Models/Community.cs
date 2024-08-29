using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourseSync.Domain.Models;
public class Community
{
    [Key]
    public Guid CommunityId { get; set; } // Primary Key

    [Required]
    [MaxLength(200)]
    public string Name { get; set; }

    [MaxLength(500)]
    public string Description { get; set; }

    // Navigation Property
    public ICollection<CommunityUser> CommunityUsers { get; set; }

    public ICollection<LearningPath> LearningPaths { get; set; }
}
