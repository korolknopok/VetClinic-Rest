using System.ComponentModel.DataAnnotations;

namespace VetClinic_Rest.Models
{
    public class Clients
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; } = null!;
        public long Phone_number { get; set; }
    }
}
