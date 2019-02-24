using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDProgrammers.Models
{
    public class PessoaModel
    {
        public int Id { get; set; }

        [DisplayName("Nome completo")]
        [StringLength(100)]
        [Required]        
        public string NomeCompleto { get; set; }

        [DisplayName("Email")]
        [StringLength(50)]
        [Required]
        public string Email { get; set; }

        [DisplayName("Telefone")]
        [StringLength(20)]
        [Required]
        public string Telefone { get; set; }
    }
}
