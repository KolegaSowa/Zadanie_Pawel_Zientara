using System.ComponentModel.DataAnnotations;

namespace Zadanie.Models
{
    public class Osoby
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage = "Brak imienia")]
        public string Imie { get; set; }
        [Required(ErrorMessage = "Brak nazwiska")]
        public string Nazwisko { get; set; }
        [Required(ErrorMessage = "Brak daty urodzenia")]
        public DateTime DataUrodzenia { get; set; }
        [Required(ErrorMessage = "Brak adresu")]
        public string Adres {  get; set; }
    }
}
