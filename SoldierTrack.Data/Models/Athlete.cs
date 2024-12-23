﻿namespace SoldierTrack.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using Base;
    using Microsoft.AspNetCore.Identity;

    using static Constants.ModelsConstraints.AthleteConstraints;

    public class Athlete : IdentityUser, IDeletableEntity
    {
        [Required]
        [MaxLength(NamesMaxLength)]
        public string FirstName { get; set; } = null!; 

        [Required]
        [MaxLength(NamesMaxLength)]
        public string LastName { get; set; } = null!;

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        [ForeignKey(nameof(Membership))]
        public int? MembershipId { get; set; }

        public Membership? Membership { get; set; }

        public ICollection<FoodDiary> FoodDiaries { get; set; } = new List<FoodDiary>();

        public ICollection<AthleteWorkout> AthletesWorkouts { get; set; } = new List<AthleteWorkout>();

        public ICollection<Achievement> Achievements { get; set; } = new List<Achievement>();

        public ICollection<Exercise> Exercises { get; set; } = new List<Exercise>();

        public ICollection<Food> Foods { get; set; } = new List<Food>();
    }
}