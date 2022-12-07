using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ggram.Web.ViewModels.Post
{
    public class AddPostViewModel
    {
        public string? UserId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }
    }
}
