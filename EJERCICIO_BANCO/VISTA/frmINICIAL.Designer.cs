namespace VISTA
{
    partial class frmINICIAL
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
            this.mnBANCO = new System.Windows.Forms.MenuStrip();
            this.operacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miCLIENTES = new System.Windows.Forms.ToolStripMenuItem();
            this.miCUENTAS = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCLIENTES = new System.Windows.Forms.TextBox();
            this.txtCUENTAS = new System.Windows.Forms.TextBox();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miOPERACIONES = new System.Windows.Forms.ToolStripMenuItem();
            this.mnBANCO.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnBANCO
            // 
            this.mnBANCO.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operacionesToolStripMenuItem,
            this.consultasToolStripMenuItem});
            this.mnBANCO.Location = new System.Drawing.Point(0, 0);
            this.mnBANCO.Name = "mnBANCO";
            this.mnBANCO.Size = new System.Drawing.Size(800, 24);
            this.mnBANCO.TabIndex = 0;
            // 
            // operacionesToolStripMenuItem
            // 
            this.operacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miCLIENTES,
            this.miCUENTAS});
            this.operacionesToolStripMenuItem.Name = "operacionesToolStripMenuItem";
            this.operacionesToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.operacionesToolStripMenuItem.Text = "Operaciones";
            // 
            // miCLIENTES
            // 
            this.miCLIENTES.Name = "miCLIENTES";
            this.miCLIENTES.Size = new System.Drawing.Size(176, 22);
            this.miCLIENTES.Text = "Gestión de Clientes";
            this.miCLIENTES.Click += new System.EventHandler(this.miCLIENTES_Click);
            // 
            // miCUENTAS
            // 
            this.miCUENTAS.Name = "miCUENTAS";
            this.miCUENTAS.Size = new System.Drawing.Size(176, 22);
            this.miCUENTAS.Text = "Gestión de Cuentas";
            this.miCUENTAS.Click += new System.EventHandler(this.miCUENTAS_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cantidad de clientes:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cantidad de cuentas:";
            // 
            // txtCLIENTES
            // 
            this.txtCLIENTES.Location = new System.Drawing.Point(138, 58);
            this.txtCLIENTES.Name = "txtCLIENTES";
            this.txtCLIENTES.ReadOnly = true;
            this.txtCLIENTES.Size = new System.Drawing.Size(100, 20);
            this.txtCLIENTES.TabIndex = 3;
            // 
            // txtCUENTAS
            // 
            this.txtCUENTAS.Location = new System.Drawing.Point(138, 85);
            this.txtCUENTAS.Name = "txtCUENTAS";
            this.txtCUENTAS.ReadOnly = true;
            this.txtCUENTAS.Size = new System.Drawing.Size(100, 20);
            this.txtCUENTAS.TabIndex = 4;
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miOPERACIONES});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // miOPERACIONES
            // 
            this.miOPERACIONES.Name = "miOPERACIONES";
            this.miOPERACIONES.Size = new System.Drawing.Size(180, 22);
            this.miOPERACIONES.Text = "Operaciones";
            this.miOPERACIONES.Click += new System.EventHandler(this.miOPERACIONES_Click);
            // 
            // frmINICIAL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCUENTAS);
            this.Controls.Add(this.txtCLIENTES);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mnBANCO);
            this.MainMenuStrip = this.mnBANCO;
            this.Name = "frmINICIAL";
            this.Text = ":.. BANCO";
            this.Activated += new System.EventHandler(this.frmINICIAL_Activated);
            this.mnBANCO.ResumeLayout(false);
            this.mnBANCO.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnBANCO;
        private System.Windows.Forms.ToolStripMenuItem operacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miCLIENTES;
        private System.Windows.Forms.ToolStripMenuItem miCUENTAS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCLIENTES;
        private System.Windows.Forms.TextBox txtCUENTAS;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miOPERACIONES;
    }
}