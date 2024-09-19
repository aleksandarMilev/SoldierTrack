﻿namespace SoldierTrack.Services.Athlete
{
    using AutoMapper;
    using AutoMapper.QueryableExtensions;
    using Microsoft.EntityFrameworkCore;
    using SoldierTrack.Data.Models;
    using SoldierTrack.Data.Repositories.Base;
    using SoldierTrack.Services.Athlete.MapperProfile;
    using SoldierTrack.Services.Athlete.Models;
    using SoldierTrack.Services.Common;

    public class AthleteService : IAthleteService
    {
        private readonly IDeletableRepository<Athlete> repository;
        private readonly IMapper mapper;

        public AthleteService(IDeletableRepository<Athlete> athleteRepository)
        {
            this.repository = athleteRepository;
            this.mapper = AutoMapperConfig<AthleteProfile>.CreateMapper();
        }

        public async Task<int> GetIdByUserIdAsync(string userId)
        {
            return await this.repository
                .AllAsNoTracking()
                .Where(a => a.UserId == userId)
                .Select(a => a.Id)
                .FirstOrDefaultAsync();
        }

        public async Task<Athlete?> GetByIdAsync(int id)
        {
            return await this.repository
                .All()
                .FirstOrDefaultAsync(a => a.Id == id);
        }

        public async Task<AthleteDetailsServiceModel?> GetDetailsModelByIdAsync(int id)
        {
            return await this.repository
                .AllAsNoTracking()
                .ProjectTo<AthleteDetailsServiceModel>(this.mapper.ConfigurationProvider)
                .FirstOrDefaultAsync(a => a.Id == id);
        }

        public async Task<bool> AthleteWithSameNumberExistsAsync(string phoneNumber, int? id = null)
        {
            var entityId = await this.repository
                .AllAsNoTracking()
                .Where(a => a.PhoneNumber == phoneNumber)
                .Select(a => a.Id)
                .FirstOrDefaultAsync();

            if (entityId != 0 && id == null)
            {
                return true;
            }

            if (entityId != 0 && id.HasValue && id.Value != entityId)
            {
                return true;
            }

            return false;
        }

        public async Task<bool> UserIsAthleteAsync(string userId)
        {
            return await this.repository
               .AllAsNoTracking()
               .Select(a => a.UserId)
               .AnyAsync(id => id == userId);
        }

        public async Task<bool> AthleteHasMembershipAsync(int id)
        {
            var membershipId = await this.repository
                .AllAsNoTracking()
                .Where(a => a.Id == id)
                .Select(a => a.MembershipId)
                .FirstOrDefaultAsync();

            return membershipId != null;
        }

        public async Task CreateAsync(AthleteServiceModel model)
        {
            var athleteEntity = this.mapper.Map<Athlete>(model);

            this.repository.Add(athleteEntity);
            await this.repository.SaveChangesAsync();
        }
    }
}
