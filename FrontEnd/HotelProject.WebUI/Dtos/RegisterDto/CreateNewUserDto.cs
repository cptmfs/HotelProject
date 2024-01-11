using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.RegisterDto
{
    public class CreateNewUserDto
    {
        [Required(ErrorMessage ="İsim bilgisi gereklidir.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Soyisim bilgisi gereklidir.")]

        public string Surname { get; set; }
        [Required(ErrorMessage = "Kullanıcı adı bilgisi gereklidir.")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Email bilgisi gereklidir.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Şifre bilgisi giriniz.")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Şifre tekrar bilgisi giriniz.")]
        [Compare("Password", ErrorMessage ="Şifreler Uyuşmuyor.")]
        public string ConfirmPassword { get; set; }

    }
}
