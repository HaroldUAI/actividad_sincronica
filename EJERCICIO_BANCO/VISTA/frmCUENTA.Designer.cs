namespace VISTA
{
    partial class frmCUENTA
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
            this.cmbTITULAR = new System.Windows.Forms.ComboBox();
            this.txtSALDO = new System.Windows.Forms.TextBox();
            this.txtCODIGO = new System.Windows.Forms.TextBox();
            this.btnCANCELAR = new System.Windows.Forms.Button();
            this.btnGUARDAR = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAGREGAR_CLIENTE = new System.Windows.Forms.Button();
            this.gbTIPO_CUENTA = new System.Windows.Forms.GroupBox();
            this.rbCAJA_AHORRO = new System.Windows.Forms.RadioButton();
            this.rbCUENTA_CORRIENTE = new System.Windows.Forms.RadioButton();
            this.lblDATO = new System.Windows.Forms.Label();
            this.txtVALOR = new System.Windows.Forms.TextBox();
            this.gbTIPO_CUENTA.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbTITULAR
            // 
            this.cmbTITULAR.FormattingEnabled = true;
            this.cmbTITULAR.Location = new System.Drawing.Point(105, 116);
            this.cmbTITULAR.Name = "cmbTITULAR";
            this.cmbTITULAR.Size = new System.Drawing.Size(218, 21);
            this.cmbTITULAR.TabIndex = 24;
            // 
            // txtSALDO
            // 
            this.txtSALDO.Location = new System.Drawing.Point(105, 209);
            this.txtSALDO.Name = "txtSALDO";
            this.txtSALDO.ReadOnly = true;
            this.txtSALDO.Size = new System.Drawing.Size(100, 20);
            this.txtSALDO.TabIndex = 23;
            // 
            // txtCODIGO
            // 
            this.txtCODIGO.Location = new System.Drawing.Point(105, 83);
            this.txtCODIGO.Name = "txtCODIGO";
            this.txtCODIGO.Size = new System.Drawing.Size(100, 20);
            this.txtCODIGO.TabIndex = 22;
            // 
            // btnCANCELAR
            // 
            this.btnCANCELAR.Location = new System.Drawing.Point(279, 326);
            this.btnCANCELAR.Name = "btnCANCELAR";
            this.btnCANCELAR.Size = new System.Drawing.Size(75, 23);
            this.btnCANCELAR.TabIndex = 21;
            this.btnCANCELAR.Text = "Cancelar";
            this.btnCANCELAR.UseVisualStyleBackColor = true;
            this.btnCANCELAR.Click += new System.EventHandler(this.btnCANCELAR_Click);
            // 
            // btnGUARDAR
            // 
            this.btnGUARDAR.Location = new System.Drawing.Point(16, 326);
            this.btnGUARDAR.Name = "btnGUARDAR";
            this.btnGUARDAR.Size = new System.Drawing.Size(75, 23);
            this.btnGUARDAR.TabIndex = 20;
            this.btnGUARDAR.Text = "Guardar";
            this.btnGUARDAR.UseVisualStyleBackColor = true;
            this.btnGUARDAR.Click += new System.EventHandler(this.btnGUARDAR_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Saldo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Titular:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Código:";
            // 
            // btnAGREGAR_CLIENTE
            // 
            this.btnAGREGAR_CLIENTE.Location = new System.Drawing.Point(340, 114);
            this.btnAGREGAR_CLIENTE.Name = "btnAGREGAR_CLIENTE";
            this.btnAGREGAR_CLIENTE.Size = new System.Drawing.Size(75, 23);
            this.btnAGREGAR_CLIENTE.TabIndex = 25;
            this.btnAGREGAR_CLIENTE.Text = "Agregar";
            this.btnAGREGAR_CLIENTE.UseVisualStyleBackColor = true;
            this.btnAGREGAR_CLIENTE.Click += new System.EventHandler(this.btnAGREGAR_CLIENTE_Click);
            // 
            // gbTIPO_CUENTA
            // 
            this.gbTIPO_CUENTA.Controls.Add(this.rbCUENTA_CORRIENTE);
            this.gbTIPO_CUENTA.Controls.Add(this.rbCAJA_AHORRO);
            this.gbTIPO_CUENTA.Location = new System.Drawing.Point(29, 2);
            this.gbTIPO_CUENTA.Name = "gbTIPO_CUENTA";
            this.gbTIPO_CUENTA.Size = new System.Drawing.Size(386, 68);
            this.gbTIPO_CUENTA.TabIndex = 26;
            this.gbTIPO_CUENTA.TabStop = false;
            this.gbTIPO_CUENTA.Text = "Tipo de Cuenta";
            // 
            // rbCAJA_AHORRO
            // 
            this.rbCAJA_AHORRO.AutoSize = true;
            this.rbCAJA_AHORRO.Checked = true;
            this.rbCAJA_AHORRO.Location = new System.Drawing.Point(32, 30);
            this.rbCAJA_AHORRO.Name = "rbCAJA_AHORRO";
            this.rbCAJA_AHORRO.Size = new System.Drawing.Size(95, 17);
            this.rbCAJA_AHORRO.TabIndex = 0;
            this.rbCAJA_AHORRO.TabStop = true;
            this.rbCAJA_AHORRO.Text = "Caja de Ahorro";
            this.rbCAJA_AHORRO.UseVisualStyleBackColor = true;
            this.rbCAJA_AHORRO.CheckedChanged += new System.EventHandler(this.rbCAJA_AHORRO_CheckedChanged);
            // 
            // rbCUENTA_CORRIENTE
            // 
            this.rbCUENTA_CORRIENTE.AutoSize = true;
            this.rbCUENTA_CORRIENTE.Location = new System.Drawing.Point(194, 30);
            this.rbCUENTA_CORRIENTE.Name = "rbCUENTA_CORRIENTE";
            this.rbCUENTA_CORRIENTE.Size = new System.Drawing.Size(104, 17);
            this.rbCUENTA_CORRIENTE.TabIndex = 1;
            this.rbCUENTA_CORRIENTE.Text = "Cuenta Corriente";
            this.rbCUENTA_CORRIENTE.UseVisualStyleBackColor = true;
            this.rbCUENTA_CORRIENTE.CheckedChanged += new System.EventHandler(this.rbCUENTA_CORRIENTE_CheckedChanged);
            // 
            // lblDATO
            // 
            this.lblDATO.AutoSize = true;
            this.lblDATO.Location = new System.Drawing.Point(28, 165);
            this.lblDATO.Name = "lblDATO";
            this.lblDATO.Size = new System.Drawing.Size(0, 13);
            this.lblDATO.TabIndex = 27;
            // 
            // txtVALOR
            // 
            this.txtVALOR.Location = new System.Drawing.Point(105, 162);
            this.txtVALOR.Name = "txtVALOR";
            this.txtVALOR.Size = new System.Drawing.Size(100, 20);
            this.txtVALOR.TabIndex = 28;
            // 
            // frmCUENTA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 362);
            this.Controls.Add(this.txtVALOR);
            this.Controls.Add(this.lblDATO);
            this.Controls.Add(this.gbTIPO_CUENTA);
            this.Controls.Add(this.btnAGREGAR_CLIENTE);
            this.Controls.Add(this.cmbTITULAR);
            this.Controls.Add(this.txtSALDO);
            this.Controls.Add(this.txtCODIGO);
            this.Controls.Add(this.btnCANCELAR);
            this.Controls.Add(this.btnGUARDAR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCUENTA";
            this.Text = "::.. CUENTA";
            this.gbTIPO_CUENTA.ResumeLayout(false);
            this.gbTIPO_CUENTA.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTITULAR;
        private System.Windows.Forms.TextBox txtSALDO;
        private System.Windows.Forms.TextBox txtCODIGO;
        private System.Windows.Forms.Button btnCANCELAR;
        private System.Windows.Forms.Button btnGUARDAR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAGREGAR_CLIENTE;
        private System.Windows.Forms.GroupBox gbTIPO_CUENTA;
        private System.Windows.Forms.RadioButton rbCUENTA_CORRIENTE;
        private System.Windows.Forms.RadioButton rbCAJA_AHORRO;
        private System.Windows.Forms.Label lblDATO;
        private System.Windows.Forms.TextBox txtVALOR;
    }
}