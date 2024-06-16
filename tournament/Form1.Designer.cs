namespace tournament
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonCasdatrar = new System.Windows.Forms.Button();
            this.labelUsuarioLog = new System.Windows.Forms.Label();
            this.labelSenhaLog = new System.Windows.Forms.Label();
            this.textBoxUsuarioLog = new System.Windows.Forms.TextBox();
            this.textBoxSenhaLog = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(234, 267);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(136, 46);
            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.Text = "&Logar";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonCasdatrar
            // 
            this.buttonCasdatrar.Location = new System.Drawing.Point(431, 267);
            this.buttonCasdatrar.Name = "buttonCasdatrar";
            this.buttonCasdatrar.Size = new System.Drawing.Size(136, 46);
            this.buttonCasdatrar.TabIndex = 1;
            this.buttonCasdatrar.Text = "&Cadastrar";
            this.buttonCasdatrar.UseVisualStyleBackColor = true;
            this.buttonCasdatrar.Click += new System.EventHandler(this.buttonCasdatrar_Click);
            // 
            // labelUsuarioLog
            // 
            this.labelUsuarioLog.AutoSize = true;
            this.labelUsuarioLog.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelUsuarioLog.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelUsuarioLog.Location = new System.Drawing.Point(286, 145);
            this.labelUsuarioLog.Name = "labelUsuarioLog";
            this.labelUsuarioLog.Size = new System.Drawing.Size(46, 13);
            this.labelUsuarioLog.TabIndex = 2;
            this.labelUsuarioLog.Text = "Usuário:";
            this.labelUsuarioLog.Click += new System.EventHandler(this.labelUsuarioLog_Click);
            // 
            // labelSenhaLog
            // 
            this.labelSenhaLog.AutoSize = true;
            this.labelSenhaLog.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelSenhaLog.Location = new System.Drawing.Point(291, 194);
            this.labelSenhaLog.Name = "labelSenhaLog";
            this.labelSenhaLog.Size = new System.Drawing.Size(41, 13);
            this.labelSenhaLog.TabIndex = 3;
            this.labelSenhaLog.Text = "Senha:";
            // 
            // textBoxUsuarioLog
            // 
            this.textBoxUsuarioLog.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBoxUsuarioLog.ForeColor = System.Drawing.SystemColors.Menu;
            this.textBoxUsuarioLog.Location = new System.Drawing.Point(338, 142);
            this.textBoxUsuarioLog.Name = "textBoxUsuarioLog";
            this.textBoxUsuarioLog.Size = new System.Drawing.Size(164, 20);
            this.textBoxUsuarioLog.TabIndex = 4;
            this.textBoxUsuarioLog.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxUsuarioLog.TextChanged += new System.EventHandler(this.textBoxUsuarioLog_TextChanged);
            // 
            // textBoxSenhaLog
            // 
            this.textBoxSenhaLog.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBoxSenhaLog.ForeColor = System.Drawing.SystemColors.Info;
            this.textBoxSenhaLog.Location = new System.Drawing.Point(338, 186);
            this.textBoxSenhaLog.Name = "textBoxSenhaLog";
            this.textBoxSenhaLog.Size = new System.Drawing.Size(164, 20);
            this.textBoxSenhaLog.TabIndex = 5;
            this.textBoxSenhaLog.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxSenhaLog.UseSystemPasswordChar = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.textBox1.Location = new System.Drawing.Point(318, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(184, 37);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "BEM VINDO";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 369);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBoxSenhaLog);
            this.Controls.Add(this.textBoxUsuarioLog);
            this.Controls.Add(this.labelSenhaLog);
            this.Controls.Add(this.labelUsuarioLog);
            this.Controls.Add(this.buttonCasdatrar);
            this.Controls.Add(this.buttonLogin);
            this.Name = "Form1";
            this.Text = "LoginScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonCasdatrar;
        private System.Windows.Forms.Label labelUsuarioLog;
        private System.Windows.Forms.Label labelSenhaLog;
        private System.Windows.Forms.TextBox textBoxUsuarioLog;
        private System.Windows.Forms.TextBox textBoxSenhaLog;
        private System.Windows.Forms.TextBox textBox1;
    }
}

