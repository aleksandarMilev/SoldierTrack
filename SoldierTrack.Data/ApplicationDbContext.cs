﻿namespace SoldierTrack.Data
{
    using System.Linq.Expressions;

    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using SoldierTrack.Data.Models;
    using SoldierTrack.Data.Models.Base;

    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Athlete> Athletes { get; set; }

        public DbSet<Workout> Workouts { get; set; }

        public DbSet<AthleteWorkout> AthletesWorkouts { get; set; }

        public DbSet<Membership> Memberships { get; set; }

        public DbSet<Achievement> Achievements { get; set; }

        public DbSet<Exercise> Exercises { get; set; }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                if (typeof(IDeletableEntity).IsAssignableFrom(entityType.ClrType))
                {
                    var lambdaExpression = GetIsDeletedFilter(entityType.ClrType);

                    modelBuilder
                        .Entity(entityType.ClrType)
                        .HasQueryFilter(lambdaExpression);
                }
            }
        }

        private static LambdaExpression GetIsDeletedFilter(Type type)
        {
            var parameter = Expression.Parameter(type, "e");
            var prop = Expression.Property(parameter, nameof(IDeletableEntity.IsDeleted));
            var condition = Expression.Equal(prop, Expression.Constant(false));

            return Expression.Lambda(condition, parameter);
        }

        public void SoftDelete<TEntity>(TEntity entity) 
            where TEntity : class, IDeletableEntity 
            => this.ApplySoftDeletionState(entity, true, DateTime.UtcNow.Date);

        public void Restore<TEntity>(TEntity entity) 
            where TEntity : class, IDeletableEntity 
            => this.ApplySoftDeletionState(entity, false, null);
       
        private void ApplySoftDeletionState<TEntity>(TEntity entity, bool isDeleted, DateTime? deletedOn)
            where TEntity : class, IDeletableEntity
        {
            var entry = this.Entry(entity);

            if (entry.State == EntityState.Detached)
            {
                this.Set<TEntity>().Attach(entity);
            }

            entry.State = EntityState.Modified;
            entity.IsDeleted = isDeleted;
            entity.DeletedOn = deletedOn;
        }
    }
}