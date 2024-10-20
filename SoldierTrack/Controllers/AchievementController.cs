﻿namespace SoldierTrack.Web.Controllers
{
    using AutoMapper;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using SoldierTrack.Services.Achievement;
    using SoldierTrack.Services.Achievement.Models;
    using SoldierTrack.Services.Athlete;
    using SoldierTrack.Services.Exercise;
    using SoldierTrack.Web.Common.Extensions;
    using SoldierTrack.Web.Models.Achievement;

    using static SoldierTrack.Web.Common.Constants.MessageConstants;

    [Authorize]
    public class AchievementController : Controller
    {
        private readonly IAchievementService achievementService;
        private readonly IExerciseService exerciseService;
        private readonly IAthleteService athleteService;
        private readonly IMapper mapper;

        public AchievementController(
            IAchievementService achievementService,
            IExerciseService exerciseService,
            IAthleteService athleteService,
            IMapper mapper)
        {
            this.achievementService = achievementService;
            this.exerciseService = exerciseService;
            this.athleteService = athleteService;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var models = await this.achievementService.GetAllByAthleteIdAsync(this.User.GetId()!);
            return this.View(models);
        }

        [HttpGet]
        public async Task<IActionResult> Create(int exerciseId)
        {
            var athleteId = this.User.GetId();
            var exerciseName = await this.exerciseService.GetNameByIdAsync(exerciseId);
            var model = new AchievementFormModel(athleteId!, exerciseId, exerciseName, DateTime.Now);

            return this.View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(AchievementFormModel viewModel)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(viewModel);
            }

            var serviceModel = this.mapper.Map<AchievementServiceModel>(viewModel);
            await this.achievementService.CreateAsync(serviceModel);

            this.TempData["SuccessMessage"] = PRSuccessfullyAdded;
            return this.RedirectToAction(nameof(GetAll), new { athleteId = viewModel.AthleteId });
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var serviceModel = await this.achievementService.GetByIdAsync(id);

            if (serviceModel == null)
            {
                return this.NotFound();
            }

            if ((serviceModel.AthleteId == null) || (serviceModel.AthleteId != this.User.GetId()!))
            {
                return this.Unauthorized();
            }

            this.ViewBag.Id = id; 
            var viewModel = this.mapper.Map<AchievementFormModel>(serviceModel);
            return this.View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(AchievementFormModel viewModel, int id)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(viewModel);
            }

            var serviceModel = this.mapper.Map<AchievementServiceModel>(viewModel);
            serviceModel.Id = id;
            await this.achievementService.EditAsync(serviceModel);
            
            this.TempData["SuccessMessage"] = AchievementEdited;
            return this.RedirectToAction(nameof(GetAll), new { athleteId = viewModel.AthleteId });
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int achievementId)
        {
            var athleteId = this.User.GetId()!; 
            await this.achievementService.DeleteAsync(achievementId, athleteId);

            this.TempData["SuccessMessage"] = AchievementDeleted;
            return this.RedirectToAction(nameof(GetAll), new { athleteId });
        }
    }
}
