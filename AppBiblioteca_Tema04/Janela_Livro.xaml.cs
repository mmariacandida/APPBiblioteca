using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace AppBiblioteca_Tema04
{
    /// <summary>
    /// Lógica interna para Janela_Livro.xaml
    /// </summary>
    public partial class Janela_Livro : Window
    {
        public Janela_Livro()
        {
            InitializeComponent();
        }

        private void InserirClick(object sender, RoutedEventArgs e)
        {
             Livro l = new Livro();
            l.Id = int.Parse(txtId.Text);
            l.IdGenero = int.Parse(txtIdGenero.Text);
            l.Escritor = txtEscritor.Text;
            l.Editora = txtEditora.Text;
            NLivro.Inserir(l);
            ListarClick(sender, e);
        }

        private void ListarClick(object sender, RoutedEventArgs e)
        {
            listLivros.ItemsSource = null;
            listLivros.ItemsSource = NLivro.Listar();
        }

        private void AtualizarClick(object sender, RoutedEventArgs e)
        {
            Livro l = new Livro();
            l.IdGenero = int.Parse(txtIdGenero.Text);
            l.Id = int.Parse(txtId.Text);
            l.Escritor = txtEscritor.Text;
            l.Editora = txtEditora.Text;
            NLivro.Atualizar(l);
            ListarClick(sender, e);
        }

        private void ExcluirClick(object sender, RoutedEventArgs e)
        {
            Livro l = new Livro();
            l.Id = int.Parse(txtId.Text);
            NLivro.Excluir(l);
            ListarClick(sender, e);
        }
    }
}
