﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IDAGroupMVC.Models
{
    public class Contact : BaseEntity
    {
        [Required]
        [StringLength(maximumLength: 31, MinimumLength = 3)]
        public string Fullname { get; set; }
        [Required]
        [StringLength(maximumLength: 50)]
        public string Email { get; set; }
        [Required]
        [StringLength(maximumLength: 20)]
        public string PhoneNumber { get; set; }
        [StringLength(maximumLength: 70, MinimumLength = 3)]
        [Required]
        public string Subject { get; set; }
        [StringLength(maximumLength: 1500)]
        [Required]
        public string Text { get; set; }
        public bool IsRead { get; set; }
    }
}
