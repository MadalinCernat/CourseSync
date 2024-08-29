using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourseSync.Domain.Models;
public class LearningStep
{
    [Key]
    public Guid LearningStepId { get; set; } // Primary Key

    [Required]
    [MaxLength(500)]
    public string Title { get; set; }

    [MaxLength(2000)]
    public string Content { get; set; }

    [Required]
    public int Order { get; set; } // The order of this step in the learning path

    [Required]
    [ForeignKey("LearningPath")]
    public Guid LearningPathId { get; set; } // Foreign Key

    // Navigation Property
    public LearningPath LearningPath { get; set; }
}
