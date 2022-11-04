using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ggram.Data.Models
{
    public class Request
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(SenderId))]
        public string SenderId { get; set; }
        public ApplicationUser Sender { get; set; }
    }
}
