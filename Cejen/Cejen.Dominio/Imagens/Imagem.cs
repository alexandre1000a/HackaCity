using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cejen.Dominio.Imagens
{
    public class Imagem
    {
        public int Id { get; set; }
        public DateTime DtInsere { get; set; }
        public string Base64 { get; set; }
        public string Tipo { get; set; }
    }
}
