using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace PrintersFrontend.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Введите имя")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Введите e-mail")]
        [EmailAddress(ErrorMessage = "Неверный e-mail")]
        public string Mail { get; set; }
        public int RoleId { get; set; }

        [Required(ErrorMessage = "Введите пароль")]
        [StringLength(64, MinimumLength = 6)]
        public string Password { get; set; }
        public virtual Role role { get; set; }
    }

    public class AUser
    { 
        [Required(ErrorMessage = "Введите e-mail")]
        [EmailAddress(ErrorMessage = "Неверный e-mail")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Введите пароль")]
        [StringLength(64, MinimumLength = 6)]
        public string Password { get; set; }
    }
    public class login_token
    {
        public string token { get; set; }
        public string name { get; set; }
    }
}
