﻿using Ggram.Web.ViewModels.Post;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ggram.Web.ViewModels
{
    public class WallViewModel
    {
        public IEnumerable<PostViewModel> Posts { get; set; }
    }
}
