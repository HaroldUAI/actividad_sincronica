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
    public partial class frmCLIENTES : Form
    {
        //declaro la variables y métodos estáticos para aplicar el patrón singleton
        private static frmCLIENTES instancia;
        public static frmCLIENTES OBTENER_INSTANCIA()
        {
            if (instancia == null)
                instancia = new frmCLIENTES();
            if (instancia.IsDisposed)
                instancia = new frmCLIENTES();

            return instancia;
        }

        //declaro las variables temporales para crear los objetos del modelo
        private MODELO.BANCO oBANCO;
        private MODELO.CLIENTE oCLIENTE;
        // declaro una variable que me indica la acción
        private string ACCION;
        private frmCLIENTES()
        {
            InitializeComponent();            
            oBANCO = MODELO.BANCO.OBTENER_INSTANCIA();

            if (oBANCO.CLIENTES.Count > 0)
                ARMA_GRILLA();
        }

        private void ARMA_GRILLA()
        {
            dgvCLIENTES.DataSource = null;
            dgvCLIENTES.DataSource = oBANCO.CLIENTES;
        }
        private void btnCERRAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }    
       

        private void btnAGREGAR_Click(object sender, EventArgs e)
        {            
            frmCLIENTE formCLIENTE = new frmCLIENTE(new MODELO.CLIENTE(), MODELO.ACCION.AGREGAR);
            DialogResult respuesta =  formCLIENTE.ShowDialog();
            if (respuesta == DialogResult.OK)
            {
                ARMA_GRILLA();
            }
        }

        private void btnMODIFICAR_Click(object sender, EventArgs e)
        {
            if (dgvCLIENTES.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un cliente de la lista");
                return;
            }
            oCLIENTE = (MODELO.CLIENTE) dgvCLIENTES.CurrentRow.DataBoundItem;
            frmCLIENTE formCLIENTE = new frmCLIENTE(oCLIENTE, MODELO.ACCION.MODIFICAR);
            DialogResult respuesta = formCLIENTE.ShowDialog();
            if (respuesta == DialogResult.OK)
            {
                ARMA_GRILLA();
            }

        }

        private void btnCONSULTAR_Click(object sender, EventArgs e)
        {
            if (dgvCLIENTES.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un cliente de la lista");
                return;
            }
            oCLIENTE = (MODELO.CLIENTE)dgvCLIENTES.CurrentRow.DataBoundItem;
            frmCLIENTE formCLIENTE = new frmCLIENTE(oCLIENTE, MODELO.ACCION.CONSULTAR);
            formCLIENTE.ShowDialog();
        }

        private void btnELIMINAR_Click(object sender, EventArgs e)
        {
            if (dgvCLIENTES.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un cliente de la lista");
                return;
            }
            oCLIENTE = (MODELO.CLIENTE)dgvCLIENTES.CurrentRow.DataBoundItem;
            if (oBANCO.CANTIDAD_CUENTAS_CLIENTE(oCLIENTE) > 0)
            {
                MessageBox.Show("No se puede eliminar un cliente con cuentas bancarias", "ATENCION");
                return;
            }

            DialogResult respuesta = MessageBox.Show("¿Confirma que desea eliminar el cliente " + oCLIENTE.NOMBRE + " del banco?", "ATENCION", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.Yes)
            {
                oBANCO.CLIENTES.Remove(oCLIENTE);
                ARMA_GRILLA();
            }
        }
    }
}
