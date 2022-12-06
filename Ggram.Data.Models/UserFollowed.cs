using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ggram.Data.Models
{
    public class UserFollowed : BaseDeletableModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string FollowedId { get; set; } = null!;

        [ForeignKey(nameof(FollowedId))]
        public ApplicationUser Followed { get; set; } = null!;
    }
}
