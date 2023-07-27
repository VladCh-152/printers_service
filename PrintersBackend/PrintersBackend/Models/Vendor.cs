using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace PrintersBackend.Models
{
    [Table("Vendors")]
    public class Vendor
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [JsonIgnore]
        public virtual ICollection<PrinterModel> Models { get; set; } = new List<PrinterModel>();
    }
}
