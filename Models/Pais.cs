using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntregaSprint3.Models
{
    [Table("Pais")]
    public class Pais
    {
        [Column("Id")]
        [Display(Name = "Código do Pais")]
        public int Id { get; set; }

        [Column("PaisNome")]
        [Display(Name = "País")]
        public string PaisNome { get; set; } = string.Empty;
    }
}
