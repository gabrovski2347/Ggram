using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ggram.Web.ViewModels.User
{
    public class UserViewModel
    {
        public string Id { get; set; } = null!;

        public string Nickname { get; set; }

        //1.1 First Name
        [Required]
        [MaxLength(20)]
        [MinLength(2)]
        public string FirstName { get; set; }

        //1.2 Last Name
        [Required]
        [MaxLength(20)]
        [MinLength(2)]
        public string LastName { get; set; }

        public string FullName;

        [MaxLength(200)]
        public string Description { get; set; }
    }
}
