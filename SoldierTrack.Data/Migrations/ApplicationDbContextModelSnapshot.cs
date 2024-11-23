﻿#nullable disable
namespace SoldierTrack.Data.Migrations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Infrastructure;

    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasDiscriminator().HasValue("IdentityUser");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("SoldierTrack.Data.Models.Achievement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AthleteId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateAchieved")
                        .HasColumnType("datetime2");

                    b.Property<int>("ExerciseId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<double>("OneRepMax")
                        .HasColumnType("float");

                    b.Property<int>("Repetitions")
                        .HasColumnType("int");

                    b.Property<double>("WeightLifted")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("AthleteId");

                    b.HasIndex("ExerciseId");

                    b.ToTable("Achievements");
                });

            modelBuilder.Entity("SoldierTrack.Data.Models.AthleteWorkout", b =>
                {
                    b.Property<string>("AthleteId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("WorkoutId")
                        .HasColumnType("int");

                    b.HasKey("AthleteId", "WorkoutId");

                    b.HasIndex("WorkoutId");

                    b.ToTable("AthletesWorkouts");
                });

            modelBuilder.Entity("SoldierTrack.Data.Models.Exercise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AthleteId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Category")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsForBeginners")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("AthleteId");

                    b.ToTable("Exercises");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Category = 1,
                            CreatedOn = new DateTime(2024, 11, 23, 11, 5, 27, 287, DateTimeKind.Utc).AddTicks(7748),
                            Description = "The snatch is one of the two Olympic weightlifting movements. It involves lifting the barbell from the ground to overhead in one fluid motion, demonstrating explosive power, speed, and mobility.",
                            ImageUrl = "https://www.muscleandfitness.com/wp-content/uploads/2021/01/the_snatch_2.jpg",
                            IsDeleted = false,
                            IsForBeginners = false,
                            Name = "Snatch"
                        },
                        new
                        {
                            Id = 2,
                            Category = 1,
                            CreatedOn = new DateTime(2024, 11, 23, 11, 5, 27, 287, DateTimeKind.Utc).AddTicks(7756),
                            Description = "The clean and jerk is the second Olympic weightlifting movement. This two-part exercise involves cleaning the barbell to the shoulders, then driving it overhead, testing strength, speed, and coordination.",
                            ImageUrl = "https://barbend.com/wp-content/uploads/2021/02/BarBend-Article-Image-760-x-427-42.jpg",
                            IsDeleted = false,
                            IsForBeginners = false,
                            Name = "Clean and Jerk"
                        },
                        new
                        {
                            Id = 3,
                            Category = 2,
                            CreatedOn = new DateTime(2024, 11, 23, 11, 5, 27, 287, DateTimeKind.Utc).AddTicks(7759),
                            Description = "The deadlift is a powerlifting movement focusing on pulling a loaded barbell from the floor to the hips. It develops overall strength, especially in the posterior chain muscles like glutes, hamstrings, and lower back.",
                            ImageUrl = "https://i.ytimg.com/vi/lIKyNDZD06g/maxresdefault.jpg",
                            IsDeleted = false,
                            IsForBeginners = true,
                            Name = "Deadlift"
                        },
                        new
                        {
                            Id = 4,
                            Category = 2,
                            CreatedOn = new DateTime(2024, 11, 23, 11, 5, 27, 287, DateTimeKind.Utc).AddTicks(7762),
                            Description = "The back squat is a foundational powerlifting exercise where a barbell is positioned on the upper back. It targets the quads, hamstrings, and glutes, building strength and stability in the lower body.",
                            ImageUrl = "https://squatuniversity.com/wp-content/uploads/2016/02/859835_577024942352334_10881976_o.jpg",
                            IsDeleted = false,
                            IsForBeginners = true,
                            Name = "Back Squat"
                        },
                        new
                        {
                            Id = 5,
                            Category = 2,
                            CreatedOn = new DateTime(2024, 11, 23, 11, 5, 27, 287, DateTimeKind.Utc).AddTicks(7766),
                            Description = "The bench press is one of the main powerlifting lifts, performed by pressing a barbell off the chest while lying down. It targets the chest, triceps, and shoulders, developing upper body pushing strength.",
                            ImageUrl = "https://completelifter.com/wp-content/uploads/2022/11/Untitled-design-4-optimized.png",
                            IsDeleted = false,
                            IsForBeginners = true,
                            Name = "Bench Press"
                        },
                        new
                        {
                            Id = 6,
                            Category = 1,
                            CreatedOn = new DateTime(2024, 11, 23, 11, 5, 27, 287, DateTimeKind.Utc).AddTicks(7769),
                            Description = "The front squat is a squat variation where the barbell is held across the front of the shoulders. It emphasizes the quads and core, requiring more upper body stability than the back squat.",
                            ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTBl-92jPe3iigzY0eJHx8P8mnNVrBO4Gq90w&s",
                            IsDeleted = false,
                            IsForBeginners = true,
                            Name = "Front Squat"
                        },
                        new
                        {
                            Id = 7,
                            Category = 1,
                            CreatedOn = new DateTime(2024, 11, 23, 11, 5, 27, 287, DateTimeKind.Utc).AddTicks(7773),
                            Description = "The overhead press is a strength exercise performed by pressing a barbell or dumbbells overhead. It primarily targets the shoulders, triceps, and upper chest, developing upper body strength.",
                            ImageUrl = "https://image.boxrox.com/2021/04/sam-kwant-thruster-overhead-barbell-1024x576.jpg",
                            IsDeleted = false,
                            IsForBeginners = true,
                            Name = "Overhead Press"
                        },
                        new
                        {
                            Id = 8,
                            Category = 1,
                            CreatedOn = new DateTime(2024, 11, 23, 11, 5, 27, 287, DateTimeKind.Utc).AddTicks(7776),
                            Description = "The power clean is a variation of the clean movement, performed without a full squat. It develops explosive power, speed, and strength, targeting multiple muscle groups.",
                            ImageUrl = "https://wodprep.com/wp-content/uploads/2022/05/jerk-dip.jpg",
                            IsDeleted = false,
                            IsForBeginners = false,
                            Name = "Power Clean"
                        },
                        new
                        {
                            Id = 9,
                            Category = 1,
                            CreatedOn = new DateTime(2024, 11, 23, 11, 5, 27, 287, DateTimeKind.Utc).AddTicks(7779),
                            Description = "The Romanian deadlift focuses on the hamstrings and glutes, with less emphasis on the lower back. It’s performed with a slight knee bend, making it a great accessory movement for the deadlift.",
                            ImageUrl = "https://www.catalystathletics.com/articles/images/rdl.jpg",
                            IsDeleted = false,
                            IsForBeginners = true,
                            Name = "Romanian Deadlift"
                        },
                        new
                        {
                            Id = 10,
                            Category = 1,
                            CreatedOn = new DateTime(2024, 11, 23, 11, 5, 27, 287, DateTimeKind.Utc).AddTicks(7783),
                            Description = "The power snatch is a variation of the snatch movement, performed without a full squat. It develops explosive power, speed, and strength, targeting multiple muscle groups.",
                            ImageUrl = "https://hortonbarbell.com/wp-content/uploads/2022/03/Hang-Power-Snatch-How-To-and-Why.png",
                            IsDeleted = false,
                            IsForBeginners = false,
                            Name = "Power Snatch"
                        });
                });

            modelBuilder.Entity("SoldierTrack.Data.Models.Food", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AthleteId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal>("Carbohydrates")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Fats")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Proteins")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TotalCalories")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("AthleteId");

                    b.ToTable("Foods");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Carbohydrates = 0m,
                            CreatedOn = new DateTime(2024, 11, 23, 11, 5, 27, 288, DateTimeKind.Utc).AddTicks(13),
                            Fats = 3.6m,
                            ImageUrl = "https://www.allrecipes.com/thmb/Bw4L_IuQHhHeqq52cEkWbA5PIGo=/0x512/filters:no_upscale():max_bytes(150000):strip_icc()/16160-juicy-grilled-chicken-breasts-ddmfs-5594-hero-3x4-902673c819994c0191442304b40104af.jpg",
                            IsDeleted = false,
                            Name = "Grilled Chicken Breast",
                            Proteins = 31m,
                            TotalCalories = 165m
                        },
                        new
                        {
                            Id = 2,
                            Carbohydrates = 45m,
                            CreatedOn = new DateTime(2024, 11, 23, 11, 5, 27, 288, DateTimeKind.Utc).AddTicks(18),
                            Fats = 1.8m,
                            ImageUrl = "https://dainty.ca/wp-content/uploads/2024/08/brown-rice-recipe-1.jpg",
                            IsDeleted = false,
                            Name = "Brown Rice",
                            Proteins = 5m,
                            TotalCalories = 215m
                        },
                        new
                        {
                            Id = 3,
                            Carbohydrates = 11.2m,
                            CreatedOn = new DateTime(2024, 11, 23, 11, 5, 27, 288, DateTimeKind.Utc).AddTicks(22),
                            Fats = 0.6m,
                            ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSY6nd4NrK34-uY3IIF19GXQ4KOBGblsBiNcQ&s",
                            IsDeleted = false,
                            Name = "Steamed Broccoli",
                            Proteins = 4.7m,
                            TotalCalories = 55.0m
                        },
                        new
                        {
                            Id = 4,
                            Carbohydrates = 26m,
                            CreatedOn = new DateTime(2024, 11, 23, 11, 5, 27, 288, DateTimeKind.Utc).AddTicks(27),
                            Fats = 0.1m,
                            ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT2fudWD3MwcLfiNpBaAtrePuW6EoizmBetqg&s",
                            IsDeleted = false,
                            Name = "Baked Sweet Potato",
                            Proteins = 2m,
                            TotalCalories = 112m
                        },
                        new
                        {
                            Id = 5,
                            Carbohydrates = 0.6m,
                            CreatedOn = new DateTime(2024, 11, 23, 11, 5, 27, 288, DateTimeKind.Utc).AddTicks(40),
                            Fats = 4.8m,
                            ImageUrl = "https://www.seriouseats.com/thmb/T5v_t4ZE06pasVLee8VYwkoG9Ec=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/perfect-soft-boiled-eggs-hero-05_1-7680c13e853046fd90db9e277911e4e8.JPG",
                            IsDeleted = false,
                            Name = "Boiled Eggs",
                            Proteins = 6m,
                            TotalCalories = 68m
                        },
                        new
                        {
                            Id = 6,
                            Carbohydrates = 9m,
                            CreatedOn = new DateTime(2024, 11, 23, 11, 5, 27, 288, DateTimeKind.Utc).AddTicks(48),
                            Fats = 15m,
                            ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSp05ca_Cf1CqlqghC5DgeX3PNdU-Kup6h1GQ&s",
                            IsDeleted = false,
                            Name = "Avocado",
                            Proteins = 2m,
                            TotalCalories = 160m
                        },
                        new
                        {
                            Id = 7,
                            Carbohydrates = 0m,
                            CreatedOn = new DateTime(2024, 11, 23, 11, 5, 27, 288, DateTimeKind.Utc).AddTicks(53),
                            Fats = 13m,
                            ImageUrl = "https://www.thecookierookie.com/wp-content/uploads/2023/05/featured-grilled-salmon-recipe.jpg",
                            IsDeleted = false,
                            Name = "Grilled Salmon",
                            Proteins = 22m,
                            TotalCalories = 206m
                        },
                        new
                        {
                            Id = 8,
                            Carbohydrates = 21m,
                            CreatedOn = new DateTime(2024, 11, 23, 11, 5, 27, 288, DateTimeKind.Utc).AddTicks(57),
                            Fats = 1.9m,
                            ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ2u08SSItJo5GaISAoLcy73puA1R-EcMMAAg&s",
                            IsDeleted = false,
                            Name = "Quinoa",
                            Proteins = 4m,
                            TotalCalories = 120m
                        },
                        new
                        {
                            Id = 9,
                            Carbohydrates = 3.4m,
                            CreatedOn = new DateTime(2024, 11, 23, 11, 5, 27, 288, DateTimeKind.Utc).AddTicks(178),
                            Fats = 4.3m,
                            ImageUrl = "https://freshmilledmama.com/wp-content/uploads/2023/03/raw-milk-cottage-cheese--500x375.jpg",
                            IsDeleted = false,
                            Name = "Cottage Cheese",
                            Proteins = 11m,
                            TotalCalories = 98m
                        },
                        new
                        {
                            Id = 10,
                            Carbohydrates = 3m,
                            CreatedOn = new DateTime(2024, 11, 23, 11, 5, 27, 288, DateTimeKind.Utc).AddTicks(182),
                            Fats = 9m,
                            ImageUrl = "https://cdn.loveandlemons.com/wp-content/uploads/2021/05/almond-butter.jpg",
                            IsDeleted = false,
                            Name = "Almond Butter",
                            Proteins = 3m,
                            TotalCalories = 98m
                        });
                });

            modelBuilder.Entity("SoldierTrack.Data.Models.FoodDiary", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AthleteId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal>("Carbohydrates")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Fats")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Proteins")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TotalCalories")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("AthleteId");

                    b.ToTable("FoodDiaries");
                });

            modelBuilder.Entity("SoldierTrack.Data.Models.Meal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Carbohydrates")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Fats")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("FoodDiaryId")
                        .HasColumnType("int");

                    b.Property<int>("MealType")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Proteins")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TotalCalories")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("FoodDiaryId");

                    b.ToTable("Meals");
                });

            modelBuilder.Entity("SoldierTrack.Data.Models.MealFood", b =>
                {
                    b.Property<int>("FoodId")
                        .HasColumnType("int");

                    b.Property<int>("MealId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("FoodId", "MealId");

                    b.HasIndex("MealId");

                    b.ToTable("MealsFoods");
                });

            modelBuilder.Entity("SoldierTrack.Data.Models.Membership", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AthleteId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsMonthly")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPending")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("TotalWorkoutsCount")
                        .HasColumnType("int");

                    b.Property<int?>("WorkoutsLeft")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Memberships");
                });

            modelBuilder.Entity("SoldierTrack.Data.Models.MembershipArchive", b =>
                {
                    b.Property<string>("AthleteId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("MembershipId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("AthleteId", "MembershipId");

                    b.HasIndex("MembershipId");

                    b.ToTable("MembershipArchives");
                });

            modelBuilder.Entity("SoldierTrack.Data.Models.Workout", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("BriefDescription")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("Category")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("CurrentParticipants")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("FullDescription")
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.Property<string>("ImageUrl")
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsForBeginners")
                        .HasColumnType("bit");

                    b.Property<int>("MaxParticipants")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Workouts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BriefDescription = "Murph is a grueling Hero WOD that challenges strength, endurance, and mental toughness, honoring Navy SEAL Lt. Michael P. Murphy.",
                            Category = 0,
                            CreatedOn = new DateTime(2024, 11, 23, 11, 5, 27, 288, DateTimeKind.Utc).AddTicks(2125),
                            CurrentParticipants = 0,
                            DateTime = new DateTime(2024, 11, 24, 12, 0, 0, 288, DateTimeKind.Utc).AddTicks(2112),
                            FullDescription = "Murph is one of the most iconic Hero WODs in CrossFit, dedicated to Navy SEAL Lt. Michael P. Murphy, who sacrificed his life in combat. This intense workout consists of a 1-mile run, 100 pull-ups, 200 push-ups, 300 air squats, and another 1-mile run, traditionally performed while wearing a 20 lb weight vest. It’s a test of physical endurance and mental resilience, symbolizing the ultimate sacrifice made by Lt. Murphy and many others who serve. Athletes can scale or partition the workout as needed, but the true spirit of Murph is pushing your limits and honoring a hero.",
                            ImageUrl = "https://i0.wp.com/btwb.blog/wp-content/uploads/2018/05/murph_final.jpg?fit=1000%2C715&ssl=1",
                            IsDeleted = false,
                            IsForBeginners = false,
                            MaxParticipants = 15,
                            Title = "Murph"
                        },
                        new
                        {
                            Id = 2,
                            BriefDescription = "Fran is a fast and intense CrossFit workout that tests your power, speed, and conditioning.",
                            Category = 0,
                            CreatedOn = new DateTime(2024, 11, 23, 11, 5, 27, 288, DateTimeKind.Utc).AddTicks(2132),
                            CurrentParticipants = 0,
                            DateTime = new DateTime(2024, 11, 25, 12, 0, 0, 288, DateTimeKind.Utc).AddTicks(2128),
                            FullDescription = "Fran is a classic CrossFit benchmark workout that combines two movements—thrusters and pull-ups—for time. The rep scheme is 21-15-9, meaning you perform 21 thrusters, 21 pull-ups, then 15 of each, and finally 9 of each. This workout pushes athletes to their limits as they strive to complete it as quickly as possible. Fran is known for its simplicity yet devastating intensity, making it a true test of athletic capacity and mental fortitude.",
                            ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSU2qyjxN9nLMueVzxB79jBW3AUwKmUWQFzDQ&s",
                            IsDeleted = false,
                            IsForBeginners = true,
                            MaxParticipants = 12,
                            Title = "Fran"
                        },
                        new
                        {
                            Id = 3,
                            BriefDescription = "Cindy is a CrossFit WOD that tests your endurance and bodyweight strength with a 20-minute AMRAP.",
                            Category = 0,
                            CreatedOn = new DateTime(2024, 11, 23, 11, 5, 27, 288, DateTimeKind.Utc).AddTicks(2137),
                            CurrentParticipants = 0,
                            DateTime = new DateTime(2024, 11, 26, 12, 0, 0, 288, DateTimeKind.Utc).AddTicks(2134),
                            FullDescription = "Cindy is a simple yet challenging CrossFit workout that involves a 20-minute AMRAP (As Many Rounds As Possible) of 5 pull-ups, 10 push-ups, and 15 air squats. It is a great test of endurance, stamina, and bodyweight strength. Athletes aim to complete as many rounds as they can within the 20-minute time frame, focusing on maintaining consistent movement and pacing. Cindy is a versatile workout suitable for athletes of all skill levels, as it can be scaled to match individual fitness abilities.",
                            ImageUrl = "https://crossfitplzen.cz/wp-content/uploads/2020/03/Cindy-WOD-1024x694.jpg",
                            IsDeleted = false,
                            IsForBeginners = true,
                            MaxParticipants = 15,
                            Title = "Cindy"
                        });
                });

            modelBuilder.Entity("SoldierTrack.Data.Models.Athlete", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("MembershipId")
                        .HasColumnType("int");

                    b.HasIndex("MembershipId")
                        .IsUnique()
                        .HasFilter("[MembershipId] IS NOT NULL");

                    b.HasDiscriminator().HasValue("Athlete");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SoldierTrack.Data.Models.Achievement", b =>
                {
                    b.HasOne("SoldierTrack.Data.Models.Athlete", "Athlete")
                        .WithMany("Achievements")
                        .HasForeignKey("AthleteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SoldierTrack.Data.Models.Exercise", "Exercise")
                        .WithMany("Achievements")
                        .HasForeignKey("ExerciseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Athlete");

                    b.Navigation("Exercise");
                });

            modelBuilder.Entity("SoldierTrack.Data.Models.AthleteWorkout", b =>
                {
                    b.HasOne("SoldierTrack.Data.Models.Athlete", "Athlete")
                        .WithMany("AthletesWorkouts")
                        .HasForeignKey("AthleteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SoldierTrack.Data.Models.Workout", "Workout")
                        .WithMany("AthletesWorkouts")
                        .HasForeignKey("WorkoutId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Athlete");

                    b.Navigation("Workout");
                });

            modelBuilder.Entity("SoldierTrack.Data.Models.Exercise", b =>
                {
                    b.HasOne("SoldierTrack.Data.Models.Athlete", "Athlete")
                        .WithMany("Exercises")
                        .HasForeignKey("AthleteId");

                    b.Navigation("Athlete");
                });

            modelBuilder.Entity("SoldierTrack.Data.Models.Food", b =>
                {
                    b.HasOne("SoldierTrack.Data.Models.Athlete", "Athlete")
                        .WithMany("Foods")
                        .HasForeignKey("AthleteId");

                    b.Navigation("Athlete");
                });

            modelBuilder.Entity("SoldierTrack.Data.Models.FoodDiary", b =>
                {
                    b.HasOne("SoldierTrack.Data.Models.Athlete", "Athlete")
                        .WithMany("FoodDiaries")
                        .HasForeignKey("AthleteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Athlete");
                });

            modelBuilder.Entity("SoldierTrack.Data.Models.Meal", b =>
                {
                    b.HasOne("SoldierTrack.Data.Models.FoodDiary", "FoodDiary")
                        .WithMany("Meals")
                        .HasForeignKey("FoodDiaryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FoodDiary");
                });

            modelBuilder.Entity("SoldierTrack.Data.Models.MealFood", b =>
                {
                    b.HasOne("SoldierTrack.Data.Models.Food", "Food")
                        .WithMany("MealsFoods")
                        .HasForeignKey("FoodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SoldierTrack.Data.Models.Meal", "Meal")
                        .WithMany("MealsFoods")
                        .HasForeignKey("MealId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Food");

                    b.Navigation("Meal");
                });

            modelBuilder.Entity("SoldierTrack.Data.Models.MembershipArchive", b =>
                {
                    b.HasOne("SoldierTrack.Data.Models.Athlete", "Athlete")
                        .WithMany()
                        .HasForeignKey("AthleteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SoldierTrack.Data.Models.Membership", "Membership")
                        .WithMany()
                        .HasForeignKey("MembershipId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Athlete");

                    b.Navigation("Membership");
                });

            modelBuilder.Entity("SoldierTrack.Data.Models.Athlete", b =>
                {
                    b.HasOne("SoldierTrack.Data.Models.Membership", "Membership")
                        .WithOne("Athlete")
                        .HasForeignKey("SoldierTrack.Data.Models.Athlete", "MembershipId");

                    b.Navigation("Membership");
                });

            modelBuilder.Entity("SoldierTrack.Data.Models.Exercise", b =>
                {
                    b.Navigation("Achievements");
                });

            modelBuilder.Entity("SoldierTrack.Data.Models.Food", b =>
                {
                    b.Navigation("MealsFoods");
                });

            modelBuilder.Entity("SoldierTrack.Data.Models.FoodDiary", b =>
                {
                    b.Navigation("Meals");
                });

            modelBuilder.Entity("SoldierTrack.Data.Models.Meal", b =>
                {
                    b.Navigation("MealsFoods");
                });

            modelBuilder.Entity("SoldierTrack.Data.Models.Membership", b =>
                {
                    b.Navigation("Athlete")
                        .IsRequired();
                });

            modelBuilder.Entity("SoldierTrack.Data.Models.Workout", b =>
                {
                    b.Navigation("AthletesWorkouts");
                });

            modelBuilder.Entity("SoldierTrack.Data.Models.Athlete", b =>
                {
                    b.Navigation("Achievements");

                    b.Navigation("AthletesWorkouts");

                    b.Navigation("Exercises");

                    b.Navigation("FoodDiaries");

                    b.Navigation("Foods");
                });
#pragma warning restore 612, 618
        }
    }
}
