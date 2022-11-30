using Ggram.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ggram.Data.Configurations
{
    public class WallConfiguration : IEntityTypeConfiguration<Wall>
    {
       
        public void Configure(EntityTypeBuilder<Wall> builder)
        {
            builder.HasData(CreateWalls());
        }

        private IEnumerable<Wall> CreateWalls()
        {

            var walls = new List<Wall>();

            var agentWall = new Wall()
            {
                Id = "ba1eaa72-c7e6-4be9-a76f-cf7a12cc4c26",
                OwnerId = "dea12856-c198-4129-b3f3-b893d8395082",
            };

            walls.Add(agentWall);

            var userWall = new Wall()
            {
                Id = "d8a02cd4-dc0b-40c4-8b1a-99069438ce00",
                OwnerId = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
            };

            walls.Add(userWall);

            var testUserWall = new Wall()
            {
                Id = "e3bf6ecf-16a5-4f20-86c1-2247168cdc55",
                OwnerId = "cb410aef-6919-41a7-8bfc-5159f1ff10b7",
            };

            walls.Add(testUserWall);

            return walls;
        }
    }
}
