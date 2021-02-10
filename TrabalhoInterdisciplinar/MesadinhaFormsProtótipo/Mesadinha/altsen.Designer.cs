namespace Mesadinha
{
    partial class altsen
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
            this.btnver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsenha2 = new System.Windows.Forms.TextBox();
            this.lblcadad = new System.Windows.Forms.Label();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btncad = new System.Windows.Forms.Button();
            this.lblnome = new System.Windows.Forms.Label();
            this.txtsenha = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnver
            // 
            this.btnver.BackColor = System.Drawing.Color.DarkGray;
            this.btnver.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnver.Location = new System.Drawing.Point(459, 254);
            this.btnver.Name = "btnver";
            this.btnver.Size = new System.Drawing.Size(76, 46);
            this.btnver.TabIndex = 38;
            this.btnver.Text = "Ver";
            this.btnver.UseVisualStyleBackColor = false;
            this.btnver.Click += new System.EventHandler(this.btnver_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 27);
            this.label1.TabIndex = 37;
            this.label1.Text = "Confirmar";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtsenha2
            // 
            this.txtsenha2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsenha2.Location = new System.Drawing.Point(232, 213);
            this.txtsenha2.Name = "txtsenha2";
            this.txtsenha2.PasswordChar = '*';
            this.txtsenha2.Size = new System.Drawing.Size(303, 35);
            this.txtsenha2.TabIndex = 36;
            this.txtsenha2.TextChanged += new System.EventHandler(this.txtsenha2_TextChanged);
            // 
            // lblcadad
            // 
            this.lblcadad.AutoSize = true;
            this.lblcadad.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcadad.ForeColor = System.Drawing.Color.Black;
            this.lblcadad.Location = new System.Drawing.Point(225, 31);
            this.lblcadad.Name = "lblcadad";
            this.lblcadad.Size = new System.Drawing.Size(310, 55);
            this.lblcadad.TabIndex = 35;
            this.lblcadad.Text = "Alterar Senha";
            // 
            // btnvoltar
            // 
            this.btnvoltar.BackColor = System.Drawing.Color.DarkGray;
            this.btnvoltar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvoltar.Location = new System.Drawing.Point(427, 359);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(105, 47);
            this.btnvoltar.TabIndex = 34;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = false;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btncad
            // 
            this.btncad.BackColor = System.Drawing.Color.DarkGray;
            this.btncad.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncad.Location = new System.Drawing.Point(316, 359);
            this.btncad.Name = "btncad";
            this.btncad.Size = new System.Drawing.Size(105, 47);
            this.btncad.TabIndex = 33;
            this.btncad.Text = "Salvar";
            this.btncad.UseVisualStyleBackColor = false;
            this.btncad.Click += new System.EventHandler(this.btncad_Click);
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnome.Location = new System.Drawing.Point(137, 155);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(70, 27);
            this.lblnome.TabIndex = 32;
            this.lblnome.Text = "Senha";
            this.lblnome.Click += new System.EventHandler(this.lblnome_Click);
            // 
            // txtsenha
            // 
            this.txtsenha.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsenha.Location = new System.Drawing.Point(229, 152);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.PasswordChar = '*';
            this.txtsenha.Size = new System.Drawing.Size(303, 35);
            this.txtsenha.TabIndex = 31;
            this.txtsenha.TextChanged += new System.EventHandler(this.txtsenha_TextChanged);
            // 
            // altsen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnver);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtsenha2);
            this.Controls.Add(this.lblcadad);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btncad);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.txtsenha);
            this.Name = "altsen";
            this.Text = "altsen";
            this.Load += new System.EventHandler(this.altsen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsenha2;
        private System.Windows.Forms.Label lblcadad;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btncad;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.TextBox txtsenha;
    }
}