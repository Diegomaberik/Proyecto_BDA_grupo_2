namespace CView
{
    partial class frm1Fac
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm1Fac));
            gbDet = new GroupBox();
            txtobsfin = new TextBox();
            btnnxt = new Button();
            btnbck = new Button();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            label6 = new Label();
            dtfecfac = new DateTimePicker();
            dtfecing = new DateTimePicker();
            label5 = new Label();
            gbCli = new GroupBox();
            txtclinom = new TextBox();
            txtcliced = new TextBox();
            txtclitel = new TextBox();
            txtclidir = new TextBox();
            gbEqui = new GroupBox();
            label3 = new Label();
            txtmar = new TextBox();
            txtmod = new TextBox();
            label2 = new Label();
            txtser = new TextBox();
            label1 = new Label();
            label4 = new Label();
            txtobsini = new TextBox();
            gbTec = new GroupBox();
            txttecnom = new TextBox();
            txttecced = new TextBox();
            dgdet = new DataGridView();
            gbTot = new GroupBox();
            label9 = new Label();
            txttotal = new TextBox();
            label8 = new Label();
            txttotimp = new TextBox();
            label7 = new Label();
            txtsubtot = new TextBox();
            gbDet.SuspendLayout();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            gbCli.SuspendLayout();
            gbEqui.SuspendLayout();
            gbTec.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgdet).BeginInit();
            gbTot.SuspendLayout();
            SuspendLayout();
            // 
            // gbDet
            // 
            gbDet.Controls.Add(txtobsfin);
            gbDet.Enabled = false;
            gbDet.Location = new Point(18, 436);
            gbDet.Name = "gbDet";
            gbDet.Size = new Size(513, 118);
            gbDet.TabIndex = 9;
            gbDet.TabStop = false;
            gbDet.Text = "Observaciones";
            // 
            // txtobsfin
            // 
            txtobsfin.Location = new Point(13, 22);
            txtobsfin.Multiline = true;
            txtobsfin.Name = "txtobsfin";
            txtobsfin.Size = new Size(490, 76);
            txtobsfin.TabIndex = 10;
            // 
            // btnnxt
            // 
            btnnxt.Image = (Image)resources.GetObject("btnnxt.Image");
            btnnxt.Location = new Point(66, 8);
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
            btnbck.Location = new Point(12, 8);
            btnbck.Margin = new Padding(4, 3, 4, 3);
            btnbck.Name = "btnbck";
            btnbck.Size = new Size(46, 48);
            btnbck.TabIndex = 3;
            btnbck.UseVisualStyleBackColor = true;
            btnbck.Click += btnbck_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(btnnxt);
            panel1.Controls.Add(btnbck);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 560);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 64);
            panel1.TabIndex = 11;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(dtfecfac);
            groupBox1.Controls.Add(dtfecing);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(gbCli);
            groupBox1.Controls.Add(gbEqui);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtobsini);
            groupBox1.Controls.Add(gbTec);
            groupBox1.Enabled = false;
            groupBox1.Location = new Point(18, 10);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(769, 270);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(519, 46);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 20;
            label6.Text = "Emision:";
            // 
            // dtfecfac
            // 
            dtfecfac.CustomFormat = "MMM d/yyyy";
            dtfecfac.Enabled = false;
            dtfecfac.Format = DateTimePickerFormat.Custom;
            dtfecfac.Location = new Point(602, 46);
            dtfecfac.MinDate = new DateTime(2025, 1, 15, 0, 0, 0, 0);
            dtfecfac.Name = "dtfecfac";
            dtfecfac.Size = new Size(115, 23);
            dtfecfac.TabIndex = 19;
            // 
            // dtfecing
            // 
            dtfecing.CustomFormat = "MMM d/yyyy";
            dtfecing.Enabled = false;
            dtfecing.Format = DateTimePickerFormat.Custom;
            dtfecing.Location = new Point(602, 19);
            dtfecing.MinDate = new DateTime(2025, 1, 15, 0, 0, 0, 0);
            dtfecing.Name = "dtfecing";
            dtfecing.Size = new Size(115, 23);
            dtfecing.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(519, 19);
            label5.Name = "label5";
            label5.Size = new Size(65, 15);
            label5.TabIndex = 13;
            label5.Text = "Recepcion:";
            // 
            // gbCli
            // 
            gbCli.Controls.Add(txtclinom);
            gbCli.Controls.Add(txtcliced);
            gbCli.Controls.Add(txtclitel);
            gbCli.Controls.Add(txtclidir);
            gbCli.Location = new Point(7, 24);
            gbCli.Name = "gbCli";
            gbCli.Size = new Size(496, 112);
            gbCli.TabIndex = 7;
            gbCli.TabStop = false;
            gbCli.Text = "Cliente";
            // 
            // txtclinom
            // 
            txtclinom.Location = new Point(6, 22);
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
            // gbEqui
            // 
            gbEqui.Controls.Add(label3);
            gbEqui.Controls.Add(txtmar);
            gbEqui.Controls.Add(txtmod);
            gbEqui.Controls.Add(label2);
            gbEqui.Controls.Add(txtser);
            gbEqui.Controls.Add(label1);
            gbEqui.Location = new Point(7, 142);
            gbEqui.Name = "gbEqui";
            gbEqui.Size = new Size(282, 116);
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
            txtmar.Location = new Point(68, 22);
            txtmar.Name = "txtmar";
            txtmar.Size = new Size(153, 23);
            txtmar.TabIndex = 4;
            // 
            // txtmod
            // 
            txtmod.Location = new Point(68, 51);
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
            txtser.Location = new Point(68, 80);
            txtser.Name = "txtser";
            txtser.Size = new Size(174, 23);
            txtser.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 83);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 0;
            label1.Text = "Serie:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(295, 164);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 8;
            label4.Text = "Defecto:";
            // 
            // txtobsini
            // 
            txtobsini.Location = new Point(352, 164);
            txtobsini.Multiline = true;
            txtobsini.Name = "txtobsini";
            txtobsini.Size = new Size(398, 88);
            txtobsini.TabIndex = 9;
            // 
            // gbTec
            // 
            gbTec.Controls.Add(txttecnom);
            gbTec.Controls.Add(txttecced);
            gbTec.Location = new Point(514, 75);
            gbTec.Name = "gbTec";
            gbTec.Size = new Size(236, 83);
            gbTec.TabIndex = 10;
            gbTec.TabStop = false;
            gbTec.Text = "Tecnico";
            // 
            // txttecnom
            // 
            txttecnom.Location = new Point(6, 22);
            txttecnom.Name = "txttecnom";
            txttecnom.Size = new Size(211, 23);
            txttecnom.TabIndex = 12;
            // 
            // txttecced
            // 
            txttecced.Location = new Point(6, 51);
            txttecced.Name = "txttecced";
            txttecced.Size = new Size(153, 23);
            txttecced.TabIndex = 11;
            // 
            // dgdet
            // 
            dgdet.AllowUserToAddRows = false;
            dgdet.AllowUserToDeleteRows = false;
            dgdet.AllowUserToResizeColumns = false;
            dgdet.AllowUserToResizeRows = false;
            dgdet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgdet.EnableHeadersVisualStyles = false;
            dgdet.Location = new Point(18, 286);
            dgdet.Name = "dgdet";
            dgdet.ReadOnly = true;
            dgdet.RowHeadersVisible = false;
            dgdet.RowTemplate.Height = 25;
            dgdet.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgdet.ShowCellErrors = false;
            dgdet.ShowCellToolTips = false;
            dgdet.ShowEditingIcon = false;
            dgdet.ShowRowErrors = false;
            dgdet.Size = new Size(769, 129);
            dgdet.TabIndex = 17;
            // 
            // gbTot
            // 
            gbTot.Controls.Add(label9);
            gbTot.Controls.Add(txttotal);
            gbTot.Controls.Add(label8);
            gbTot.Controls.Add(txttotimp);
            gbTot.Controls.Add(label7);
            gbTot.Controls.Add(txtsubtot);
            gbTot.Enabled = false;
            gbTot.Location = new Point(543, 442);
            gbTot.Name = "gbTot";
            gbTot.Size = new Size(244, 112);
            gbTot.TabIndex = 13;
            gbTot.TabStop = false;
            gbTot.Text = "Totales";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 83);
            label9.Name = "label9";
            label9.Size = new Size(35, 15);
            label9.TabIndex = 21;
            label9.Text = "Total:";
            // 
            // txttotal
            // 
            txttotal.Location = new Point(83, 80);
            txttotal.Name = "txttotal";
            txttotal.Size = new Size(153, 23);
            txttotal.TabIndex = 20;
            txttotal.TextAlign = HorizontalAlignment.Right;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 54);
            label8.Name = "label8";
            label8.Size = new Size(65, 15);
            label8.TabIndex = 19;
            label8.Text = "Impuestos:";
            // 
            // txttotimp
            // 
            txttotimp.Location = new Point(83, 51);
            txttotimp.Name = "txttotimp";
            txttotimp.Size = new Size(153, 23);
            txttotimp.TabIndex = 18;
            txttotimp.TextAlign = HorizontalAlignment.Right;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 25);
            label7.Name = "label7";
            label7.Size = new Size(54, 15);
            label7.TabIndex = 17;
            label7.Text = "Subtotal:";
            // 
            // txtsubtot
            // 
            txtsubtot.Location = new Point(83, 22);
            txtsubtot.Name = "txtsubtot";
            txtsubtot.Size = new Size(153, 23);
            txtsubtot.TabIndex = 16;
            txtsubtot.TextAlign = HorizontalAlignment.Right;
            // 
            // frm1Fac
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 624);
            Controls.Add(gbTot);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Controls.Add(dgdet);
            Controls.Add(gbDet);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "frm1Fac";
            Text = "Consulta de Facturas";
            Load += frm1Fac_Load;
            Shown += frm1Fac_Shown;
            gbDet.ResumeLayout(false);
            gbDet.PerformLayout();
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            gbCli.ResumeLayout(false);
            gbCli.PerformLayout();
            gbEqui.ResumeLayout(false);
            gbEqui.PerformLayout();
            gbTec.ResumeLayout(false);
            gbTec.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgdet).EndInit();
            gbTot.ResumeLayout(false);
            gbTot.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbDet;
        private Button btnnxt;
        private Button btnbck;
        private Panel panel1;
        private TextBox txtobsfin;
        private GroupBox groupBox1;
        private Label label6;
        private DateTimePicker dtfecfac;
        private DateTimePicker dtfecing;
        private DataGridView dgdet;
        private Label label5;
        private GroupBox gbCli;
        private TextBox txtclinom;
        private TextBox txtcliced;
        private TextBox txtclitel;
        private TextBox txtclidir;
        private GroupBox gbEqui;
        private Label label3;
        private TextBox txtmar;
        private TextBox txtmod;
        private Label label2;
        private TextBox txtser;
        private Label label1;
        private Label label4;
        private TextBox txtobsini;
        private GroupBox gbTec;
        private TextBox txttecnom;
        private TextBox txttecced;
        private GroupBox gbTot;
        private Label label9;
        private TextBox txttotal;
        private Label label8;
        private TextBox txttotimp;
        private Label label7;
        private TextBox txtsubtot;
    }
}