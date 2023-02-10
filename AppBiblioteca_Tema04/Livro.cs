using System;
using System.Collections.Generic;
using System.Text;

namespace AppBiblioteca_Tema04
{
    public class Livro
    {
        public int Id { get; set; }

        public int IdGenero { get; set; }

        public string Escritor { get; set; }

        public string Editora { get; set; }

        public override string ToString()
        {
            return $"{Id} - {IdGenero} - {Escritor} - {Editora}";
        }
    }
}
