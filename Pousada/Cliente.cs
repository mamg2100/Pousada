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
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reservas reserva = new Reservas();
            reserva.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void monthCalendar1_Validating(object sender, CancelEventArgs e)
        {

        }

        private void Cliente_Load(object sender, EventArgs e)
        {

        }
    }
}
