using System.Data;
using System;

namespace UnivercityApiBackend.DataAccess.Entities
{
    public class BaseEntity
    {
        [Required]
        [Key]
        public int BaseEntityId { get; set; }
        public string CreateBy { get; set; } = string.Empty;
        public DateTime CreateAt { get; set; } = DateTime.Now;
        public string UpdteBy { get; set; } = string.Empty;
        public DateTime UpdteAt { get; set; } = DateTime.Now;
        public string UpdateBy { get; set; } = string.Empty;
        public DateTime DeleteAt { get; set; } = DateTime.Now;
        public bool IsDelete { get; set; } = true;
    }
}
