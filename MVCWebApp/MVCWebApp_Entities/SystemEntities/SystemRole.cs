using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCWebApp_Entities.SystemEntities
{
    [Table("SystemRole")]
    public class SystemRole
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
    }
}