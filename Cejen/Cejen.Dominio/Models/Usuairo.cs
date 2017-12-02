using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cejen.Dominio.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public TipoUsuario TipoUsurio { get; set; }

        public List<Campanha> Campanhas { get; set; }
        public List<Doacao> Doacoes { get; set; }
    }
}
