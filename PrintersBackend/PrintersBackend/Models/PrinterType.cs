using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace PrintersBackend.Models
{
    [Table("PrinterTypes")]
    public class PrinterType
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [JsonIgnore]
        public virtual ICollection<PrinterModel> Models { get; set; } = new List<PrinterModel>();
    }
}
