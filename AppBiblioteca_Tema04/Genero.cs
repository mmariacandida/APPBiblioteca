using System;
using System.Collections.Generic;
using System.Text;

namespace AppBiblioteca_Tema04
{
    class Genero
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public override string ToString()
        {
            return Nome;
        }
    }
}
