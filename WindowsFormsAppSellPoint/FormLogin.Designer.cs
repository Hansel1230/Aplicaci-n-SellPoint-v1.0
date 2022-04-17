namespace WindowsFormsAppSellPoint
{
    partial class FormLogin
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageCredenciales = new System.Windows.Forms.TabPage();
            this.textBoxContrasena = new System.Windows.Forms.TextBox();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.labelContrasena = new System.Windows.Forms.Label();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageCredenciales.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageCredenciales);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(14, 12);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(335, 160);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageCredenciales
            // 
            this.tabPageCredenciales.Controls.Add(this.textBoxContrasena);
            this.tabPageCredenciales.Controls.Add(this.textBoxUsuario);
            this.tabPageCredenciales.Controls.Add(this.labelUsuario);
            this.tabPageCredenciales.Controls.Add(this.labelContrasena);
            this.tabPageCredenciales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageCredenciales.Location = new System.Drawing.Point(4, 25);
            this.tabPageCredenciales.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPageCredenciales.Name = "tabPageCredenciales";
            this.tabPageCredenciales.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPageCredenciales.Size = new System.Drawing.Size(327, 131);
            this.tabPageCredenciales.TabIndex = 0;
            this.tabPageCredenciales.Text = "Credenciales";
            this.tabPageCredenciales.UseVisualStyleBackColor = true;
            // 
            // textBoxContrasena
            // 
            this.textBoxContrasena.Location = new System.Drawing.Point(134, 53);
            this.textBoxContrasena.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxContrasena.Name = "textBoxContrasena";
            this.textBoxContrasena.Size = new System.Drawing.Size(184, 22);
            this.textBoxContrasena.TabIndex = 5;
            this.textBoxContrasena.Click += new System.EventHandler(this.textBoxContrasena_Click);
            this.textBoxContrasena.Leave += new System.EventHandler(this.textBoxContrasena_Leave);
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(134, 18);
            this.textBoxUsuario.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(184, 22);
            this.textBoxUsuario.TabIndex = 4;
            this.textBoxUsuario.Click += new System.EventHandler(this.textBoxUsuario_Click);
            this.textBoxUsuario.Leave += new System.EventHandler(this.textBoxUsuario_Leave);
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelUsuario.Location = new System.Drawing.Point(7, 18);
            this.labelUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(63, 18);
            this.labelUsuario.TabIndex = 3;
            this.labelUsuario.Text = "Usuario";
            // 
            // labelContrasena
            // 
            this.labelContrasena.AutoSize = true;
            this.labelContrasena.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelContrasena.Location = new System.Drawing.Point(6, 56);
            this.labelContrasena.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelContrasena.Name = "labelContrasena";
            this.labelContrasena.Size = new System.Drawing.Size(88, 18);
            this.labelContrasena.TabIndex = 0;
            this.labelContrasena.Text = "Contraseña";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Location = new System.Drawing.Point(215, 178);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(64, 23);
            this.buttonCancelar.TabIndex = 1;
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAceptar.Location = new System.Drawing.Point(131, 178);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(53, 23);
            this.buttonAceptar.TabIndex = 2;
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 208);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormLogin";
            this.Text = "Acceso al sistema";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageCredenciales.ResumeLayout(false);
            this.tabPageCredenciales.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageCredenciales;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.TextBox textBoxContrasena;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label labelContrasena;
    }
}