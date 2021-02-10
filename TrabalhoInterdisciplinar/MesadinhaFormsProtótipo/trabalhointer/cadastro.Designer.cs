namespace trabalhointer
{
    partial class cadastro
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
            this.txtnome = new System.Windows.Forms.TextBox();
            this.lblnome = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.lblsenha = new System.Windows.Forms.Label();
            this.txtsenha = new System.Windows.Forms.TextBox();
            this.btncad = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.lblcadad = new System.Windows.Forms.Label();
            this.btnver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(217, 127);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(303, 26);
            this.txtnome.TabIndex = 0;
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Location = new System.Drawing.Point(343, 104);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(51, 20);
            this.lblnome.TabIndex = 1;
            this.lblnome.Text = "Nome";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(342, 156);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(53, 20);
            this.lblemail.TabIndex = 3;
            this.lblemail.Text = "E-mail";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(217, 179);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(303, 26);
            this.txtemail.TabIndex = 2;
            // 
            // lblsenha
            // 
            this.lblsenha.AutoSize = true;
            this.lblsenha.Location = new System.Drawing.Point(338, 208);
            this.lblsenha.Name = "lblsenha";
            this.lblsenha.Size = new System.Drawing.Size(56, 20);
            this.lblsenha.TabIndex = 9;
            this.lblsenha.Text = "Senha";
            // 
            // txtsenha
            // 
            this.txtsenha.Location = new System.Drawing.Point(217, 231);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.PasswordChar = '°';
            this.txtsenha.Size = new System.Drawing.Size(303, 26);
            this.txtsenha.TabIndex = 8;
            // 
            // btncad
            // 
            this.btncad.BackColor = System.Drawing.Color.DodgerBlue;
            this.btncad.Location = new System.Drawing.Point(217, 263);
            this.btncad.Name = "btncad";
            this.btncad.Size = new System.Drawing.Size(105, 47);
            this.btncad.TabIndex = 10;
            this.btncad.Text = "Cadastrar";
            this.btncad.UseVisualStyleBackColor = false;
            this.btncad.Click += new System.EventHandler(this.btncad_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.BackColor = System.Drawing.Color.HotPink;
            this.btnvoltar.Location = new System.Drawing.Point(415, 263);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(105, 47);
            this.btnvoltar.TabIndex = 11;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = false;
            // 
            // lblcadad
            // 
            this.lblcadad.AutoSize = true;
            this.lblcadad.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcadad.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblcadad.Location = new System.Drawing.Point(235, 9);
            this.lblcadad.Name = "lblcadad";
            this.lblcadad.Size = new System.Drawing.Size(274, 64);
            this.lblcadad.TabIndex = 12;
            this.lblcadad.Text = "Cadastrar";
            // 
            // btnver
            // 
            this.btnver.Location = new System.Drawing.Point(526, 232);
            this.btnver.Name = "btnver";
            this.btnver.Size = new System.Drawing.Size(51, 25);
            this.btnver.TabIndex = 13;
            this.btnver.Text = "Ver";
            this.btnver.UseVisualStyleBackColor = true;
            this.btnver.Click += new System.EventHandler(this.btnver_Click);
            // 
            // cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnver);
            this.Controls.Add(this.lblcadad);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btncad);
            this.Controls.Add(this.lblsenha);
            this.Controls.Add(this.txtsenha);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.txtnome);
            this.Name = "cadastro";
            this.Text = "cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label lblsenha;
        private System.Windows.Forms.TextBox txtsenha;
        private System.Windows.Forms.Button btncad;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Label lblcadad;
        private System.Windows.Forms.Button btnver;
    }
}