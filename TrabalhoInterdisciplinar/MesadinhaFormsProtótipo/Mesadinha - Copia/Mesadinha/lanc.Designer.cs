namespace Mesadinha
{
    partial class lanc
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtcod = new System.Windows.Forms.NumericUpDown();
            this.txtval = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxcon = new System.Windows.Forms.ComboBox();
            this.dtgcat = new System.Windows.Forms.DataGridView();
            this.btnex = new System.Windows.Forms.Button();
            this.lblcadad = new System.Windows.Forms.Label();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btncat = new System.Windows.Forms.Button();
            this.lblnome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtcod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgcat)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(612, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 27);
            this.label1.TabIndex = 55;
            this.label1.Text = "Codigo";
            // 
            // txtcod
            // 
            this.txtcod.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcod.Location = new System.Drawing.Point(699, 147);
            this.txtcod.Maximum = new decimal(new int[] {
            1874919423,
            2328306,
            0,
            0});
            this.txtcod.Name = "txtcod";
            this.txtcod.Size = new System.Drawing.Size(89, 35);
            this.txtcod.TabIndex = 54;
            // 
            // txtval
            // 
            this.txtval.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtval.Location = new System.Drawing.Point(242, 93);
            this.txtval.Maximum = new decimal(new int[] {
            1874919423,
            2328306,
            0,
            0});
            this.txtval.Name = "txtval";
            this.txtval.Size = new System.Drawing.Size(303, 35);
            this.txtval.TabIndex = 53;
            this.txtval.ValueChanged += new System.EventHandler(this.txtval_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(158, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 27);
            this.label2.TabIndex = 52;
            this.label2.Text = "Conta";
            // 
            // cbxcon
            // 
            this.cbxcon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxcon.FormattingEnabled = true;
            this.cbxcon.Location = new System.Drawing.Point(242, 147);
            this.cbxcon.Name = "cbxcon";
            this.cbxcon.Size = new System.Drawing.Size(303, 35);
            this.cbxcon.TabIndex = 51;
            // 
            // dtgcat
            // 
            this.dtgcat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgcat.Location = new System.Drawing.Point(12, 273);
            this.dtgcat.Name = "dtgcat";
            this.dtgcat.RowHeadersWidth = 62;
            this.dtgcat.RowTemplate.Height = 28;
            this.dtgcat.Size = new System.Drawing.Size(776, 181);
            this.dtgcat.TabIndex = 50;
            // 
            // btnex
            // 
            this.btnex.BackColor = System.Drawing.Color.DarkGray;
            this.btnex.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnex.Location = new System.Drawing.Point(692, 206);
            this.btnex.Name = "btnex";
            this.btnex.Size = new System.Drawing.Size(96, 47);
            this.btnex.TabIndex = 49;
            this.btnex.Text = "Excluir";
            this.btnex.UseVisualStyleBackColor = false;
            this.btnex.Click += new System.EventHandler(this.btnex_Click);
            // 
            // lblcadad
            // 
            this.lblcadad.AutoSize = true;
            this.lblcadad.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcadad.ForeColor = System.Drawing.Color.Black;
            this.lblcadad.Location = new System.Drawing.Point(244, 22);
            this.lblcadad.Name = "lblcadad";
            this.lblcadad.Size = new System.Drawing.Size(298, 55);
            this.lblcadad.TabIndex = 48;
            this.lblcadad.Text = "Lancamentos";
            // 
            // btnvoltar
            // 
            this.btnvoltar.BackColor = System.Drawing.Color.DarkGray;
            this.btnvoltar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvoltar.Location = new System.Drawing.Point(412, 206);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(133, 47);
            this.btnvoltar.TabIndex = 47;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = false;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btncat
            // 
            this.btncat.BackColor = System.Drawing.Color.DarkGray;
            this.btncat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncat.Location = new System.Drawing.Point(263, 206);
            this.btncat.Name = "btncat";
            this.btncat.Size = new System.Drawing.Size(143, 47);
            this.btncat.TabIndex = 46;
            this.btncat.Text = "Salvar\r\n";
            this.btncat.UseVisualStyleBackColor = false;
            this.btncat.Click += new System.EventHandler(this.btncat_Click);
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnome.Location = new System.Drawing.Point(158, 97);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(62, 27);
            this.lblnome.TabIndex = 45;
            this.lblnome.Text = "Valor";
            // 
            // lanc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcod);
            this.Controls.Add(this.txtval);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxcon);
            this.Controls.Add(this.dtgcat);
            this.Controls.Add(this.btnex);
            this.Controls.Add(this.lblcadad);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btncat);
            this.Controls.Add(this.lblnome);
            this.Name = "lanc";
            this.Text = "lanc";
            this.Load += new System.EventHandler(this.lanc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtcod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgcat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown txtcod;
        private System.Windows.Forms.NumericUpDown txtval;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxcon;
        private System.Windows.Forms.DataGridView dtgcat;
        private System.Windows.Forms.Button btnex;
        private System.Windows.Forms.Label lblcadad;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btncat;
        private System.Windows.Forms.Label lblnome;
    }
}