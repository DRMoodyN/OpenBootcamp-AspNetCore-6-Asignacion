using System.Data;
using System;

namespace Models.Entities
{
    public abstract class BaseEntity
    {
        [Required]
        [Key]
        public int BaseEntityId { get; set; }
        public int UserId { get; set; }
        public DateTime CreateAt { get; set; } = DateTime.Now;
        public User UpdteBy { get; set; } = new User();
        public DateTime UpdteAt { get; set; } = DateTime.Now;
        public DateTime DeleteAt { get; set; } = DateTime.Now;
        public bool IsDelete { get; set; } = true;
    }
}
