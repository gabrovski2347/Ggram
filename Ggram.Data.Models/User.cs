using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ggram.Data.Models
{
    public class User : IdentityUser
    {
        //1.1 First Name
        public string FirstName { get; set; }

        //1.2 Last Name
        public string LastName { get; set; }

        //1.4 Posts
        public IEnumerable<Post> Posts { get; set; }
        //1.3 Images
    }
}
