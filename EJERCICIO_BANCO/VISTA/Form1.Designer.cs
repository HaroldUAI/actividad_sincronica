namespace VISTA
{
    partial class frmCLIENTES
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbCLIENTES = new System.Windows.Forms.GroupBox();
            this.btnCERRAR = new System.Windows.Forms.Button();
            this.btnCONSULTAR = new System.Windows.Forms.Button();
            this.btnELIMINAR = new System.Windows.Forms.Button();
            this.btnMODIFICAR = new System.Windows.Forms.Button();
            this.btnAGREGAR = new System.Windows.Forms.Button();
            this.dgvCLIENTES = new System.Windows.Forms.DataGridView();
            this.gbCLIENTES.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCLIENTES)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCLIENTES
            // 
            this.gbCLIENTES.Controls.Add(this.btnCERRAR);
            this.gbCLIENTES.Controls.Add(this.btnCONSULTAR);
            this.gbCLIENTES.Controls.Add(this.btnELIMINAR);
            this.gbCLIENTES.Controls.Add(this.btnMODIFICAR);
            this.gbCLIENTES.Controls.Add(this.btnAGREGAR);
            this.gbCLIENTES.Controls.Add(this.dgvCLIENTES);
            this.gbCLIENTES.Location = new System.Drawing.Point(11, 12);
            this.gbCLIENTES.Name = "gbCLIENTES";
            this.gbCLIENTES.Size = new System.Drawing.Size(1092, 417);
            this.gbCLIENTES.TabIndex = 0;
            this.gbCLIENTES.TabStop = false;
            this.gbCLIENTES.Text = "Lista de Clientes";
            // 
            // btnCERRAR
            // 
            this.btnCERRAR.Location = new System.Drawing.Point(960, 351);
            this.btnCERRAR.Name = "btnCERRAR";
            this.btnCERRAR.Size = new System.Drawing.Size(75, 23);
            this.btnCERRAR.TabIndex = 5;
            this.btnCERRAR.Text = "Cerrar";
            this.btnCERRAR.UseVisualStyleBackColor = true;
            this.btnCERRAR.Click += new System.EventHandler(this.btnCERRAR_Click);
            // 
            // btnCONSULTAR
            // 
            this.btnCONSULTAR.Location = new System.Drawing.Point(249, 351);
            this.btnCONSULTAR.Name = "btnCONSULTAR";
            this.btnCONSULTAR.Size = new System.Drawing.Size(75, 23);
            this.btnCONSULTAR.TabIndex = 4;
            this.btnCONSULTAR.Text = "Consultar";
            this.btnCONSULTAR.UseVisualStyleBackColor = true;
            this.btnCONSULTAR.Click += new System.EventHandler(this.btnCONSULTAR_Click);
            // 
            // btnELIMINAR
            // 
            this.btnELIMINAR.Location = new System.Drawing.Point(168, 351);
            this.btnELIMINAR.Name = "btnELIMINAR";
            this.btnELIMINAR.Size = new System.Drawing.Size(75, 23);
            this.btnELIMINAR.TabIndex = 3;
            this.btnELIMINAR.Text = "Eliminar";
            this.btnELIMINAR.UseVisualStyleBackColor = true;
            this.btnELIMINAR.Click += new System.EventHandler(this.btnELIMINAR_Click);
            // 
            // btnMODIFICAR
            // 
            this.btnMODIFICAR.Location = new System.Drawing.Point(87, 351);
            this.btnMODIFICAR.Name = "btnMODIFICAR";
            this.btnMODIFICAR.Size = new System.Drawing.Size(75, 23);
            this.btnMODIFICAR.TabIndex = 2;
            this.btnMODIFICAR.Text = "Modificar";
            this.btnMODIFICAR.UseVisualStyleBackColor = true;
            this.btnMODIFICAR.Click += new System.EventHandler(this.btnMODIFICAR_Click);
            // 
            // btnAGREGAR
            // 
            this.btnAGREGAR.Location = new System.Drawing.Point(6, 351);
            this.btnAGREGAR.Name = "btnAGREGAR";
            this.btnAGREGAR.Size = new System.Drawing.Size(75, 23);
            this.btnAGREGAR.TabIndex = 1;
            this.btnAGREGAR.Text = "Agregar";
            this.btnAGREGAR.UseVisualStyleBackColor = true;
            this.btnAGREGAR.Click += new System.EventHandler(this.btnAGREGAR_Click);
            // 
            // dgvCLIENTES
            // 
            this.dgvCLIENTES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCLIENTES.Location = new System.Drawing.Point(1, 19);
            this.dgvCLIENTES.Name = "dgvCLIENTES";
            this.dgvCLIENTES.Size = new System.Drawing.Size(1034, 316);
            this.dgvCLIENTES.TabIndex = 0;
            // 
            // frmCLIENTES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 450);
            this.Controls.Add(this.gbCLIENTES);
            this.Name = "frmCLIENTES";
            this.Text = "::.. CLIENTES DEL BANCO";
            this.gbCLIENTES.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCLIENTES)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCLIENTES;
        private System.Windows.Forms.Button btnCERRAR;
        private System.Windows.Forms.Button btnCONSULTAR;
        private System.Windows.Forms.Button btnELIMINAR;
        private System.Windows.Forms.Button btnMODIFICAR;
        private System.Windows.Forms.Button btnAGREGAR;
        private System.Windows.Forms.DataGridView dgvCLIENTES;
    }
}

