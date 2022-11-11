using System;

namespace Models.Entities
{
    public class ChapterModel : BaseEntity
    {
        [Required]
        public string Chapter = string.Empty;
    }
}
