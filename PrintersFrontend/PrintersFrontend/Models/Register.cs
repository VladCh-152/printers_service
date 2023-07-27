using System;
using System.ComponentModel.DataAnnotations;

namespace PrintersFrontend.Models
{
    public class Register
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Введите имя")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Введите e-mail")]
        [EmailAddress(ErrorMessage = "Неверный e-mail")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Введите пароль")]
        [StringLength(64, MinimumLength = 6)]
        public string Pass1 { get; set; }

        [Required(ErrorMessage = "Подтвердите пароль")]
        [Compare("Pass1")]
        public string Pass2 { get; set; }
    }
}
