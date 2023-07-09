using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OtelRezervasyon.webui.Dtos.LoginDto
{
    public class LoginUserDto
    {
        
        [Required(ErrorMessage = "Kullanıcı adı alanı zorunludur")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Şifre alanı zorunludur")]
        public string Password { get; set; }

    }
}