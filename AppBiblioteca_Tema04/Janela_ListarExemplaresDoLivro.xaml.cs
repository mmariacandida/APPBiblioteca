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
    /// Lógica interna para Janela_ListarExemplaresDoLivro.xaml
    /// </summary>
    public partial class Janela_ListarExemplaresDoLivro : Window
    {
        public Janela_ListarExemplaresDoLivro()
        {
            InitializeComponent();
            listLivros.ItemsSource = NLivro.Listar();
        }

        private void ListarClick(object sender, RoutedEventArgs e)
        {
            if (listLivros.SelectedItem != null)
            {
                Livro l = (Livro)listLivros.SelectedItem;
                listExemplares.ItemsSource = null;
                listExemplares.ItemsSource = NExemplar.Listar(l);
            }
            else
                MessageBox.Show("É preciso selecionar um livro primeiro!");
        }
    }
}
