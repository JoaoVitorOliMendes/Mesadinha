namespace Mesadinha
{
    partial class cat
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
            this.btnex = new System.Windows.Forms.Button();
            this.lblcadad = new System.Windows.Forms.Label();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btncat = new System.Windows.Forms.Button();
            this.lblnome = new System.Windows.Forms.Label();
            this.txtcat = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgcat)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgcat
            // 
            this.dtgcat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgcat.Location = new System.Drawing.Point(5, 278);
            this.dtgcat.Name = "dtgcat";
            this.dtgcat.RowHeadersWidth = 62;
            this.dtgcat.RowTemplate.Height = 28;
            this.dtgcat.Size = new System.Drawing.Size(790, 158);
            this.dtgcat.TabIndex = 26;
            this.dtgcat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgcat_CellContentClick);
            // 
            // btnex
            // 
            this.btnex.BackColor = System.Drawing.Color.DarkGray;
            this.btnex.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnex.Location = new System.Drawing.Point(342, 199);
            this.btnex.Name = "btnex";
            this.btnex.Size = new System.Drawing.Size(104, 47);
            this.btnex.TabIndex = 25;
            this.btnex.Text = "Excluir";
            this.btnex.UseVisualStyleBackColor = false;
            this.btnex.Click += new System.EventHandler(this.btnex_Click);
            // 
            // lblcadad
            // 
            this.lblcadad.AutoSize = true;
            this.lblcadad.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcadad.ForeColor = System.Drawing.Color.Black;
            this.lblcadad.Location = new System.Drawing.Point(286, 14);
            this.lblcadad.Name = "lblcadad";
            this.lblcadad.Size = new System.Drawing.Size(226, 55);
            this.lblcadad.TabIndex = 24;
            this.lblcadad.Text = "Categoria\r\n";
            // 
            // btnvoltar
            // 
            this.btnvoltar.BackColor = System.Drawing.Color.DarkGray;
            this.btnvoltar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvoltar.Location = new System.Drawing.Point(452, 199);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(99, 47);
            this.btnvoltar.TabIndex = 23;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = false;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btncat
            // 
            this.btncat.BackColor = System.Drawing.Color.DarkGray;
            this.btncat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncat.Location = new System.Drawing.Point(237, 199);
            this.btncat.Name = "btncat";
            this.btncat.Size = new System.Drawing.Size(99, 47);
            this.btncat.TabIndex = 22;
            this.btncat.Text = "Salvar\r\n";
            this.btncat.UseVisualStyleBackColor = false;
            this.btncat.Click += new System.EventHandler(this.btncat_Click);
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnome.Location = new System.Drawing.Point(139, 121);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(100, 54);
            this.lblnome.TabIndex = 21;
            this.lblnome.Text = "Nome da\r\ncategoria\r\n";
            // 
            // txtcat
            // 
            this.txtcat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcat.Location = new System.Drawing.Point(248, 128);
            this.txtcat.Name = "txtcat";
            this.txtcat.Size = new System.Drawing.Size(303, 35);
            this.txtcat.TabIndex = 20;
            // 
            // cat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgcat);
            this.Controls.Add(this.btnex);
            this.Controls.Add(this.lblcadad);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btncat);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.txtcat);
            this.Name = "cat";
            this.Text = "cat";
            ((System.ComponentModel.ISupportInitialize)(this.dtgcat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgcat;
        private System.Windows.Forms.Button btnex;
        private System.Windows.Forms.Label lblcadad;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btncat;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.TextBox txtcat;
    }
}