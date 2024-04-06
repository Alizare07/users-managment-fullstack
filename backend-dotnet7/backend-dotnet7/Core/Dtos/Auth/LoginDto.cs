using System.ComponentModel.DataAnnotations;

namespace backend_dotnet7.Core.Dtos.Auth
{
    public class LoginDto
    {
        [Required(ErrorMessage ="Username is required")]
        public string UserName { get; set;  }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }

    }
}
