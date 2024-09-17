﻿namespace SoldierTrack.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using SoldierTrack.Data.Models.Base;

    using static SoldierTrack.Data.Constants.ModelsConstraints.WorkoutConstraints;

    public class Workout : BaseDeletableModel<int>
    {
        [Required]
        [MaxLength(TitleMaxLength)]
        required public string Title { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public TimeSpan Time { get; set; }

        [MaxLength(BriefDescriptionMaxLength)]
        public string? BriefDescription { get; set; } 

        [MaxLength(FullDescriptionMaxLength)]
        public string? FullDescription { get; set; } 

        [MaxLength(ImageUrlMaxLength)]
        public string? ImageUrl { get; set; } 

        [Required]
        required public Category CategoryName { get; set; }

        [Required]
        public bool IsForBeginners { get; set; }

        public int MaxParticipants { get; set; }

        public int CurrentParticipants { get; set; }

        public ICollection<AthleteWorkout> AthletesWorkouts { get; set; } = new List<AthleteWorkout>();
    }
}