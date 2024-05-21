
using System.ComponentModel.DataAnnotations;

namespace Application.DTO.Request.Identity
{
    public class LoginUserRequestDTO
    {
        [EmailAddress]
        //[RegularExpression()]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
