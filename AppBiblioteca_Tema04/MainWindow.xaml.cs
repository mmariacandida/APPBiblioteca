using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AppBiblioteca_Tema04
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Genero_Click(object sender, RoutedEventArgs e)
        {
            Janela_Genero w = new Janela_Genero();
            w.ShowDialog();
        }

        private void Button_Livro_Click(object sender, RoutedEventArgs e)
        {
            Janela_Livro w = new Janela_Livro();
            w.ShowDialog();
        }

        private void Button_Exemplar_Click(object sender, RoutedEventArgs e)
        {
            Janela_Exemplar w = new Janela_Exemplar();
            w.ShowDialog();
        }

        private void Button_CadastroExemplarLivro_Click(object sender, RoutedEventArgs e)
        {
            Janela_LivroPGenero w = new Janela_LivroPGenero();
            w.ShowDialog();
        }

        private void Button_CadastroLivroGen_Click(object sender, RoutedEventArgs e)
        {
            Janela_LivroPGenero w = new Janela_LivroPGenero();
            w.ShowDialog();
        }

        private void Button_ListarLivroGen_Click(object sender, RoutedEventArgs e)
        {
            Janela_ListarLivrosDoGenero w = new Janela_ListarLivrosDoGenero();
            w.ShowDialog();
        }

        private void Button_ListarExemplarLivro_Click(object sender, RoutedEventArgs e)
        {
            Janela_ListarExemplaresDoLivro w = new Janela_ListarExemplaresDoLivro();
            w.ShowDialog();
        }
    }
}
