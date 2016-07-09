namespace Pousada
{
    partial class Reservas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mEditHoraEntrada = new System.Windows.Forms.MaskedTextBox();
            this.mEditHoraSaida = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSaida = new System.Windows.Forms.TextBox();
            this.txtEntrada = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotalRecebido = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblOpcao = new System.Windows.Forms.Label();
            this.txtValorDesconto = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rbValor = new System.Windows.Forms.RadioButton();
            this.rbPorcento = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtValorPago = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValorReserva = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCodReserva = new System.Windows.Forms.TextBox();
            this.cmbNrPessoa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.rbNovo = new System.Windows.Forms.RadioButton();
            this.bt_Gravar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.rbAlterar = new System.Windows.Forms.RadioButton();
            this.rbExclui = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // mEditHoraEntrada
            // 
            this.mEditHoraEntrada.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mEditHoraEntrada.Location = new System.Drawing.Point(45, 110);
            this.mEditHoraEntrada.Mask = "00:00";
            this.mEditHoraEntrada.Name = "mEditHoraEntrada";
            this.mEditHoraEntrada.Size = new System.Drawing.Size(80, 22);
            this.mEditHoraEntrada.TabIndex = 7;
            this.mEditHoraEntrada.Text = "1300";
            this.mEditHoraEntrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mEditHoraEntrada.ValidatingType = typeof(System.DateTime);
            this.mEditHoraEntrada.Enter += new System.EventHandler(this.mEditHoraEntrada_Enter);
            // 
            // mEditHoraSaida
            // 
            this.mEditHoraSaida.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mEditHoraSaida.Location = new System.Drawing.Point(168, 110);
            this.mEditHoraSaida.Mask = "00:00";
            this.mEditHoraSaida.Name = "mEditHoraSaida";
            this.mEditHoraSaida.Size = new System.Drawing.Size(80, 22);
            this.mEditHoraSaida.TabIndex = 8;
            this.mEditHoraSaida.Text = "1200";
            this.mEditHoraSaida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mEditHoraSaida.ValidatingType = typeof(System.DateTime);
            this.mEditHoraSaida.Enter += new System.EventHandler(this.mEditHoraSaida_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(168, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 47;
            this.label3.Text = "Check-out";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 48;
            this.label4.Text = "Check-in";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 16);
            this.label5.TabIndex = 49;
            this.label5.Text = "Hora Entrada";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(168, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 50;
            this.label6.Text = "Hora Saída";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtSaida);
            this.panel1.Controls.Add(this.txtEntrada);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.mEditHoraEntrada);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.mEditHoraSaida);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(297, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(297, 171);
            this.panel1.TabIndex = 51;
            // 
            // txtSaida
            // 
            this.txtSaida.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaida.Location = new System.Drawing.Point(168, 37);
            this.txtSaida.Margin = new System.Windows.Forms.Padding(4);
            this.txtSaida.MaxLength = 10;
            this.txtSaida.Name = "txtSaida";
            this.txtSaida.Size = new System.Drawing.Size(80, 22);
            this.txtSaida.TabIndex = 6;
            this.txtSaida.Text = "09/10/2010";
            this.txtSaida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSaida.TextChanged += new System.EventHandler(this.txtSaida_TextChanged);
            this.txtSaida.Enter += new System.EventHandler(this.txtSaida_Enter);
            this.txtSaida.Leave += new System.EventHandler(this.txtSaida_Leave);
            // 
            // txtEntrada
            // 
            this.txtEntrada.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntrada.Location = new System.Drawing.Point(45, 37);
            this.txtEntrada.Margin = new System.Windows.Forms.Padding(4);
            this.txtEntrada.MaxLength = 10;
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.Size = new System.Drawing.Size(80, 22);
            this.txtEntrada.TabIndex = 5;
            this.txtEntrada.Text = "09/10/2010";
            this.txtEntrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEntrada.TextChanged += new System.EventHandler(this.txtEntrada_TextChanged);
            this.txtEntrada.Enter += new System.EventHandler(this.txtEntrada_Enter);
            this.txtEntrada.Leave += new System.EventHandler(this.txtEntrada_Leave);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblTotalRecebido);
            this.panel2.Controls.Add(this.label24);
            this.panel2.Controls.Add(this.label23);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label22);
            this.panel2.Controls.Add(this.lblTotal);
            this.panel2.Controls.Add(this.lblOpcao);
            this.panel2.Controls.Add(this.txtValorDesconto);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtDesconto);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtValorPago);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtValorReserva);
            this.panel2.Location = new System.Drawing.Point(14, 193);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(580, 275);
            this.panel2.TabIndex = 60;
            // 
            // lblTotalRecebido
            // 
            this.lblTotalRecebido.AutoSize = true;
            this.lblTotalRecebido.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRecebido.ForeColor = System.Drawing.Color.Black;
            this.lblTotalRecebido.Location = new System.Drawing.Point(476, 216);
            this.lblTotalRecebido.Name = "lblTotalRecebido";
            this.lblTotalRecebido.Size = new System.Drawing.Size(46, 23);
            this.lblTotalRecebido.TabIndex = 85;
            this.lblTotalRecebido.Text = "0,00";
            this.lblTotalRecebido.Visible = false;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.Black;
            this.label24.Location = new System.Drawing.Point(360, 216);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(111, 23);
            this.label24.TabIndex = 84;
            this.label24.Text = "Recebido($)";
            this.label24.Visible = false;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(48, 166);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(23, 16);
            this.label23.TabIndex = 83;
            this.label23.Text = "(-)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(46, 55);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(26, 16);
            this.label13.TabIndex = 82;
            this.label13.Text = "(+)";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(48, 107);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(23, 16);
            this.label22.TabIndex = 81;
            this.label22.Text = "(-)";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Black;
            this.lblTotal.Location = new System.Drawing.Point(258, 216);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(46, 23);
            this.lblTotal.TabIndex = 79;
            this.lblTotal.Text = "0,00";
            // 
            // lblOpcao
            // 
            this.lblOpcao.AutoSize = true;
            this.lblOpcao.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpcao.Location = new System.Drawing.Point(362, 143);
            this.lblOpcao.Name = "lblOpcao";
            this.lblOpcao.Size = new System.Drawing.Size(149, 16);
            this.lblOpcao.TabIndex = 78;
            this.lblOpcao.Text = "Digite um valor (% ou $)";
            // 
            // txtValorDesconto
            // 
            this.txtValorDesconto.Enabled = false;
            this.txtValorDesconto.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorDesconto.Location = new System.Drawing.Point(362, 163);
            this.txtValorDesconto.Margin = new System.Windows.Forms.Padding(4);
            this.txtValorDesconto.Name = "txtValorDesconto";
            this.txtValorDesconto.Size = new System.Drawing.Size(150, 22);
            this.txtValorDesconto.TabIndex = 10;
            this.txtValorDesconto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorDesconto_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(363, 35);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(125, 16);
            this.label12.TabIndex = 51;
            this.label12.Text = "Formas de Desconto";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.rbValor);
            this.panel4.Controls.Add(this.rbPorcento);
            this.panel4.Location = new System.Drawing.Point(353, 43);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(180, 62);
            this.panel4.TabIndex = 13;
            // 
            // rbValor
            // 
            this.rbValor.AutoSize = true;
            this.rbValor.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbValor.Location = new System.Drawing.Point(84, 21);
            this.rbValor.Name = "rbValor";
            this.rbValor.Size = new System.Drawing.Size(73, 18);
            this.rbValor.TabIndex = 75;
            this.rbValor.TabStop = true;
            this.rbValor.Text = "Valor ($)";
            this.rbValor.UseVisualStyleBackColor = true;
            this.rbValor.CheckedChanged += new System.EventHandler(this.rbValor_CheckedChanged);
            // 
            // rbPorcento
            // 
            this.rbPorcento.AutoSize = true;
            this.rbPorcento.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPorcento.Location = new System.Drawing.Point(23, 21);
            this.rbPorcento.Name = "rbPorcento";
            this.rbPorcento.Size = new System.Drawing.Size(37, 18);
            this.rbPorcento.TabIndex = 12;
            this.rbPorcento.TabStop = true;
            this.rbPorcento.Text = "%";
            this.rbPorcento.UseVisualStyleBackColor = true;
            this.rbPorcento.CheckedChanged += new System.EventHandler(this.rbPorcento_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(73, 216);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(172, 23);
            this.label10.TabIndex = 67;
            this.label10.Text = "Total a Receber ($)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(74, 143);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 16);
            this.label9.TabIndex = 65;
            this.label9.Text = "Total do Desconto ($)";
            // 
            // txtDesconto
            // 
            this.txtDesconto.Enabled = false;
            this.txtDesconto.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesconto.Location = new System.Drawing.Point(74, 163);
            this.txtDesconto.Margin = new System.Windows.Forms.Padding(4);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(163, 22);
            this.txtDesconto.TabIndex = 11;
            this.txtDesconto.Text = "100,00";
            this.txtDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(74, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 16);
            this.label8.TabIndex = 63;
            this.label8.Text = "Valor Pago ($)";
            // 
            // txtValorPago
            // 
            this.txtValorPago.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorPago.Location = new System.Drawing.Point(74, 105);
            this.txtValorPago.Margin = new System.Windows.Forms.Padding(4);
            this.txtValorPago.Name = "txtValorPago";
            this.txtValorPago.Size = new System.Drawing.Size(163, 22);
            this.txtValorPago.TabIndex = 9;
            this.txtValorPago.Text = "100,00";
            this.txtValorPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValorPago.Enter += new System.EventHandler(this.txtValorPago_Enter);
            this.txtValorPago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorPago_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 16);
            this.label2.TabIndex = 61;
            this.label2.Text = "Valor da Reserva ($)";
            // 
            // txtValorReserva
            // 
            this.txtValorReserva.Enabled = false;
            this.txtValorReserva.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorReserva.Location = new System.Drawing.Point(74, 52);
            this.txtValorReserva.Margin = new System.Windows.Forms.Padding(4);
            this.txtValorReserva.Name = "txtValorReserva";
            this.txtValorReserva.Size = new System.Drawing.Size(163, 22);
            this.txtValorReserva.TabIndex = 9;
            this.txtValorReserva.Text = "1.000,00";
            this.txtValorReserva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.txtCodReserva);
            this.panel3.Controls.Add(this.cmbNrPessoa);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label19);
            this.panel3.Controls.Add(this.txtCliente);
            this.panel3.Controls.Add(this.cmbTipo);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(14, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(276, 171);
            this.panel3.TabIndex = 61;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(32, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 16);
            this.label11.TabIndex = 49;
            this.label11.Text = "Cód.Reserva";
            // 
            // txtCodReserva
            // 
            this.txtCodReserva.BackColor = System.Drawing.Color.Yellow;
            this.txtCodReserva.Enabled = false;
            this.txtCodReserva.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodReserva.Location = new System.Drawing.Point(32, 36);
            this.txtCodReserva.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodReserva.Name = "txtCodReserva";
            this.txtCodReserva.Size = new System.Drawing.Size(105, 22);
            this.txtCodReserva.TabIndex = 1;
            this.txtCodReserva.Leave += new System.EventHandler(this.txtCodReserva_Leave);
            // 
            // cmbNrPessoa
            // 
            this.cmbNrPessoa.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNrPessoa.FormattingEnabled = true;
            this.cmbNrPessoa.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbNrPessoa.Location = new System.Drawing.Point(32, 129);
            this.cmbNrPessoa.Name = "cmbNrPessoa";
            this.cmbNrPessoa.Size = new System.Drawing.Size(69, 22);
            this.cmbNrPessoa.TabIndex = 4;
            this.cmbNrPessoa.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            this.cmbNrPessoa.Enter += new System.EventHandler(this.cmbNrPessoa_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 46;
            this.label1.Text = "Nº Pessoas";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(146, 18);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(73, 16);
            this.label19.TabIndex = 45;
            this.label19.Text = "Cód.Cliente";
            // 
            // txtCliente
            // 
            this.txtCliente.Enabled = false;
            this.txtCliente.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Location = new System.Drawing.Point(146, 36);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(105, 22);
            this.txtCliente.TabIndex = 2;
            this.txtCliente.Enter += new System.EventHandler(this.txtCliente_Enter);
            // 
            // cmbTipo
            // 
            this.cmbTipo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(32, 81);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(219, 22);
            this.cmbTipo.TabIndex = 3;
            this.cmbTipo.Enter += new System.EventHandler(this.cmbTipo_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(32, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 16);
            this.label7.TabIndex = 42;
            this.label7.Text = "Tipo";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label21);
            this.panel5.Controls.Add(this.label20);
            this.panel5.Controls.Add(this.label18);
            this.panel5.Controls.Add(this.label16);
            this.panel5.Controls.Add(this.label15);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.Location = new System.Drawing.Point(601, 16);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(247, 171);
            this.panel5.TabIndex = 62;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(155, 126);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(18, 18);
            this.label21.TabIndex = 57;
            this.label21.Text = "3";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(134, 79);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(73, 18);
            this.label20.TabIndex = 56;
            this.label20.Text = "123 dias";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(134, 31);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(106, 18);
            this.label18.TabIndex = 55;
            this.label18.Text = "23/03/2016";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(6, 127);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(101, 16);
            this.label16.TabIndex = 54;
            this.label16.Text = "Nr.Hospedagens";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(6, 79);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 16);
            this.label15.TabIndex = 53;
            this.label15.Text = "Dias corridos";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, 31);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(122, 16);
            this.label14.TabIndex = 51;
            this.label14.Text = "Última Hospedagem";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(750, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "&Cliente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rbNovo
            // 
            this.rbNovo.AutoSize = true;
            this.rbNovo.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNovo.Location = new System.Drawing.Point(638, 240);
            this.rbNovo.Name = "rbNovo";
            this.rbNovo.Size = new System.Drawing.Size(83, 17);
            this.rbNovo.TabIndex = 11;
            this.rbNovo.Text = "&Confirmar";
            this.rbNovo.UseVisualStyleBackColor = true;
            // 
            // bt_Gravar
            // 
            this.bt_Gravar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Gravar.Location = new System.Drawing.Point(750, 256);
            this.bt_Gravar.Name = "bt_Gravar";
            this.bt_Gravar.Size = new System.Drawing.Size(75, 23);
            this.bt_Gravar.TabIndex = 14;
            this.bt_Gravar.Text = "&OK";
            this.bt_Gravar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(750, 294);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // rbAlterar
            // 
            this.rbAlterar.AutoSize = true;
            this.rbAlterar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAlterar.Location = new System.Drawing.Point(638, 283);
            this.rbAlterar.Name = "rbAlterar";
            this.rbAlterar.Size = new System.Drawing.Size(64, 17);
            this.rbAlterar.TabIndex = 12;
            this.rbAlterar.Text = "&Alterar";
            this.rbAlterar.UseVisualStyleBackColor = true;
            // 
            // rbExclui
            // 
            this.rbExclui.AutoSize = true;
            this.rbExclui.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbExclui.Location = new System.Drawing.Point(639, 326);
            this.rbExclui.Name = "rbExclui";
            this.rbExclui.Size = new System.Drawing.Size(63, 17);
            this.rbExclui.TabIndex = 13;
            this.rbExclui.Text = "&Excluir";
            this.rbExclui.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(749, 445);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "&Sair";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(615, 214);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 81;
            this.monthCalendar1.Visible = false;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // Reservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 486);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rbNovo);
            this.Controls.Add(this.bt_Gravar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.rbAlterar);
            this.Controls.Add(this.rbExclui);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Reservas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Reservas";
            this.Load += new System.EventHandler(this.Reservas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mEditHoraEntrada;
        private System.Windows.Forms.MaskedTextBox mEditHoraSaida;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtValorPago;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValorReserva;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCodReserva;
        private System.Windows.Forms.ComboBox cmbNrPessoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbValor;
        private System.Windows.Forms.RadioButton rbPorcento;
        private System.Windows.Forms.Label lblOpcao;
        private System.Windows.Forms.TextBox txtValorDesconto;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rbNovo;
        private System.Windows.Forms.Button bt_Gravar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.RadioButton rbAlterar;
        private System.Windows.Forms.RadioButton rbExclui;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TextBox txtSaida;
        private System.Windows.Forms.TextBox txtEntrada;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lblTotalRecebido;
        private System.Windows.Forms.Label label24;
    }
}