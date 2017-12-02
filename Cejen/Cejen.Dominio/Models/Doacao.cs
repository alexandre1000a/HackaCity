using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cejen.Dominio.Models
{
    public class Doacao
    {
        public int Id { get; set; }
        public Usuario Doador { get; set; }
        public Campanha Campanha { get; set; }
        public int Quantidade { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataDeDoacao { get; set; }
    }
}
