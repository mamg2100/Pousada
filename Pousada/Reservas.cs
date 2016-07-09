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
    public partial class Reservas : Form
    {
        int flag = 0; // variável que controla qual o campo tem o foco para destacar o campo e controlar o Calendario
        Double reserva = 0;
        Double desconto = 0;
        Double entrada = 0;
        Double total = 0;
        Double taxa = 0;
        
        public Reservas()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Show();
        }

        private void Reservas_Load(object sender, EventArgs e)
        {
            soma();
        }

        private void soma()
        {            
            reserva = Convert.ToDouble(txtValorReserva.Text);
            desconto = Convert.ToDouble(txtDesconto.Text);
            entrada = Convert.ToDouble(txtValorPago.Text);            
            total = reserva - entrada - desconto;
            
            if (total>=0)
            {
            lblTotal.Text = Convert.ToString(total);
            lblTotal.Text = Convert.ToDouble(lblTotal.Text).ToString("C");
            lblTotal.Text = lblTotal.Text.Replace("R$", "");
            }else
            {
                MessageBox.Show("Rever os valores de descontos.");
                txtValorDesconto.Focus();
            }
       
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCodReserva_Leave(object sender, EventArgs e)
        {
            flag = 1;
            destacaTxtBoxs(flag);
        }

        private void destacaTxtBoxs(int flag)
        {
            switch(flag){
            
                case 1:
                    retiraDestaque();
                    txtCodReserva.BackColor = Color.Yellow;                    
                    break;
                case 2:
                    retiraDestaque();
                    txtCliente.BackColor = Color.Yellow;
                    break;
                case 3:
                    retiraDestaque();
                    cmbTipo.BackColor = Color.Yellow;
                    break;
                case 4:
                    retiraDestaque();
                    cmbNrPessoa.BackColor = Color.Yellow;
                    break;
                case 5:
                    retiraDestaque();
                    txtEntrada.BackColor = Color.Yellow;
                    break;
                case 6:
                    retiraDestaque();
                    txtSaida.BackColor = Color.Yellow;
                    break;
                case 7:
                    retiraDestaque();
                    mEditHoraEntrada.BackColor = Color.Yellow;
                    break;
                case 8:
                    retiraDestaque();
                    mEditHoraSaida.BackColor = Color.Yellow;
                    break;
                case 9:
                    retiraDestaque();
                    break;
                case 10:
                    retiraDestaque();
                    txtValorPago.BackColor = Color.Yellow;
                    break;
                case 14:
                    retiraDestaque();
                    txtValorDesconto.BackColor = Color.Yellow;
                    break;   
            }
        }

        private void retiraDestaque()
        {
            txtCodReserva.BackColor = Color.White;                    
            txtCliente.BackColor = Color.White;
            cmbTipo.BackColor = Color.White;
            cmbNrPessoa.BackColor = Color.White;
            txtEntrada.BackColor = Color.White;
            txtSaida.BackColor = Color.White;
            mEditHoraEntrada.BackColor = Color.White;
            mEditHoraSaida.BackColor = Color.White;
            txtValorPago.BackColor = Color.White;
            txtValorDesconto.BackColor = Color.White;
        }

       private void cmbNrPessoa_Enter(object sender, EventArgs e)
        {
            flag = 4;
            destacaTxtBoxs(4);

        }

        private void txtEntrada_Enter(object sender, EventArgs e)
        {
            flag = 5;
            destacaTxtBoxs(flag);
            monthCalendar1.Visible = true;
        }

        private void txtSaida_Enter(object sender, EventArgs e)
        {
            flag = 6;
            destacaTxtBoxs(flag);
            monthCalendar1.Visible = true;
        }

        private void mEditHoraEntrada_Enter(object sender, EventArgs e)
        {
            flag = 7;
            destacaTxtBoxs(flag);
        }

        private void mEditHoraSaida_Enter(object sender, EventArgs e)
        {
            flag = 8;
            destacaTxtBoxs(flag);
        }

        private void txtCliente_Enter(object sender, EventArgs e)
        {
            flag = 2;
            destacaTxtBoxs(2); 
        }

        private void cmbTipo_Enter(object sender, EventArgs e)
        {
            flag = 3;
            destacaTxtBoxs(3);
        }

        private void txtEntrada_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            if (txtEntrada.Text == "" )
            {
            txtEntrada.Text = txtEntrada.Text = monthCalendar1.SelectionRange.Start.ToString("dd/MM/yyyy");
            
            }
            else
            {
            txtSaida.Text = txtSaida.Text = monthCalendar1.SelectionRange.Start.ToString("dd/MM/yyyy");
            
            }
        }

        private void txtSaida_TextChanged(object sender, EventArgs e)
        {
            monthCalendar1.Visible = true;
        }

        private void txtEntrada_Leave(object sender, EventArgs e)
        {
            monthCalendar1.Visible = false;
        }

        private void txtSaida_Leave(object sender, EventArgs e)
        {
            monthCalendar1.Visible = false;
        }

        private void txtValorPago_Enter(object sender, EventArgs e)
        {
            flag = 10;
            destacaTxtBoxs(flag);
        }

        private void rbPorcento_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPorcento.Checked == true)
            {
                lblOpcao.Text = "Taxa de desconto (%)";
                txtValorDesconto.Width= 70;
            }
            else 
            {
                lblOpcao.Text = "Valor de desconto ($)";
                txtValorDesconto.Width = 150;
            }

            txtValorDesconto.Text = "";
            txtValorDesconto.Focus();
        }

        private void txtValorDesconto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) {
                
                if (rbValor.Checked == true)
                    // teste
                {
                    txtValorDesconto.Text = Convert.ToDouble(txtValorDesconto.Text).ToString("C");
                    txtValorDesconto.Text = txtValorDesconto.Text.Replace("R$", "");
                    txtDesconto.Text = txtValorDesconto.Text;
                    txtDesconto.Text = Convert.ToDouble(txtDesconto.Text).ToString("C");
                    txtDesconto.Text = txtDesconto.Text.Replace("R$", "");
                    
                    soma();
                }
                else {

                    somaComPorcentagem();
                    txtDesconto.Text = desconto.ToString();
                    //txtDesconto.Text = txtValorDesconto.Text;
                    txtDesconto.Text = Convert.ToDouble(txtDesconto.Text).ToString("C");
                    txtDesconto.Text = txtDesconto.Text.Replace("R$", "");
                    

                }

                //txtValorDesconto.Enabled = false;
            
            }
            
        }

        private double somaComPorcentagem()
        {
            reserva = Convert.ToDouble(txtValorReserva.Text);
            taxa = Convert.ToDouble(txtValorDesconto.Text);
            desconto = Convert.ToDouble(txtValorReserva.Text)*taxa/100;
            entrada = Convert.ToDouble(txtValorPago.Text);
            total = reserva - entrada - desconto;
            if (total >= 0)
            {
                lblTotal.Text = Convert.ToString(total);
                lblTotal.Text = Convert.ToDouble(lblTotal.Text).ToString("C");
                lblTotal.Text = lblTotal.Text.Replace("R$", "");

                txtDesconto.Text = txtValorDesconto.Text;
            }
            else {

                MessageBox.Show("Rever os valores de desconto");
                txtValorDesconto.Focus();
            }
           
            return(desconto);
       
        }

        private void txtValorPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) {
                try
                {
                    txtValorPago.Text = Convert.ToDouble(txtValorPago.Text).ToString("C");
                    txtValorPago.Text = txtValorPago.Text.Replace("R$", "");
                    soma();
                }
                catch {
                    MessageBox.Show("O valor digitado para moeda não está no formato correto",
                    "Critical Warning",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RightAlign,
                    true);
                }
            }
        }

        private void rbValor_CheckedChanged(object sender, EventArgs e)
        {
            if (rbValor.Checked == true)
            {
                txtValorDesconto.Enabled = true;
                lblOpcao.Text = "Valor de desconto ($)";
                txtValorDesconto.Width = 150;
            }
            else
            {
                txtValorDesconto.Enabled = true;
                lblOpcao.Text = "Taxa de desconto (%)";
                txtValorDesconto.Width = 70;
            }

            txtValorDesconto.Text = "";
            txtValorDesconto.Focus();

        }
    }
}
