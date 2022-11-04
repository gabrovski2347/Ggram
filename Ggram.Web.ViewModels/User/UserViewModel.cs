using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ggram.Web.ViewModels.User
{
    public class UserViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public WallViewModel Wall { get; set; }
    }
}
