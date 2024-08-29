using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourseSync.Domain.Models;
public class LearningPath
{
    [Key]
    public Guid LearningPathId { get; set; } // Primary Key

    [Required]
    [MaxLength(200)]
    public string Title { get; set; }

    [MaxLength(1000)]
    public string Description { get; set; }

    [Required]
    [ForeignKey("Community")]
    public Guid CommunityId { get; set; } // Foreign Key

    // Navigation Property
    public Community Community { get; set; }

    public ICollection<LearningStep> LearningSteps { get; set; }
}
