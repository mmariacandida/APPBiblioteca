﻿using System;
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
    /// Lógica interna para Janela_Genero.xaml
    /// </summary>
    public partial class Janela_Genero : Window
    {
        public Janela_Genero()
        {
            InitializeComponent();
        }

        private void InserirClick(object sender, RoutedEventArgs e)
        {
            Genero g = new Genero();
            g.Id = int.Parse(txtId.Text);
            g.Nome = txtNome.Text;
            NGenero.Inserir(g);
            ListarClick(sender, e);
        }

        private void AtualizarClick(object sender, RoutedEventArgs e)
        {
            Genero g = new Genero();
            g.Id = int.Parse(txtId.Text);
            g.Nome = txtNome.Text;
            NGenero.Atualizar(g);
            ListarClick(sender, e);
        }

        private void ExcluirClick(object sender, RoutedEventArgs e)
        {
            Genero g = new Genero();
            g.Id = int.Parse(txtId.Text);
            NGenero.Excluir(g);
            ListarClick(sender, e);
        }

        private void ListarClick(object sender, RoutedEventArgs e)
        {
            listGeneros.ItemsSource = null;
            listGeneros.ItemsSource = NGenero.Listar();
        }
        private void listGeneros_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listGeneros.SelectedItem != null)
            {
                Genero obj = (Genero)listGeneros.SelectedItem;
                txtId.Text = obj.Id.ToString();
                txtNome.Text = obj.Nome;
            }
        }
    }
}


