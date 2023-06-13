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
    public partial class formCadastro : ContentPage
    {
        public formCadastro()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            Model.Correntista c = await CorrentistaDataService.save(new Model.Correntista{nome = txtNome.Text, cpf = txtCpf.Text,  data_nasc = dpDataNasc.Date, senha = txtSenha.Text });


            await DisplayAlert("Sucesso", "Cadastro realizado!", "Ok");

            {
                txtNome.Text = "";
                txtSenha.Text = "";
                txtCpf.Text = "";
                dpDataNasc.Date = DateTime.Now;
            }
        }
    }
}