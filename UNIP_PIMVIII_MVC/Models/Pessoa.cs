using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UNIP_PIMVIII_MVC.Models
{
    [Table("pessoa")]
    public class Pessoa
    {
        [Display(Name = "ID")]
        [Column("ID")]
        public int ID { get; set; } = 0;

        [Display(Name = "NOME")]
        [Column("NOME")]
        public String NOME { get; set; } = String.Empty;
        
        [Display(Name = "CPF")]
        [Column("CPF")]
        public int CPF { get; set; } = 0;

        [Display(Name = "ENDERECO")]
        [Column("ENDERECO")]
        public int ENDERECO { get; set; } = 0;
    }
}
