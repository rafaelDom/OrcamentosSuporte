namespace OrcamentosSuporte
{
    partial class OrcamentoIncluirAlterar
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtempresa = new System.Windows.Forms.TextBox();
            this.txtequipamento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ckgarantia = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lstselecionados = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.dtorcamento = new System.Windows.Forms.MaskedTextBox();
            this.btnconcluir = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtresponsavel = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.mktelefone = new System.Windows.Forms.MaskedTextBox();
            this.idalterar = new System.Windows.Forms.Label();
            this.lstdisponiveis = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Orçamento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "|   Incluir - Editar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Empresa:";
            // 
            // txtempresa
            // 
            this.txtempresa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtempresa.Location = new System.Drawing.Point(108, 83);
            this.txtempresa.Name = "txtempresa";
            this.txtempresa.Size = new System.Drawing.Size(280, 22);
            this.txtempresa.TabIndex = 3;
            // 
            // txtequipamento
            // 
            this.txtequipamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtequipamento.Location = new System.Drawing.Point(108, 122);
            this.txtequipamento.Name = "txtequipamento";
            this.txtequipamento.Size = new System.Drawing.Size(170, 22);
            this.txtequipamento.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Equipamento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Data Orçam:";
            // 
            // ckgarantia
            // 
            this.ckgarantia.AutoSize = true;
            this.ckgarantia.Location = new System.Drawing.Point(29, 199);
            this.ckgarantia.Name = "ckgarantia";
            this.ckgarantia.Size = new System.Drawing.Size(70, 17);
            this.ckgarantia.TabIndex = 8;
            this.ckgarantia.Text = "Garantia";
            this.ckgarantia.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Disponíveis:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(349, 371);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = ">";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(349, 412);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(39, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "<";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lstselecionados
            // 
            this.lstselecionados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstselecionados.FormattingEnabled = true;
            this.lstselecionados.Location = new System.Drawing.Point(419, 256);
            this.lstselecionados.Name = "lstselecionados";
            this.lstselecionados.Size = new System.Drawing.Size(281, 262);
            this.lstselecionados.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(406, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Valor:";
            // 
            // txtvalor
            // 
            this.txtvalor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtvalor.Location = new System.Drawing.Point(482, 198);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(100, 22);
            this.txtvalor.TabIndex = 15;
            // 
            // dtorcamento
            // 
            this.dtorcamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dtorcamento.Location = new System.Drawing.Point(108, 159);
            this.dtorcamento.Mask = "00/00/0000";
            this.dtorcamento.Name = "dtorcamento";
            this.dtorcamento.Size = new System.Drawing.Size(73, 22);
            this.dtorcamento.TabIndex = 16;
            this.dtorcamento.ValidatingType = typeof(System.DateTime);
            // 
            // btnconcluir
            // 
            this.btnconcluir.Location = new System.Drawing.Point(625, 554);
            this.btnconcluir.Name = "btnconcluir";
            this.btnconcluir.Size = new System.Drawing.Size(75, 23);
            this.btnconcluir.TabIndex = 17;
            this.btnconcluir.Text = "Concluir";
            this.btnconcluir.UseVisualStyleBackColor = true;
            this.btnconcluir.Click += new System.EventHandler(this.btnconcluir_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(522, 554);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 18;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.button4_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(416, 237);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Selecionados:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(758, 237);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Selecionados:";
            // 
            // txtresponsavel
            // 
            this.txtresponsavel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtresponsavel.Location = new System.Drawing.Point(482, 83);
            this.txtresponsavel.Name = "txtresponsavel";
            this.txtresponsavel.Size = new System.Drawing.Size(218, 22);
            this.txtresponsavel.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(402, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Responsável:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(402, 131);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "E-mail:";
            // 
            // txtemail
            // 
            this.txtemail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtemail.Location = new System.Drawing.Point(482, 122);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(218, 22);
            this.txtemail.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(402, 168);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Telefone:";
            // 
            // mktelefone
            // 
            this.mktelefone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mktelefone.Location = new System.Drawing.Point(482, 159);
            this.mktelefone.Mask = "(00)00000-9999";
            this.mktelefone.Name = "mktelefone";
            this.mktelefone.Size = new System.Drawing.Size(100, 22);
            this.mktelefone.TabIndex = 26;
            // 
            // idalterar
            // 
            this.idalterar.AutoSize = true;
            this.idalterar.Location = new System.Drawing.Point(108, 52);
            this.idalterar.Name = "idalterar";
            this.idalterar.Size = new System.Drawing.Size(0, 13);
            this.idalterar.TabIndex = 27;
            // 
            // lstdisponiveis
            // 
            this.lstdisponiveis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstdisponiveis.FormattingEnabled = true;
            this.lstdisponiveis.Location = new System.Drawing.Point(28, 256);
            this.lstdisponiveis.Name = "lstdisponiveis";
            this.lstdisponiveis.Size = new System.Drawing.Size(291, 262);
            this.lstdisponiveis.TabIndex = 9;
            this.lstdisponiveis.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // OrcamentoIncluirAlterar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(724, 589);
            this.Controls.Add(this.idalterar);
            this.Controls.Add(this.mktelefone);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtresponsavel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnconcluir);
            this.Controls.Add(this.dtorcamento);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lstselecionados);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lstdisponiveis);
            this.Controls.Add(this.ckgarantia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtequipamento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtempresa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrcamentoIncluirAlterar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orçamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtempresa;
        private System.Windows.Forms.TextBox txtequipamento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox ckgarantia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox lstselecionados;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.MaskedTextBox dtorcamento;
        private System.Windows.Forms.Button btnconcluir;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtresponsavel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox mktelefone;
        public System.Windows.Forms.Label idalterar;
        private System.Windows.Forms.ListBox lstdisponiveis;
    }
}