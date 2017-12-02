using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cejen.Model
{
    public class TextoTema
    {
        public int IdTextoTema { get; set; }
        public string Texto { get; set; }
        public Temas Tema { get; set; }
        public bool Ativo { get; set; }
    }
}
