namespace trabalhointer
{
    partial class senha
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
            this.lblcadad = new System.Windows.Forms.Label();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btncad = new System.Windows.Forms.Button();
            this.lblnome = new System.Windows.Forms.Label();
            this.txtSENHA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSENHA2 = new System.Windows.Forms.TextBox();
            this.btnver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblcadad
            // 
            this.lblcadad.AutoSize = true;
            this.lblcadad.Font = new System.Drawing.Font("Verdana", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcadad.ForeColor = System.Drawing.Color.Purple;
            this.lblcadad.Location = new System.Drawing.Point(195, 39);
            this.lblcadad.Name = "lblcadad";
            this.lblcadad.Size = new System.Drawing.Size(411, 60);
            this.lblcadad.TabIndex = 27;
            this.lblcadad.Text = "Alterar Senha";
            this.lblcadad.Click += new System.EventHandler(this.lblcadad_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.BackColor = System.Drawing.Color.Purple;
            this.btnvoltar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvoltar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnvoltar.Location = new System.Drawing.Point(427, 322);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(125, 54);
            this.btnvoltar.TabIndex = 26;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = false;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btncad
            // 
            this.btncad.BackColor = System.Drawing.Color.Purple;
            this.btncad.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncad.ForeColor = System.Drawing.SystemColors.Control;
            this.btncad.Location = new System.Drawing.Point(249, 322);
            this.btncad.Name = "btncad";
            this.btncad.Size = new System.Drawing.Size(125, 54);
            this.btncad.TabIndex = 25;
            this.btncad.Text = "Alterar";
            this.btncad.UseVisualStyleBackColor = false;
            this.btncad.Click += new System.EventHandler(this.btncad_Click);
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnome.Location = new System.Drawing.Point(357, 128);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(87, 29);
            this.lblnome.TabIndex = 24;
            this.lblnome.Text = "Senha";
            this.lblnome.Click += new System.EventHandler(this.lblnome_Click);
            // 
            // txtSENHA
            // 
            this.txtSENHA.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSENHA.Location = new System.Drawing.Point(249, 160);
            this.txtSENHA.Name = "txtSENHA";
            this.txtSENHA.PasswordChar = '*';
            this.txtSENHA.Size = new System.Drawing.Size(303, 37);
            this.txtSENHA.TabIndex = 23;
            this.txtSENHA.TextChanged += new System.EventHandler(this.txtnome_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(294, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 29);
            this.label1.TabIndex = 29;
            this.label1.Text = "Confirmar Senha";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtSENHA2
            // 
            this.txtSENHA2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSENHA2.Location = new System.Drawing.Point(249, 256);
            this.txtSENHA2.Name = "txtSENHA2";
            this.txtSENHA2.PasswordChar = '*';
            this.txtSENHA2.Size = new System.Drawing.Size(303, 37);
            this.txtSENHA2.TabIndex = 28;
            this.txtSENHA2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnver
            // 
            this.btnver.BackColor = System.Drawing.Color.Purple;
            this.btnver.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnver.ForeColor = System.Drawing.SystemColors.Control;
            this.btnver.Location = new System.Drawing.Point(581, 252);
            this.btnver.Name = "btnver";
            this.btnver.Size = new System.Drawing.Size(67, 44);
            this.btnver.TabIndex = 30;
            this.btnver.Text = "Ver";
            this.btnver.UseVisualStyleBackColor = false;
            this.btnver.Click += new System.EventHandler(this.btnver_Click);
            // 
            // senha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnver);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSENHA2);
            this.Controls.Add(this.lblcadad);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btncad);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.txtSENHA);
            this.Name = "senha";
            this.Text = "senha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcadad;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btncad;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.TextBox txtSENHA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSENHA2;
        private System.Windows.Forms.Button btnver;
    }
}