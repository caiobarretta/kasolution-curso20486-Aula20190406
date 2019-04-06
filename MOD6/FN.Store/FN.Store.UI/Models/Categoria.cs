using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FN.Store.UI.Models
{
    [Table(nameof(Categoria))]
    public class Categoria
    {
        [Key]
        [Required(ErrorMessage = "Campo Obrigatório.")]
        public int Id { get; set; }

        [Column(TypeName = "varchar(100)")]
        [Required(ErrorMessage = "Campo Obrigatório.")]
        public string Nome { get; set; }

        public ICollection<Produto> Produtos { get; set; }
    }
}
