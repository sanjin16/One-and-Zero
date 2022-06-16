﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NormativeCalculator.Database.EF;

namespace NormativeCalculator.Database.Migrations
{
    [DbContext(typeof(NormativeCalculatorDbContext))]
    [Migration("20220616081310_newseeddata1")]
    partial class newseeddata1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NormativeCalculator.Database.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateCreated = new DateTime(2020, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            Name = "Pancakes"
                        },
                        new
                        {
                            Id = 2,
                            DateCreated = new DateTime(2020, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            Name = "Waffles"
                        },
                        new
                        {
                            Id = 3,
                            DateCreated = new DateTime(2021, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            Name = "Cake"
                        },
                        new
                        {
                            Id = 4,
                            DateCreated = new DateTime(2019, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            Name = "Lava cake"
                        },
                        new
                        {
                            Id = 5,
                            DateCreated = new DateTime(2022, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            Name = "Muffin"
                        },
                        new
                        {
                            Id = 6,
                            DateCreated = new DateTime(2022, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            Name = "Carrot cake"
                        },
                        new
                        {
                            Id = 7,
                            DateCreated = new DateTime(2022, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            Name = "Cheesecake"
                        },
                        new
                        {
                            Id = 8,
                            DateCreated = new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            Name = "Coffee Cake Recipes"
                        },
                        new
                        {
                            Id = 9,
                            DateCreated = new DateTime(2022, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            Name = "Coconut Cake"
                        },
                        new
                        {
                            Id = 10,
                            DateCreated = new DateTime(2022, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            Name = "Cupcakes"
                        },
                        new
                        {
                            Id = 11,
                            DateCreated = new DateTime(2022, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            Name = "Fruitcake"
                        },
                        new
                        {
                            Id = 12,
                            DateCreated = new DateTime(2022, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            Name = "Holiday cake"
                        });
                });

            modelBuilder.Entity("NormativeCalculator.Database.Entities.Ingredient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("MeasureType")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Ingredients");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsDeleted = false,
                            MeasureType = 3,
                            Name = "Suger",
                            Price = 2m,
                            Quantity = 100
                        },
                        new
                        {
                            Id = 2,
                            IsDeleted = false,
                            MeasureType = 5,
                            Name = "Flour",
                            Price = 6m,
                            Quantity = 100
                        },
                        new
                        {
                            Id = 3,
                            IsDeleted = false,
                            MeasureType = 1,
                            Name = "Egg",
                            Price = 2m,
                            Quantity = 2
                        },
                        new
                        {
                            Id = 4,
                            IsDeleted = false,
                            MeasureType = 3,
                            Name = "Brown suger",
                            Price = 2m,
                            Quantity = 200
                        },
                        new
                        {
                            Id = 5,
                            IsDeleted = false,
                            MeasureType = 5,
                            Name = "Milk",
                            Price = 1m,
                            Quantity = 200
                        },
                        new
                        {
                            Id = 6,
                            IsDeleted = false,
                            MeasureType = 5,
                            Name = "Water",
                            Price = 2m,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 7,
                            IsDeleted = false,
                            MeasureType = 3,
                            Name = "Buter",
                            Price = 4m,
                            Quantity = 350
                        },
                        new
                        {
                            Id = 8,
                            IsDeleted = false,
                            MeasureType = 2,
                            Name = "Walnut",
                            Price = 10m,
                            Quantity = 2
                        },
                        new
                        {
                            Id = 9,
                            IsDeleted = false,
                            MeasureType = 1,
                            Name = "Banana",
                            Price = 3m,
                            Quantity = 5
                        },
                        new
                        {
                            Id = 10,
                            IsDeleted = false,
                            MeasureType = 3,
                            Name = "Salt",
                            Price = 1m,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 11,
                            IsDeleted = false,
                            MeasureType = 2,
                            Name = "Strawberries",
                            Price = 15m,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 12,
                            IsDeleted = false,
                            MeasureType = 3,
                            Name = "Baking powder",
                            Price = 4m,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 13,
                            IsDeleted = false,
                            MeasureType = 2,
                            Name = "Blueberry",
                            Price = 12m,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 14,
                            IsDeleted = false,
                            MeasureType = 1,
                            Name = "Vanilla extract",
                            Price = 6m,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 15,
                            IsDeleted = false,
                            MeasureType = 3,
                            Name = "Caramel",
                            Price = 11m,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 16,
                            IsDeleted = false,
                            MeasureType = 2,
                            Name = "Honey",
                            Price = 40m,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 17,
                            IsDeleted = false,
                            MeasureType = 3,
                            Name = "Baking soda",
                            Price = 12m,
                            Quantity = 1
                        });
                });

            modelBuilder.Entity("NormativeCalculator.Database.Entities.Recipe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("UserId");

                    b.ToTable("Recipe");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            DateCreated = new DateTime(2022, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "This easy American pancake recipe makes light and fluffy pancakes that are great for a weekend brunch.",
                            IsDeleted = false,
                            Name = "Lite Carrot Cake",
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 6,
                            DateCreated = new DateTime(2022, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Pipe royal icing carrots on parchment to decorate your cake.",
                            IsDeleted = false,
                            Name = "Royal Icing Carrots",
                            UserId = 2
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 7,
                            DateCreated = new DateTime(2022, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "This is a great recipe that gets compliments when ever I make it..",
                            IsDeleted = false,
                            Name = "Brownie Caramel Cheesecake",
                            UserId = 2
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 7,
                            DateCreated = new DateTime(2022, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Love lemon meringue pie and cheesecake?",
                            IsDeleted = false,
                            Name = "Lemon Meringue Cheesecake",
                            UserId = 5
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 8,
                            DateCreated = new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Love lemon meringue pie and cheesecake?",
                            IsDeleted = false,
                            Name = "Blueberry Buttermilk Coffeecake",
                            UserId = 7
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 8,
                            DateCreated = new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "This is really easy and so very, very good.",
                            IsDeleted = false,
                            Name = "Apple Coffee Cake",
                            UserId = 3
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 9,
                            DateCreated = new DateTime(2022, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "A moist coconut pound cake, a crowd pleaser.",
                            IsDeleted = false,
                            Name = "Coconut Cream Pound Cake",
                            UserId = 4
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 9,
                            DateCreated = new DateTime(2022, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Coconut oil is the special ingredient in these delicately flavored, tender cupcakes. Garnish with a slice of fresh Key lime if desired.",
                            IsDeleted = false,
                            Name = "Coconut Cupcakes",
                            UserId = 5
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 10,
                            DateCreated = new DateTime(2022, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "This simple white cake recipe uses just 7 ingredients.",
                            IsDeleted = false,
                            Name = "Simple White Cake",
                            UserId = 5
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 10,
                            DateCreated = new DateTime(2022, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "A cinnamon sugary cupcake reminiscent of the deep - fried Mexican dessert!.",
                            IsDeleted = false,
                            Name = "Sopapilla Cupcakes",
                            UserId = 6
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = 11,
                            DateCreated = new DateTime(2022, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "This has been a favorite of my husband's since I can long remember.",
                            IsDeleted = false,
                            Name = "English Walnut Date Cake",
                            UserId = 3
                        },
                        new
                        {
                            Id = 12,
                            CategoryId = 11,
                            DateCreated = new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "This is a large recipe that is rich and dark.",
                            IsDeleted = false,
                            Name = "Festive Fruitcakee",
                            UserId = 3
                        },
                        new
                        {
                            Id = 13,
                            CategoryId = 12,
                            DateCreated = new DateTime(2022, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "A sweet biscuit-style shortcake with two layers of juicy strawberries and cream.",
                            IsDeleted = false,
                            Name = "Strawberry Shortcake",
                            UserId = 2
                        });
                });

            modelBuilder.Entity("NormativeCalculator.Database.Entities.RecipeIngredients", b =>
                {
                    b.Property<int>("IngredientId")
                        .HasColumnType("int");

                    b.Property<int>("RecipeId")
                        .HasColumnType("int");

                    b.Property<int>("MeasureType")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("IngredientId", "RecipeId");

                    b.HasIndex("RecipeId");

                    b.ToTable("RecipeIngredients");

                    b.HasData(
                        new
                        {
                            IngredientId = 3,
                            RecipeId = 1,
                            MeasureType = 1,
                            Quantity = 3
                        },
                        new
                        {
                            IngredientId = 3,
                            RecipeId = 2,
                            MeasureType = 2,
                            Quantity = 3
                        },
                        new
                        {
                            IngredientId = 5,
                            RecipeId = 2,
                            MeasureType = 5,
                            Quantity = 2
                        },
                        new
                        {
                            IngredientId = 5,
                            RecipeId = 3,
                            MeasureType = 4,
                            Quantity = 4
                        },
                        new
                        {
                            IngredientId = 7,
                            RecipeId = 3,
                            MeasureType = 3,
                            Quantity = 700
                        },
                        new
                        {
                            IngredientId = 7,
                            RecipeId = 4,
                            MeasureType = 2,
                            Quantity = 2
                        },
                        new
                        {
                            IngredientId = 2,
                            RecipeId = 4,
                            MeasureType = 5,
                            Quantity = 600
                        },
                        new
                        {
                            IngredientId = 6,
                            RecipeId = 5,
                            MeasureType = 4,
                            Quantity = 1
                        },
                        new
                        {
                            IngredientId = 11,
                            RecipeId = 5,
                            MeasureType = 5,
                            Quantity = 3
                        },
                        new
                        {
                            IngredientId = 10,
                            RecipeId = 6,
                            MeasureType = 3,
                            Quantity = 2
                        },
                        new
                        {
                            IngredientId = 13,
                            RecipeId = 6,
                            MeasureType = 3,
                            Quantity = 5
                        },
                        new
                        {
                            IngredientId = 17,
                            RecipeId = 7,
                            MeasureType = 3,
                            Quantity = 150
                        },
                        new
                        {
                            IngredientId = 16,
                            RecipeId = 7,
                            MeasureType = 3,
                            Quantity = 600
                        },
                        new
                        {
                            IngredientId = 15,
                            RecipeId = 8,
                            MeasureType = 2,
                            Quantity = 1
                        },
                        new
                        {
                            IngredientId = 14,
                            RecipeId = 8,
                            MeasureType = 3,
                            Quantity = 200
                        },
                        new
                        {
                            IngredientId = 13,
                            RecipeId = 9,
                            MeasureType = 1,
                            Quantity = 10
                        },
                        new
                        {
                            IngredientId = 12,
                            RecipeId = 10,
                            MeasureType = 3,
                            Quantity = 300
                        },
                        new
                        {
                            IngredientId = 12,
                            RecipeId = 11,
                            MeasureType = 3,
                            Quantity = 300
                        },
                        new
                        {
                            IngredientId = 9,
                            RecipeId = 12,
                            MeasureType = 3,
                            Quantity = 300
                        },
                        new
                        {
                            IngredientId = 13,
                            RecipeId = 13,
                            MeasureType = 3,
                            Quantity = 300
                        },
                        new
                        {
                            IngredientId = 8,
                            RecipeId = 13,
                            MeasureType = 5,
                            Quantity = 100
                        });
                });

            modelBuilder.Entity("NormativeCalculator.Database.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "Sanjin",
                            LastName = "Sabanovic",
                            PasswordHash = new byte[] { 107, 94, 64, 162, 54, 41, 11, 240, 234, 30, 149, 239, 91, 222, 8, 211, 204, 134, 116, 191, 238, 164, 102, 37, 173, 34, 103, 120, 178, 212, 86, 73, 99, 241, 250, 230, 56, 51, 203, 2, 192, 76, 61, 112, 84, 89, 162, 103, 53, 208, 10, 30, 3, 53, 216, 87, 189, 135, 147, 12, 83, 186, 220, 82 },
                            PasswordSalt = new byte[] { 208, 36, 189, 249, 3, 184, 31, 72, 78, 66, 192, 202, 12, 154, 62, 165, 231, 188, 161, 205, 151, 178, 229, 202, 171, 223, 12, 64, 39, 239, 117, 153, 187, 16, 26, 20, 249, 127, 83, 80, 142, 31, 88, 105, 230, 230, 151, 31, 60, 217, 194, 147, 111, 18, 180, 81, 89, 162, 19, 145, 78, 55, 6, 219, 63, 191, 47, 46, 238, 238, 20, 30, 211, 20, 183, 164, 31, 145, 193, 216, 148, 21, 239, 66, 248, 143, 250, 218, 89, 166, 72, 110, 46, 230, 56, 246, 210, 254, 172, 171, 144, 157, 181, 42, 218, 248, 56, 8, 241, 69, 127, 177, 102, 198, 241, 166, 121, 94, 77, 208, 124, 148, 1, 181, 215, 232, 151, 247 },
                            Username = "sanjin"
                        },
                        new
                        {
                            Id = 2,
                            FirstName = "Merisa",
                            LastName = "Mulac",
                            PasswordHash = new byte[] { 3, 135, 30, 77, 133, 20, 195, 62, 254, 142, 194, 46, 198, 227, 108, 139, 235, 124, 252, 228, 239, 185, 35, 32, 230, 145, 152, 253, 183, 206, 37, 64, 29, 26, 165, 9, 213, 34, 32, 21, 251, 32, 220, 100, 61, 247, 113, 226, 197, 65, 93, 52, 57, 240, 104, 235, 167, 80, 37, 229, 7, 85, 68, 84 },
                            PasswordSalt = new byte[] { 208, 36, 189, 249, 3, 184, 31, 72, 78, 66, 192, 202, 12, 154, 62, 165, 231, 188, 161, 205, 151, 178, 229, 202, 171, 223, 12, 64, 39, 239, 117, 153, 187, 16, 26, 20, 249, 127, 83, 80, 142, 31, 88, 105, 230, 230, 151, 31, 60, 217, 194, 147, 111, 18, 180, 81, 89, 162, 19, 145, 78, 55, 6, 219, 63, 191, 47, 46, 238, 238, 20, 30, 211, 20, 183, 164, 31, 145, 193, 216, 148, 21, 239, 66, 248, 143, 250, 218, 89, 166, 72, 110, 46, 230, 56, 246, 210, 254, 172, 171, 144, 157, 181, 42, 218, 248, 56, 8, 241, 69, 127, 177, 102, 198, 241, 166, 121, 94, 77, 208, 124, 148, 1, 181, 215, 232, 151, 247 },
                            Username = "merisa"
                        },
                        new
                        {
                            Id = 3,
                            FirstName = "Alema",
                            LastName = "Duvnjak",
                            PasswordHash = new byte[] { 241, 74, 172, 28, 150, 19, 103, 204, 70, 247, 159, 71, 43, 40, 114, 35, 56, 29, 81, 127, 26, 206, 249, 77, 206, 80, 248, 168, 158, 94, 165, 233, 85, 133, 251, 227, 148, 141, 19, 96, 9, 248, 54, 29, 188, 183, 182, 150, 13, 113, 125, 67, 94, 251, 75, 135, 19, 175, 25, 77, 168, 62, 112, 143 },
                            PasswordSalt = new byte[] { 208, 36, 189, 249, 3, 184, 31, 72, 78, 66, 192, 202, 12, 154, 62, 165, 231, 188, 161, 205, 151, 178, 229, 202, 171, 223, 12, 64, 39, 239, 117, 153, 187, 16, 26, 20, 249, 127, 83, 80, 142, 31, 88, 105, 230, 230, 151, 31, 60, 217, 194, 147, 111, 18, 180, 81, 89, 162, 19, 145, 78, 55, 6, 219, 63, 191, 47, 46, 238, 238, 20, 30, 211, 20, 183, 164, 31, 145, 193, 216, 148, 21, 239, 66, 248, 143, 250, 218, 89, 166, 72, 110, 46, 230, 56, 246, 210, 254, 172, 171, 144, 157, 181, 42, 218, 248, 56, 8, 241, 69, 127, 177, 102, 198, 241, 166, 121, 94, 77, 208, 124, 148, 1, 181, 215, 232, 151, 247 },
                            Username = "alema"
                        },
                        new
                        {
                            Id = 4,
                            FirstName = "Amra",
                            LastName = "Dedic",
                            PasswordHash = new byte[] { 130, 60, 235, 206, 202, 100, 108, 200, 47, 153, 125, 118, 80, 103, 9, 27, 59, 8, 29, 181, 204, 164, 203, 66, 200, 141, 222, 138, 119, 196, 232, 130, 80, 174, 88, 171, 41, 117, 202, 88, 45, 59, 100, 105, 14, 13, 130, 190, 247, 119, 105, 254, 161, 95, 137, 112, 243, 2, 232, 66, 185, 22, 31, 213 },
                            PasswordSalt = new byte[] { 208, 36, 189, 249, 3, 184, 31, 72, 78, 66, 192, 202, 12, 154, 62, 165, 231, 188, 161, 205, 151, 178, 229, 202, 171, 223, 12, 64, 39, 239, 117, 153, 187, 16, 26, 20, 249, 127, 83, 80, 142, 31, 88, 105, 230, 230, 151, 31, 60, 217, 194, 147, 111, 18, 180, 81, 89, 162, 19, 145, 78, 55, 6, 219, 63, 191, 47, 46, 238, 238, 20, 30, 211, 20, 183, 164, 31, 145, 193, 216, 148, 21, 239, 66, 248, 143, 250, 218, 89, 166, 72, 110, 46, 230, 56, 246, 210, 254, 172, 171, 144, 157, 181, 42, 218, 248, 56, 8, 241, 69, 127, 177, 102, 198, 241, 166, 121, 94, 77, 208, 124, 148, 1, 181, 215, 232, 151, 247 },
                            Username = "amra"
                        },
                        new
                        {
                            Id = 5,
                            FirstName = "Mirza",
                            LastName = "Lepir",
                            PasswordHash = new byte[] { 141, 161, 238, 142, 185, 235, 251, 168, 128, 46, 157, 81, 6, 66, 71, 215, 250, 167, 90, 53, 62, 196, 7, 163, 160, 126, 32, 32, 78, 37, 190, 23, 175, 67, 24, 183, 138, 145, 243, 112, 2, 131, 176, 188, 210, 189, 118, 181, 51, 240, 107, 96, 38, 248, 70, 227, 31, 245, 38, 104, 20, 111, 3, 186 },
                            PasswordSalt = new byte[] { 208, 36, 189, 249, 3, 184, 31, 72, 78, 66, 192, 202, 12, 154, 62, 165, 231, 188, 161, 205, 151, 178, 229, 202, 171, 223, 12, 64, 39, 239, 117, 153, 187, 16, 26, 20, 249, 127, 83, 80, 142, 31, 88, 105, 230, 230, 151, 31, 60, 217, 194, 147, 111, 18, 180, 81, 89, 162, 19, 145, 78, 55, 6, 219, 63, 191, 47, 46, 238, 238, 20, 30, 211, 20, 183, 164, 31, 145, 193, 216, 148, 21, 239, 66, 248, 143, 250, 218, 89, 166, 72, 110, 46, 230, 56, 246, 210, 254, 172, 171, 144, 157, 181, 42, 218, 248, 56, 8, 241, 69, 127, 177, 102, 198, 241, 166, 121, 94, 77, 208, 124, 148, 1, 181, 215, 232, 151, 247 },
                            Username = "mirza"
                        },
                        new
                        {
                            Id = 6,
                            FirstName = "Haris",
                            LastName = "Tulic",
                            PasswordHash = new byte[] { 151, 145, 71, 57, 237, 250, 194, 5, 50, 196, 7, 74, 34, 80, 191, 127, 164, 51, 108, 148, 52, 12, 205, 5, 174, 53, 119, 176, 32, 33, 108, 235, 80, 137, 121, 235, 249, 106, 46, 114, 197, 228, 207, 209, 17, 100, 217, 224, 222, 22, 74, 43, 224, 230, 21, 158, 16, 7, 74, 159, 100, 27, 143, 183 },
                            PasswordSalt = new byte[] { 208, 36, 189, 249, 3, 184, 31, 72, 78, 66, 192, 202, 12, 154, 62, 165, 231, 188, 161, 205, 151, 178, 229, 202, 171, 223, 12, 64, 39, 239, 117, 153, 187, 16, 26, 20, 249, 127, 83, 80, 142, 31, 88, 105, 230, 230, 151, 31, 60, 217, 194, 147, 111, 18, 180, 81, 89, 162, 19, 145, 78, 55, 6, 219, 63, 191, 47, 46, 238, 238, 20, 30, 211, 20, 183, 164, 31, 145, 193, 216, 148, 21, 239, 66, 248, 143, 250, 218, 89, 166, 72, 110, 46, 230, 56, 246, 210, 254, 172, 171, 144, 157, 181, 42, 218, 248, 56, 8, 241, 69, 127, 177, 102, 198, 241, 166, 121, 94, 77, 208, 124, 148, 1, 181, 215, 232, 151, 247 },
                            Username = "haris"
                        },
                        new
                        {
                            Id = 7,
                            FirstName = "Nejra",
                            LastName = "Setka",
                            PasswordHash = new byte[] { 157, 19, 132, 101, 157, 151, 108, 81, 241, 201, 170, 132, 91, 243, 78, 37, 36, 117, 25, 101, 127, 150, 175, 220, 84, 131, 83, 124, 178, 176, 213, 137, 168, 104, 117, 109, 235, 146, 166, 121, 178, 26, 121, 191, 172, 15, 143, 15, 93, 217, 134, 216, 90, 13, 180, 176, 185, 194, 230, 53, 201, 209, 222, 159 },
                            PasswordSalt = new byte[] { 208, 36, 189, 249, 3, 184, 31, 72, 78, 66, 192, 202, 12, 154, 62, 165, 231, 188, 161, 205, 151, 178, 229, 202, 171, 223, 12, 64, 39, 239, 117, 153, 187, 16, 26, 20, 249, 127, 83, 80, 142, 31, 88, 105, 230, 230, 151, 31, 60, 217, 194, 147, 111, 18, 180, 81, 89, 162, 19, 145, 78, 55, 6, 219, 63, 191, 47, 46, 238, 238, 20, 30, 211, 20, 183, 164, 31, 145, 193, 216, 148, 21, 239, 66, 248, 143, 250, 218, 89, 166, 72, 110, 46, 230, 56, 246, 210, 254, 172, 171, 144, 157, 181, 42, 218, 248, 56, 8, 241, 69, 127, 177, 102, 198, 241, 166, 121, 94, 77, 208, 124, 148, 1, 181, 215, 232, 151, 247 },
                            Username = "nejra"
                        });
                });

            modelBuilder.Entity("NormativeCalculator.Database.Entities.Recipe", b =>
                {
                    b.HasOne("NormativeCalculator.Database.Entities.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NormativeCalculator.Database.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("User");
                });

            modelBuilder.Entity("NormativeCalculator.Database.Entities.RecipeIngredients", b =>
                {
                    b.HasOne("NormativeCalculator.Database.Entities.Ingredient", "Ingredient")
                        .WithMany("RecipeIngredients")
                        .HasForeignKey("IngredientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NormativeCalculator.Database.Entities.Recipe", "Recipe")
                        .WithMany("RecipeIngredients")
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ingredient");

                    b.Navigation("Recipe");
                });

            modelBuilder.Entity("NormativeCalculator.Database.Entities.Ingredient", b =>
                {
                    b.Navigation("RecipeIngredients");
                });

            modelBuilder.Entity("NormativeCalculator.Database.Entities.Recipe", b =>
                {
                    b.Navigation("RecipeIngredients");
                });
#pragma warning restore 612, 618
        }
    }
}