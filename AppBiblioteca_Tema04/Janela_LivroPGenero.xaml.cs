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
    /// Lógica interna para Janela_LivroPGenero.xaml
    /// </summary>
    public partial class Janela_LivroPGenero : Window
    {
        public Janela_LivroPGenero()
        {
            InitializeComponent();
            listLivros.ItemsSource = null;
            listLivros.ItemsSource = NLivro.Listar();
            listGenero.ItemsSource = null;
            listGenero.ItemsSource = NGenero.Listar();
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
            if (listLivros.SelectedItem != null && listGenero.SelectedItem != null)
            {
                Livro l = (Livro)listLivros.SelectedItem;
                Genero g = (Genero)listGenero.SelectedItem;
                NLivro.AtribuirGenero(l, g);
                ListarClick(sender, e);
            }
            else
            {
                ListarClick(sender, e);
                MessageBox.Show("É preciso selecionar um livro e um gênero");
            }
        }
    }
}
