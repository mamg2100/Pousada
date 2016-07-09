using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pousada
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)

        {
            
           
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "admin" && txtSenha.Text == "admin")
            {
                Principal inicial = new Principal();
                inicial.Show();
            }
            else
            {
                MessageBox.Show("Usuário ou senha não cadastrados");
                limpaCampos();
                txtUsuario.Focus();

            }

        }

        private void limpaCampos()
        {
            txtUsuario.Text = "";
            txtSenha.Text = "";
            

        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) {

                if (txtUsuario.Text != "")
                {
                    if (txtUsuario.Text == "admin")
                    {
                        txtSenha.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Usuário não cadastrado!");
                        txtUsuario.Text = "";
                        txtUsuario.Focus();
                  }
                    
                }
                else { 
                                
                }
            
            }
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {

                if (txtSenha.Text != "")
                {
                    if (txtSenha.Text == "admin")
                    {
                        Principal principal = new Principal();
                        principal.Show();
                        
                       
                    }
                    else
                    {
                        MessageBox.Show("Senha incorreta!");
                        txtSenha.Text = "";
                    }
                }
                else
                {

                }

            }
        }

    }
}
