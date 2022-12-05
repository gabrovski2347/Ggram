using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Ggram.Data.Models
{
    public class UserFriend : BaseDeletableModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string UserId { get; set; } = null!;

        public ApplicationUser User { get; set; } = null!;

        [Required]
        public string FriendId { get; set; } = null!;

        public ApplicationUser Friend { get; set; } = null!;
    }
}