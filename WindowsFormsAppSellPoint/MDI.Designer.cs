namespace WindowsFormsAppSellPoint
{
    partial class MDI
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
            this.radMenuItem1 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem3 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuSeparatorItem1 = new Telerik.WinControls.UI.RadMenuSeparatorItem();
            this.radMenuItem4 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuSeparatorItem2 = new Telerik.WinControls.UI.RadMenuSeparatorItem();
            this.radMenuItem5 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem2 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem6 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuSeparatorItem3 = new Telerik.WinControls.UI.RadMenuSeparatorItem();
            this.radMenuItem7 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuSeparatorItem4 = new Telerik.WinControls.UI.RadMenuSeparatorItem();
            this.radMenuItem8 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenu1 = new Telerik.WinControls.UI.RadMenu();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).BeginInit();
            this.SuspendLayout();
            // 
            // radMenuItem1
            // 
            this.radMenuItem1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem3,
            this.radMenuSeparatorItem1,
            this.radMenuItem4,
            this.radMenuSeparatorItem2,
            this.radMenuItem5});
            this.radMenuItem1.Name = "radMenuItem1";
            this.radMenuItem1.Text = "Archivo";
            // 
            // radMenuItem3
            // 
            this.radMenuItem3.Name = "radMenuItem3";
            this.radMenuItem3.Text = "Grupos Entidades";
            this.radMenuItem3.Click += new System.EventHandler(this.radMenuItem3_Click_1);
            // 
            // radMenuSeparatorItem1
            // 
            this.radMenuSeparatorItem1.Name = "radMenuSeparatorItem1";
            this.radMenuSeparatorItem1.Text = "radMenuSeparatorItem1";
            this.radMenuSeparatorItem1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // radMenuItem4
            // 
            this.radMenuItem4.Name = "radMenuItem4";
            this.radMenuItem4.Text = "Tipos Entidades";
            this.radMenuItem4.Click += new System.EventHandler(this.radMenuItem4_Click_1);
            // 
            // radMenuSeparatorItem2
            // 
            this.radMenuSeparatorItem2.Name = "radMenuSeparatorItem2";
            this.radMenuSeparatorItem2.Text = "radMenuSeparatorItem2";
            this.radMenuSeparatorItem2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // radMenuItem5
            // 
            this.radMenuItem5.Name = "radMenuItem5";
            this.radMenuItem5.Text = "Entidades";
            this.radMenuItem5.Click += new System.EventHandler(this.radMenuItem5_Click);
            // 
            // radMenuItem2
            // 
            this.radMenuItem2.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem6,
            this.radMenuSeparatorItem3,
            this.radMenuItem7,
            this.radMenuSeparatorItem4,
            this.radMenuItem8});
            this.radMenuItem2.Name = "radMenuItem2";
            this.radMenuItem2.Text = "Sistema";
            // 
            // radMenuItem6
            // 
            this.radMenuItem6.Name = "radMenuItem6";
            this.radMenuItem6.Text = "Acerca de...";
            // 
            // radMenuSeparatorItem3
            // 
            this.radMenuSeparatorItem3.Name = "radMenuSeparatorItem3";
            this.radMenuSeparatorItem3.Text = "radMenuSeparatorItem3";
            this.radMenuSeparatorItem3.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // radMenuItem7
            // 
            this.radMenuItem7.Name = "radMenuItem7";
            this.radMenuItem7.Text = "Login";
            this.radMenuItem7.Click += new System.EventHandler(this.radMenuItem7_Click);
            // 
            // radMenuSeparatorItem4
            // 
            this.radMenuSeparatorItem4.Name = "radMenuSeparatorItem4";
            this.radMenuSeparatorItem4.Text = "radMenuSeparatorItem4";
            this.radMenuSeparatorItem4.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // radMenuItem8
            // 
            this.radMenuItem8.Name = "radMenuItem8";
            this.radMenuItem8.Text = "Salir";
            // 
            // radMenu1
            // 
            this.radMenu1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem1,
            this.radMenuItem2});
            this.radMenu1.Location = new System.Drawing.Point(0, 0);
            this.radMenu1.Name = "radMenu1";
            this.radMenu1.Size = new System.Drawing.Size(455, 20);
            this.radMenu1.TabIndex = 1;
            // 
            // MDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 450);
            this.Controls.Add(this.radMenu1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.Name = "MDI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "SellPoint v1.0";
            this.Load += new System.EventHandler(this.MDI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Telerik.WinControls.UI.RadMenuItem radMenuItem3;
        private Telerik.WinControls.UI.RadMenuSeparatorItem radMenuSeparatorItem1;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem4;
        private Telerik.WinControls.UI.RadMenuSeparatorItem radMenuSeparatorItem2;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem5;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem6;
        private Telerik.WinControls.UI.RadMenuSeparatorItem radMenuSeparatorItem3;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem7;
        private Telerik.WinControls.UI.RadMenuSeparatorItem radMenuSeparatorItem4;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem8;
        private Telerik.WinControls.UI.RadMenu radMenu1;
        public Telerik.WinControls.UI.RadMenuItem radMenuItem1;
        public Telerik.WinControls.UI.RadMenuItem radMenuItem2;
    }
}