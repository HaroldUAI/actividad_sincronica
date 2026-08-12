namespace VISTA
{
    partial class frmCLIENTE
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
            this.txtEDAD = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCANCELAR = new System.Windows.Forms.Button();
            this.btnGUARDAR = new System.Windows.Forms.Button();
            this.txtFECHA_NACIMIENTO = new System.Windows.Forms.TextBox();
            this.txtEMAIL = new System.Windows.Forms.TextBox();
            this.txtTELEFONO = new System.Windows.Forms.TextBox();
            this.txtNOMBRE = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtEDAD
            // 
            this.txtEDAD.Location = new System.Drawing.Point(133, 203);
            this.txtEDAD.Name = "txtEDAD";
            this.txtEDAD.ReadOnly = true;
            this.txtEDAD.Size = new System.Drawing.Size(202, 20);
            this.txtEDAD.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Edad:";
            // 
            // btnCANCELAR
            // 
            this.btnCANCELAR.Location = new System.Drawing.Point(260, 281);
            this.btnCANCELAR.Name = "btnCANCELAR";
            this.btnCANCELAR.Size = new System.Drawing.Size(75, 23);
            this.btnCANCELAR.TabIndex = 25;
            this.btnCANCELAR.Text = "Cancelar";
            this.btnCANCELAR.UseVisualStyleBackColor = true;
            this.btnCANCELAR.Click += new System.EventHandler(this.btnCANCELAR_Click);
            // 
            // btnGUARDAR
            // 
            this.btnGUARDAR.Location = new System.Drawing.Point(34, 281);
            this.btnGUARDAR.Name = "btnGUARDAR";
            this.btnGUARDAR.Size = new System.Drawing.Size(75, 23);
            this.btnGUARDAR.TabIndex = 24;
            this.btnGUARDAR.Text = "Guardar";
            this.btnGUARDAR.UseVisualStyleBackColor = true;
            this.btnGUARDAR.Click += new System.EventHandler(this.btnGUARDAR_Click);
            // 
            // txtFECHA_NACIMIENTO
            // 
            this.txtFECHA_NACIMIENTO.Location = new System.Drawing.Point(133, 158);
            this.txtFECHA_NACIMIENTO.Name = "txtFECHA_NACIMIENTO";
            this.txtFECHA_NACIMIENTO.Size = new System.Drawing.Size(202, 20);
            this.txtFECHA_NACIMIENTO.TabIndex = 23;
            // 
            // txtEMAIL
            // 
            this.txtEMAIL.Location = new System.Drawing.Point(133, 122);
            this.txtEMAIL.Name = "txtEMAIL";
            this.txtEMAIL.Size = new System.Drawing.Size(202, 20);
            this.txtEMAIL.TabIndex = 22;
            // 
            // txtTELEFONO
            // 
            this.txtTELEFONO.Location = new System.Drawing.Point(133, 85);
            this.txtTELEFONO.Name = "txtTELEFONO";
            this.txtTELEFONO.Size = new System.Drawing.Size(202, 20);
            this.txtTELEFONO.TabIndex = 21;
            // 
            // txtNOMBRE
            // 
            this.txtNOMBRE.Location = new System.Drawing.Point(133, 49);
            this.txtNOMBRE.Name = "txtNOMBRE";
            this.txtNOMBRE.Size = new System.Drawing.Size(202, 20);
            this.txtNOMBRE.TabIndex = 20;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(133, 17);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(105, 20);
            this.txtDNI.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Fecha Nacimiento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Teléfono:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "DNI:";
            // 
            // frmCLIENTE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 331);
            this.Controls.Add(this.txtEDAD);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCANCELAR);
            this.Controls.Add(this.btnGUARDAR);
            this.Controls.Add(this.txtFECHA_NACIMIENTO);
            this.Controls.Add(this.txtEMAIL);
            this.Controls.Add(this.txtTELEFONO);
            this.Controls.Add(this.txtNOMBRE);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCLIENTE";
            this.Text = "::.. CLIENTE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEDAD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCANCELAR;
        private System.Windows.Forms.Button btnGUARDAR;
        private System.Windows.Forms.TextBox txtFECHA_NACIMIENTO;
        private System.Windows.Forms.TextBox txtEMAIL;
        private System.Windows.Forms.TextBox txtTELEFONO;
        private System.Windows.Forms.TextBox txtNOMBRE;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}