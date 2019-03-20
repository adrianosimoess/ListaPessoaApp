using System;

using Xamarin.Forms;

namespace ListaPessoaApp
{
    public class ListaPage : ContentPage
    {
        public ListaPage()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

