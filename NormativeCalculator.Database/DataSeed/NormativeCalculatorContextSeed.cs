using Microsoft.EntityFrameworkCore;
using NormativeCalculator.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace NormativeCalculator.Database.DataSeed
{
    public static class NormativeCalculatorContextSeed
    {
        public static void DataSeed(this ModelBuilder modelBuilder)
        {

            using var hmac = new HMACSHA512();
            modelBuilder.Entity<User>().HasData
        (
                new User
                {
                    Id = 1,
                    LastName="Sabanovic",
                    FirstName="Sanjin",
                    Username= "Sanjin",
                    PasswordHash =hmac.ComputeHash(Encoding.UTF8.GetBytes("Password")),
                    PasswordSalt=hmac.Key
                }

                );
            modelBuilder.Entity<RecipeCategories>().HasData
            (
            new RecipeCategories
            {
                Id = 1,
                Name = "Pancakes",
                DateCreated = DateTime.Now,

            },
            new RecipeCategories
            {
                Id = 2,
                Name = "Waffles",
                DateCreated = new DateTime(new Random().Next(2022, 2022))

            }
            );
            modelBuilder.Entity<Ingredient>().HasData
       (
       new Ingredient
       {
           Id = 1,
           Name = "Suger",
           Price = 2,
           Quantity = 100,
           measureType = Common.Enum.MeasureType.gr,
       },
        new Ingredient
        {
            Id = 2,
            Name = "Flour",
            Price = 6,
            Quantity = 100,
            measureType = Common.Enum.MeasureType.ml,
        },
          new Ingredient
          {
              Id = 3,
              Name = "egg",
              Price = 2,
              Quantity = 2,
              measureType = Common.Enum.MeasureType.kom,
          },
            new Ingredient
            {
                Id = 4,
                Name = "Brown suger",
                Price = 2,
                Quantity = 200,
                measureType = Common.Enum.MeasureType.gr,
            },
             new Ingredient
             {
                 Id = 5,
                 Name = "Milk",
                 Price = 1,
                 Quantity = 200,
                 measureType = Common.Enum.MeasureType.ml,
             },
               new Ingredient
               {
                   Id = 6,
                   Name = "Water",
                   Price = 2,
                   Quantity = 1,
                   measureType = Common.Enum.MeasureType.ml,
               },
                new Ingredient
                {
                    Id = 7,
                    Name = "Buter",
                    Price = 4,
                    Quantity = 350,
                    measureType = Common.Enum.MeasureType.gr,
                },
                new Ingredient
                {
                    Id = 8,
                    Name = "Walnut",
                    Price = 10,
                    Quantity = 2,
                    measureType = Common.Enum.MeasureType.kg,
                },
                 new Ingredient
                 {
                     Id = 9,
                     Name = "Banana",
                     Price = 3,
                     Quantity = 5,
                     measureType = Common.Enum.MeasureType.kom,
                 },
                  new Ingredient
                  {
                      Id = 10,
                      Name = "Salt",
                      Price = 1,
                      Quantity = 1,
                      measureType = Common.Enum.MeasureType.gr,
                  });
        }
    }
}
