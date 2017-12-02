using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cejen.Dominio.Models
{
    public class Campanha
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public Usuario Criador { get; set; }
        public Recurso Recurso { get; set; }
        public List<Doacao> Doacoes { get; set; }
        public DateTime DataDeCriacao { get; set; }
        public DateTime DataDeCampanha { get; set; }
        public DateTime DataDeEncerramento { get; set; }
    }
}
