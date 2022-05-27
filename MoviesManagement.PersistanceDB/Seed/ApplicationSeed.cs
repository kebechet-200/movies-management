using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MoviesManagement.Domain.POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesManagement.PersistanceDB.Seed
{
    public static class ApplicationSeed
    {
        public static void Initialize(this ModelBuilder builder)
        {
            SeedMovies(builder);
            SeedUserAndRole(builder);
        }

        private static void SeedMovies(ModelBuilder builder)
        {
            builder.Entity<Movie>().HasData(
                new Movie
                {
                    Id = 1,
                    Name = "შეშლილთა კუნძული",
                    Description = "ფილმის აღწერა #1",
                    StartDate = DateTime.Now.AddHours(1),
                    Image = "https://fr.web.img4.acsta.net/medias/nmedia/18/69/96/84/19151192.jpg",
                    IsActive = true,
                    IsExpired = false
                },

                new Movie
                {
                    Id = 2,
                    Name = "ჰარი პოტერი და ფილოსოფიური ქვა",
                    Description = "ფილმის აღწერა #2",
                    StartDate = DateTime.Now.AddHours(3),
                    Image = "https://www.themoviedb.org/t/p/w500/wuMc08IPKEatf9rnMNXvIDxqP4W.jpg",
                    IsActive = true,
                    IsExpired = false
                },

                new Movie
                {
                    Id = 3,
                    Name = "დედოფლის გამბიტი",
                    Description = "ფილმის აღწერა #3",
                    StartDate = DateTime.Now.AddHours(8),
                    Image = "https://cdn.unitycms.io/image/ocroped/1200,1200,1000,1000,0,0/J-Xznv7DCWA/0MhZW_2tq5Y8clI2S8XVNo.jpg",
                    IsActive = true,
                    IsExpired = false
                },

                new Movie
                {
                    Id = 4,
                    Name = "პროფესორი და შეშლილი",
                    Description = "ფილმის აღწერა #4",
                    StartDate = DateTime.Now,
                    Image = "https://fr.web.img6.acsta.net/pictures/19/02/13/12/13/2348674.jpg",
                    IsActive = true,
                    IsExpired = true
                }
            );
        }

        private static void SeedUserAndRole(ModelBuilder builder)
        {
            var user = new User
            {
                Email = "lasha997@gmail.com",
                NormalizedEmail = "LASHA997@GMAIL.COM",
                UserName = "lasha997",
                NormalizedUserName = "LASHA997",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString("D")
            };

            var password = new PasswordHasher<User>();
            var hashed = password.HashPassword(user, "87654321");
            user.PasswordHash = hashed;

            builder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                },
                new IdentityRole
                {
                    Name = "Moderator",
                    NormalizedName = "MODERATOR"
                },
                new IdentityRole
                {
                    Name = "Customer",
                    NormalizedName = "CUSTOMER"
                }
            );

            builder.Entity<User>().HasData(
                new User
                {
                    Email = "lasha997@gmail.com",
                    NormalizedEmail = "LASHA997@GMAIL.COM",
                    UserName = "lasha997",
                    NormalizedUserName = "LASHA997",
                    EmailConfirmed = true,
                    PhoneNumberConfirmed = true,
                    SecurityStamp = Guid.NewGuid().ToString("D"),
                    PasswordHash = hashed
                });
        }
    }
}
