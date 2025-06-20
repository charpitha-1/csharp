using System.ComponentModel.DataAnnotations;

namespace RoomManagerMvcApp.DTO
{
    public class LoginInfoDTO
    {
        [Required]
        public string Email {  get; set; }
        [Required]
        public string Password { get; set; }
    }
}
