using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VISTA
{
    public partial class frmCLIENTE : Form
    {
        MODELO.BANCO oBANCO;
        MODELO.CLIENTE oCLIENTE;

        MODELO.ACCION ACCION;
        public frmCLIENTE(MODELO.CLIENTE miCLIENTE, MODELO.ACCION miACCION)
        {
            InitializeComponent();

            oBANCO = MODELO.BANCO.OBTENER_INSTANCIA();
            oCLIENTE = miCLIENTE;
            ACCION = miACCION;
            if (ACCION != MODELO.ACCION.AGREGAR)
            {
                txtDNI.Text = oCLIENTE.DNI.ToString();
                txtNOMBRE.Text = oCLIENTE.NOMBRE;
                txtTELEFONO.Text = oCLIENTE.TELEFONO.ToString();
                txtEMAIL.Text = oCLIENTE.EMAIL;
                txtFECHA_NACIMIENTO.Text = oCLIENTE.FECHA_NACIMIENTO.ToShortDateString();
                txtEDAD.Text = oCLIENTE.CALCULAR_EDAD().ToString();

                if (ACCION == MODELO.ACCION.CONSULTAR)
                {
                    btnGUARDAR.Enabled = false;
                }

            }

        }

        private void btnGUARDAR_Click(object sender, EventArgs e)
        {
            #region VALIDACIONES DE CARGA
            int DNI;
            if (!int.TryParse(txtDNI.Text, out DNI))
            {
                MessageBox.Show("Ingrese el DNI correctamente");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNOMBRE.Text))
            {
                MessageBox.Show("Ingrese el nombre del cliente");
                return;
            }

            int TELEFONO;
            if (!int.TryParse(txtTELEFONO.Text, out TELEFONO))
            {
                MessageBox.Show("Ingrese el teléfono del cliente correctamente");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtEMAIL.Text))
            {
                MessageBox.Show("Ingrese el email del cliente");
                return;
            }

            DateTime FECHA_NACIMIENTO;
            if (!DateTime.TryParse(txtFECHA_NACIMIENTO.Text, out FECHA_NACIMIENTO))
            {
                MessageBox.Show("Ingrese la fecha de nacimiento correcta del cliente");
                return;
            }
            #endregion
            //asigno los valores a los atributos del objeto
            oCLIENTE.DNI = DNI;
            oCLIENTE.NOMBRE = txtNOMBRE.Text.ToUpper();
            oCLIENTE.TELEFONO = TELEFONO;
            oCLIENTE.EMAIL = txtEMAIL.Text;
            oCLIENTE.FECHA_NACIMIENTO = FECHA_NACIMIENTO;
            //agrego el cliente al banco, si la operación es agregar
            if (ACCION == MODELO.ACCION.AGREGAR)
                oBANCO.CLIENTES.Add(oCLIENTE);

            this.DialogResult = DialogResult.OK;
        }

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
