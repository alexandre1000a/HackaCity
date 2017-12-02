using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cejen.Dominio.Tema
{
   public class Tema
    {
        public int IdTema { get; set; }
        public string Texto { get; set; }
        public bool Ativo { get; set; }
        public virtual ICollection<Cejen.Dominio.TextoTema.TextoTema> TextoTema { get; set; }
        public DateTime DtInsere { get; set; }
    }
}
