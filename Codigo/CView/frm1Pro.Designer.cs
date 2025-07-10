namespace CView
{
    partial class frm1Pro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm1Pro));
            gb1 = new GroupBox();
            nmstock = new NumericUpDown();
            label6 = new Label();
            label5 = new Label();
            txtmar = new TextBox();
            nmcosto = new NumericUpDown();
            label4 = new Label();
            label3 = new Label();
            txtref = new TextBox();
            nmvalor = new NumericUpDown();
            txtcod = new TextBox();
            txtnom = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            btnnxt = new Button();
            btnbck = new Button();
            gb1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmstock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmcosto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmvalor).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // gb1
            // 
            gb1.Controls.Add(nmstock);
            gb1.Controls.Add(label6);
            gb1.Controls.Add(label5);
            gb1.Controls.Add(txtmar);
            gb1.Controls.Add(nmcosto);
            gb1.Controls.Add(label4);
            gb1.Controls.Add(label3);
            gb1.Controls.Add(txtref);
            gb1.Controls.Add(nmvalor);
            gb1.Controls.Add(txtcod);
            gb1.Controls.Add(txtnom);
            gb1.Controls.Add(label2);
            gb1.Controls.Add(label1);
            gb1.Enabled = false;
            gb1.Location = new Point(22, 14);
            gb1.Margin = new Padding(4, 3, 4, 3);
            gb1.Name = "gb1";
            gb1.Padding = new Padding(4, 3, 4, 3);
            gb1.Size = new Size(525, 192);
            gb1.TabIndex = 0;
            gb1.TabStop = false;
            gb1.Text = "Datos de Producto";
            // 
            // nmstock
            // 
            nmstock.Location = new Point(394, 131);
            nmstock.Margin = new Padding(4, 3, 4, 3);
            nmstock.Name = "nmstock";
            nmstock.Size = new Size(76, 23);
            nmstock.TabIndex = 6;
            nmstock.TextAlign = HorizontalAlignment.Right;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(331, 133);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 19;
            label6.Text = "Stock:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 106);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 18;
            label5.Text = "Marca:";
            // 
            // txtmar
            // 
            txtmar.Location = new Point(94, 103);
            txtmar.Margin = new Padding(4, 3, 4, 3);
            txtmar.MaxLength = 50;
            txtmar.Name = "txtmar";
            txtmar.Size = new Size(173, 23);
            txtmar.TabIndex = 3;
            // 
            // nmcosto
            // 
            nmcosto.DecimalPlaces = 2;
            nmcosto.Location = new Point(94, 160);
            nmcosto.Margin = new Padding(4, 3, 4, 3);
            nmcosto.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            nmcosto.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nmcosto.Name = "nmcosto";
            nmcosto.Size = new Size(117, 23);
            nmcosto.TabIndex = 5;
            nmcosto.TextAlign = HorizontalAlignment.Right;
            nmcosto.Value = new decimal(new int[] { 50, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 162);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 15;
            label4.Text = "Costo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 77);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 14;
            label3.Text = "Referencia:";
            // 
            // txtref
            // 
            txtref.Location = new Point(94, 74);
            txtref.Margin = new Padding(4, 3, 4, 3);
            txtref.MaxLength = 50;
            txtref.Name = "txtref";
            txtref.Size = new Size(173, 23);
            txtref.TabIndex = 2;
            // 
            // nmvalor
            // 
            nmvalor.DecimalPlaces = 2;
            nmvalor.Location = new Point(94, 131);
            nmvalor.Margin = new Padding(4, 3, 4, 3);
            nmvalor.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            nmvalor.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nmvalor.Name = "nmvalor";
            nmvalor.Size = new Size(117, 23);
            nmvalor.TabIndex = 4;
            nmvalor.TextAlign = HorizontalAlignment.Right;
            nmvalor.Value = new decimal(new int[] { 50, 0, 0, 0 });
            // 
            // txtcod
            // 
            txtcod.Location = new Point(478, 11);
            txtcod.Margin = new Padding(4, 3, 4, 3);
            txtcod.MaxLength = 3;
            txtcod.Name = "txtcod";
            txtcod.ReadOnly = true;
            txtcod.Size = new Size(39, 23);
            txtcod.TabIndex = 11;
            txtcod.Visible = false;
            // 
            // txtnom
            // 
            txtnom.Location = new Point(94, 22);
            txtnom.Margin = new Padding(4, 3, 4, 3);
            txtnom.MaxLength = 50;
            txtnom.Multiline = true;
            txtnom.Name = "txtnom";
            txtnom.Size = new Size(376, 46);
            txtnom.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 133);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 1;
            label2.Text = "Precio:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 25);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 0;
            label1.Text = "Descripción:";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(btnnxt);
            panel1.Controls.Add(btnbck);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 215);
            panel1.Name = "panel1";
            panel1.Size = new Size(570, 64);
            panel1.TabIndex = 3;
            // 
            // btnnxt
            // 
            btnnxt.Image = (Image)resources.GetObject("btnnxt.Image");
            btnnxt.Location = new Point(66, 6);
            btnnxt.Margin = new Padding(4, 3, 4, 3);
            btnnxt.Name = "btnnxt";
            btnnxt.Size = new Size(46, 48);
            btnnxt.TabIndex = 6;
            btnnxt.UseVisualStyleBackColor = true;
            btnnxt.Click += btnnxt_Click;
            // 
            // btnbck
            // 
            btnbck.Image = (Image)resources.GetObject("btnbck.Image");
            btnbck.Location = new Point(13, 6);
            btnbck.Margin = new Padding(4, 3, 4, 3);
            btnbck.Name = "btnbck";
            btnbck.Size = new Size(46, 48);
            btnbck.TabIndex = 5;
            btnbck.UseVisualStyleBackColor = true;
            btnbck.Click += btnbck_Click;
            // 
            // frm1Pro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 279);
            Controls.Add(panel1);
            Controls.Add(gb1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "frm1Pro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consulta - Productos";
            Load += frm1Pro_Load;
            Shown += frm1Pro_Shown;
            gb1.ResumeLayout(false);
            gb1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmstock).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmcosto).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmvalor).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcod;
        private System.Windows.Forms.NumericUpDown nmvalor;
        private Label label3;
        private TextBox txtref;
        private NumericUpDown nmstock;
        private Label label6;
        private Label label5;
        private TextBox txtmar;
        private NumericUpDown nmcosto;
        private Label label4;
        private Panel panel1;
        private Button btnnxt;
        private Button btnbck;
    }
}