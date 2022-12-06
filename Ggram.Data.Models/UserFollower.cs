using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ggram.Data.Models
{
    public class UserFollower : BaseDeletableModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string FollowerId { get; set; } = null!;

        [ForeignKey(nameof(FollowerId))]
        public ApplicationUser Follower { get; set; } = null!;

    }
}