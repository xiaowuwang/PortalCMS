﻿using Portal.CMS.Entities.Entities.Posts;
using System.Collections.Generic;

namespace Portal.CMS.Web.Areas.Admin.ViewModels.BlogManager
{
    public class AppDrawerViewModel
    {
        public List<Post> PostList { get; set; }
    }
}