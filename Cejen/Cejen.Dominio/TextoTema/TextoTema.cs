using System;
using System.Collections;
namespace Cejen.Dominio.TextoTema
{
    public class TextoTema
    {
        public int IdTextoTema { get; set; }
        public string Texto { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public virtual Cejen.Dominio.Tema.Tema Tema { get; set; }
        public bool Ativo { get; set; }
        public DateTime DtInsere { get; set; }
    }
}
