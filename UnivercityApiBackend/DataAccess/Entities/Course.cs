using System;

namespace UnivercityApiBackend.DataAccess.Entities
{
    public class Course : BaseEntity
    {
        [Required, StringLength(50, ErrorMessage = "50 Caracters max")]
        public string CursoName { get; set; } = string.Empty;

        [Required, StringLength(280, ErrorMessage = "280 Caracters max")]
        public string DescriptioCorta { get; set; } = string.Empty;

        [Required]
        public string DescriptionLarga { get; set; } = string.Empty;

        [Required]
        public string Objectivo { get; set; } = string.Empty;
        [Required]
        public string Requisitos { get; set; } = string.Empty;

        public NivelCurso NivelCurso { get; set; }
    }
}
