using System.ComponentModel.DataAnnotations;

namespace PrintersFrontend.Models
{
    public class Printer
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Введите наименование")]
        [StringLength(16, ErrorMessage = "Наименование должно быть короче 16 символов")]
        public string InventoryNum { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Выберите модель")]
        public int ModelId { get; set; }
        public virtual PrinterModel Model { get; set; }
        
    }
}
