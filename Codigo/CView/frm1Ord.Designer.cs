namespace CView
{
    partial class frm1Ord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm1Ord));
            gb1 = new GroupBox();
            lbfac = new Label();
            dtfecfac = new DateTimePicker();
            label5 = new Label();
            dtfecing = new DateTimePicker();
            pictureBox1 = new PictureBox();
            gbTec = new GroupBox();
            txttecnom = new TextBox();
            txttecced = new TextBox();
            txtobs = new TextBox();
            label4 = new Label();
            gbEqui = new GroupBox();
            label3 = new Label();
            txtmar = new TextBox();
            txtmod = new TextBox();
            label2 = new Label();
            txtser = new TextBox();
            label1 = new Label();
            gbCli = new GroupBox();
            txtid = new TextBox();
            txtclinom = new TextBox();
            txtcliced = new TextBox();
            txtclitel = new TextBox();
            txtclidir = new TextBox();
            btnnxt = new Button();
            btnbck = new Button();
            groupBox1 = new GroupBox();
            dgdet = new DataGridView();
            panel1 = new Panel();
            lbinfo = new Label();
            gb1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            gbTec.SuspendLayout();
            gbEqui.SuspendLayout();
            gbCli.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgdet).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // gb1
            // 
            gb1.Controls.Add(lbfac);
            gb1.Controls.Add(dtfecfac);
            gb1.Controls.Add(label5);
            gb1.Controls.Add(dtfecing);
            gb1.Controls.Add(pictureBox1);
            gb1.Controls.Add(gbTec);
            gb1.Controls.Add(txtobs);
            gb1.Controls.Add(label4);
            gb1.Controls.Add(gbEqui);
            gb1.Controls.Add(gbCli);
            gb1.Enabled = false;
            gb1.Location = new Point(12, 12);
            gb1.Name = "gb1";
            gb1.Size = new Size(767, 345);
            gb1.TabIndex = 4;
            gb1.TabStop = false;
            gb1.Text = "Orden";
            // 
            // lbfac
            // 
            lbfac.AutoSize = true;
            lbfac.Location = new Point(551, 57);
            lbfac.Name = "lbfac";
            lbfac.Size = new Size(63, 15);
            lbfac.TabIndex = 15;
            lbfac.Text = "Facturado:";
            lbfac.Visible = false;
            // 
            // dtfecfac
            // 
            dtfecfac.CustomFormat = "MMM d/yyyy";
            dtfecfac.Enabled = false;
            dtfecfac.Format = DateTimePickerFormat.Custom;
            dtfecfac.Location = new Point(621, 51);
            dtfecfac.MinDate = new DateTime(2025, 1, 15, 0, 0, 0, 0);
            dtfecfac.Name = "dtfecfac";
            dtfecfac.Size = new Size(115, 23);
            dtfecfac.TabIndex = 14;
            dtfecfac.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(551, 28);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 13;
            label5.Text = "Emisión:";
            // 
            // dtfecing
            // 
            dtfecing.CustomFormat = "MMM d/yyyy";
            dtfecing.Enabled = false;
            dtfecing.Format = DateTimePickerFormat.Custom;
            dtfecing.Location = new Point(621, 22);
            dtfecing.MinDate = new DateTime(2025, 1, 15, 0, 0, 0, 0);
            dtfecing.Name = "dtfecing";
            dtfecing.Size = new Size(115, 23);
            dtfecing.TabIndex = 12;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(551, 170);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(171, 169);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // gbTec
            // 
            gbTec.Controls.Add(txttecnom);
            gbTec.Controls.Add(txttecced);
            gbTec.Location = new Point(519, 77);
            gbTec.Name = "gbTec";
            gbTec.Size = new Size(223, 87);
            gbTec.TabIndex = 10;
            gbTec.TabStop = false;
            gbTec.Text = "Tecnico";
            // 
            // txttecnom
            // 
            txttecnom.Location = new Point(6, 22);
            txttecnom.Name = "txttecnom";
            txttecnom.Size = new Size(197, 23);
            txttecnom.TabIndex = 12;
            // 
            // txttecced
            // 
            txttecced.Location = new Point(6, 51);
            txttecced.Name = "txttecced";
            txttecced.Size = new Size(153, 23);
            txttecced.TabIndex = 11;
            // 
            // txtobs
            // 
            txtobs.Location = new Point(74, 246);
            txtobs.Multiline = true;
            txtobs.Name = "txtobs";
            txtobs.Size = new Size(439, 93);
            txtobs.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 249);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 8;
            label4.Text = "Defecto:";
            // 
            // gbEqui
            // 
            gbEqui.Controls.Add(label3);
            gbEqui.Controls.Add(txtmar);
            gbEqui.Controls.Add(txtmod);
            gbEqui.Controls.Add(label2);
            gbEqui.Controls.Add(txtser);
            gbEqui.Controls.Add(label1);
            gbEqui.Location = new Point(17, 148);
            gbEqui.Name = "gbEqui";
            gbEqui.Size = new Size(496, 86);
            gbEqui.TabIndex = 8;
            gbEqui.TabStop = false;
            gbEqui.Text = "Equipo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 54);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 7;
            label3.Text = "Modelo:";
            // 
            // txtmar
            // 
            txtmar.Location = new Point(85, 22);
            txtmar.Name = "txtmar";
            txtmar.Size = new Size(153, 23);
            txtmar.TabIndex = 4;
            // 
            // txtmod
            // 
            txtmod.Location = new Point(85, 51);
            txtmod.Name = "txtmod";
            txtmod.Size = new Size(153, 23);
            txtmod.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 25);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 6;
            label2.Text = "Marca:";
            // 
            // txtser
            // 
            txtser.Location = new Point(308, 22);
            txtser.Name = "txtser";
            txtser.Size = new Size(174, 23);
            txtser.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(267, 25);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 0;
            label1.Text = "Serie:";
            // 
            // gbCli
            // 
            gbCli.Controls.Add(txtid);
            gbCli.Controls.Add(txtclinom);
            gbCli.Controls.Add(txtcliced);
            gbCli.Controls.Add(txtclitel);
            gbCli.Controls.Add(txtclidir);
            gbCli.Location = new Point(17, 22);
            gbCli.Name = "gbCli";
            gbCli.Size = new Size(496, 112);
            gbCli.TabIndex = 7;
            gbCli.TabStop = false;
            gbCli.Text = "Cliente";
            // 
            // txtid
            // 
            txtid.Location = new Point(210, 75);
            txtid.Name = "txtid";
            txtid.Size = new Size(46, 23);
            txtid.TabIndex = 10;
            txtid.Visible = false;
            // 
            // txtclinom
            // 
            txtclinom.Location = new Point(6, 18);
            txtclinom.Name = "txtclinom";
            txtclinom.Size = new Size(476, 23);
            txtclinom.TabIndex = 9;
            // 
            // txtcliced
            // 
            txtcliced.Location = new Point(329, 76);
            txtcliced.Name = "txtcliced";
            txtcliced.Size = new Size(153, 23);
            txtcliced.TabIndex = 8;
            // 
            // txtclitel
            // 
            txtclitel.Location = new Point(6, 76);
            txtclitel.Name = "txtclitel";
            txtclitel.Size = new Size(153, 23);
            txtclitel.TabIndex = 7;
            // 
            // txtclidir
            // 
            txtclidir.Location = new Point(6, 47);
            txtclidir.Name = "txtclidir";
            txtclidir.Size = new Size(476, 23);
            txtclidir.TabIndex = 6;
            // 
            // btnnxt
            // 
            btnnxt.Image = (Image)resources.GetObject("btnnxt.Image");
            btnnxt.Location = new Point(66, 3);
            btnnxt.Margin = new Padding(4, 3, 4, 3);
            btnnxt.Name = "btnnxt";
            btnnxt.Size = new Size(46, 48);
            btnnxt.TabIndex = 4;
            btnnxt.UseVisualStyleBackColor = true;
            btnnxt.Click += btnnxt_Click;
            // 
            // btnbck
            // 
            btnbck.Image = (Image)resources.GetObject("btnbck.Image");
            btnbck.Location = new Point(12, 3);
            btnbck.Margin = new Padding(4, 3, 4, 3);
            btnbck.Name = "btnbck";
            btnbck.Size = new Size(46, 48);
            btnbck.TabIndex = 3;
            btnbck.UseVisualStyleBackColor = true;
            btnbck.Click += btnbck_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgdet);
            groupBox1.Location = new Point(13, 363);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(766, 171);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detalles";
            // 
            // dgdet
            // 
            dgdet.AllowUserToAddRows = false;
            dgdet.AllowUserToDeleteRows = false;
            dgdet.AllowUserToResizeColumns = false;
            dgdet.AllowUserToResizeRows = false;
            dgdet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgdet.EnableHeadersVisualStyles = false;
            dgdet.Location = new Point(12, 24);
            dgdet.Name = "dgdet";
            dgdet.ReadOnly = true;
            dgdet.RowHeadersVisible = false;
            dgdet.RowTemplate.Height = 25;
            dgdet.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgdet.ShowCellErrors = false;
            dgdet.ShowCellToolTips = false;
            dgdet.ShowEditingIcon = false;
            dgdet.ShowRowErrors = false;
            dgdet.Size = new Size(742, 136);
            dgdet.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(lbinfo);
            panel1.Controls.Add(btnnxt);
            panel1.Controls.Add(btnbck);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 569);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 64);
            panel1.TabIndex = 7;
            // 
            // lbinfo
            // 
            lbinfo.AutoSize = true;
            lbinfo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbinfo.Location = new Point(588, 6);
            lbinfo.Name = "lbinfo";
            lbinfo.Size = new Size(102, 32);
            lbinfo.TabIndex = 5;
            lbinfo.Text = "ACTIVO";
            // 
            // frm1Ord
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 633);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Controls.Add(gb1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "frm1Ord";
            Text = "Consulta de Ordenes";
            Load += frm1Ord_Load;
            Shown += frm1Ord_Shown;
            gb1.ResumeLayout(false);
            gb1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            gbTec.ResumeLayout(false);
            gbTec.PerformLayout();
            gbEqui.ResumeLayout(false);
            gbEqui.PerformLayout();
            gbCli.ResumeLayout(false);
            gbCli.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgdet).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gb1;
        private Label label5;
        private DateTimePicker dtfecing;
        private PictureBox pictureBox1;
        private GroupBox gbTec;
        private TextBox txttecced;
        private TextBox txtobs;
        private Label label4;
        private GroupBox gbEqui;
        private Label label3;
        private TextBox txtmar;
        private TextBox txtmod;
        private Label label2;
        private TextBox txtser;
        private Label label1;
        private GroupBox gbCli;
        private TextBox txtcliced;
        private TextBox txtclitel;
        private TextBox txtclidir;
        private Button btnnxt;
        private Button btnbck;
        private GroupBox groupBox1;
        private DataGridView dgdet;
        private Panel panel1;
        private TextBox txttecnom;
        private TextBox txtclinom;
        private Label lbinfo;
        private Label lbfac;
        private DateTimePicker dtfecfac;
        private TextBox txtid;
    }
}