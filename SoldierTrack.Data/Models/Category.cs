﻿namespace SoldierTrack.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using SoldierTrack.Data.Models.Base;

    using static SoldierTrack.Data.Constants.ModelsConstraints.CategoryConstraints;

    public class Category : BaseModel<int>
    {
        [Required]
        [MaxLength(NameMaxLength)]
        required public string Name { get; set; }

        public ICollection<Workout> Workouts { get; set; } = new List<Workout>();
    }
}
