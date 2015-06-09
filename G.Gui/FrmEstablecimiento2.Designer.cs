namespace G.Gui
{
    partial class FrmEstablecimiento2
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Nombre_text = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Campo_lbl = new System.Windows.Forms.Label();
            this.Renspa_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 128);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(504, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Nombre_text
            // 
            this.Nombre_text.Location = new System.Drawing.Point(71, 84);
            this.Nombre_text.Name = "Nombre_text";
            this.Nombre_text.Size = new System.Drawing.Size(259, 20);
            this.Nombre_text.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(446, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Campo_lbl
            // 
            this.Campo_lbl.AutoSize = true;
            this.Campo_lbl.Location = new System.Drawing.Point(18, 9);
            this.Campo_lbl.Name = "Campo_lbl";
            this.Campo_lbl.Size = new System.Drawing.Size(43, 13);
            this.Campo_lbl.TabIndex = 4;
            this.Campo_lbl.Text = "Campo:";
            // 
            // Renspa_lbl
            // 
            this.Renspa_lbl.AutoSize = true;
            this.Renspa_lbl.Location = new System.Drawing.Point(18, 47);
            this.Renspa_lbl.Name = "Renspa_lbl";
            this.Renspa_lbl.Size = new System.Drawing.Size(47, 13);
            this.Renspa_lbl.TabIndex = 5;
            this.Renspa_lbl.Text = "Renspa:";
            // 
            // FrmEstablecimiento2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 150);
            this.Controls.Add(this.Renspa_lbl);
            this.Controls.Add(this.Campo_lbl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Nombre_text);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Name = "FrmEstablecimiento2";
            this.Text = "Ingresar Establecimiento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TextBox Nombre_text;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Campo_lbl;
        private System.Windows.Forms.Label Renspa_lbl;
    }
}