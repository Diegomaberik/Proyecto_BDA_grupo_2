namespace CView
{
    partial class frm2Ord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm2Ord));
            btnsave = new Button();
            gb1 = new GroupBox();
            label5 = new Label();
            dtfecing = new DateTimePicker();
            pictureBox1 = new PictureBox();
            gbTec = new GroupBox();
            txtteccod = new TextBox();
            txttecced = new TextBox();
            cbTec = new ComboBox();
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
            txtclicod = new TextBox();
            cbCli = new ComboBox();
            txtcliced = new TextBox();
            txtclitel = new TextBox();
            txtclidir = new TextBox();
            panel1 = new Panel();
            gb1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            gbTec.SuspendLayout();
            gbEqui.SuspendLayout();
            gbCli.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnsave
            // 
            btnsave.Image = (Image)resources.GetObject("btnsave.Image");
            btnsave.Location = new Point(741, 5);
            btnsave.Margin = new Padding(4, 3, 4, 3);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(46, 48);
            btnsave.TabIndex = 11;
            btnsave.UseVisualStyleBackColor = true;
            btnsave.Click += btnsave_Click;
            // 
            // gb1
            // 
            gb1.Controls.Add(label5);
            gb1.Controls.Add(dtfecing);
            gb1.Controls.Add(pictureBox1);
            gb1.Controls.Add(gbTec);
            gb1.Controls.Add(txtobs);
            gb1.Controls.Add(label4);
            gb1.Controls.Add(gbEqui);
            gb1.Controls.Add(gbCli);
            gb1.Location = new Point(15, 10);
            gb1.Name = "gb1";
            gb1.Size = new Size(767, 345);
            gb1.TabIndex = 3;
            gb1.TabStop = false;
            gb1.Text = "Orden";
            gb1.Enter += gb1_Enter;
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
            pictureBox1.Click += pictureBox1_Click;
            // 
            // gbTec
            // 
            gbTec.Controls.Add(txtteccod);
            gbTec.Controls.Add(txttecced);
            gbTec.Controls.Add(cbTec);
            gbTec.Location = new Point(519, 69);
            gbTec.Name = "gbTec";
            gbTec.Size = new Size(223, 93);
            gbTec.TabIndex = 10;
            gbTec.TabStop = false;
            gbTec.Text = "Tecnico";
            // 
            // txtteccod
            // 
            txtteccod.Location = new Point(180, 56);
            txtteccod.Name = "txtteccod";
            txtteccod.Size = new Size(30, 23);
            txtteccod.TabIndex = 7;
            txtteccod.Visible = false;
            // 
            // txttecced
            // 
            txttecced.Enabled = false;
            txttecced.Location = new Point(6, 51);
            txttecced.Name = "txttecced";
            txttecced.Size = new Size(153, 23);
            txttecced.TabIndex = 6;
            // 
            // cbTec
            // 
            cbTec.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTec.FormattingEnabled = true;
            cbTec.Location = new Point(6, 22);
            cbTec.Name = "cbTec";
            cbTec.Size = new Size(211, 23);
            cbTec.TabIndex = 5;
            cbTec.SelectedIndexChanged += cbTec_SelectedIndexChanged;
            // 
            // txtobs
            // 
            txtobs.Location = new Point(74, 246);
            txtobs.MaxLength = 200;
            txtobs.Multiline = true;
            txtobs.Name = "txtobs";
            txtobs.Size = new Size(439, 93);
            txtobs.TabIndex = 10;
            txtobs.KeyPress += txtobs_KeyPress;
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
            txtmar.MaxLength = 50;
            txtmar.Name = "txtmar";
            txtmar.Size = new Size(153, 23);
            txtmar.TabIndex = 7;
            txtmar.KeyPress += txtmar_KeyPress;
            // 
            // txtmod
            // 
            txtmod.Location = new Point(85, 51);
            txtmod.MaxLength = 50;
            txtmod.Name = "txtmod";
            txtmod.Size = new Size(153, 23);
            txtmod.TabIndex = 9;
            txtmod.KeyPress += txtmod_KeyPress;
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
            txtser.MaxLength = 13;
            txtser.Name = "txtser";
            txtser.Size = new Size(174, 23);
            txtser.TabIndex = 8;
            txtser.KeyPress += txtser_KeyPress;
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
            gbCli.Controls.Add(txtclicod);
            gbCli.Controls.Add(cbCli);
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
            // txtclicod
            // 
            txtclicod.Location = new Point(226, 78);
            txtclicod.Name = "txtclicod";
            txtclicod.Size = new Size(24, 23);
            txtclicod.TabIndex = 5;
            txtclicod.Visible = false;
            // 
            // cbCli
            // 
            cbCli.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCli.FormattingEnabled = true;
            cbCli.Location = new Point(6, 18);
            cbCli.Name = "cbCli";
            cbCli.Size = new Size(476, 23);
            cbCli.TabIndex = 1;
            cbCli.SelectedIndexChanged += cbCli_SelectedIndexChanged;
            // 
            // txtcliced
            // 
            txtcliced.Enabled = false;
            txtcliced.Location = new Point(329, 76);
            txtcliced.Name = "txtcliced";
            txtcliced.Size = new Size(153, 23);
            txtcliced.TabIndex = 4;
            // 
            // txtclitel
            // 
            txtclitel.Enabled = false;
            txtclitel.Location = new Point(6, 76);
            txtclitel.Name = "txtclitel";
            txtclitel.Size = new Size(153, 23);
            txtclitel.TabIndex = 3;
            // 
            // txtclidir
            // 
            txtclidir.Enabled = false;
            txtclidir.Location = new Point(6, 47);
            txtclidir.Name = "txtclidir";
            txtclidir.Size = new Size(476, 23);
            txtclidir.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(btnsave);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 386);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 64);
            panel1.TabIndex = 6;
            // 
            // frm2Ord
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(gb1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "frm2Ord";
            Text = "Genera nueva Orden de Trabajo";
            Load += frm2Ord_Load;
            Shown += frm2Ord_Shown;
            gb1.ResumeLayout(false);
            gb1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            gbTec.ResumeLayout(false);
            gbTec.PerformLayout();
            gbEqui.ResumeLayout(false);
            gbEqui.PerformLayout();
            gbCli.ResumeLayout(false);
            gbCli.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btnsave;
    private GroupBox gb1;
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
    private ComboBox cbCli;
    private TextBox txtcliced;
    private TextBox txtclitel;
    private TextBox txtclidir;
    private PictureBox pictureBox1;
    private GroupBox gbTec;
    private TextBox txttecced;
    private ComboBox cbTec;
        private DateTimePicker dtfecing;
        private Label label5;
        private Panel panel1;
        private TextBox txtteccod;
        private TextBox txtclicod;
    }
}