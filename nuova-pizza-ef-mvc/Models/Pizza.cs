using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace nuova_pizza_ef_mvc.Models
{
    [Table("NuovaPizza")]
    public class Pizza
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Il campo è obbligatorio")]
        [StringLength(100, ErrorMessage = "{0} length must be between {2} and {1}.", MinimumLength = 2)]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Il campo è obbligatorio")]
        [StringLength(200, ErrorMessage = "{0} length must be between {2} and {1}.", MinimumLength = 5)]

        public string Descrizione { get; set; }

        public string? sFoto { get; set; }


        [Required(ErrorMessage = "Il campo è obbligatorio")]
        [Range(1, 20)]
        public double Prezzo { get; set; }

        [NotMapped]
        public IFormFile Foto { get; set; }


        public Pizza()
        {

        }

        
    }
}
