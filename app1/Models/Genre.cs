﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace app1.Models
{
    public class Genre
    {
        public byte Id { get; set; }

        [Required]
        public String Name { get; set; }
    }
}