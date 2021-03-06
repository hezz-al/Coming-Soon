﻿using System.ComponentModel.DataAnnotations;

namespace MainSite.Models.Entity
{
    public class Setting:BaseEntity
    {
        [Required]
        public string Slogan { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public string PlayStore { get; set; }
        public string AppStore { get; set; }
        public string Facebook { get; set; }
        public string Twitter { get; set; }
        public string Instagram { get; set; }
    }
}
