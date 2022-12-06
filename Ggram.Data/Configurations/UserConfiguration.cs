using Ggram.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ggram.Data.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.HasData(CreateUsers());
        }

        private IEnumerable<ApplicationUser> CreateUsers()
        {
            var hasher = new PasswordHasher<ApplicationUser>();

            var users = new List<ApplicationUser>();

            var agent = new ApplicationUser()
            {
                Id = "dea12856-c198-4129-b3f3-b893d8395082",
                UserName = "agent@mail.com",
                FirstName = "Petar",
                LastName = "Petrov",
                NormalizedUserName = "agent@mail.com",
                Email = "agent@mail.com",
                NormalizedEmail = "agent@mail.com",
                Description = "I am agent"
            };

            agent.PasswordHash = hasher.HashPassword(agent, "agent123");

            users.Add(agent);

            var user = new ApplicationUser()
            {
                Id = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                UserName = "guest@mail.com",
                FirstName = "Georgi",
                LastName = "Petrov",
                NormalizedUserName = "guest@mail.com",
                Email = "guest@mail.com",
                NormalizedEmail = "guest@mail.com",
                Description = "I am user1"
            };

            user.PasswordHash = hasher.HashPassword(user, "user123");

            users.Add(user);

            var testUser = new ApplicationUser()
            {
                Id = "cb410aef-6919-41a7-8bfc-5159f1ff10b7",
                UserName = "test@mail.com",
                FirstName = "Dimitar",
                LastName = "Geshev",
                NormalizedUserName = "test@mail.com",
                Email = "test@mail.com",
                NormalizedEmail = "test@mail.com",
                Description = "I am user2"
            };

            testUser.PasswordHash = hasher.HashPassword(testUser, "user123");

            users.Add(testUser);

            return users;
        }
    }
}
