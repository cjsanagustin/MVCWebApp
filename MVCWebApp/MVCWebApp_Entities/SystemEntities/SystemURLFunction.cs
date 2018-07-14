using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCWebApp_Entities.SystemEntities
{
    [Table("SystemURLFunction")]
    public class SystemURLFunction
    {
        public int Id { get; set; }
        public int SystemURLParentID { get; set; }
        public int SystemURLID { get; set; }
        [Required]
        [StringLength(50)]
        public string FunctionCode { get; set; }
    }
}