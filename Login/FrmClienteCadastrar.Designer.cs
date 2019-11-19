namespace Login
{
    partial class FrmClienteCadastrar
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
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCpfCnpj = new System.Windows.Forms.Label();
            this.lblTipoPessoa = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCpfCnpj = new System.Windows.Forms.TextBox();
            this.radioFisica = new System.Windows.Forms.RadioButton();
            this.RadioJurudica = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(322, 233);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(403, 233);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(5, 6);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome:";
            // 
            // lblCpfCnpj
            // 
            this.lblCpfCnpj.AutoSize = true;
            this.lblCpfCnpj.Location = new System.Drawing.Point(5, 34);
            this.lblCpfCnpj.Name = "lblCpfCnpj";
            this.lblCpfCnpj.Size = new System.Drawing.Size(62, 13);
            this.lblCpfCnpj.TabIndex = 3;
            this.lblCpfCnpj.Text = "CPF/CNPJ:";
            // 
            // lblTipoPessoa
            // 
            this.lblTipoPessoa.AutoSize = true;
            this.lblTipoPessoa.Location = new System.Drawing.Point(5, 71);
            this.lblTipoPessoa.Name = "lblTipoPessoa";
            this.lblTipoPessoa.Size = new System.Drawing.Size(84, 13);
            this.lblTipoPessoa.TabIndex = 4;
            this.lblTipoPessoa.Text = "Tipo de Pessoa:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(44, 2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(434, 20);
            this.txtNome.TabIndex = 7;
            // 
            // txtCpfCnpj
            // 
            this.txtCpfCnpj.Location = new System.Drawing.Point(66, 34);
            this.txtCpfCnpj.Name = "txtCpfCnpj";
            this.txtCpfCnpj.Size = new System.Drawing.Size(412, 20);
            this.txtCpfCnpj.TabIndex = 8;
            // 
            // radioFisica
            // 
            this.radioFisica.AutoSize = true;
            this.radioFisica.Location = new System.Drawing.Point(118, 71);
            this.radioFisica.Name = "radioFisica";
            this.radioFisica.Size = new System.Drawing.Size(54, 17);
            this.radioFisica.TabIndex = 9;
            this.radioFisica.TabStop = true;
            this.radioFisica.Text = "Física";
            this.radioFisica.UseVisualStyleBackColor = true;
            // 
            // RadioJurudica
            // 
            this.RadioJurudica.AutoSize = true;
            this.RadioJurudica.Location = new System.Drawing.Point(227, 69);
            this.RadioJurudica.Name = "RadioJurudica";
            this.RadioJurudica.Size = new System.Drawing.Size(63, 17);
            this.RadioJurudica.TabIndex = 10;
            this.RadioJurudica.TabStop = true;
            this.RadioJurudica.Text = "Jurídica";
            this.RadioJurudica.UseVisualStyleBackColor = true;
            // 
            // FrmClienteCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.RadioJurudica);
            this.Controls.Add(this.radioFisica);
            this.Controls.Add(this.txtCpfCnpj);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblTipoPessoa);
            this.Controls.Add(this.lblCpfCnpj);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmClienteCadastrar";
            this.Text = "Cadastrar Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCpfCnpj;
        private System.Windows.Forms.Label lblTipoPessoa;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCpfCnpj;
        private System.Windows.Forms.RadioButton radioFisica;
        private System.Windows.Forms.RadioButton RadioJurudica;
    }
}