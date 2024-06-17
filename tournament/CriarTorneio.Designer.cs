namespace tournament
{
    partial class CriarTorneio
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonCriar = new System.Windows.Forms.Button();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxNparticipantes = new System.Windows.Forms.ComboBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxDescricao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxVerificador = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.textBox1.Location = new System.Drawing.Point(286, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(229, 37);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Crie seu torneio";
            // 
            // buttonCriar
            // 
            this.buttonCriar.Location = new System.Drawing.Point(452, 382);
            this.buttonCriar.Name = "buttonCriar";
            this.buttonCriar.Size = new System.Drawing.Size(114, 56);
            this.buttonCriar.TabIndex = 1;
            this.buttonCriar.Text = "Criar";
            this.buttonCriar.UseVisualStyleBackColor = true;
            this.buttonCriar.Click += new System.EventHandler(this.buttonCriar_Click);
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.Location = new System.Drawing.Point(262, 382);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(114, 56);
            this.buttonVoltar.TabIndex = 2;
            this.buttonVoltar.Text = "Voltar";
            this.buttonVoltar.UseVisualStyleBackColor = true;
            this.buttonVoltar.Click += new System.EventHandler(this.buttonVoltar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(273, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(273, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "N# de participantes:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(273, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Descrição:";
            // 
            // comboBoxNparticipantes
            // 
            this.comboBoxNparticipantes.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.comboBoxNparticipantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxNparticipantes.ForeColor = System.Drawing.SystemColors.Info;
            this.comboBoxNparticipantes.FormattingEnabled = true;
            this.comboBoxNparticipantes.Items.AddRange(new object[] {
            "4",
            "6",
            "8",
            "10"});
            this.comboBoxNparticipantes.Location = new System.Drawing.Point(417, 176);
            this.comboBoxNparticipantes.Name = "comboBoxNparticipantes";
            this.comboBoxNparticipantes.Size = new System.Drawing.Size(121, 21);
            this.comboBoxNparticipantes.TabIndex = 6;
            // 
            // textBoxNome
            // 
            this.textBoxNome.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBoxNome.ForeColor = System.Drawing.SystemColors.Info;
            this.textBoxNome.Location = new System.Drawing.Point(333, 116);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(205, 20);
            this.textBoxNome.TabIndex = 7;
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBoxDescricao.ForeColor = System.Drawing.SystemColors.Info;
            this.textBoxDescricao.Location = new System.Drawing.Point(360, 226);
            this.textBoxDescricao.Multiline = true;
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(179, 65);
            this.textBoxDescricao.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(273, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Sorteio de partidas:";
            // 
            // comboBoxVerificador
            // 
            this.comboBoxVerificador.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.comboBoxVerificador.ForeColor = System.Drawing.SystemColors.Info;
            this.comboBoxVerificador.FormattingEnabled = true;
            this.comboBoxVerificador.Items.AddRange(new object[] {
            "Ativado",
            "Desativado"});
            this.comboBoxVerificador.Location = new System.Drawing.Point(415, 321);
            this.comboBoxVerificador.Name = "comboBoxVerificador";
            this.comboBoxVerificador.Size = new System.Drawing.Size(123, 21);
            this.comboBoxVerificador.TabIndex = 10;
            // 
            // CriarTorneio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxVerificador);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxDescricao);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.comboBoxNparticipantes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonVoltar);
            this.Controls.Add(this.buttonCriar);
            this.Controls.Add(this.textBox1);
            this.Name = "CriarTorneio";
            this.Text = "CriarTorneio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonCriar;
        private System.Windows.Forms.Button buttonVoltar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxNparticipantes;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxDescricao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxVerificador;
    }
}