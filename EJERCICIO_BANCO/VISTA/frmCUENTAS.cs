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
    public partial class frmCUENTAS : Form
    {
        //declaro la variables y métodos estáticos para aplicar el patrón singleton
        private static frmCUENTAS instancia;
        public static frmCUENTAS OBTENER_INSTANCIA()
        {
            if (instancia == null)
                instancia = new frmCUENTAS();
            if (instancia.IsDisposed)
                instancia = new frmCUENTAS();

            return instancia;
        }
        MODELO.BANCO oBANCO;
        MODELO.CUENTA oCUENTA;
        // declaro una variable que me indica la acción
        private string ACCION;
        private frmCUENTAS()
        {
            InitializeComponent();
            oBANCO = MODELO.BANCO.OBTENER_INSTANCIA();

            COMBO_CLIENTES();

            if (oBANCO.CUENTAS.Count > 0)
            {
                ARMA_GRILLA();
            }
        }

        private void COMBO_CLIENTES()
        {
          // Vacío la lista de clientes cada vez que quiero armar una nueva
            cmbTITULARES.Items.Clear();
          
            //le pido al banco la lisya de clientes y la asigno como arreglo
            cmbTITULARES.Items.AddRange(oBANCO.CLIENTES.ToArray());
            cmbTITULARES.Items.Insert(0, new MODELO.CLIENTE { DNI = 0, NOMBRE="Todos los clientes..."}); 
            cmbTITULARES.DisplayMember = "NOMBRE";
            cmbTITULARES.ValueMember = "DNI";
        }
       private void ARMA_GRILLA()
        {           

            dgvCUENTAS.DataSource = null;
            dgvCUENTAS.DataSource = oBANCO.OBTENER_CUENTAS(cmbTITULARES.SelectedItem!=null?((MODELO.CLIENTE)cmbTITULARES.SelectedItem).DNI: 0);
        }

        private void btnCERRAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAGREGAR_Click(object sender, EventArgs e)
        {
            frmCUENTA formCUENTA = new frmCUENTA(MODELO.ACCION.AGREGAR);
            DialogResult respuesta = formCUENTA.ShowDialog();
            if (respuesta == DialogResult.OK)
            {
                COMBO_CLIENTES();
                ARMA_GRILLA();
            }
        }

        private void btnMODIFICAR_Click(object sender, EventArgs e)
        {
            if (dgvCUENTAS.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un cliente de la lista");
                return;
            }          
            oCUENTA = (MODELO.CUENTA) dgvCUENTAS.CurrentRow.DataBoundItem;
            frmCUENTA formCUENTA = new frmCUENTA(oCUENTA, MODELO.ACCION.MODIFICAR);
            DialogResult respuesta = formCUENTA.ShowDialog();
            if (respuesta == DialogResult.OK)
            {
                COMBO_CLIENTES();
                ARMA_GRILLA();
            }

        }

        private void btnCONSULTAR_Click(object sender, EventArgs e)
        {
            if (dgvCUENTAS.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un cliente de la lista");
                return;
            }            
            oCUENTA = (MODELO.CUENTA)dgvCUENTAS.CurrentRow.DataBoundItem;
            frmCUENTA formCUENTA = new frmCUENTA(oCUENTA, MODELO.ACCION.CONSULTAR);
            formCUENTA.ShowDialog();
        }

        private void btnELIMINAR_Click(object sender, EventArgs e)
        {
            if (dgvCUENTAS.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un cliente de la lista");
                return;
            }            
            oCUENTA = (MODELO.CUENTA)dgvCUENTAS.CurrentRow.DataBoundItem;
            if (oCUENTA.SALDO != 0)
            {
                MessageBox.Show("No se puede eliminar una cuenta con saldo distinto de cero");
                return;
            }

            DialogResult respuesta = MessageBox.Show("¿Confirma que desea eliminar la cuenta " + oCUENTA.CODIGO + " del banco?", "ATENCION", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.Yes)
            {
                oBANCO.CUENTAS.Remove(oCUENTA);
                ARMA_GRILLA();
            }
        }       
       

        private void btnDEPOSITAR_Click(object sender, EventArgs e)
        {
            if (dgvCUENTAS.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un cliente de la lista");
                return;
            }
            oCUENTA = (MODELO.CUENTA)dgvCUENTAS.CurrentRow.DataBoundItem;
            string IMPORTE = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el importe a depositar", "DEPOSITAR", "0");
            if (IMPORTE != "0" && IMPORTE != "")
            {
                oCUENTA.DEPOSITAR(Convert.ToDecimal(IMPORTE));
                MODELO.OPERACION oOPERACION = new MODELO.OPERACION();
                oOPERACION.CODIGO = long.Parse(DateTime.Now.ToString("yyyyMMddHHmmss"));
                oOPERACION.FECHA = DateTime.Now;
                oOPERACION.CUENTA = oCUENTA;
                oOPERACION.TIPO = MODELO.TIPO_OPERACION.DEPOSITO;
                oOPERACION.IMPORTE = Convert.ToDecimal(IMPORTE);
                oBANCO.OPERACIONES.Add(oOPERACION);
                ARMA_GRILLA();                
            }
        }

        private void btnEXTRAER_Click(object sender, EventArgs e)
        {
            if (dgvCUENTAS.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un cliente de la lista");
                return;
            }
            oCUENTA = (MODELO.CUENTA)dgvCUENTAS.CurrentRow.DataBoundItem;
            string IMPORTE = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el importe a depositar", "DEPOSITAR", "0");
            if (IMPORTE != "0" && IMPORTE != "")
            {
                try
                {
                    oCUENTA.EXTRAER(Convert.ToDecimal(IMPORTE));
                    MODELO.OPERACION oOPERACION = new MODELO.OPERACION();
                    oOPERACION.CODIGO = long.Parse(DateTime.Now.ToString("yyyyMMddHHmmss"));
                    oOPERACION.FECHA = DateTime.Now;
                    oOPERACION.CUENTA = oCUENTA;
                    oOPERACION.TIPO = MODELO.TIPO_OPERACION.EXTRACCION;
                    oOPERACION.IMPORTE = Convert.ToDecimal(IMPORTE);
                    oBANCO.OPERACIONES.Add(oOPERACION);
                    ARMA_GRILLA();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "¡¡ATENCION!!");
                }
            }
        }

        private void btnBUSCAR_Click(object sender, EventArgs e)
        {
            ARMA_GRILLA();
        }
    }
}
