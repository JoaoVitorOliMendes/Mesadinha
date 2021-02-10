namespace Mesadinha
{
    partial class altd
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
            this.lblemail = new System.Windows.Forms.Label();
            this.lblnome = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtend = new System.Windows.Forms.TextBox();
            this.txttel = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lblcadad
            // 
            this.lblcadad.AutoSize = true;
            this.lblcadad.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcadad.ForeColor = System.Drawing.Color.Black;
            this.lblcadad.Location = new System.Drawing.Point(246, 22);
            this.lblcadad.Name = "lblcadad";
            this.lblcadad.Size = new System.Drawing.Size(315, 55);
            this.lblcadad.TabIndex = 28;
            this.lblcadad.Text = "Alterar Dados";
            // 
            // btnvoltar
            // 
            this.btnvoltar.BackColor = System.Drawing.Color.DarkGray;
            this.btnvoltar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvoltar.Location = new System.Drawing.Point(447, 275);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(105, 47);
            this.btnvoltar.TabIndex = 27;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = false;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btncad
            // 
            this.btncad.BackColor = System.Drawing.Color.DarkGray;
            this.btncad.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncad.Location = new System.Drawing.Point(333, 275);
            this.btncad.Name = "btncad";
            this.btncad.Size = new System.Drawing.Size(105, 47);
            this.btncad.TabIndex = 26;
            this.btncad.Text = "Alterar";
            this.btncad.UseVisualStyleBackColor = false;
            this.btncad.Click += new System.EventHandler(this.btncad_Click);
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.Location = new System.Drawing.Point(158, 227);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(76, 27);
            this.lblemail.TabIndex = 25;
            this.lblemail.Text = "E-mail";
            this.lblemail.Click += new System.EventHandler(this.lblemail_Click);
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnome.Location = new System.Drawing.Point(164, 105);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(70, 27);
            this.lblnome.TabIndex = 24;
            this.lblnome.Text = "Nome";
            // 
            // txtnome
            // 
            this.txtnome.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnome.Location = new System.Drawing.Point(249, 101);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(303, 35);
            this.txtnome.TabIndex = 23;
            this.txtnome.TextChanged += new System.EventHandler(this.txtnome_TextChanged);
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(249, 224);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(303, 35);
            this.txtemail.TabIndex = 29;
            this.txtemail.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 27);
            this.label1.TabIndex = 31;
            this.label1.Text = "Telefone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(130, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 27);
            this.label2.TabIndex = 33;
            this.label2.Text = "Endereço";
            // 
            // txtend
            // 
            this.txtend.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtend.Location = new System.Drawing.Point(249, 183);
            this.txtend.Name = "txtend";
            this.txtend.Size = new System.Drawing.Size(303, 35);
            this.txtend.TabIndex = 32;
            // 
            // txttel
            // 
            this.txttel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttel.Location = new System.Drawing.Point(249, 142);
            this.txttel.Mask = "(99) 00000-0000";
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(303, 35);
            this.txttel.TabIndex = 34;
            // 
            // altd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txttel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtend);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.lblcadad);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btncad);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.txtnome);
            this.Name = "altd";
            this.Text = "altd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcadad;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btncad;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtend;
        private System.Windows.Forms.MaskedTextBox txttel;
    }
}