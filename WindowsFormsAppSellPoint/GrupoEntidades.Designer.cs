namespace WindowsFormsAppSellPoint
{
    partial class GrupoEntidades
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
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CerrarBtn = new Telerik.WinControls.UI.RadButton();
            this.MdoficarBtn = new Telerik.WinControls.UI.RadButton();
            this.EliminarBtn = new Telerik.WinControls.UI.RadButton();
            this.AgregarBtn = new Telerik.WinControls.UI.RadButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BuscarBtn = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CerrarBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MdoficarBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EliminarBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgregarBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BuscarBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(0, 162);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.CerrarBtn);
            this.splitContainer1.Panel2.Controls.Add(this.MdoficarBtn);
            this.splitContainer1.Panel2.Controls.Add(this.EliminarBtn);
            this.splitContainer1.Panel2.Controls.Add(this.AgregarBtn);
            this.splitContainer1.Size = new System.Drawing.Size(604, 313);
            this.splitContainer1.SplitterDistance = 480;
            this.splitContainer1.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 9);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(471, 299);
            this.dataGridView1.TabIndex = 0;
            // 
            // CerrarBtn
            // 
            this.CerrarBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CerrarBtn.Location = new System.Drawing.Point(3, 286);
            this.CerrarBtn.Name = "CerrarBtn";
            this.CerrarBtn.Size = new System.Drawing.Size(110, 24);
            this.CerrarBtn.TabIndex = 13;
            this.CerrarBtn.Text = "Cerrar";
            this.CerrarBtn.Click += new System.EventHandler(this.CerrarBtn_Click);
            // 
            // MdoficarBtn
            // 
            this.MdoficarBtn.Location = new System.Drawing.Point(7, 121);
            this.MdoficarBtn.Name = "MdoficarBtn";
            this.MdoficarBtn.Size = new System.Drawing.Size(110, 24);
            this.MdoficarBtn.TabIndex = 11;
            this.MdoficarBtn.Text = "Modificar";
            // 
            // EliminarBtn
            // 
            this.EliminarBtn.Location = new System.Drawing.Point(7, 165);
            this.EliminarBtn.Name = "EliminarBtn";
            this.EliminarBtn.Size = new System.Drawing.Size(110, 24);
            this.EliminarBtn.TabIndex = 12;
            this.EliminarBtn.Text = "Eliminar";
            // 
            // AgregarBtn
            // 
            this.AgregarBtn.Location = new System.Drawing.Point(7, 79);
            this.AgregarBtn.Name = "AgregarBtn";
            this.AgregarBtn.Size = new System.Drawing.Size(110, 24);
            this.AgregarBtn.TabIndex = 3;
            this.AgregarBtn.Text = "Adiccionar";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(459, 20);
            this.textBox1.TabIndex = 9;
            // 
            // BuscarBtn
            // 
            this.BuscarBtn.Location = new System.Drawing.Point(364, 132);
            this.BuscarBtn.Name = "BuscarBtn";
            this.BuscarBtn.Size = new System.Drawing.Size(110, 24);
            this.BuscarBtn.TabIndex = 10;
            this.BuscarBtn.Text = "Buscar";
            // 
            // GrupoEntidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CerrarBtn;
            this.ClientSize = new System.Drawing.Size(616, 478);
            this.Controls.Add(this.BuscarBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GrupoEntidades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grupo Entidades";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CerrarBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MdoficarBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EliminarBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgregarBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BuscarBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private Telerik.WinControls.UI.RadButton MdoficarBtn;
        private Telerik.WinControls.UI.RadButton EliminarBtn;
        private Telerik.WinControls.UI.RadButton AgregarBtn;
        private System.Windows.Forms.TextBox textBox1;
        private Telerik.WinControls.UI.RadButton BuscarBtn;
        private Telerik.WinControls.UI.RadButton CerrarBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}