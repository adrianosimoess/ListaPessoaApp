using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListaPessoaApp.Model;
using Xamarin.Forms;

namespace ListaPessoaApp
{
    public partial class MainPage : ContentPage
    {
        List<Pessoa> lista_pessoa = new List<Pessoa>();

        public MainPage()
        {
            InitializeComponent();
        }

        void Handle_Clicked_1(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new ListaPage(lista_pessoa));
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Pessoa pessoa = new Pessoa();

            pessoa.nome = (nome.Text);
            pessoa.sobrenome = (sobrenome.Text);
            pessoa.dtCadastro = string.Format("{0: dd/MM/yyyy HH:mm:ss}",DateTime.Now);


            lista_pessoa.Add(pessoa);

            nome.Text = string.Empty;
            sobrenome.Text = string.Empty;
        }
    }
}
