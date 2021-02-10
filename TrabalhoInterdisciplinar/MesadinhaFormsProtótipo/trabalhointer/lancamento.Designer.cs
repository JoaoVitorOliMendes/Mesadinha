namespace trabalhointer
{
    partial class lancamento
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
            this.lbl3 = new System.Windows.Forms.Label();
            this.cbxNOME = new System.Windows.Forms.ComboBox();
            this.dtgLANC = new System.Windows.Forms.DataGridView();
            this.btnDEL = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnVOLTAR = new System.Windows.Forms.Button();
            this.btnSAL = new System.Windows.Forms.Button();
            this.lbl2 = new System.Windows.Forms.Label();
            this.txtVALOR = new System.Windows.Forms.NumericUpDown();
            this.txtCODIGO = new System.Windows.Forms.NumericUpDown();
            this.lbl4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLANC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVALOR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCODIGO)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(352, 158);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(83, 29);
            this.lbl3.TabIndex = 41;
            this.lbl3.Text = "Conta";
            // 
            // cbxNOME
            // 
            this.cbxNOME.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxNOME.FormattingEnabled = true;
            this.cbxNOME.Location = new System.Drawing.Point(242, 190);
            this.cbxNOME.Name = "cbxNOME";
            this.cbxNOME.Size = new System.Drawing.Size(303, 37);
            this.cbxNOME.TabIndex = 40;
            this.cbxNOME.SelectedIndexChanged += new System.EventHandler(this.cbxcon_SelectedIndexChanged);
            // 
            // dtgLANC
            // 
            this.dtgLANC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgLANC.Location = new System.Drawing.Point(12, 286);
            this.dtgLANC.Name = "dtgLANC";
            this.dtgLANC.RowHeadersWidth = 62;
            this.dtgLANC.RowTemplate.Height = 28;
            this.dtgLANC.Size = new System.Drawing.Size(776, 181);
            this.dtgLANC.TabIndex = 37;
            // 
            // btnDEL
            // 
            this.btnDEL.BackColor = System.Drawing.Color.Purple;
            this.btnDEL.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDEL.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDEL.Location = new System.Drawing.Point(677, 233);
            this.btnDEL.Name = "btnDEL";
            this.btnDEL.Size = new System.Drawing.Size(111, 47);
            this.btnDEL.TabIndex = 36;
            this.btnDEL.Text = "Deletar";
            this.btnDEL.UseVisualStyleBackColor = false;
            this.btnDEL.Click += new System.EventHandler(this.btnex_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Verdana", 25F, System.Drawing.FontStyle.Bold);
            this.lbl1.ForeColor = System.Drawing.Color.Purple;
            this.lbl1.Location = new System.Drawing.Point(195, 9);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(397, 60);
            this.lbl1.TabIndex = 35;
            this.lbl1.Text = "Lancamentos";
            // 
            // btnVOLTAR
            // 
            this.btnVOLTAR.BackColor = System.Drawing.Color.Purple;
            this.btnVOLTAR.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVOLTAR.ForeColor = System.Drawing.SystemColors.Control;
            this.btnVOLTAR.Location = new System.Drawing.Point(412, 233);
            this.btnVOLTAR.Name = "btnVOLTAR";
            this.btnVOLTAR.Size = new System.Drawing.Size(133, 47);
            this.btnVOLTAR.TabIndex = 34;
            this.btnVOLTAR.Text = "Voltar";
            this.btnVOLTAR.UseVisualStyleBackColor = false;
            this.btnVOLTAR.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btnSAL
            // 
            this.btnSAL.BackColor = System.Drawing.Color.Purple;
            this.btnSAL.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSAL.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSAL.Location = new System.Drawing.Point(242, 233);
            this.btnSAL.Name = "btnSAL";
            this.btnSAL.Size = new System.Drawing.Size(143, 47);
            this.btnSAL.TabIndex = 33;
            this.btnSAL.Text = "Salvar\r\n";
            this.btnSAL.UseVisualStyleBackColor = false;
            this.btnSAL.Click += new System.EventHandler(this.btncat_Click);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(357, 74);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(73, 29);
            this.lbl2.TabIndex = 32;
            this.lbl2.Text = "Valor";
            // 
            // txtVALOR
            // 
            this.txtVALOR.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVALOR.Location = new System.Drawing.Point(242, 106);
            this.txtVALOR.Maximum = new decimal(new int[] {
            1874919423,
            2328306,
            0,
            0});
            this.txtVALOR.Name = "txtVALOR";
            this.txtVALOR.Size = new System.Drawing.Size(303, 37);
            this.txtVALOR.TabIndex = 42;
            // 
            // txtCODIGO
            // 
            this.txtCODIGO.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCODIGO.Location = new System.Drawing.Point(677, 190);
            this.txtCODIGO.Maximum = new decimal(new int[] {
            1874919423,
            2328306,
            0,
            0});
            this.txtCODIGO.Name = "txtCODIGO";
            this.txtCODIGO.Size = new System.Drawing.Size(111, 37);
            this.txtCODIGO.TabIndex = 43;
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.Location = new System.Drawing.Point(684, 158);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(96, 29);
            this.lbl4.TabIndex = 44;
            this.lbl4.Text = "Codigo";
            // 
            // lancamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.txtCODIGO);
            this.Controls.Add(this.txtVALOR);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.cbxNOME);
            this.Controls.Add(this.dtgLANC);
            this.Controls.Add(this.btnDEL);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnVOLTAR);
            this.Controls.Add(this.btnSAL);
            this.Controls.Add(this.lbl2);
            this.Name = "lancamento";
            this.Text = "lancamento";
            this.Load += new System.EventHandler(this.lancamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgLANC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVALOR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCODIGO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.ComboBox cbxNOME;
        private System.Windows.Forms.DataGridView dtgLANC;
        private System.Windows.Forms.Button btnDEL;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnVOLTAR;
        private System.Windows.Forms.Button btnSAL;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.NumericUpDown txtVALOR;
        private System.Windows.Forms.NumericUpDown txtCODIGO;
        private System.Windows.Forms.Label lbl4;
    }
}