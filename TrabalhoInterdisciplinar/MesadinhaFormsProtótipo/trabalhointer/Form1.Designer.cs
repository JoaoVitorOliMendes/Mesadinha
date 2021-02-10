namespace trabalhointer
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblemail = new System.Windows.Forms.Label();
            this.lblsenha = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtsenha = new System.Windows.Forms.TextBox();
            this.btncad = new System.Windows.Forms.Button();
            this.lblcad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(362, 74);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(53, 20);
            this.lblemail.TabIndex = 4;
            this.lblemail.Text = "E-mail";
            this.lblemail.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblsenha
            // 
            this.lblsenha.AutoSize = true;
            this.lblsenha.Location = new System.Drawing.Point(360, 194);
            this.lblsenha.Name = "lblsenha";
            this.lblsenha.Size = new System.Drawing.Size(56, 20);
            this.lblsenha.TabIndex = 5;
            this.lblsenha.Text = "Senha";
            this.lblsenha.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(254, 122);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(269, 26);
            this.txtemail.TabIndex = 0;
            this.txtemail.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtsenha
            // 
            this.txtsenha.Location = new System.Drawing.Point(314, 236);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.Size = new System.Drawing.Size(148, 26);
            this.txtsenha.TabIndex = 3;
            this.txtsenha.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btncad
            // 
            this.btncad.BackColor = System.Drawing.Color.Gold;
            this.btncad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncad.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btncad.Location = new System.Drawing.Point(477, 307);
            this.btncad.Name = "btncad";
            this.btncad.Size = new System.Drawing.Size(110, 28);
            this.btncad.TabIndex = 6;
            this.btncad.Text = "Cadastrar";
            this.btncad.UseVisualStyleBackColor = false;
            // 
            // lblcad
            // 
            this.lblcad.AutoSize = true;
            this.lblcad.Location = new System.Drawing.Point(187, 311);
            this.lblcad.Name = "lblcad";
            this.lblcad.Size = new System.Drawing.Size(284, 20);
            this.lblcad.TabIndex = 7;
            this.lblcad.Text = "Não tem cadastro? Cadastre-se agora!";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblcad);
            this.Controls.Add(this.btncad);
            this.Controls.Add(this.lblsenha);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.txtsenha);
            this.Controls.Add(this.txtemail);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblsenha;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtsenha;
        private System.Windows.Forms.Button btncad;
        private System.Windows.Forms.Label lblcad;
    }
}

