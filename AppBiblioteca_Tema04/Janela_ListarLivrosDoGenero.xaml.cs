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
    /// Lógica interna para Janela_ListarLivrosDoGenero.xaml
    /// </summary>
    public partial class Janela_ListarLivrosDoGenero : Window
    {
        public Janela_ListarLivrosDoGenero()
        {
            InitializeComponent();
        }

        private void ListarClick(object sender, RoutedEventArgs e)
        {
            listLivros.ItemsSource = null;
            listLivros.ItemsSource = NLivro.Listar();
            listGenero.ItemsSource = null;
            listGenero.ItemsSource = NGenero.Listar();
        }

        private void AplicarClick(object sender, RoutedEventArgs e)
        {
            if (listLivros.SelectedItem != null &&
               listGenero.SelectedItem != null)
            {
                Livro l = (Livro)listLivros.SelectedItem;
                Genero g = (Genero)listGenero.SelectedItem;
                NLivro.AtribuirGenero(l, g);
                ListarClick(sender, e);
            }
            else
            {
                MessageBox.Show("É preciso selecionar 1 livro e 1 gênero!");
            }
        }
    }
}
