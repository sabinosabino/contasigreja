using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDizimoOferta.Models
{
    public class Pessoas
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo nome é necessário")]
        public string Nome { get; set; }

        public DateTime? DataNascimento { get; set; }

        public string Endereco { get; set; }

        public string Telefone { get; set; }

        public string Email { get; set; }

        public string Tipo { get; set; }
    }
}
