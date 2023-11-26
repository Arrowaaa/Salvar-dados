namespace Arquivoemtexto
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
            this.txbInput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnler = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbTelefone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.rbtelefone = new System.Windows.Forms.RadioButton();
            this.rbemail = new System.Windows.Forms.RadioButton();
            this.lbnome = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbemail = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbtelefone = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbxnome = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbInput
            // 
            this.txbInput.Location = new System.Drawing.Point(5, 53);
            this.txbInput.Name = "txbInput";
            this.txbInput.Size = new System.Drawing.Size(225, 20);
            this.txbInput.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(18, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 60);
            this.button1.TabIndex = 1;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnler
            // 
            this.btnler.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnler.Location = new System.Drawing.Point(155, 259);
            this.btnler.Name = "btnler";
            this.btnler.Size = new System.Drawing.Size(75, 60);
            this.btnler.TabIndex = 2;
            this.btnler.Text = "Ler";
            this.btnler.UseVisualStyleBackColor = false;
            this.btnler.Click += new System.EventHandler(this.btnler_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Telefone";
            // 
            // txbTelefone
            // 
            this.txbTelefone.Location = new System.Drawing.Point(5, 128);
            this.txbTelefone.Name = "txbTelefone";
            this.txbTelefone.Size = new System.Drawing.Size(225, 20);
            this.txbTelefone.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 31);
            this.label3.TabIndex = 7;
            this.label3.Text = "Email";
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(5, 213);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(225, 20);
            this.txbEmail.TabIndex = 6;
            // 
            // rbtelefone
            // 
            this.rbtelefone.AutoSize = true;
            this.rbtelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtelefone.Location = new System.Drawing.Point(322, 55);
            this.rbtelefone.Name = "rbtelefone";
            this.rbtelefone.Size = new System.Drawing.Size(82, 21);
            this.rbtelefone.TabIndex = 8;
            this.rbtelefone.TabStop = true;
            this.rbtelefone.Text = "Telefone";
            this.rbtelefone.UseVisualStyleBackColor = true;
            // 
            // rbemail
            // 
            this.rbemail.AutoSize = true;
            this.rbemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbemail.Location = new System.Drawing.Point(322, 98);
            this.rbemail.Name = "rbemail";
            this.rbemail.Size = new System.Drawing.Size(60, 21);
            this.rbemail.TabIndex = 9;
            this.rbemail.TabStop = true;
            this.rbemail.Text = "Email";
            this.rbemail.UseVisualStyleBackColor = true;
            // 
            // lbnome
            // 
            this.lbnome.AutoSize = true;
            this.lbnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnome.Location = new System.Drawing.Point(273, 216);
            this.lbnome.Name = "lbnome";
            this.lbnome.Size = new System.Drawing.Size(53, 17);
            this.lbnome.TabIndex = 10;
            this.lbnome.Text = "Nome: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(357, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "resposta";
            // 
            // lbemail
            // 
            this.lbemail.AutoSize = true;
            this.lbemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbemail.Location = new System.Drawing.Point(273, 249);
            this.lbemail.Name = "lbemail";
            this.lbemail.Size = new System.Drawing.Size(50, 17);
            this.lbemail.TabIndex = 12;
            this.lbemail.Text = "Email: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(357, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "resposta";
            // 
            // lbtelefone
            // 
            this.lbtelefone.AutoSize = true;
            this.lbtelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtelefone.Location = new System.Drawing.Point(273, 281);
            this.lbtelefone.Name = "lbtelefone";
            this.lbtelefone.Size = new System.Drawing.Size(72, 17);
            this.lbtelefone.TabIndex = 15;
            this.lbtelefone.Text = "Telefone: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(366, 281);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "resposta";
            // 
            // cbxnome
            // 
            this.cbxnome.FormattingEnabled = true;
            this.cbxnome.Location = new System.Drawing.Point(257, 160);
            this.cbxnome.Name = "cbxnome";
            this.cbxnome.Size = new System.Drawing.Size(186, 21);
            this.cbxnome.TabIndex = 16;
            this.cbxnome.SelectedIndexChanged += new System.EventHandler(this.cbxnome_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(287, 140);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "Nome Contato: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 346);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbxnome);
            this.Controls.Add(this.lbtelefone);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbemail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbnome);
            this.Controls.Add(this.rbemail);
            this.Controls.Add(this.rbtelefone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbTelefone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnler);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txbInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbInput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbTelefone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.RadioButton rbtelefone;
        private System.Windows.Forms.RadioButton rbemail;
        private System.Windows.Forms.Label lbnome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbemail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbtelefone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbxnome;
        private System.Windows.Forms.Label label10;
    }
}

