﻿namespace SoldierTrack.Services.Food
{
    using Models;

    public interface IFoodService
    {
        Task<FoodPageServiceModel> GetPageModelsAsync(FoodSearchParams searchParams, string athleteId, bool userIsAdmin);

        Task<FoodServiceModel?> GetByIdAsync(int id);

        Task<bool> FoodLimitReachedAsync(string athleteId);

        Task<int> CreateAsync(FoodServiceModel model);

        Task EditAsync(FoodServiceModel model);

        Task DeleteAsync(int foodId, string athleteId, bool userIsAdmin);

    }
}
