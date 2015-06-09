namespace G.Gui
{
    partial class FrmBovinoGeneral
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.rp_text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Categoria_text = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Cantidad_num = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Establecimiento_text = new System.Windows.Forms.TextBox();
            this.renspa_text = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Cantidad_num)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 335);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(622, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rp:";
            // 
            // rp_text
            // 
            this.rp_text.Location = new System.Drawing.Point(114, 137);
            this.rp_text.Name = "rp_text";
            this.rp_text.Size = new System.Drawing.Size(108, 20);
            this.rp_text.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Categoria:";
            // 
            // Categoria_text
            // 
            this.Categoria_text.FormattingEnabled = true;
            this.Categoria_text.Location = new System.Drawing.Point(114, 172);
            this.Categoria_text.Name = "Categoria_text";
            this.Categoria_text.Size = new System.Drawing.Size(201, 21);
            this.Categoria_text.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cantidad:";
            // 
            // Cantidad_num
            // 
            this.Cantidad_num.Location = new System.Drawing.Point(114, 214);
            this.Cantidad_num.Name = "Cantidad_num";
            this.Cantidad_num.Size = new System.Drawing.Size(108, 20);
            this.Cantidad_num.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(431, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(535, 309);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Establecimiento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Renspa:";
            // 
            // Establecimiento_text
            // 
            this.Establecimiento_text.Location = new System.Drawing.Point(114, 27);
            this.Establecimiento_text.Name = "Establecimiento_text";
            this.Establecimiento_text.Size = new System.Drawing.Size(201, 20);
            this.Establecimiento_text.TabIndex = 11;
            // 
            // renspa_text
            // 
            this.renspa_text.Location = new System.Drawing.Point(114, 67);
            this.renspa_text.Name = "renspa_text";
            this.renspa_text.Size = new System.Drawing.Size(201, 20);
            this.renspa_text.TabIndex = 12;
            // 
            // FrmBovinoGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 357);
            this.Controls.Add(this.renspa_text);
            this.Controls.Add(this.Establecimiento_text);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Cantidad_num);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Categoria_text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rp_text);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "FrmBovinoGeneral";
            this.Text = "Ingresar";
            ((System.ComponentModel.ISupportInitialize)(this.Cantidad_num)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox rp_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown Cantidad_num;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.ComboBox Categoria_text;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Establecimiento_text;
        private System.Windows.Forms.TextBox renspa_text;
    }
}