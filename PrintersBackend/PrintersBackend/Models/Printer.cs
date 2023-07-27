using System.ComponentModel.DataAnnotations.Schema;

namespace PrintersBackend.Models
{
    [Table("Printers")]
    public class Printer
    {
        public int Id { get; set; }
        public string InventoryNum { get; set; }
        public int ModelId { get; set; }

        [ForeignKey("ModelId")]
        public virtual PrinterModel Model { get; set; }
    }
}
