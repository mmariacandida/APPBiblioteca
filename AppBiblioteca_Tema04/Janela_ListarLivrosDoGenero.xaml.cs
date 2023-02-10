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
            if (listGenero.SelectedItem != null)
            {
                Genero g = (Genero)listGenero.SelectedItem;
                if (g != null)
                {
                    listLivros.ItemsSource = null;
                    listLivros.ItemsSource = NLivro.Listar(g); ;
                }
                    
            }
            else
            {
                listLivros.ItemsSource = null;
                listLivros.ItemsSource = NLivro.Listar();
                listGenero.ItemsSource = null;
                listGenero.ItemsSource = NGenero.Listar();
            }
            
        }

        
    }
}
