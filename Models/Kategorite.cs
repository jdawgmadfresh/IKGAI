using System.ComponentModel.DataAnnotations;

namespace Main.Models
{
    public class Kategorite
    {
        [Key]
        public int Numri { get; set; }
        public string Emri { get; set; }
    }
}
