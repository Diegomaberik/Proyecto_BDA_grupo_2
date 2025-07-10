namespace CView
{
    partial class frm2Ser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm2Ser));
            gb1 = new GroupBox();
            label3 = new Label();
            txtref = new TextBox();
            nmvalor = new NumericUpDown();
            txtcod = new TextBox();
            txtnom = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btndel = new Button();
            btnnew = new Button();
            btnexit = new Button();
            btnnxt = new Button();
            btnbck = new Button();
            btnedit = new Button();
            btnsave = new Button();
            panel1 = new Panel();
            gb1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmvalor).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // gb1
            // 
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
            gb1.Size = new Size(525, 135);
            gb1.TabIndex = 0;
            gb1.TabStop = false;
            gb1.Text = "Datos de Servicio";
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
            txtref.KeyPress += txtref_KeyPress;
            // 
            // nmvalor
            // 
            nmvalor.DecimalPlaces = 2;
            nmvalor.Location = new Point(94, 106);
            nmvalor.Margin = new Padding(4, 3, 4, 3);
            nmvalor.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            nmvalor.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nmvalor.Name = "nmvalor";
            nmvalor.Size = new Size(117, 23);
            nmvalor.TabIndex = 3;
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
            txtnom.KeyPress += txtnom_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 108);
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
            // btndel
            // 
            btndel.Image = (Image)resources.GetObject("btndel.Image");
            btndel.Location = new Point(403, 4);
            btndel.Margin = new Padding(4, 3, 4, 3);
            btndel.Name = "btndel";
            btndel.Size = new Size(46, 48);
            btndel.TabIndex = 6;
            btndel.UseVisualStyleBackColor = true;
            btndel.Click += btndel_Click;
            // 
            // btnnew
            // 
            btnnew.Image = (Image)resources.GetObject("btnnew.Image");
            btnnew.Location = new Point(511, 4);
            btnnew.Margin = new Padding(4, 3, 4, 3);
            btnnew.Name = "btnnew";
            btnnew.Size = new Size(46, 48);
            btnnew.TabIndex = 8;
            btnnew.UseVisualStyleBackColor = true;
            btnnew.Click += btnnew_Click;
            // 
            // btnexit
            // 
            btnexit.Image = (Image)resources.GetObject("btnexit.Image");
            btnexit.Location = new Point(511, 4);
            btnexit.Margin = new Padding(4, 3, 4, 3);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(46, 48);
            btnexit.TabIndex = 6;
            btnexit.UseVisualStyleBackColor = true;
            btnexit.Click += btnexit_Click;
            // 
            // btnnxt
            // 
            btnnxt.Image = (Image)resources.GetObject("btnnxt.Image");
            btnnxt.Location = new Point(68, 4);
            btnnxt.Margin = new Padding(4, 3, 4, 3);
            btnnxt.Name = "btnnxt";
            btnnxt.Size = new Size(46, 48);
            btnnxt.TabIndex = 5;
            btnnxt.UseVisualStyleBackColor = true;
            btnnxt.Click += btnnxt_Click;
            // 
            // btnbck
            // 
            btnbck.Image = (Image)resources.GetObject("btnbck.Image");
            btnbck.Location = new Point(15, 4);
            btnbck.Margin = new Padding(4, 3, 4, 3);
            btnbck.Name = "btnbck";
            btnbck.Size = new Size(46, 48);
            btnbck.TabIndex = 4;
            btnbck.UseVisualStyleBackColor = true;
            btnbck.Click += btnbck_Click;
            // 
            // btnedit
            // 
            btnedit.Image = (Image)resources.GetObject("btnedit.Image");
            btnedit.Location = new Point(455, 4);
            btnedit.Margin = new Padding(4, 3, 4, 3);
            btnedit.Name = "btnedit";
            btnedit.Size = new Size(46, 48);
            btnedit.TabIndex = 7;
            btnedit.UseVisualStyleBackColor = true;
            btnedit.Click += btnedit_Click;
            // 
            // btnsave
            // 
            btnsave.Image = (Image)resources.GetObject("btnsave.Image");
            btnsave.Location = new Point(455, 4);
            btnsave.Margin = new Padding(4, 3, 4, 3);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(46, 48);
            btnsave.TabIndex = 0;
            btnsave.UseVisualStyleBackColor = true;
            btnsave.Click += btnsave_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(btndel);
            panel1.Controls.Add(btnnew);
            panel1.Controls.Add(btnsave);
            panel1.Controls.Add(btnexit);
            panel1.Controls.Add(btnedit);
            panel1.Controls.Add(btnnxt);
            panel1.Controls.Add(btnbck);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 162);
            panel1.Name = "panel1";
            panel1.Size = new Size(570, 64);
            panel1.TabIndex = 7;
            // 
            // frm2Ser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 226);
            Controls.Add(panel1);
            Controls.Add(gb1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "frm2Ser";
            Text = "Crea/Modifica - Servicios";
            Load += frm2Ser_Load;
            gb1.ResumeLayout(false);
            gb1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmvalor).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnnxt;
        private System.Windows.Forms.Button btnbck;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.TextBox txtcod;
        private System.Windows.Forms.NumericUpDown nmvalor;
        private Label label3;
        private TextBox txtref;
        private Panel panel1;
    }
}