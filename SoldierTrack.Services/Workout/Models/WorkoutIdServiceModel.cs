﻿namespace SoldierTrack.Services.Workout.Models
{
    using SoldierTrack.Services.Workout.Models.Base;

    public class WorkoutIdServiceModel : WorkoutBaseServiceModel
    {
        public int Id { get; init; }

        public int CurrentParticipants { get; init; }

        public string CategoryName { get; init; } = null!;
    }
}
