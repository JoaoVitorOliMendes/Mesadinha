namespace Mesadinha
{
    partial class Conta
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
            this.label2 = new System.Windows.Forms.Label();
            this.cbxcat = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxtipo = new System.Windows.Forms.ComboBox();
            this.dtgcat = new System.Windows.Forms.DataGridView();
            this.btnex = new System.Windows.Forms.Button();
            this.lblcadad = new System.Windows.Forms.Label();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btncat = new System.Windows.Forms.Button();
            this.lblnome = new System.Windows.Forms.Label();
            this.txtcon = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgcat)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(132, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 27);
            this.label2.TabIndex = 41;
            this.label2.Text = "Categoria";
            // 
            // cbxcat
            // 
            this.cbxcat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxcat.FormattingEnabled = true;
            this.cbxcat.Location = new System.Drawing.Point(262, 202);
            this.cbxcat.Name = "cbxcat";
            this.cbxcat.Size = new System.Drawing.Size(303, 35);
            this.cbxcat.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(182, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 27);
            this.label1.TabIndex = 39;
            this.label1.Text = "Tipo";
            // 
            // cbxtipo
            // 
            this.cbxtipo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxtipo.FormattingEnabled = true;
            this.cbxtipo.Items.AddRange(new object[] {
            "despesa",
            "receita"});
            this.cbxtipo.Location = new System.Drawing.Point(262, 141);
            this.cbxtipo.Name = "cbxtipo";
            this.cbxtipo.Size = new System.Drawing.Size(303, 35);
            this.cbxtipo.TabIndex = 38;
            // 
            // dtgcat
            // 
            this.dtgcat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgcat.Location = new System.Drawing.Point(12, 309);
            this.dtgcat.Name = "dtgcat";
            this.dtgcat.RowHeadersWidth = 62;
            this.dtgcat.RowTemplate.Height = 28;
            this.dtgcat.Size = new System.Drawing.Size(776, 158);
            this.dtgcat.TabIndex = 37;
            // 
            // btnex
            // 
            this.btnex.BackColor = System.Drawing.Color.DarkGray;
            this.btnex.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnex.Location = new System.Drawing.Point(358, 256);
            this.btnex.Name = "btnex";
            this.btnex.Size = new System.Drawing.Size(100, 47);
            this.btnex.TabIndex = 36;
            this.btnex.Text = "Excluir";
            this.btnex.UseVisualStyleBackColor = false;
            this.btnex.Click += new System.EventHandler(this.btnex_Click);
            // 
            // lblcadad
            // 
            this.lblcadad.AutoSize = true;
            this.lblcadad.BackColor = System.Drawing.Color.Transparent;
            this.lblcadad.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcadad.ForeColor = System.Drawing.Color.Black;
            this.lblcadad.Location = new System.Drawing.Point(339, 9);
            this.lblcadad.Name = "lblcadad";
            this.lblcadad.Size = new System.Drawing.Size(149, 55);
            this.lblcadad.TabIndex = 35;
            this.lblcadad.Text = "Conta";
            this.lblcadad.Click += new System.EventHandler(this.lblcadad_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.BackColor = System.Drawing.Color.DarkGray;
            this.btnvoltar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvoltar.Location = new System.Drawing.Point(464, 256);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(101, 47);
            this.btnvoltar.TabIndex = 34;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = false;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btncat
            // 
            this.btncat.BackColor = System.Drawing.Color.DarkGray;
            this.btncat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncat.Location = new System.Drawing.Point(248, 256);
            this.btncat.Name = "btncat";
            this.btncat.Size = new System.Drawing.Size(104, 47);
            this.btncat.TabIndex = 33;
            this.btncat.Text = "Salvar\r\n";
            this.btncat.UseVisualStyleBackColor = false;
            this.btncat.Click += new System.EventHandler(this.btncat_Click);
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnome.Location = new System.Drawing.Point(167, 83);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(70, 27);
            this.lblnome.TabIndex = 32;
            this.lblnome.Text = "Nome";
            // 
            // txtcon
            // 
            this.txtcon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcon.Location = new System.Drawing.Point(262, 80);
            this.txtcon.Name = "txtcon";
            this.txtcon.Size = new System.Drawing.Size(303, 35);
            this.txtcon.TabIndex = 31;
            // 
            // Conta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxcat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxtipo);
            this.Controls.Add(this.dtgcat);
            this.Controls.Add(this.btnex);
            this.Controls.Add(this.lblcadad);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btncat);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.txtcon);
            this.Name = "Conta";
            this.Text = "Conta";
            ((System.ComponentModel.ISupportInitialize)(this.dtgcat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxcat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxtipo;
        private System.Windows.Forms.DataGridView dtgcat;
        private System.Windows.Forms.Button btnex;
        private System.Windows.Forms.Label lblcadad;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btncat;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.TextBox txtcon;
    }
}