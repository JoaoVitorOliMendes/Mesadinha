namespace trabalhointer
{
    partial class conta
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
            this.dtgcat = new System.Windows.Forms.DataGridView();
            this.btnDEL = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnVOLTAR = new System.Windows.Forms.Button();
            this.btnCON = new System.Windows.Forms.Button();
            this.lbl2 = new System.Windows.Forms.Label();
            this.txtNOME = new System.Windows.Forms.TextBox();
            this.cbxTIPO = new System.Windows.Forms.ComboBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.cbxCAT = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgcat)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgcat
            // 
            this.dtgcat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgcat.Location = new System.Drawing.Point(12, 366);
            this.dtgcat.Name = "dtgcat";
            this.dtgcat.RowHeadersWidth = 62;
            this.dtgcat.RowTemplate.Height = 28;
            this.dtgcat.Size = new System.Drawing.Size(776, 127);
            this.dtgcat.TabIndex = 26;
            this.dtgcat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgcat_CellContentClick);
            // 
            // btnDEL
            // 
            this.btnDEL.BackColor = System.Drawing.Color.Purple;
            this.btnDEL.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDEL.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDEL.Location = new System.Drawing.Point(664, 313);
            this.btnDEL.Name = "btnDEL";
            this.btnDEL.Size = new System.Drawing.Size(124, 47);
            this.btnDEL.TabIndex = 25;
            this.btnDEL.Text = "Deletar";
            this.btnDEL.UseVisualStyleBackColor = false;
            this.btnDEL.Click += new System.EventHandler(this.btnex_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Verdana", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.Purple;
            this.lbl1.Location = new System.Drawing.Point(304, 4);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(187, 60);
            this.lbl1.TabIndex = 24;
            this.lbl1.Text = "Conta";
            this.lbl1.Click += new System.EventHandler(this.lblcadad_Click);
            // 
            // btnVOLTAR
            // 
            this.btnVOLTAR.BackColor = System.Drawing.Color.Purple;
            this.btnVOLTAR.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVOLTAR.ForeColor = System.Drawing.SystemColors.Control;
            this.btnVOLTAR.Location = new System.Drawing.Point(427, 313);
            this.btnVOLTAR.Name = "btnVOLTAR";
            this.btnVOLTAR.Size = new System.Drawing.Size(122, 47);
            this.btnVOLTAR.TabIndex = 23;
            this.btnVOLTAR.Text = "Voltar";
            this.btnVOLTAR.UseVisualStyleBackColor = false;
            this.btnVOLTAR.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btnCON
            // 
            this.btnCON.BackColor = System.Drawing.Color.Purple;
            this.btnCON.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCON.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCON.Location = new System.Drawing.Point(246, 313);
            this.btnCON.Name = "btnCON";
            this.btnCON.Size = new System.Drawing.Size(122, 47);
            this.btnCON.TabIndex = 22;
            this.btnCON.Text = "Salvar\r\n";
            this.btnCON.UseVisualStyleBackColor = false;
            this.btnCON.Click += new System.EventHandler(this.btncat_Click);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(300, 84);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(194, 29);
            this.lbl2.TabIndex = 21;
            this.lbl2.Text = "Nome da conta\r\n";
            // 
            // txtNOME
            // 
            this.txtNOME.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNOME.Location = new System.Drawing.Point(246, 116);
            this.txtNOME.Name = "txtNOME";
            this.txtNOME.Size = new System.Drawing.Size(303, 37);
            this.txtNOME.TabIndex = 20;
            // 
            // cbxTIPO
            // 
            this.cbxTIPO.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTIPO.FormattingEnabled = true;
            this.cbxTIPO.Items.AddRange(new object[] {
            "despesa",
            "receita"});
            this.cbxTIPO.Location = new System.Drawing.Point(246, 194);
            this.cbxTIPO.Name = "cbxTIPO";
            this.cbxTIPO.Size = new System.Drawing.Size(303, 37);
            this.cbxTIPO.TabIndex = 27;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(365, 162);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(64, 29);
            this.lbl3.TabIndex = 28;
            this.lbl3.Text = "Tipo";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.Location = new System.Drawing.Point(334, 238);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(127, 29);
            this.lbl4.TabIndex = 30;
            this.lbl4.Text = "Categoria";
            // 
            // cbxCAT
            // 
            this.cbxCAT.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCAT.FormattingEnabled = true;
            this.cbxCAT.Location = new System.Drawing.Point(246, 270);
            this.cbxCAT.Name = "cbxCAT";
            this.cbxCAT.Size = new System.Drawing.Size(303, 37);
            this.cbxCAT.TabIndex = 29;
            this.cbxCAT.SelectedIndexChanged += new System.EventHandler(this.cbxcat_SelectedIndexChanged);
            // 
            // conta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(800, 505);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.cbxCAT);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.cbxTIPO);
            this.Controls.Add(this.dtgcat);
            this.Controls.Add(this.btnDEL);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnVOLTAR);
            this.Controls.Add(this.btnCON);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.txtNOME);
            this.Name = "conta";
            this.Text = "conta";
            this.Load += new System.EventHandler(this.conta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgcat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgcat;
        private System.Windows.Forms.Button btnDEL;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnVOLTAR;
        private System.Windows.Forms.Button btnCON;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox txtNOME;
        private System.Windows.Forms.ComboBox cbxTIPO;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.ComboBox cbxCAT;
    }
}