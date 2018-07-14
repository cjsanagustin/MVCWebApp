using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCWebApp_Entities.SystemEntities
{
    [Table("SystemURL")]
    public class SystemURL
    {
        public int Id { get; set; }
        [Required]
        [StringLength(250)]
        public string URL { get; set; }
        [Required]
        [StringLength(100)]
        public string PageName { get; set; }
        [Required]
        [StringLength(250)]
        public string PageDecription { get; set; }
        public bool IsOnTopMenu { get; set; }
        public bool IsOnMenu { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
    }
}