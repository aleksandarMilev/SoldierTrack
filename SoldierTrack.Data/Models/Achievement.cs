﻿namespace SoldierTrack.Data.Models
{
    using System.ComponentModel.DataAnnotations.Schema;

    using SoldierTrack.Data.Models.Base;

    public class Achievement : BaseModel<int>
    {
        public DateTime DateAchieved { get; set; }

        public double WeightLifted { get; set; }

        public int Repetitions { get; set; }

        public double OneRepMax { get; set; }

        [ForeignKey(nameof(Athlete))]
        public int AthleteId { get; set; }

        public Athlete Athlete { get; set; } = null!;

        [ForeignKey(nameof(Exercise))]
        public int ExerciseId { get; set; }

        public Exercise Exercise { get; set; } = null!;
    }
}
