namespace VISTA
{
    partial class frmOPERACIONES
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
            this.dgvOPERACIONES = new System.Windows.Forms.DataGridView();
            this.btnCERRAR = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.btnBUSCAR = new System.Windows.Forms.Button();
            this.txtCUENTA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chkHABILITAR_FILTRO_FECHAS = new System.Windows.Forms.CheckBox();
            this.pFECHAS = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFECHA_DESDE = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFECHA_HASTA = new System.Windows.Forms.TextBox();
            this.btnELIMINAR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOPERACIONES)).BeginInit();
            this.pFECHAS.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvOPERACIONES
            // 
            this.dgvOPERACIONES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOPERACIONES.Location = new System.Drawing.Point(12, 104);
            this.dgvOPERACIONES.Name = "dgvOPERACIONES";
            this.dgvOPERACIONES.Size = new System.Drawing.Size(1024, 442);
            this.dgvOPERACIONES.TabIndex = 0;
            // 
            // btnCERRAR
            // 
            this.btnCERRAR.Location = new System.Drawing.Point(961, 560);
            this.btnCERRAR.Name = "btnCERRAR";
            this.btnCERRAR.Size = new System.Drawing.Size(75, 29);
            this.btnCERRAR.TabIndex = 1;
            this.btnCERRAR.Text = "Cerrar";
            this.btnCERRAR.UseVisualStyleBackColor = true;
            this.btnCERRAR.Click += new System.EventHandler(this.btnCERRAR_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "DNI:";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(72, 2);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(145, 20);
            this.txtDNI.TabIndex = 3;
            // 
            // btnBUSCAR
            // 
            this.btnBUSCAR.Location = new System.Drawing.Point(859, 9);
            this.btnBUSCAR.Name = "btnBUSCAR";
            this.btnBUSCAR.Size = new System.Drawing.Size(151, 62);
            this.btnBUSCAR.TabIndex = 4;
            this.btnBUSCAR.Text = "BUSCAR";
            this.btnBUSCAR.UseVisualStyleBackColor = true;
            this.btnBUSCAR.Click += new System.EventHandler(this.btnBUSCAR_Click);
            // 
            // txtCUENTA
            // 
            this.txtCUENTA.Location = new System.Drawing.Point(72, 32);
            this.txtCUENTA.Name = "txtCUENTA";
            this.txtCUENTA.Size = new System.Drawing.Size(145, 20);
            this.txtCUENTA.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "CUENTA:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "FECHAS:";
            // 
            // chkHABILITAR_FILTRO_FECHAS
            // 
            this.chkHABILITAR_FILTRO_FECHAS.AutoSize = true;
            this.chkHABILITAR_FILTRO_FECHAS.Location = new System.Drawing.Point(72, 71);
            this.chkHABILITAR_FILTRO_FECHAS.Name = "chkHABILITAR_FILTRO_FECHAS";
            this.chkHABILITAR_FILTRO_FECHAS.Size = new System.Drawing.Size(104, 17);
            this.chkHABILITAR_FILTRO_FECHAS.TabIndex = 8;
            this.chkHABILITAR_FILTRO_FECHAS.Text = "Filtrar por fechas";
            this.chkHABILITAR_FILTRO_FECHAS.UseVisualStyleBackColor = true;
            this.chkHABILITAR_FILTRO_FECHAS.CheckedChanged += new System.EventHandler(this.chkHABILITAR_FILTRO_FECHAS_CheckedChanged);
            // 
            // pFECHAS
            // 
            this.pFECHAS.Controls.Add(this.txtFECHA_HASTA);
            this.pFECHAS.Controls.Add(this.label5);
            this.pFECHAS.Controls.Add(this.txtFECHA_DESDE);
            this.pFECHAS.Controls.Add(this.label4);
            this.pFECHAS.Location = new System.Drawing.Point(182, 59);
            this.pFECHAS.Name = "pFECHAS";
            this.pFECHAS.Size = new System.Drawing.Size(609, 39);
            this.pFECHAS.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "desde";
            // 
            // txtFECHA_DESDE
            // 
            this.txtFECHA_DESDE.Location = new System.Drawing.Point(45, 9);
            this.txtFECHA_DESDE.Name = "txtFECHA_DESDE";
            this.txtFECHA_DESDE.Size = new System.Drawing.Size(145, 20);
            this.txtFECHA_DESDE.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(212, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "- hasta ";
            // 
            // txtFECHA_HASTA
            // 
            this.txtFECHA_HASTA.Location = new System.Drawing.Point(260, 9);
            this.txtFECHA_HASTA.Name = "txtFECHA_HASTA";
            this.txtFECHA_HASTA.Size = new System.Drawing.Size(145, 20);
            this.txtFECHA_HASTA.TabIndex = 9;
            // 
            // btnELIMINAR
            // 
            this.btnELIMINAR.Location = new System.Drawing.Point(15, 566);
            this.btnELIMINAR.Name = "btnELIMINAR";
            this.btnELIMINAR.Size = new System.Drawing.Size(75, 23);
            this.btnELIMINAR.TabIndex = 10;
            this.btnELIMINAR.Text = "Eliminar";
            this.btnELIMINAR.UseVisualStyleBackColor = true;
            this.btnELIMINAR.Click += new System.EventHandler(this.btnELIMINAR_Click);
            // 
            // frmOPERACIONES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 601);
            this.Controls.Add(this.btnELIMINAR);
            this.Controls.Add(this.pFECHAS);
            this.Controls.Add(this.chkHABILITAR_FILTRO_FECHAS);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCUENTA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBUSCAR);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCERRAR);
            this.Controls.Add(this.dgvOPERACIONES);
            this.Name = "frmOPERACIONES";
            this.Text = "::.. OPERACIONES";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOPERACIONES)).EndInit();
            this.pFECHAS.ResumeLayout(false);
            this.pFECHAS.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOPERACIONES;
        private System.Windows.Forms.Button btnCERRAR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Button btnBUSCAR;
        private System.Windows.Forms.TextBox txtCUENTA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkHABILITAR_FILTRO_FECHAS;
        private System.Windows.Forms.Panel pFECHAS;
        private System.Windows.Forms.TextBox txtFECHA_HASTA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFECHA_DESDE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnELIMINAR;
    }
}