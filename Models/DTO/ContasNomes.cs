using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDizimoOferta.Models.DTO
{
    public class ContasNomes
    {
        public int Id { get; set; }
        public DateTime Data { get; set; } = DateTime.Now;
        public string Competencia { get; set; }
        public string PessoaNome { get; set; }
        public string TipoNome { get; set; }
        public decimal ValorConta { get; set; }
        public string Observacao { get; set; }
    }
}
