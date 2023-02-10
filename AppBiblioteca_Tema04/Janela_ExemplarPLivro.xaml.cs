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
    /// Lógica interna para Janela_ExemplarPLivro.xaml
    /// </summary>
    public partial class Janela_ExemplarPLivro : Window
    {
        public Janela_ExemplarPLivro()
        {
            InitializeComponent();
        }

        private void ListarClick(object sender, RoutedEventArgs e)
        {
            listLivro.ItemsSource = null;
            listLivro.ItemsSource = NLivro.Listar();
            listExemplar.ItemsSource = null;
            listExemplar.ItemsSource = NExemplar.Listar();
        }

        private void AtribuirClick(object sender, RoutedEventArgs e)
        {
            if (listLivro.SelectedItem != null &&
               listExemplar.SelectedItem != null)
            {
                Livro l = (Livro)listLivro.SelectedItem;
                Exemplar ex = (Exemplar)listExemplar.SelectedItem;
                NExemplar.AtribuirLivro(ex, l);
                ListarClick(sender, e);
            }
            else
            {
                MessageBox.Show("É preciso selecionar um livro e um exemplar antes");
            }
        }
    }
}
