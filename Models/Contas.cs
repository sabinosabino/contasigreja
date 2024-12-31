using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDizimoOferta.Models
{
    public class Contas
    {
        public int Id { get; set; }
        public DateTime Data { get; set; } = DateTime.Now;
        public string Competencia { get; set; }
        public int PessoaId { get; set; }
        public int TipoId { get; set; }
        public decimal ValorConta { get; set; }
        public string Observacao { get; set; }
    }
}
