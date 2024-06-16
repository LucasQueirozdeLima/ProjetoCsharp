namespace tournament
{
    partial class Cadastro
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
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelSenha = new System.Windows.Forms.Label();
            this.labelConfirmaSenha = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxUsuarioCad = new System.Windows.Forms.TextBox();
            this.textBoxEmailCad = new System.Windows.Forms.TextBox();
            this.textBoxSenhaCad = new System.Windows.Forms.TextBox();
            this.textBoxConfirmarSenhaCad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonCadastrar.Location = new System.Drawing.Point(453, 262);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(128, 57);
            this.buttonCadastrar.TabIndex = 0;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.Location = new System.Drawing.Point(251, 262);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(128, 57);
            this.buttonVoltar.TabIndex = 1;
            this.buttonVoltar.Text = "Voltar";
            this.buttonVoltar.UseVisualStyleBackColor = true;
            this.buttonVoltar.Click += new System.EventHandler(this.buttonVoltar_Click);
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelUsuario.Location = new System.Drawing.Point(291, 82);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(46, 13);
            this.labelUsuario.TabIndex = 2;
            this.labelUsuario.Text = "Usuário:";
            this.labelUsuario.Click += new System.EventHandler(this.labelUsuario_Click);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelEmail.Location = new System.Drawing.Point(302, 119);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(35, 13);
            this.labelEmail.TabIndex = 3;
            this.labelEmail.Text = "Email:";
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelSenha.Location = new System.Drawing.Point(296, 158);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(41, 13);
            this.labelSenha.TabIndex = 4;
            this.labelSenha.Text = "Senha:";
            // 
            // labelConfirmaSenha
            // 
            this.labelConfirmaSenha.AutoSize = true;
            this.labelConfirmaSenha.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelConfirmaSenha.Location = new System.Drawing.Point(249, 196);
            this.labelConfirmaSenha.Name = "labelConfirmaSenha";
            this.labelConfirmaSenha.Size = new System.Drawing.Size(88, 13);
            this.labelConfirmaSenha.TabIndex = 5;
            this.labelConfirmaSenha.Text = "Consirmar senha:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.textBox1.Location = new System.Drawing.Point(320, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(222, 37);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "Cadastre-se";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxUsuarioCad
            // 
            this.textBoxUsuarioCad.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBoxUsuarioCad.ForeColor = System.Drawing.SystemColors.Info;
            this.textBoxUsuarioCad.Location = new System.Drawing.Point(343, 79);
            this.textBoxUsuarioCad.Name = "textBoxUsuarioCad";
            this.textBoxUsuarioCad.Size = new System.Drawing.Size(176, 20);
            this.textBoxUsuarioCad.TabIndex = 7;
            // 
            // textBoxEmailCad
            // 
            this.textBoxEmailCad.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBoxEmailCad.ForeColor = System.Drawing.SystemColors.Info;
            this.textBoxEmailCad.Location = new System.Drawing.Point(343, 116);
            this.textBoxEmailCad.Name = "textBoxEmailCad";
            this.textBoxEmailCad.Size = new System.Drawing.Size(176, 20);
            this.textBoxEmailCad.TabIndex = 8;
            // 
            // textBoxSenhaCad
            // 
            this.textBoxSenhaCad.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBoxSenhaCad.ForeColor = System.Drawing.SystemColors.Info;
            this.textBoxSenhaCad.Location = new System.Drawing.Point(343, 155);
            this.textBoxSenhaCad.Name = "textBoxSenhaCad";
            this.textBoxSenhaCad.Size = new System.Drawing.Size(176, 20);
            this.textBoxSenhaCad.TabIndex = 9;
            this.textBoxSenhaCad.UseSystemPasswordChar = true;
            // 
            // textBoxConfirmarSenhaCad
            // 
            this.textBoxConfirmarSenhaCad.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBoxConfirmarSenhaCad.ForeColor = System.Drawing.SystemColors.Info;
            this.textBoxConfirmarSenhaCad.Location = new System.Drawing.Point(343, 193);
            this.textBoxConfirmarSenhaCad.Name = "textBoxConfirmarSenhaCad";
            this.textBoxConfirmarSenhaCad.Size = new System.Drawing.Size(176, 20);
            this.textBoxConfirmarSenhaCad.TabIndex = 10;
            this.textBoxConfirmarSenhaCad.UseSystemPasswordChar = true;
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxConfirmarSenhaCad);
            this.Controls.Add(this.textBoxSenhaCad);
            this.Controls.Add(this.textBoxEmailCad);
            this.Controls.Add(this.textBoxUsuarioCad);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelConfirmaSenha);
            this.Controls.Add(this.labelSenha);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.buttonVoltar);
            this.Controls.Add(this.buttonCadastrar);
            this.Name = "Cadastro";
            this.Text = "Cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCadastrar;
        private System.Windows.Forms.Button buttonVoltar;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelSenha;
        private System.Windows.Forms.Label labelConfirmaSenha;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBoxUsuarioCad;
        private System.Windows.Forms.TextBox textBoxEmailCad;
        private System.Windows.Forms.TextBox textBoxSenhaCad;
        private System.Windows.Forms.TextBox textBoxConfirmarSenhaCad;
    }
}