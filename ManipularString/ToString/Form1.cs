﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToString
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            #region ToString / Contains
            //string texto = "Este tipo de variável é alfanumérica";

            //if (texto.Contains("tipo"))
            //{
            //    txt1.Text = "Contém.";
            //}
            //else
            //{
            //    txt1.Text = "Não Contém.";
            //}

            //int numero = 5400;
            //bool logico = false;

            //txt1.Text = numero.ToString();
            //txt1.Text = logico.ToString();
            #endregion

            #region To Upper / To Lower

            //string nome = "Gustavo";

            //txt1.Text = nome.ToUpper();
            ////txt1.Text = nome.ToLower();
            #endregion

            #region IndexOf / LastIndexOf
            //string nome = "Gustavo Henrique";

            //// Retorna a posição do primeiro caractere ou conjunto de caracteres na string

            ////int indice = nome.IndexOf('a');
            ////int indice = nome.IndexOf("ust");
            ////int indice = nome.IndexOf('e');

            ////int indice = nome.IndexOf('u', 7);
            ////int indice = nome.IndexOf('u', 7, 2);

            ////int indice = nome.LastIndexOf('e');
            //int indice = nome.LastIndexOf('e',2,8);


            //txt1.Text = indice.ToString();
            #endregion

            #region Insert / Replace

            //string nome = "Henrique Silva";
            //string nomeFinal = nome.Insert(9, "Gustavo ");

            //nomeFinal = nomeFinal.Replace('a', 'y');

            //txt1.Text = nomeFinal;

            #endregion

            #region Length / SubString

            //string nome = "Gustavo Henrique Silva";
            //int tamanho = nome.Length;

            //txt1.Text = "Seu nome contém: " + tamanho + " letras.\n";

            //for(int i = 0; i < tamanho; i++)
            //{
            //    txt1.Text += nome[i];
            //}

            //string parteDoNome = nome.Substring(0, 7);
            //txt1.Text += "\n" + parteDoNome;

            //parteDoNome = nome.Substring(nome.IndexOf(" ") + 1);
            //txt1.Text += "\n" + parteDoNome;

            #endregion

            #region Split

            // txt1.Text = null;

            ////string nomes = "Gustavo Leonardo-Rafael_Daniela_Luísa-Giovana";
            ////char[] separador = { ' ', '-', '_' };

            ////string[] resultado = nomes.Split(separador);

            //string nomes = "Gustavo_+_Leonardo_+_Rafael_+_Daniela_+_Luísa_+_Giovana";
            // string[] separador = { "_+_" };

            // string[] resultado = nomes.Split(separador, StringSplitOptions.None);

            // foreach (string nome in resultado)
            // {
            //     txt1.Text += nome + "\n";
            // }
            #endregion

            #region StartsWith / EndsWith

            //txt1.Text = null;
            //string nome = "Gabriel";

            //if (nome.StartsWith("g", StringComparison.OrdinalIgnoreCase))
            //{
            //    txt1.Text += "Começa com G. ";
            //}
            //else
            //{
            //    txt1.Text += "Não começa com G. ";
            //}

            //if (nome.EndsWith("o"))
            //{
            //    txt1.Text += "Termina com o.";
            //}
            //else
            //{
            //    txt1.Text += "Não termina com o.";
            //}

            #endregion

            #region Trim / TrimStart / TrimEnd

            //string mensagem = "     %%9 --___9 %  Olá  ,    mundo!    ";
            //char[] separadores = { ' ', '%', '9', '-', '_' };

            //txt1.Text = ">" + mensagem.Trim(separadores) + "<";

            #endregion

            #region CompareTo / Equals

            //string nome = "Lucas", nome2 = "Gabriel";

            ////if (nome.Equals("gUStavo", StringComparison.OrdinalIgnoreCase))
            ////{
            ////    txt1.Text = "São iguais.";
            ////}
            ////else
            ////{
            ////    txt1.Text = "São diferentes";
            ////}

            //txt1.Text = nome.CompareTo(nome2).ToString();

            #endregion

            #region Format

            ////decimal valor = 19.95m;
            ////double temperatura = 25.8;

            ////string mensagem = "O valor do produto é: " + valor + ". E a temperatura é de: " + temperatura + "°C.";
            ////mensagem = String.Format("O valor do produto é: {0:C2}. E a temperatura é de: {1:N3}°C.", valor, temperatura); 

            ////string mensagem = String.Format("Hoje é {0:D} e são {0:T} horas.", DateTime.Now);
            //string mensagem = $"Hoje é {DateTime.Now:D} e são {DateTime.Now:T} horas.";

            //txt1.Text = mensagem;

            #endregion
        }
    }
}
