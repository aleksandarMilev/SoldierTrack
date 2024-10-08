﻿namespace SoldierTrack.Services.Exercise
{
    using SoldierTrack.Services.Exercise.Models;

    public interface IExerciseService
    {
        Task<ExerciseDetailsServiceModel?> GetDetailsById(int id);

        Task<ExercisePageServiceModel> GetPageModelsAsync(string? searchTerm, int pageIndex, int pageSize);

        Task<string> GetNameByIdAsync(int id);

    }
}
