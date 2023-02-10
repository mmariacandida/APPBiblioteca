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
    /// Lógica interna para Janela_Exemplar.xaml
    /// </summary>
    public partial class Janela_Exemplar : Window
    {
        public Janela_Exemplar()
        {
            InitializeComponent();
        }

        private void InserirClick(object sender, RoutedEventArgs e)
        {
            Exemplar ext = new Exemplar();
            ext.Id = int.Parse(txtIdExemplar.Text);
            ext.IdLivro = int.Parse(txtIdLivro.Text);
            ext.Codigo = int.Parse(txtCodigo.Text);
            ext.Localizaçao = int.Parse(txtLoc.Text);
            NExemplar.Inserir(ext);
            ListarClick(sender, e);
        }

        private void ListarClick(object sender, RoutedEventArgs e)
        {
            listExemplares.ItemsSource = null;
            listExemplares.ItemsSource = NExemplar.Listar();
        }

        private void AtualizarClick(object sender, RoutedEventArgs e)
        {
            Exemplar ext = new Exemplar();
            ext.Id = int.Parse(txtIdExemplar.Text);
            ext.IdLivro = int.Parse(txtIdLivro.Text);
            ext.Codigo = int.Parse(txtCodigo.Text);
            ext.Localizaçao = int.Parse(txtLoc.Text);

            NExemplar.Atualizar(ext);
            ListarClick(sender, e);
        }

        private void ExcluirClick(object sender, RoutedEventArgs e)
        {
            Exemplar ext = new Exemplar();
            ext.Id = int.Parse(txtIdExemplar.Text);
            NExemplar.Excluir(ext);
            ListarClick(sender, e);
        }
        private void listExemplares_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listExemplares.SelectedItem != null)
            {
                Exemplar obj = (Exemplar)listExemplares.SelectedItem; if(obj != null){ 
                    txtIdExemplar.Text = obj.Id.ToString();
                    txtCodigo.Text = obj.Codigo.ToString();
                    txtLoc.Text = obj.Localizaçao.ToString();
                }
            }
        }
    }
}
