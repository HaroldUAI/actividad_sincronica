namespace VISTA
{
    partial class frmCUENTAS
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
            this.gbCUENTAS = new System.Windows.Forms.GroupBox();
            this.btnEXTRAER = new System.Windows.Forms.Button();
            this.btnCERRAR = new System.Windows.Forms.Button();
            this.btnDEPOSITAR = new System.Windows.Forms.Button();
            this.btnCONSULTAR = new System.Windows.Forms.Button();
            this.btnELIMINAR = new System.Windows.Forms.Button();
            this.btnMODIFICAR = new System.Windows.Forms.Button();
            this.btnAGREGAR = new System.Windows.Forms.Button();
            this.dgvCUENTAS = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTITULARES = new System.Windows.Forms.ComboBox();
            this.btnBUSCAR = new System.Windows.Forms.Button();
            this.gbCUENTAS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCUENTAS)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCUENTAS
            // 
            this.gbCUENTAS.Controls.Add(this.btnBUSCAR);
            this.gbCUENTAS.Controls.Add(this.cmbTITULARES);
            this.gbCUENTAS.Controls.Add(this.label1);
            this.gbCUENTAS.Controls.Add(this.btnEXTRAER);
            this.gbCUENTAS.Controls.Add(this.btnCERRAR);
            this.gbCUENTAS.Controls.Add(this.btnDEPOSITAR);
            this.gbCUENTAS.Controls.Add(this.btnCONSULTAR);
            this.gbCUENTAS.Controls.Add(this.btnELIMINAR);
            this.gbCUENTAS.Controls.Add(this.btnMODIFICAR);
            this.gbCUENTAS.Controls.Add(this.btnAGREGAR);
            this.gbCUENTAS.Controls.Add(this.dgvCUENTAS);
            this.gbCUENTAS.Location = new System.Drawing.Point(12, 12);
            this.gbCUENTAS.Name = "gbCUENTAS";
            this.gbCUENTAS.Size = new System.Drawing.Size(1036, 468);
            this.gbCUENTAS.TabIndex = 1;
            this.gbCUENTAS.TabStop = false;
            this.gbCUENTAS.Text = "Lista de Cuentas";
            // 
            // btnEXTRAER
            // 
            this.btnEXTRAER.Location = new System.Drawing.Point(410, 439);
            this.btnEXTRAER.Name = "btnEXTRAER";
            this.btnEXTRAER.Size = new System.Drawing.Size(75, 23);
            this.btnEXTRAER.TabIndex = 1;
            this.btnEXTRAER.Text = "Extraer";
            this.btnEXTRAER.UseVisualStyleBackColor = true;
            this.btnEXTRAER.Click += new System.EventHandler(this.btnEXTRAER_Click);
            // 
            // btnCERRAR
            // 
            this.btnCERRAR.Location = new System.Drawing.Point(935, 439);
            this.btnCERRAR.Name = "btnCERRAR";
            this.btnCERRAR.Size = new System.Drawing.Size(75, 23);
            this.btnCERRAR.TabIndex = 5;
            this.btnCERRAR.Text = "Cerrar";
            this.btnCERRAR.UseVisualStyleBackColor = true;
            this.btnCERRAR.Click += new System.EventHandler(this.btnCERRAR_Click);
            // 
            // btnDEPOSITAR
            // 
            this.btnDEPOSITAR.Location = new System.Drawing.Point(329, 439);
            this.btnDEPOSITAR.Name = "btnDEPOSITAR";
            this.btnDEPOSITAR.Size = new System.Drawing.Size(75, 23);
            this.btnDEPOSITAR.TabIndex = 0;
            this.btnDEPOSITAR.Text = "Depositar";
            this.btnDEPOSITAR.UseVisualStyleBackColor = true;
            this.btnDEPOSITAR.Click += new System.EventHandler(this.btnDEPOSITAR_Click);
            // 
            // btnCONSULTAR
            // 
            this.btnCONSULTAR.Location = new System.Drawing.Point(248, 439);
            this.btnCONSULTAR.Name = "btnCONSULTAR";
            this.btnCONSULTAR.Size = new System.Drawing.Size(75, 23);
            this.btnCONSULTAR.TabIndex = 4;
            this.btnCONSULTAR.Text = "Consultar";
            this.btnCONSULTAR.UseVisualStyleBackColor = true;
            this.btnCONSULTAR.Click += new System.EventHandler(this.btnCONSULTAR_Click);
            // 
            // btnELIMINAR
            // 
            this.btnELIMINAR.Location = new System.Drawing.Point(167, 439);
            this.btnELIMINAR.Name = "btnELIMINAR";
            this.btnELIMINAR.Size = new System.Drawing.Size(75, 23);
            this.btnELIMINAR.TabIndex = 3;
            this.btnELIMINAR.Text = "Eliminar";
            this.btnELIMINAR.UseVisualStyleBackColor = true;
            this.btnELIMINAR.Click += new System.EventHandler(this.btnELIMINAR_Click);
            // 
            // btnMODIFICAR
            // 
            this.btnMODIFICAR.Location = new System.Drawing.Point(86, 439);
            this.btnMODIFICAR.Name = "btnMODIFICAR";
            this.btnMODIFICAR.Size = new System.Drawing.Size(75, 23);
            this.btnMODIFICAR.TabIndex = 2;
            this.btnMODIFICAR.Text = "Modificar";
            this.btnMODIFICAR.UseVisualStyleBackColor = true;
            this.btnMODIFICAR.Click += new System.EventHandler(this.btnMODIFICAR_Click);
            // 
            // btnAGREGAR
            // 
            this.btnAGREGAR.Location = new System.Drawing.Point(5, 439);
            this.btnAGREGAR.Name = "btnAGREGAR";
            this.btnAGREGAR.Size = new System.Drawing.Size(75, 23);
            this.btnAGREGAR.TabIndex = 1;
            this.btnAGREGAR.Text = "Agregar";
            this.btnAGREGAR.UseVisualStyleBackColor = true;
            this.btnAGREGAR.Click += new System.EventHandler(this.btnAGREGAR_Click);
            // 
            // dgvCUENTAS
            // 
            this.dgvCUENTAS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCUENTAS.Location = new System.Drawing.Point(0, 107);
            this.dgvCUENTAS.Name = "dgvCUENTAS";
            this.dgvCUENTAS.Size = new System.Drawing.Size(1010, 316);
            this.dgvCUENTAS.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Titular:";
            // 
            // cmbTITULARES
            // 
            this.cmbTITULARES.FormattingEnabled = true;
            this.cmbTITULARES.Location = new System.Drawing.Point(60, 25);
            this.cmbTITULARES.Name = "cmbTITULARES";
            this.cmbTITULARES.Size = new System.Drawing.Size(247, 21);
            this.cmbTITULARES.TabIndex = 7;
            // 
            // btnBUSCAR
            // 
            this.btnBUSCAR.Location = new System.Drawing.Point(869, 19);
            this.btnBUSCAR.Name = "btnBUSCAR";
            this.btnBUSCAR.Size = new System.Drawing.Size(141, 55);
            this.btnBUSCAR.TabIndex = 8;
            this.btnBUSCAR.Text = "Buscar";
            this.btnBUSCAR.UseVisualStyleBackColor = true;
            this.btnBUSCAR.Click += new System.EventHandler(this.btnBUSCAR_Click);
            // 
            // frmCUENTAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 492);
            this.Controls.Add(this.gbCUENTAS);
            this.Name = "frmCUENTAS";
            this.Text = "::. BANCO : GESTION DE CUENTAS";
            this.gbCUENTAS.ResumeLayout(false);
            this.gbCUENTAS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCUENTAS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCUENTAS;
        private System.Windows.Forms.Button btnCERRAR;
        private System.Windows.Forms.Button btnCONSULTAR;
        private System.Windows.Forms.Button btnELIMINAR;
        private System.Windows.Forms.Button btnMODIFICAR;
        private System.Windows.Forms.Button btnAGREGAR;
        private System.Windows.Forms.DataGridView dgvCUENTAS;
        private System.Windows.Forms.Button btnEXTRAER;
        private System.Windows.Forms.Button btnDEPOSITAR;
        private System.Windows.Forms.Button btnBUSCAR;
        private System.Windows.Forms.ComboBox cmbTITULARES;
        private System.Windows.Forms.Label label1;
    }
}