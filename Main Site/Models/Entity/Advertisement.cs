using System;
using System.ComponentModel.DataAnnotations;

namespace MainSite.Models.Entity
{
    public class Advertisement : BaseEntity
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string Link { get; set; }
        public string Image { get; set; }
        public DateTime EndDate { get; set; }
        [Required]
        public bool Status { get; set; }
    }
}
