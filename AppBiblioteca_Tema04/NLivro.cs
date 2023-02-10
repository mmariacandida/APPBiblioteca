using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace AppBiblioteca_Tema04
{
    static class NLivro
    {
        private static List<Livro> livros = new List<Livro>();

        public static void Inserir(Livro l)
        {
            Abrir();
            livros.Add(l);
            Salvar();
        }

        public static void Excluir(Livro l)
        {
            Abrir();
            livros.Remove(Listar(l.Id));
            Salvar();
        }

        public static void Atualizar(Livro l)
        {
            Abrir();
            Livro obj = Listar(l.Id);
            obj.Escritor = l.Escritor;
            obj.Id = l.Id;
            obj.Editora = l.Editora;
            obj.IdGenero = l.IdGenero;
            Salvar();
        }

        public static List<Livro> Listar()
        {
            Abrir();
            return livros;
        }

        public static Livro Listar(int id)
        {
            foreach (Livro l in livros)
            {
                if (l.Id == id)
                {
                    return l;
                }
            }

            return null;
        }

        internal static void AplicarGenero(Livro l, Genero g)
        {
            throw new NotImplementedException();
        }

        public static List<Livro> Listar(Genero g)
        {
            Abrir();
            List<Livro> ls = new List<Livro>();
            foreach (Livro obj in livros)
                if (obj.IdGenero == g.Id) ls.Add(obj);
            return ls;
        }



        public static void Abrir()
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Livro>));
                using (StreamReader reader = new StreamReader("./livro.xml"))
                {
                    livros = (List<Livro>)serializer.Deserialize(reader);
                }
            }
            catch
            {
                livros = new List<Livro>();
            }
        }

        public static void Salvar()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Livro>));
            using (StreamWriter writer = new StreamWriter("./livro.xml"))
            {
                serializer.Serialize(writer, livros);
            }
        }

        public static void AtribuirGenero(Livro l, Genero g)
        {
            Abrir();
            Livro obj = Listar(l.Id);
            obj.IdGenero = g.Id;
            Salvar();
        }
    }
}
