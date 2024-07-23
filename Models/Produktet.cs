using System.ComponentModel.DataAnnotations;

namespace Main.Models
{
    public class Produktet
    {
        [Key]
        public int Numri { get; set; }
        public String Emri { get; set; }
    }
}
