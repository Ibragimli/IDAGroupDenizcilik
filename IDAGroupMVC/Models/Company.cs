﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IDAGroupMVC.Models
{
    public class Company : BaseEntity
    {
        [StringLength(maximumLength: 50, MinimumLength = 2)]
        public string Name { get; set; }
        [StringLength(maximumLength: 100, MinimumLength = 3)]
        public string Title { get; set; }
        public bool IsHome { get; set; }
        [StringLength(maximumLength: 1000)]
        public string Description { get; set; }
        [StringLength(maximumLength: 150, MinimumLength = 5)]
        public int? ViewCountId { get; set; }
        public ViewCount ViewCount { get; set; }
        public string Website { get; set; }
        [NotMapped]
        public List<IFormFile> ImageFiles { get; set; }
        [NotMapped]
        public IFormFile PosterImageFile { get; set; }
        [NotMapped]
        public List<int> CompanyImagesIds { get; set; }
        public List<CompanyImages> CompanyImages { get; set; }

    }
}
