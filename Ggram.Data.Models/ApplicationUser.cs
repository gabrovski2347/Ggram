using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
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
            Friends = new HashSet<ApplicationUser>();
            Requests = new HashSet<Request>();
        }
        //1.1 First Name
        public string FirstName { get; set; }

        //1.2 Last Name
        public string LastName { get; set; }

        public IEnumerable<ApplicationUser> Friends { get; set; }

        public IEnumerable<Request> Requests { get; set; }

        [ForeignKey(nameof(WallId))]
        public string WallId { get; set; }

        public Wall Wall { get; set; }

        //1.4 Posts
        //1.3 Images
    }
}
