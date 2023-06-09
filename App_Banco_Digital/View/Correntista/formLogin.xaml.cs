﻿using App_Banco_Digital.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_Banco_Digital.View.Correntista
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class formLogin : ContentPage
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            Model.Correntista c = await CorrentistaDataService.login(new Model.Correntista { cpf = txtCpf.Text, senha = txtSenha.Text});

            if (c.id != null)
            {
                await DisplayAlert("Login bem sucedido", "Seja bem vindo " + c.nome, "ok");
            }
        }

        private void cadastro_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new formCadastro());
        }
    }
}