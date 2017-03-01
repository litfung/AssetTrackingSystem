﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AssetTrackingSystem_v2.Models
{
    public class GeneralCategory
    {
        public int Id { get; set; }

        [Required]
        [Index(IsUnique = true)]
        public string Name { get; set; }

        [Required]
        [StringLength(2, MinimumLength = 2)]
        [RegularExpression("^A-Z\\S$", ErrorMessage = "Only uppercase letters allowed with no empty space")]
        public string ShortName { get; set; }
        public List<Category> Categories { get; set; }
    }
}