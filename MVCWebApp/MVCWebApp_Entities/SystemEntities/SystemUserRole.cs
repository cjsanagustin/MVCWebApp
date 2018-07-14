using System.ComponentModel.DataAnnotations.Schema;

namespace MVCWebApp_Entities.SystemEntities
{
    [Table("SystemUserRole")]
    public class SystemUserRole
    {
        public int Id { get; set; }
        public int SystemUserID { get; set; }
        public int SystemRoleID { get; set; }
    }
}