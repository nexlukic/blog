﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Blog.Biznis.DTO;

namespace Blog.Models.Aplication
{
    public class SingleViewModel
    {
       public List<PostDto> post { get; set; }
    }
}