using System;
using System.Collections.Generic;
using System.Text;

namespace AppBiblioteca_Tema04
{
    public class Exemplar
    {
        public int Id { get; set; }

        public int IdLivro { get; set; }

        public int Codigo { get; set; }

        public int Localizaçao { get; set; }

        public override string ToString()
        {
            return $"{Id} - {IdLivro} - {Codigo} - {Localizaçao}";
        }
    }
}
