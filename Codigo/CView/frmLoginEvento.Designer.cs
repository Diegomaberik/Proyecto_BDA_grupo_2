namespace CView
{
    partial class frmLoginEvento
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            this.panelFondo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblClave = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();

            this.panelFondo.SuspendLayout();
            this.SuspendLayout();

            // 
            // panelFondo
            // 
            this.panelFondo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelFondo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFondo.Controls.Add(this.lblTitulo);
            this.panelFondo.Controls.Add(this.lblUsuario);
            this.panelFondo.Controls.Add(this.txtUsuario);
            this.panelFondo.Controls.Add(this.lblClave);
            this.panelFondo.Controls.Add(this.txtClave);
            this.panelFondo.Controls.Add(this.btnIngresar);
            this.panelFondo.Location = new System.Drawing.Point(230, 80);
            this.panelFondo.Name = "panelFondo";
            this.panelFondo.Size = new System.Drawing.Size(340, 280);
            this.panelFondo.TabIndex = 0;

            // 
            // lblTitulo
            // 
            this.lblTitulo.Text = "Inicio de Sesión";
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(70, 20);
            this.lblTitulo.Size = new System.Drawing.Size(200, 40);
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // lblUsuario
            // 
            this.lblUsuario.Text = "Usuario o Correo:";
            this.lblUsuario.Location = new System.Drawing.Point(30, 80);
            this.lblUsuario.Size = new System.Drawing.Size(100, 20);

            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(30, 105);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(270, 23);

            // 
            // lblClave
            // 
            this.lblClave.Text = "Contraseña:";
            this.lblClave.Location = new System.Drawing.Point(30, 140);
            this.lblClave.Size = new System.Drawing.Size(100, 20);

            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(30, 165);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(270, 23);
            this.txtClave.PasswordChar = '*';

            // 
            // btnIngresar
            // 
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnIngresar.ForeColor = System.Drawing.Color.White;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Location = new System.Drawing.Point(110, 210);
            this.btnIngresar.Size = new System.Drawing.Size(120, 35);
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);

            // 
            // frmLoginEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelFondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmLoginEvento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login | Proyecto Final";

            this.panelFondo.ResumeLayout(false);
            this.panelFondo.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelFondo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Button btnIngresar;
    }
}
