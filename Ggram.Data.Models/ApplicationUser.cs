using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ggram.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser()
        {
            Posts = new HashSet<Post>();
            Followers = new HashSet<UserFollower>();
            Followed = new HashSet<UserFollowed>();
        }
        //1.1 First Name
        [Required]
        [MaxLength(20)]
        public string FirstName { get; set; }

        //1.2 Last Name
        [Required]
        [MaxLength(20)]
        public string LastName { get; set; }

        [MaxLength(200)]
        public string Description { get; set; } = null!;

        public IEnumerable<Post> Posts { get; set; }

        public IEnumerable<UserFollowed> Followed { get; set; }

        public IEnumerable<UserFollower> Followers { get; set; }
    }
}
