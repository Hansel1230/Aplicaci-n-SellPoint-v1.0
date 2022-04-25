namespace WindowsFormsAppSellPoint
{
    partial class Entidades
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.labelEntidades = new System.Windows.Forms.Label();
            this.TextBoxBuscar = new Telerik.WinControls.UI.RadTextBox();
            this.ButtonEliminar = new Telerik.WinControls.UI.RadButton();
            this.ButtonBuscar = new Telerik.WinControls.UI.RadButton();
            this.ButtonModificar = new Telerik.WinControls.UI.RadButton();
            this.ButtonAdicionar = new Telerik.WinControls.UI.RadButton();
            this.DataGridViewEntidades = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonModificar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonAdicionar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewEntidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewEntidades.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // labelEntidades
            // 
            this.labelEntidades.AutoSize = true;
            this.labelEntidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEntidades.Location = new System.Drawing.Point(8, 12);
            this.labelEntidades.Name = "labelEntidades";
            this.labelEntidades.Size = new System.Drawing.Size(70, 25);
            this.labelEntidades.TabIndex = 14;
            this.labelEntidades.Text = "label1";
            this.labelEntidades.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TextBoxBuscar
            // 
            this.TextBoxBuscar.Location = new System.Drawing.Point(13, 68);
            this.TextBoxBuscar.Name = "TextBoxBuscar";
            this.TextBoxBuscar.Size = new System.Drawing.Size(503, 20);
            this.TextBoxBuscar.TabIndex = 13;
            // 
            // ButtonEliminar
            // 
            this.ButtonEliminar.Location = new System.Drawing.Point(554, 357);
            this.ButtonEliminar.Name = "ButtonEliminar";
            this.ButtonEliminar.Size = new System.Drawing.Size(110, 24);
            this.ButtonEliminar.TabIndex = 12;
            this.ButtonEliminar.Text = "Eliminar";
            // 
            // ButtonBuscar
            // 
            this.ButtonBuscar.Location = new System.Drawing.Point(554, 66);
            this.ButtonBuscar.Name = "ButtonBuscar";
            this.ButtonBuscar.Size = new System.Drawing.Size(110, 24);
            this.ButtonBuscar.TabIndex = 11;
            this.ButtonBuscar.Text = "Buscar";
            // 
            // ButtonModificar
            // 
            this.ButtonModificar.Location = new System.Drawing.Point(554, 288);
            this.ButtonModificar.Name = "ButtonModificar";
            this.ButtonModificar.Size = new System.Drawing.Size(110, 24);
            this.ButtonModificar.TabIndex = 10;
            this.ButtonModificar.Text = "Modificar";
            this.ButtonModificar.Click += new System.EventHandler(this.ButtonModificar_Click);
            // 
            // ButtonAdicionar
            // 
            this.ButtonAdicionar.Location = new System.Drawing.Point(554, 217);
            this.ButtonAdicionar.Name = "ButtonAdicionar";
            this.ButtonAdicionar.Size = new System.Drawing.Size(110, 24);
            this.ButtonAdicionar.TabIndex = 9;
            this.ButtonAdicionar.Text = "Adicionar";
            this.ButtonAdicionar.Click += new System.EventHandler(this.ButtonAdicionar_Click);
            // 
            // DataGridViewEntidades
            // 
            this.DataGridViewEntidades.Location = new System.Drawing.Point(13, 155);
            // 
            // 
            // 
            this.DataGridViewEntidades.MasterTemplate.AllowAddNewRow = false;
            this.DataGridViewEntidades.MasterTemplate.AllowCellContextMenu = false;
            this.DataGridViewEntidades.MasterTemplate.AllowColumnReorder = false;
            this.DataGridViewEntidades.MasterTemplate.AllowColumnResize = false;
            this.DataGridViewEntidades.MasterTemplate.AllowDeleteRow = false;
            this.DataGridViewEntidades.MasterTemplate.AllowDragToGroup = false;
            this.DataGridViewEntidades.MasterTemplate.AllowEditRow = false;
            this.DataGridViewEntidades.MasterTemplate.AllowRowResize = false;
            this.DataGridViewEntidades.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.DataGridViewEntidades.Name = "DataGridViewEntidades";
            this.DataGridViewEntidades.Size = new System.Drawing.Size(503, 289);
            this.DataGridViewEntidades.TabIndex = 8;
            // 
            // Entidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 457);
            this.Controls.Add(this.labelEntidades);
            this.Controls.Add(this.TextBoxBuscar);
            this.Controls.Add(this.ButtonEliminar);
            this.Controls.Add(this.ButtonBuscar);
            this.Controls.Add(this.ButtonModificar);
            this.Controls.Add(this.ButtonAdicionar);
            this.Controls.Add(this.DataGridViewEntidades);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Entidades";
            this.Text = "Entidades";
            this.Load += new System.EventHandler(this.Entidades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonModificar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonAdicionar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewEntidades.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewEntidades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label labelEntidades;
        private Telerik.WinControls.UI.RadTextBox TextBoxBuscar;
        private Telerik.WinControls.UI.RadButton ButtonEliminar;
        private Telerik.WinControls.UI.RadButton ButtonBuscar;
        private Telerik.WinControls.UI.RadButton ButtonModificar;
        public Telerik.WinControls.UI.RadButton ButtonAdicionar;
        private Telerik.WinControls.UI.RadGridView DataGridViewEntidades;
    }
}