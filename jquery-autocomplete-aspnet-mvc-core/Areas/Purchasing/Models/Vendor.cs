
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace jquery_autocomplete_aspnet_mvc_core.Areas.Purchasing.Models
{
    [Table("Vendor", Schema = "Purchasing")]  
    public class Vendor
    {
        [Key]
        public int BusinessEntityID { get; set; }

        public string AccountNumber { get; set; }

        public string Name { get; set; }

    }
}
