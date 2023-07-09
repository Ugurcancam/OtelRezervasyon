using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OtelRezervasyon.webui.Dtos.RegisterDto
{
    public class NewUserDto
    {
        [Required(ErrorMessage = "Ad Soyad alanı zorunludur")]
        public string AdSoyad { get; set; }
        
        [Required(ErrorMessage = "Kullanıcı adı alanı zorunludur")]
        public string Username { get; set; }
        public string Mail { get; set; }

        [Required(ErrorMessage = "Şifre alanı zorunludur")]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Şifreler Uyuşmuyor")]
        public string ConfirmPassword { get; set; }
    }
}