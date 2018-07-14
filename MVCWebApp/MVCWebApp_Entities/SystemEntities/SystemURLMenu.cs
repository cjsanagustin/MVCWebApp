using System.ComponentModel.DataAnnotations.Schema;

namespace MVCWebApp_Entities.SystemEntities
{
    [Table("SystemURLMenu")]
    public class SystemURLMenu
    {
        public int Id { get; set; }
        public int SystemURLParentID { get; set; }
        public int SystemURLID { get; set; }
        public bool IsHidden { get; set; }
    }
}