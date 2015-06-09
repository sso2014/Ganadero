namespace G.Gui
{
    partial class FrmTransferencia
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
            this.label2 = new System.Windows.Forms.Label();
            this.DesdeEstablecimineto_comboBox = new System.Windows.Forms.ComboBox();
            this.HastaEstablecimiento_comboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Categoria_comboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Cantidad_num = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Cantidad_num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 442);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(832, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Desde:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hasta:";
            // 
            // DesdeEstablecimineto_comboBox
            // 
            this.DesdeEstablecimineto_comboBox.FormattingEnabled = true;
            this.DesdeEstablecimineto_comboBox.Location = new System.Drawing.Point(79, 37);
            this.DesdeEstablecimineto_comboBox.Name = "DesdeEstablecimineto_comboBox";
            this.DesdeEstablecimineto_comboBox.Size = new System.Drawing.Size(121, 21);
            this.DesdeEstablecimineto_comboBox.TabIndex = 3;
            this.DesdeEstablecimineto_comboBox.SelectedIndexChanged += new System.EventHandler(this.DesdeEstablecimineto_comboBox_SelectedIndexChanged);
            // 
            // HastaEstablecimiento_comboBox
            // 
            this.HastaEstablecimiento_comboBox.FormattingEnabled = true;
            this.HastaEstablecimiento_comboBox.Location = new System.Drawing.Point(79, 84);
            this.HastaEstablecimiento_comboBox.Name = "HastaEstablecimiento_comboBox";
            this.HastaEstablecimiento_comboBox.Size = new System.Drawing.Size(121, 21);
            this.HastaEstablecimiento_comboBox.TabIndex = 4;
            this.HastaEstablecimiento_comboBox.SelectedIndexChanged += new System.EventHandler(this.HastaEstablecimiento_comboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Categoria:";
            // 
            // Categoria_comboBox
            // 
            this.Categoria_comboBox.FormattingEnabled = true;
            this.Categoria_comboBox.Location = new System.Drawing.Point(79, 286);
            this.Categoria_comboBox.Name = "Categoria_comboBox";
            this.Categoria_comboBox.Size = new System.Drawing.Size(186, 21);
            this.Categoria_comboBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(297, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cantidad:";
            // 
            // Cantidad_num
            // 
            this.Cantidad_num.Location = new System.Drawing.Point(359, 289);
            this.Cantidad_num.Name = "Cantidad_num";
            this.Cantidad_num.Size = new System.Drawing.Size(120, 20);
            this.Cantidad_num.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(763, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Comentario:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(90, 345);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(412, 78);
            this.textBox1.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(298, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(504, 201);
            this.dataGridView1.TabIndex = 12;
            // 
            // FrmTransferencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 464);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Cantidad_num);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Categoria_comboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.HastaEstablecimiento_comboBox);
            this.Controls.Add(this.DesdeEstablecimineto_comboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "FrmTransferencia";
            this.Text = "Transferir";
            ((System.ComponentModel.ISupportInitialize)(this.Cantidad_num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown Cantidad_num;
        public System.Windows.Forms.ComboBox DesdeEstablecimineto_comboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.ComboBox HastaEstablecimiento_comboBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.ComboBox Categoria_comboBox;
    }
}