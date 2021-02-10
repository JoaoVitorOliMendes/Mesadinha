namespace trabalhointer
{
    partial class dados
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnVOLTAR = new System.Windows.Forms.Button();
            this.btnALT = new System.Windows.Forms.Button();
            this.lbl3 = new System.Windows.Forms.Label();
            this.txtEMAIL = new System.Windows.Forms.TextBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.txtNOME = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Verdana", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.Purple;
            this.lbl1.Location = new System.Drawing.Point(167, 41);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(411, 60);
            this.lbl1.TabIndex = 22;
            this.lbl1.Text = "Alterar Dados";
            this.lbl1.Click += new System.EventHandler(this.lblcadad_Click);
            // 
            // btnVOLTAR
            // 
            this.btnVOLTAR.BackColor = System.Drawing.Color.Purple;
            this.btnVOLTAR.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVOLTAR.ForeColor = System.Drawing.SystemColors.Control;
            this.btnVOLTAR.Location = new System.Drawing.Point(397, 355);
            this.btnVOLTAR.Name = "btnVOLTAR";
            this.btnVOLTAR.Size = new System.Drawing.Size(126, 47);
            this.btnVOLTAR.TabIndex = 21;
            this.btnVOLTAR.Text = "Voltar";
            this.btnVOLTAR.UseVisualStyleBackColor = false;
            this.btnVOLTAR.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btnALT
            // 
            this.btnALT.BackColor = System.Drawing.Color.Purple;
            this.btnALT.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnALT.ForeColor = System.Drawing.SystemColors.Control;
            this.btnALT.Location = new System.Drawing.Point(220, 355);
            this.btnALT.Name = "btnALT";
            this.btnALT.Size = new System.Drawing.Size(126, 47);
            this.btnALT.TabIndex = 20;
            this.btnALT.Text = "Alterar";
            this.btnALT.UseVisualStyleBackColor = false;
            this.btnALT.Click += new System.EventHandler(this.btncad_Click);
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(327, 237);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(88, 29);
            this.lbl3.TabIndex = 17;
            this.lbl3.Text = "E-mail";
            this.lbl3.Click += new System.EventHandler(this.lblemail_Click);
            // 
            // txtEMAIL
            // 
            this.txtEMAIL.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEMAIL.Location = new System.Drawing.Point(220, 269);
            this.txtEMAIL.Name = "txtEMAIL";
            this.txtEMAIL.Size = new System.Drawing.Size(303, 37);
            this.txtEMAIL.TabIndex = 16;
            this.txtEMAIL.TextChanged += new System.EventHandler(this.txtemail_TextChanged);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(330, 129);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(83, 29);
            this.lbl2.TabIndex = 15;
            this.lbl2.Text = "Nome";
            this.lbl2.Click += new System.EventHandler(this.lblnome_Click);
            // 
            // txtNOME
            // 
            this.txtNOME.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNOME.Location = new System.Drawing.Point(220, 161);
            this.txtNOME.Name = "txtNOME";
            this.txtNOME.Size = new System.Drawing.Size(303, 37);
            this.txtNOME.TabIndex = 14;
            this.txtNOME.TextChanged += new System.EventHandler(this.txtnome_TextChanged);
            // 
            // dados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnVOLTAR);
            this.Controls.Add(this.btnALT);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.txtEMAIL);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.txtNOME);
            this.Name = "dados";
            this.Text = "dados";
            this.Load += new System.EventHandler(this.dados_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnVOLTAR;
        private System.Windows.Forms.Button btnALT;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.TextBox txtEMAIL;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox txtNOME;
    }
}