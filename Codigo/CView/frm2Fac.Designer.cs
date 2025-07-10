namespace CView
{
    partial class frm2Fac
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm2Fac));
            btnsave = new Button();
            gb1 = new GroupBox();
            dgOrd = new DataGridView();
            btndw = new Button();
            btnup = new Button();
            label5 = new Label();
            gbTec = new GroupBox();
            txttecnom = new TextBox();
            txttecced = new TextBox();
            txtobsini = new TextBox();
            label4 = new Label();
            gbEqui = new GroupBox();
            label3 = new Label();
            txtmar = new TextBox();
            txtmod = new TextBox();
            label2 = new Label();
            txtser = new TextBox();
            label1 = new Label();
            gbCli = new GroupBox();
            txtclinom = new TextBox();
            txtcliced = new TextBox();
            txtclitel = new TextBox();
            txtclidir = new TextBox();
            gbTot = new GroupBox();
            label9 = new Label();
            txttotal = new TextBox();
            label8 = new Label();
            txttotimp = new TextBox();
            label7 = new Label();
            txtsubtot = new TextBox();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            dtfecing = new DateTimePicker();
            dgdet = new DataGridView();
            groupBox2 = new GroupBox();
            txtobsfin = new TextBox();
            gb1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgOrd).BeginInit();
            gbTec.SuspendLayout();
            gbEqui.SuspendLayout();
            gbCli.SuspendLayout();
            gbTot.SuspendLayout();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgdet).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnsave
            // 
            btnsave.Image = (Image)resources.GetObject("btnsave.Image");
            btnsave.Location = new Point(735, 10);
            btnsave.Margin = new Padding(4, 3, 4, 3);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(46, 48);
            btnsave.TabIndex = 0;
            btnsave.UseVisualStyleBackColor = true;
            btnsave.Click += btnsave_Click;
            // 
            // gb1
            // 
            gb1.Controls.Add(dgOrd);
            gb1.Location = new Point(12, 12);
            gb1.Name = "gb1";
            gb1.Size = new Size(704, 123);
            gb1.TabIndex = 4;
            gb1.TabStop = false;
            gb1.Text = "Selecione Orden";
            // 
            // dgOrd
            // 
            dgOrd.AllowUserToAddRows = false;
            dgOrd.AllowUserToDeleteRows = false;
            dgOrd.AllowUserToResizeColumns = false;
            dgOrd.AllowUserToResizeRows = false;
            dgOrd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgOrd.EnableHeadersVisualStyles = false;
            dgOrd.Location = new Point(6, 22);
            dgOrd.Name = "dgOrd";
            dgOrd.ReadOnly = true;
            dgOrd.RowHeadersVisible = false;
            dgOrd.RowTemplate.Height = 25;
            dgOrd.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgOrd.ShowCellErrors = false;
            dgOrd.ShowCellToolTips = false;
            dgOrd.ShowEditingIcon = false;
            dgOrd.ShowRowErrors = false;
            dgOrd.Size = new Size(694, 92);
            dgOrd.TabIndex = 16;
            dgOrd.CellContentClick += dgOrd_CellContentClick;
            // 
            // btndw
            // 
            btndw.Image = (Image)resources.GetObject("btndw.Image");
            btndw.Location = new Point(733, 78);
            btndw.Margin = new Padding(4, 3, 4, 3);
            btndw.Name = "btndw";
            btndw.Size = new Size(46, 48);
            btndw.TabIndex = 1;
            btndw.UseVisualStyleBackColor = true;
            btndw.Click += btndw_Click;
            // 
            // btnup
            // 
            btnup.Image = (Image)resources.GetObject("btnup.Image");
            btnup.Location = new Point(733, 78);
            btnup.Margin = new Padding(4, 3, 4, 3);
            btnup.Name = "btnup";
            btnup.Size = new Size(46, 48);
            btnup.TabIndex = 17;
            btnup.UseVisualStyleBackColor = true;
            btnup.Visible = false;
            btnup.Click += btnup_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(514, 27);
            label5.Name = "label5";
            label5.Size = new Size(65, 15);
            label5.TabIndex = 13;
            label5.Text = "Recepcion:";
            // 
            // gbTec
            // 
            gbTec.Controls.Add(txttecnom);
            gbTec.Controls.Add(txttecced);
            gbTec.Location = new Point(514, 53);
            gbTec.Name = "gbTec";
            gbTec.Size = new Size(236, 93);
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
            // txtobsini
            // 
            txtobsini.Location = new Point(352, 164);
            txtobsini.Multiline = true;
            txtobsini.Name = "txtobsini";
            txtobsini.Size = new Size(398, 88);
            txtobsini.TabIndex = 9;
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
            // gbTot
            // 
            gbTot.Controls.Add(label9);
            gbTot.Controls.Add(txttotal);
            gbTot.Controls.Add(label8);
            gbTot.Controls.Add(txttotimp);
            gbTot.Controls.Add(label7);
            gbTot.Controls.Add(txtsubtot);
            gbTot.Enabled = false;
            gbTot.Location = new Point(535, 503);
            gbTot.Name = "gbTot";
            gbTot.Size = new Size(244, 112);
            gbTot.TabIndex = 5;
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
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(btnsave);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 628);
            panel1.Name = "panel1";
            panel1.Size = new Size(795, 64);
            panel1.TabIndex = 7;
            panel1.Visible = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtfecing);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(gbCli);
            groupBox1.Controls.Add(gbEqui);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtobsini);
            groupBox1.Controls.Add(gbTec);
            groupBox1.Enabled = false;
            groupBox1.Location = new Point(12, 141);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(769, 268);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos";
            // 
            // dtfecing
            // 
            dtfecing.CustomFormat = "MMM d/yyyy";
            dtfecing.Enabled = false;
            dtfecing.Format = DateTimePickerFormat.Custom;
            dtfecing.Location = new Point(589, 24);
            dtfecing.MinDate = new DateTime(2025, 1, 15, 0, 0, 0, 0);
            dtfecing.Name = "dtfecing";
            dtfecing.Size = new Size(115, 23);
            dtfecing.TabIndex = 18;
            // 
            // dgdet
            // 
            dgdet.AllowUserToAddRows = false;
            dgdet.AllowUserToDeleteRows = false;
            dgdet.AllowUserToResizeColumns = false;
            dgdet.AllowUserToResizeRows = false;
            dgdet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgdet.EnableHeadersVisualStyles = false;
            dgdet.Location = new Point(14, 414);
            dgdet.Name = "dgdet";
            dgdet.ReadOnly = true;
            dgdet.RowHeadersVisible = false;
            dgdet.RowTemplate.Height = 25;
            dgdet.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgdet.ShowCellErrors = false;
            dgdet.ShowCellToolTips = false;
            dgdet.ShowEditingIcon = false;
            dgdet.ShowRowErrors = false;
            dgdet.Size = new Size(767, 83);
            dgdet.TabIndex = 17;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtobsfin);
            groupBox2.Location = new Point(12, 503);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(452, 112);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Observaciones Finales:";
            // 
            // txtobsfin
            // 
            txtobsfin.Location = new Point(16, 27);
            txtobsfin.Multiline = true;
            txtobsfin.Name = "txtobsfin";
            txtobsfin.Size = new Size(398, 67);
            txtobsfin.TabIndex = 10;
            // 
            // frm2Fac
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(795, 692);
            Controls.Add(groupBox2);
            Controls.Add(dgdet);
            Controls.Add(groupBox1);
            Controls.Add(gbTot);
            Controls.Add(gb1);
            Controls.Add(panel1);
            Controls.Add(btndw);
            Controls.Add(btnup);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "frm2Fac";
            Text = "Genera Factura";
            Load += frm2Fac_Load;
            Shown += frm2Fac_Shown;
            gb1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgOrd).EndInit();
            gbTec.ResumeLayout(false);
            gbTec.PerformLayout();
            gbEqui.ResumeLayout(false);
            gbEqui.PerformLayout();
            gbCli.ResumeLayout(false);
            gbCli.PerformLayout();
            gbTot.ResumeLayout(false);
            gbTot.PerformLayout();
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgdet).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnsave;
        private GroupBox gb1;
        private Label label5;
        private GroupBox gbTec;
        private TextBox txttecnom;
        private TextBox txttecced;
        private TextBox txtobsini;
        private Label label4;
        private GroupBox gbEqui;
        private Label label3;
        private TextBox txtmar;
        private TextBox txtmod;
        private Label label2;
        private TextBox txtser;
        private Label label1;
        private GroupBox gbCli;
        private TextBox txtclinom;
        private TextBox txtcliced;
        private TextBox txtclitel;
        private TextBox txtclidir;
        private GroupBox gbTot;
        private Label label9;
        private TextBox txttotal;
        private Label label8;
        private TextBox txttotimp;
        private Label label7;
        private TextBox txtsubtot;
        private Panel panel1;
        private GroupBox groupBox1;
        private Button btnup;
        private Button btndw;
        private DataGridView dgOrd;
        private DataGridView dgdet;
        private GroupBox groupBox2;
        private TextBox txtobsfin;
        private DateTimePicker dtfecing;
    }
}