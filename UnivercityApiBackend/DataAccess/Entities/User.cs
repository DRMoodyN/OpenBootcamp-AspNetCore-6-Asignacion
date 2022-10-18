using System;

namespace UnivercityApiBackend.DataAccess.Entities
{
    public class User : BaseEntity
    {
        [Required, StringLength(50, ErrorMessage = "50 Caracters max")]
        public string FirstName { get; set; } = string.Empty;

        [Required, StringLength(50, ErrorMessage = "50 Caracters max")]
        public string LastName { get; set; } = string.Empty;

        [Required, StringLength(50, ErrorMessage = "50 Caracters max")]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required, StringLength(50, ErrorMessage = "50 Caracters max")]
        public string Password { get; set; } = string.Empty;
    }
}
