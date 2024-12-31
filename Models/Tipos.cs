using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDizimoOferta.Models
{
    public class Tipos
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo Nome é necessário")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo Origem é necessário")]
        public  string Origem { get; set; }
    }
}
