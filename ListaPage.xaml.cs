using System;
using System.Collections.Generic;
using ListaPessoaApp.Model;
using Xamarin.Forms;

namespace ListaPessoaApp
{
    public partial class ListaPage : ContentPage
    {

        public ListaPage(List<Pessoa> lista_pessoa)
        {
            InitializeComponent();
            listView_dadisPessoas.ItemsSource = lista_pessoa;
        }
    }
}
