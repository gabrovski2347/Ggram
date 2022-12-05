using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ggram.Data.Models
{
    public class BaseDeletableModel
    {
        [DefaultValue("false")]
        public bool IsDeleted { get; set; }
    }
}
