namespace CView
{
    partial class frm2Cli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm2Cli));
            gb1 = new GroupBox();
            label2 = new Label();
            txtcor = new TextBox();
            txtcod = new TextBox();
            txttel = new TextBox();
            txtdir = new TextBox();
            txtced = new TextBox();
            txtnom = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
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
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // gb1
            // 
            gb1.Controls.Add(label2);
            gb1.Controls.Add(txtcor);
            gb1.Controls.Add(txtcod);
            gb1.Controls.Add(txttel);
            gb1.Controls.Add(txtdir);
            gb1.Controls.Add(txtced);
            gb1.Controls.Add(txtnom);
            gb1.Controls.Add(label5);
            gb1.Controls.Add(label4);
            gb1.Controls.Add(label3);
            gb1.Controls.Add(label1);
            gb1.Enabled = false;
            gb1.Location = new Point(22, 14);
            gb1.Margin = new Padding(4, 3, 4, 3);
            gb1.Name = "gb1";
            gb1.Padding = new Padding(4, 3, 4, 3);
            gb1.Size = new Size(525, 209);
            gb1.TabIndex = 0;
            gb1.TabStop = false;
            gb1.Text = "Datos de Cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 167);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 13;
            label2.Text = "Correo:";
            // 
            // txtcor
            // 
            txtcor.Location = new Point(100, 164);
            txtcor.Margin = new Padding(4, 3, 4, 3);
            txtcor.MaxLength = 50;
            txtcor.Name = "txtcor";
            txtcor.Size = new Size(376, 23);
            txtcor.TabIndex = 5;
            txtcor.KeyPress += txtcor_KeyPress;
            // 
            // txtcod
            // 
            txtcod.Location = new Point(484, 12);
            txtcod.Margin = new Padding(4, 3, 4, 3);
            txtcod.MaxLength = 3;
            txtcod.Name = "txtcod";
            txtcod.ReadOnly = true;
            txtcod.Size = new Size(33, 23);
            txtcod.TabIndex = 11;
            txtcod.Visible = false;
            // 
            // txttel
            // 
            txttel.Location = new Point(100, 80);
            txttel.Margin = new Padding(4, 3, 4, 3);
            txttel.MaxLength = 10;
            txttel.Name = "txttel";
            txttel.Size = new Size(116, 23);
            txttel.TabIndex = 3;
            txttel.KeyPress += txttel_KeyPress;
            // 
            // txtdir
            // 
            txtdir.Location = new Point(100, 109);
            txtdir.Margin = new Padding(4, 3, 4, 3);
            txtdir.MaxLength = 50;
            txtdir.Multiline = true;
            txtdir.Name = "txtdir";
            txtdir.Size = new Size(376, 49);
            txtdir.TabIndex = 4;
            txtdir.KeyPress += txtdir_KeyPress;
            // 
            // txtced
            // 
            txtced.Location = new Point(100, 51);
            txtced.Margin = new Padding(4, 3, 4, 3);
            txtced.MaxLength = 10;
            txtced.Name = "txtced";
            txtced.Size = new Size(116, 23);
            txtced.TabIndex = 2;
            txtced.KeyPress += txtced_KeyPress;
            // 
            // txtnom
            // 
            txtnom.Location = new Point(100, 22);
            txtnom.Margin = new Padding(4, 3, 4, 3);
            txtnom.MaxLength = 50;
            txtnom.Name = "txtnom";
            txtnom.Size = new Size(376, 23);
            txtnom.TabIndex = 1;
            txtnom.KeyPress += txtnom_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 83);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 4;
            label5.Text = "Teléfono:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 112);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 3;
            label4.Text = "Dirección:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 54);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 2;
            label3.Text = "Cédula:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 25);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // btndel
            // 
            btndel.Image = (Image)resources.GetObject("btndel.Image");
            btndel.Location = new Point(395, 4);
            btndel.Margin = new Padding(4, 3, 4, 3);
            btndel.Name = "btndel";
            btndel.Size = new Size(46, 48);
            btndel.TabIndex = 8;
            btndel.UseVisualStyleBackColor = true;
            btndel.Click += btndel_Click;
            // 
            // btnnew
            // 
            btnnew.Image = (Image)resources.GetObject("btnnew.Image");
            btnnew.Location = new Point(503, 4);
            btnnew.Margin = new Padding(4, 3, 4, 3);
            btnnew.Name = "btnnew";
            btnnew.Size = new Size(46, 48);
            btnnew.TabIndex = 10;
            btnnew.UseVisualStyleBackColor = true;
            btnnew.Click += btnnew_Click;
            // 
            // btnexit
            // 
            btnexit.Image = (Image)resources.GetObject("btnexit.Image");
            btnexit.Location = new Point(503, 4);
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
            btnnxt.Location = new Point(60, 4);
            btnnxt.Margin = new Padding(4, 3, 4, 3);
            btnnxt.Name = "btnnxt";
            btnnxt.Size = new Size(46, 48);
            btnnxt.TabIndex = 7;
            btnnxt.UseVisualStyleBackColor = true;
            btnnxt.Click += btnnxt_Click;
            // 
            // btnbck
            // 
            btnbck.Image = (Image)resources.GetObject("btnbck.Image");
            btnbck.Location = new Point(7, 4);
            btnbck.Margin = new Padding(4, 3, 4, 3);
            btnbck.Name = "btnbck";
            btnbck.Size = new Size(46, 48);
            btnbck.TabIndex = 6;
            btnbck.UseVisualStyleBackColor = true;
            btnbck.Click += btnbck_Click;
            // 
            // btnedit
            // 
            btnedit.Image = (Image)resources.GetObject("btnedit.Image");
            btnedit.Location = new Point(447, 4);
            btnedit.Margin = new Padding(4, 3, 4, 3);
            btnedit.Name = "btnedit";
            btnedit.Size = new Size(46, 48);
            btnedit.TabIndex = 9;
            btnedit.UseVisualStyleBackColor = true;
            btnedit.Click += btnedit_Click;
            // 
            // btnsave
            // 
            btnsave.Image = (Image)resources.GetObject("btnsave.Image");
            btnsave.Location = new Point(447, 4);
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
            panel1.Location = new Point(0, 234);
            panel1.Name = "panel1";
            panel1.Size = new Size(565, 64);
            panel1.TabIndex = 7;
            // 
            // frm2Cli
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 298);
            Controls.Add(panel1);
            Controls.Add(gb1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "frm2Cli";
            Text = "Crea/Modifica - Clientes";
            Load += frm2Cli_Load;
            gb1.ResumeLayout(false);
            gb1.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.TextBox txttel;
        private System.Windows.Forms.TextBox txtdir;
        private System.Windows.Forms.TextBox txtced;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnnxt;
        private System.Windows.Forms.Button btnbck;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.TextBox txtcod;
        private Label label2;
        private TextBox txtcor;
        private Panel panel1;
    }
}