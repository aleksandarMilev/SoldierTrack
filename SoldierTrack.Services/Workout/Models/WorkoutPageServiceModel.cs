﻿namespace SoldierTrack.Services.Workout.Models
{
    public class WorkoutPageServiceModel
    {
        public int PageIndex { get; set; }
        public int TotalPages { get; set; }
        public int PageSize { get; set; }
        public int TotalCount { get; set; }

        public IEnumerable<EditWorkoutServiceModel> Workouts { get; set; } = new List<EditWorkoutServiceModel>();
    }
}
