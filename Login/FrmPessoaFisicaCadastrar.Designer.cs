namespace Login
{
    partial class FrmPessoaFisicaCadastrar
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
            this.txtRG = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblRG = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.dtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.lblCPF = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtRG
            // 
            this.txtRG.Location = new System.Drawing.Point(41, 44);
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(448, 20);
            this.txtRG.TabIndex = 17;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(55, 12);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(434, 20);
            this.txtNome.TabIndex = 16;
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.Location = new System.Drawing.Point(16, 44);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(26, 13);
            this.lblRG.TabIndex = 14;
            this.lblRG.Text = "RG:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(16, 16);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 13;
            this.lblNome.Text = "Nome:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(414, 133);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(333, 133);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 11;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Location = new System.Drawing.Point(16, 114);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(92, 13);
            this.lblDataNascimento.TabIndex = 19;
            this.lblDataNascimento.Text = "Data Nascimento:";
            // 
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.Location = new System.Drawing.Point(105, 114);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Size = new System.Drawing.Size(200, 20);
            this.dtpDataNascimento.TabIndex = 21;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(16, 78);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(30, 13);
            this.lblCPF.TabIndex = 22;
            this.lblCPF.Text = "CPF:";
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(41, 78);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(448, 20);
            this.txtCPF.TabIndex = 23;
            // 
            // FrmPessoaFisicaCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 180);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.dtpDataNascimento);
            this.Controls.Add(this.lblDataNascimento);
            this.Controls.Add(this.txtRG);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblRG);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Name = "FrmPessoaFisicaCadastrar";
            this.Text = "Cadastro Pessoa Física";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtRG;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.DateTimePicker dtpDataNascimento;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.TextBox txtCPF;
    }
}