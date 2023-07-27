using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace PrintersFrontend.Models
{
    public class PrinterType
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Введите наименование")]
        [StringLength(16, ErrorMessage = "Наименование должно быть короче 16 символов")]
        public string Name { get; set; }

        [JsonIgnore]
        public virtual ICollection<PrinterModel> Models { get; set; } = new List<PrinterModel>();
    }
}
