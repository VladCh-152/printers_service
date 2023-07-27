using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;

namespace PrintersFrontend.Models
{
    public class PrinterModel
    {
        public int Id { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Выберите производителя")]
        public int VendorId { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Выберите тип")]
        public int TypeId { get; set; }

        public virtual Vendor Vendor { get; set; }
        public virtual PrinterType Type { get; set; }

        [JsonIgnore]
        public virtual ICollection<Printer> Printers { get; set; } = new List<Printer>();

        public string Name => Vendor?.Name + " " + Type?.Name;
    }
}
