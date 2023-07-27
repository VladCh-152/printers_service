using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace PrintersBackend.Models
{
    [Table("PrinterModels")]
    public class PrinterModel
    {
        public int Id { get; set; }
        public int VendorId { get; set; }
        public int TypeId { get; set; }

        [ForeignKey("VendorId")]
        public virtual Vendor Vendor { get; set; }

        [ForeignKey("TypeId")]
        public virtual PrinterType Type { get; set; }

        [JsonIgnore]
        public virtual ICollection<Printer> Printers { get; set; } = new List<Printer>();
    }
}
