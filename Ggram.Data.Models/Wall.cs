using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ggram.Data.Models
{
    public class Wall
    {
        [Key]
        public int Id { get; set; }

        public string OwnerId { get; set; }

        [ForeignKey(nameof(OwnerId))]
        public ApplicationUser Owner { get; set; }

        public IEnumerable<Post> Posts { get; set; } = new HashSet<Post>();
    }
}
