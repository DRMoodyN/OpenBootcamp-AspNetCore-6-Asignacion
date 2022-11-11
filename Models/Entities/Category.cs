
namespace Models.Entities
{
    public class Category : BaseEntity
    {
        [Required]
        public string CategoryName { get; set; } = null!;
        public List<Course> Courses { get; set; } = new List<Course>();
    }
}

