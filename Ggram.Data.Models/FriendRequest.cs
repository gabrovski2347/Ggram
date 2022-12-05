using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Ggram.Data.Models
{
    public class FriendRequest : BaseDeletableModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string SenderId { get; set; } = null!;

        public ApplicationUser Sender { get; set; } = null!;

        [Required]
        public string ReceiverId { get; set; } = null!;

        public ApplicationUser Receiver { get; set; } = null!;
    }
}