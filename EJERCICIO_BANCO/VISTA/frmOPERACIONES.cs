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
    public partial class frmOPERACIONES : Form
    {
        private static frmOPERACIONES instancia;
        public static frmOPERACIONES OBTENER_INSTANCIA()
        {
            if (instancia == null)
                instancia = new frmOPERACIONES();
            if (instancia.IsDisposed)
                instancia = new frmOPERACIONES();

            return instancia;
        }
        MODELO.BANCO oBANCO;
        private frmOPERACIONES()
        {
            InitializeComponent();
            oBANCO = MODELO.BANCO.OBTENER_INSTANCIA();
            pFECHAS.Enabled = false;
            if (oBANCO.OPERACIONES.Count > 0)
                ARMA_GRILLA();
        }

        private void ARMA_GRILLA()
        {
            int DNI;
            if (string.IsNullOrEmpty(txtDNI.Text))
            {
                DNI = 0;
            } else
            {
                if (int.TryParse (txtDNI.Text, out DNI) == false)
                {
                    MessageBox.Show("Debe ingresar un DNI válido", "¡ATENCION!");
                    return;
                }
            }
            int CUENTA;
            if (string.IsNullOrEmpty(txtCUENTA.Text))
            {
                CUENTA = 0;
            }
            else
            {
                if (int.TryParse(txtCUENTA.Text, out CUENTA) == false)
                {
                    MessageBox.Show("Debe ingresar un numero de CUENTA válido", "¡ATENCION!");
                    return;
                }
            }
            MODELO.FILTRO_FECHA oFILTRO_FECHA = new MODELO.FILTRO_FECHA();
            oFILTRO_FECHA.APLICA_FILTRO = chkHABILITAR_FILTRO_FECHAS.Checked;
            if (chkHABILITAR_FILTRO_FECHAS.Checked)
            {
                DateTime FECHA_DESDE;
                if (!DateTime.TryParse(txtFECHA_DESDE.Text, out FECHA_DESDE))
                {
                    FECHA_DESDE = DateTime.MinValue;
                }
                oFILTRO_FECHA.FECHA_DESDE = FECHA_DESDE;
                DateTime FECHA_HASTA;
                if (!DateTime.TryParse(txtFECHA_HASTA.Text, out FECHA_HASTA))
                {
                    FECHA_HASTA = DateTime.MinValue;
                }
                oFILTRO_FECHA.FECHA_HASTA = FECHA_HASTA;
            }

            dgvOPERACIONES.DataSource = null;
            dgvOPERACIONES.DataSource = oBANCO.OBTENER_OPERACIONES(DNI, CUENTA, oFILTRO_FECHA);
        }
        private void btnCERRAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBUSCAR_Click(object sender, EventArgs e)
        {
            ARMA_GRILLA();
        }

        private void chkHABILITAR_FILTRO_FECHAS_CheckedChanged(object sender, EventArgs e)
        {
            pFECHAS.Enabled = chkHABILITAR_FILTRO_FECHAS.Checked;
        }

        private void btnELIMINAR_Click(object sender, EventArgs e)
        {
            if (dgvOPERACIONES.CurrentRow == null)
            {
                MessageBox.Show("No ha seleccionado ninguna operación para anular");
                return;
            }
            MODELO.OPERACION oOPERACION = oBANCO.OPERACIONES.Find(_ => _.CODIGO == long.Parse(dgvOPERACIONES.CurrentRow.Cells[0].Value.ToString()));
            DialogResult respuesta = MessageBox.Show("¿Confirma que desea eliminar la operación seleccionada?", "¡ATENCION!", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.Yes)
            {
                if (oOPERACION.TIPO == MODELO.TIPO_OPERACION.DEPOSITO)
                {
                    oOPERACION.CUENTA.SALDO -= oOPERACION.IMPORTE;
                } else
                {
                    oOPERACION.CUENTA.SALDO += oOPERACION.IMPORTE;
                }
                oBANCO.OPERACIONES.Remove(oOPERACION);
                ARMA_GRILLA();
            }
        }
    }
}
