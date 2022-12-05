using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ggram.Web.ViewModels.Post
{
    public class PostViewModel
    {
        [Required]
        [MaxLength(20)]
        [MinLength(2)]
        public string Title { get; set; } = null!;

        [MaxLength(200)]
        public string Description { get; set; } = null!;
    }
}
