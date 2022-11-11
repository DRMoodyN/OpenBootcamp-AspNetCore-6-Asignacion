namespace Models.Entities
{
    public class Course : BaseEntity
    {
        [Required, StringLength(50, ErrorMessage = "50 Caracters max")]
        public string CursoName { get; set; } = string.Empty;

        [Required, StringLength(280, ErrorMessage = "280 Caracters max")]
        public string DescriptioCorta { get; set; } = string.Empty;

        [Required]
        public string DescriptionLarga { get; set; } = string.Empty;

        [Required, StringLength(280, ErrorMessage = "100 Caracters max")]
        public string Objectivo { get; set; } = string.Empty;

        [Required, StringLength(280, ErrorMessage = "100 Caracters max")]
        public string Requisitos { get; set; } = string.Empty;

        [Required]
        public NivelCurso NivelCurso { get; set; } = NivelCurso.Basico;
        [Required]
        public List<Category> Categories { get; set; } = new List<Category>();
        [Required]
        public List<Student> Students { get; set; } = new List<Student>();
        [Required]
        public ChapterModel ChapterModel { get; set; } = new ChapterModel();
    }
}
