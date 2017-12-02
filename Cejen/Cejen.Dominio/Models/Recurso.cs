using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cejen.Dominio.Models
{
    public class Recurso
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        public decimal Valor { get; set; }
        public TipoRecurso TipoRecurso { get; set; }
        public Campanha Campanha { get; set; }
    }
}
