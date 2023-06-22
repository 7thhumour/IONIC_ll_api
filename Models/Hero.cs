using System.ComponentModel.DataAnnotations;

namespace Ionic_II.Models
{
    public class Hero
    {
        [Key]
        public int HeroId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Birthday { get; set; }
        public string Height { get; set; }
        public bool isAlive { get; set; }
        public string FileName { get; set; }
        public string ImageBase64 { get; set; }

    }
}
