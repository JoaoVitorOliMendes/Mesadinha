namespace trabalhointer
{
    partial class categoria
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
            this.btnSAL = new System.Windows.Forms.Button();
            this.lbl2 = new System.Windows.Forms.Label();
            this.txtCAT = new System.Windows.Forms.TextBox();
            this.btnDEL = new System.Windows.Forms.Button();
            this.dtgCAT = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCAT)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Verdana", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.Purple;
            this.lbl1.Location = new System.Drawing.Point(257, 9);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(294, 60);
            this.lbl1.TabIndex = 17;
            this.lbl1.Text = "Categoria\r\n";
            this.lbl1.Click += new System.EventHandler(this.lblcadad_Click);
            // 
            // btnVOLTAR
            // 
            this.btnVOLTAR.BackColor = System.Drawing.Color.Purple;
            this.btnVOLTAR.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVOLTAR.ForeColor = System.Drawing.SystemColors.Control;
            this.btnVOLTAR.Location = new System.Drawing.Point(438, 207);
            this.btnVOLTAR.Name = "btnVOLTAR";
            this.btnVOLTAR.Size = new System.Drawing.Size(122, 56);
            this.btnVOLTAR.TabIndex = 16;
            this.btnVOLTAR.Text = "Voltar";
            this.btnVOLTAR.UseVisualStyleBackColor = false;
            this.btnVOLTAR.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btnSAL
            // 
            this.btnSAL.BackColor = System.Drawing.Color.Purple;
            this.btnSAL.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSAL.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSAL.Location = new System.Drawing.Point(257, 207);
            this.btnSAL.Name = "btnSAL";
            this.btnSAL.Size = new System.Drawing.Size(122, 56);
            this.btnSAL.TabIndex = 15;
            this.btnSAL.Text = "Salvar\r\n";
            this.btnSAL.UseVisualStyleBackColor = false;
            this.btnSAL.Click += new System.EventHandler(this.btncad_Click);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(285, 121);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(238, 29);
            this.lbl2.TabIndex = 14;
            this.lbl2.Text = "Nome da categoria\r\n";
            this.lbl2.Click += new System.EventHandler(this.lblnome_Click);
            // 
            // txtCAT
            // 
            this.txtCAT.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCAT.Location = new System.Drawing.Point(257, 153);
            this.txtCAT.Name = "txtCAT";
            this.txtCAT.Size = new System.Drawing.Size(303, 37);
            this.txtCAT.TabIndex = 13;
            this.txtCAT.TextChanged += new System.EventHandler(this.txtnome_TextChanged);
            // 
            // btnDEL
            // 
            this.btnDEL.BackColor = System.Drawing.Color.Purple;
            this.btnDEL.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDEL.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDEL.Location = new System.Drawing.Point(664, 207);
            this.btnDEL.Name = "btnDEL";
            this.btnDEL.Size = new System.Drawing.Size(124, 56);
            this.btnDEL.TabIndex = 18;
            this.btnDEL.Text = "Deletar";
            this.btnDEL.UseVisualStyleBackColor = false;
            this.btnDEL.Click += new System.EventHandler(this.btnex_Click);
            // 
            // dtgCAT
            // 
            this.dtgCAT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCAT.Location = new System.Drawing.Point(5, 284);
            this.dtgCAT.Name = "dtgCAT";
            this.dtgCAT.RowHeadersWidth = 62;
            this.dtgCAT.RowTemplate.Height = 28;
            this.dtgCAT.Size = new System.Drawing.Size(790, 158);
            this.dtgCAT.TabIndex = 19;
            this.dtgCAT.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // categoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgCAT);
            this.Controls.Add(this.btnDEL);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnVOLTAR);
            this.Controls.Add(this.btnSAL);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.txtCAT);
            this.Name = "categoria";
            this.Text = "categoria";
            this.Load += new System.EventHandler(this.categoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCAT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnVOLTAR;
        private System.Windows.Forms.Button btnSAL;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox txtCAT;
        private System.Windows.Forms.Button btnDEL;
        private System.Windows.Forms.DataGridView dtgCAT;
    }
}