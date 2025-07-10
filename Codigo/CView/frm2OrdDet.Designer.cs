namespace CView
{
    partial class frm2OrdDet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm2OrdDet));
            gbOrd = new GroupBox();
            dgOrd = new DataGridView();
            tabc = new TabControl();
            tbpro = new TabPage();
            txtprocod = new TextBox();
            nmprocan = new NumericUpDown();
            label11 = new Label();
            txtpromar = new TextBox();
            label7 = new Label();
            txtprotot = new TextBox();
            txtproprc = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            txtproref = new TextBox();
            cbPro = new ComboBox();
            txtproobs = new TextBox();
            label3 = new Label();
            tbser = new TabPage();
            txtsercod = new TextBox();
            txtserprc = new TextBox();
            label8 = new Label();
            label9 = new Label();
            txtserref = new TextBox();
            cbSer = new ComboBox();
            txtserobs = new TextBox();
            label10 = new Label();
            tbobs = new TabPage();
            txtobs = new TextBox();
            label2 = new Label();
            btnsave = new Button();
            panel1 = new Panel();
            gbOrd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgOrd).BeginInit();
            tabc.SuspendLayout();
            tbpro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmprocan).BeginInit();
            tbser.SuspendLayout();
            tbobs.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // gbOrd
            // 
            gbOrd.Controls.Add(dgOrd);
            gbOrd.Location = new Point(21, 14);
            gbOrd.Name = "gbOrd";
            gbOrd.Size = new Size(661, 131);
            gbOrd.TabIndex = 0;
            gbOrd.TabStop = false;
            gbOrd.Text = "Seleccione Orden";
            // 
            // dgOrd
            // 
            dgOrd.AllowUserToAddRows = false;
            dgOrd.AllowUserToDeleteRows = false;
            dgOrd.AllowUserToResizeColumns = false;
            dgOrd.AllowUserToResizeRows = false;
            dgOrd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgOrd.Location = new Point(18, 22);
            dgOrd.Name = "dgOrd";
            dgOrd.RowHeadersVisible = false;
            dgOrd.RowTemplate.Height = 25;
            dgOrd.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgOrd.ShowCellErrors = false;
            dgOrd.ShowCellToolTips = false;
            dgOrd.ShowEditingIcon = false;
            dgOrd.ShowRowErrors = false;
            dgOrd.Size = new Size(625, 98);
            dgOrd.TabIndex = 0;
            // 
            // tabc
            // 
            tabc.Controls.Add(tbpro);
            tabc.Controls.Add(tbser);
            tabc.Controls.Add(tbobs);
            tabc.Location = new Point(21, 157);
            tabc.Name = "tabc";
            tabc.SelectedIndex = 0;
            tabc.Size = new Size(661, 163);
            tabc.TabIndex = 3;
            // 
            // tbpro
            // 
            tbpro.Controls.Add(txtprocod);
            tbpro.Controls.Add(nmprocan);
            tbpro.Controls.Add(label11);
            tbpro.Controls.Add(txtpromar);
            tbpro.Controls.Add(label7);
            tbpro.Controls.Add(txtprotot);
            tbpro.Controls.Add(txtproprc);
            tbpro.Controls.Add(label6);
            tbpro.Controls.Add(label5);
            tbpro.Controls.Add(label4);
            tbpro.Controls.Add(txtproref);
            tbpro.Controls.Add(cbPro);
            tbpro.Controls.Add(txtproobs);
            tbpro.Controls.Add(label3);
            tbpro.Location = new Point(4, 24);
            tbpro.Name = "tbpro";
            tbpro.Padding = new Padding(3);
            tbpro.Size = new Size(653, 135);
            tbpro.TabIndex = 1;
            tbpro.Text = "Productos";
            tbpro.UseVisualStyleBackColor = true;
            // 
            // txtprocod
            // 
            txtprocod.Location = new Point(12, 99);
            txtprocod.Name = "txtprocod";
            txtprocod.Size = new Size(21, 23);
            txtprocod.TabIndex = 16;
            txtprocod.Visible = false;
            // 
            // nmprocan
            // 
            nmprocan.Location = new Point(286, 71);
            nmprocan.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nmprocan.Name = "nmprocan";
            nmprocan.Size = new Size(104, 23);
            nmprocan.TabIndex = 15;
            nmprocan.TextAlign = HorizontalAlignment.Right;
            nmprocan.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nmprocan.ValueChanged += nmprocan_ValueChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 74);
            label11.Name = "label11";
            label11.Size = new Size(43, 15);
            label11.TabIndex = 14;
            label11.Text = "Marca:";
            // 
            // txtpromar
            // 
            txtpromar.Enabled = false;
            txtpromar.Location = new Point(77, 71);
            txtpromar.Name = "txtpromar";
            txtpromar.Size = new Size(107, 23);
            txtpromar.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(212, 103);
            label7.Name = "label7";
            label7.Size = new Size(35, 15);
            label7.TabIndex = 12;
            label7.Text = "Total:";
            // 
            // txtprotot
            // 
            txtprotot.Enabled = false;
            txtprotot.Location = new Point(286, 100);
            txtprotot.Name = "txtprotot";
            txtprotot.Size = new Size(104, 23);
            txtprotot.TabIndex = 11;
            txtprotot.TextAlign = HorizontalAlignment.Right;
            // 
            // txtproprc
            // 
            txtproprc.Enabled = false;
            txtproprc.Location = new Point(286, 38);
            txtproprc.Name = "txtproprc";
            txtproprc.Size = new Size(104, 23);
            txtproprc.TabIndex = 9;
            txtproprc.TextAlign = HorizontalAlignment.Right;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 38);
            label6.Name = "label6";
            label6.Size = new Size(65, 15);
            label6.TabIndex = 8;
            label6.Text = "Referencia:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(212, 74);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 7;
            label5.Text = "Cantidad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(212, 41);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 6;
            label4.Text = "Precio:";
            // 
            // txtproref
            // 
            txtproref.Enabled = false;
            txtproref.Location = new Point(77, 35);
            txtproref.Name = "txtproref";
            txtproref.Size = new Size(107, 23);
            txtproref.TabIndex = 5;
            // 
            // cbPro
            // 
            cbPro.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPro.FormattingEnabled = true;
            cbPro.Location = new Point(6, 6);
            cbPro.Name = "cbPro";
            cbPro.Size = new Size(384, 23);
            cbPro.TabIndex = 4;
            cbPro.SelectedIndexChanged += cbPro_SelectedIndexChanged;
            // 
            // txtproobs
            // 
            txtproobs.Location = new Point(408, 35);
            txtproobs.MaxLength = 200;
            txtproobs.Multiline = true;
            txtproobs.Name = "txtproobs";
            txtproobs.Size = new Size(231, 88);
            txtproobs.TabIndex = 3;
            txtproobs.KeyPress += txtproobs_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(408, 9);
            label3.Name = "label3";
            label3.Size = new Size(87, 15);
            label3.TabIndex = 2;
            label3.Text = "Observaciones:";
            // 
            // tbser
            // 
            tbser.Controls.Add(txtsercod);
            tbser.Controls.Add(txtserprc);
            tbser.Controls.Add(label8);
            tbser.Controls.Add(label9);
            tbser.Controls.Add(txtserref);
            tbser.Controls.Add(cbSer);
            tbser.Controls.Add(txtserobs);
            tbser.Controls.Add(label10);
            tbser.Location = new Point(4, 24);
            tbser.Name = "tbser";
            tbser.Size = new Size(653, 135);
            tbser.TabIndex = 2;
            tbser.Text = "Servicios";
            tbser.UseVisualStyleBackColor = true;
            // 
            // txtsercod
            // 
            txtsercod.Location = new Point(177, 104);
            txtsercod.Name = "txtsercod";
            txtsercod.Size = new Size(42, 23);
            txtsercod.TabIndex = 17;
            txtsercod.Visible = false;
            // 
            // txtserprc
            // 
            txtserprc.Enabled = false;
            txtserprc.Location = new Point(287, 65);
            txtserprc.Name = "txtserprc";
            txtserprc.Size = new Size(104, 23);
            txtserprc.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(10, 68);
            label8.Name = "label8";
            label8.Size = new Size(65, 15);
            label8.TabIndex = 15;
            label8.Text = "Referencia:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(213, 68);
            label9.Name = "label9";
            label9.Size = new Size(43, 15);
            label9.TabIndex = 14;
            label9.Text = "Precio:";
            // 
            // txtserref
            // 
            txtserref.Enabled = false;
            txtserref.Location = new Point(81, 65);
            txtserref.Name = "txtserref";
            txtserref.Size = new Size(107, 23);
            txtserref.TabIndex = 13;
            // 
            // cbSer
            // 
            cbSer.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSer.FormattingEnabled = true;
            cbSer.Location = new Point(7, 16);
            cbSer.Name = "cbSer";
            cbSer.Size = new Size(384, 23);
            cbSer.TabIndex = 12;
            // 
            // txtserobs
            // 
            txtserobs.Location = new Point(409, 34);
            txtserobs.MaxLength = 200;
            txtserobs.Multiline = true;
            txtserobs.Name = "txtserobs";
            txtserobs.Size = new Size(226, 88);
            txtserobs.TabIndex = 11;
            txtserobs.KeyPress += txtserobs_KeyPress;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(409, 8);
            label10.Name = "label10";
            label10.Size = new Size(87, 15);
            label10.TabIndex = 10;
            label10.Text = "Observaciones:";
            // 
            // tbobs
            // 
            tbobs.Controls.Add(txtobs);
            tbobs.Controls.Add(label2);
            tbobs.Location = new Point(4, 24);
            tbobs.Name = "tbobs";
            tbobs.Padding = new Padding(3);
            tbobs.Size = new Size(653, 135);
            tbobs.TabIndex = 0;
            tbobs.Text = "Otros";
            tbobs.UseVisualStyleBackColor = true;
            // 
            // txtobs
            // 
            txtobs.Location = new Point(104, 43);
            txtobs.MaxLength = 200;
            txtobs.Multiline = true;
            txtobs.Name = "txtobs";
            txtobs.Size = new Size(454, 61);
            txtobs.TabIndex = 1;
            txtobs.KeyPress += txtobs_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(104, 25);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 0;
            label2.Text = "Detalle:";
            // 
            // btnsave
            // 
            btnsave.Image = (Image)resources.GetObject("btnsave.Image");
            btnsave.Location = new Point(626, 5);
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
            panel1.Controls.Add(btnsave);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 351);
            panel1.Name = "panel1";
            panel1.Size = new Size(694, 64);
            panel1.TabIndex = 7;
            // 
            // frm2OrdDet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(694, 415);
            Controls.Add(panel1);
            Controls.Add(tabc);
            Controls.Add(gbOrd);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "frm2OrdDet";
            Text = "Bitacora de Ordenes";
            Load += frm2OrdDet_Load;
            Shown += frm2OrdDet_Shown;
            gbOrd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgOrd).EndInit();
            tabc.ResumeLayout(false);
            tbpro.ResumeLayout(false);
            tbpro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmprocan).EndInit();
            tbser.ResumeLayout(false);
            tbser.PerformLayout();
            tbobs.ResumeLayout(false);
            tbobs.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbOrd;
        private DataGridView dgOrd;
        private TabControl tabc;
        private TabPage tbpro;
        private TextBox txtproref;
        private ComboBox cbPro;
        private TextBox txtproobs;
        private Label label3;
        private TabPage tbser;
        private TabPage tbobs;
        private TextBox txtobs;
        private Label label2;
        private Label label11;
        private TextBox txtpromar;
        private Label label7;
        private TextBox txtprotot;
        private TextBox txtproprc;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txtserprc;
        private Label label8;
        private Label label9;
        private TextBox txtserref;
        private ComboBox cbSer;
        private TextBox txtserobs;
        private Label label10;
        private Button btnsave;
        private Panel panel1;
        private NumericUpDown nmprocan;
        private TextBox txtprocod;
        private TextBox txtsercod;
    }
}