using EntregaSprint3.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntregaSprint3.Models
{
    [Table("SaidaProduto")]
    public class SaidaProduto
    {
        [Column("Id")]
        [Display(Name = "Cód. Saida do Produto")]
        public int Id { get; set; }

        [ForeignKey("ProdutoId")]
        [Display(Name = "Produto")]
        public int ProdutoId { get; set; }
        public Produto? Produto { get; set; }

        [Column("DataSaidaProduto")]
        [Display(Name = "Data da Saida")]
        public DateTime DataSaidaProduto { get; set; }

        [Column("QuantidadeSaidaProduto")]
        [Display(Name = "Quantidade")]
        public int QuantidadeSaidaProduto { get; set; }

        [ForeignKey("UsuarioId")]
        [Display(Name = "Usuario")]
        public int UsuarioId { get; set; }
        public Usuario? Usuario { get; set; }

        [ForeignKey("ClienteId")]
        [Display(Name = "Cliente")]
        public int ClienteId { get; set; }
        public Cliente? Cliente { get; set; }

        [ForeignKey("TipoSaidaId")]
        [Display(Name = "TipoSaida")]
        public int TipoSaidaId { get; set; }
        public TipoSaida? TipoSaida { get; set; }

    }
}
