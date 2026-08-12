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
    public partial class frmCUENTA : Form
    {
        MODELO.BANCO oBANCO;
        MODELO.CUENTA oCUENTA;
        MODELO.ACCION ACCION;
        int CODIGO_CUENTA;

        #region CONSTRUCTORES
        // voy a tener 2 constructores en función de la acción que voy a realizar sobre el formulario
        // Un constructor será para agregar cuentas
        // el otro para modificar y consultar cuentas existentes
        //EL MECANISMO QUE ME PERMITE ESTA PRACTICA DE PROGRAMACION ESTA BASADO EN EL CONCEPTO DE POLIMORFISMO
        //QUE ADEMAS SE CONOCE COMO SOBRECARGA -> SOBRECARGA DE UN METODO
        // COMO EL CONSTRUCTOR TIENE DISTINTOS PARAMETROS PUEDO INVOCAR EN TIEMPO DE EJECUCION ALGUNO DE LOS DOS
        public frmCUENTA(MODELO.ACCION miACCION)
        {
            InitializeComponent();
            oBANCO = MODELO.BANCO.OBTENER_INSTANCIA();           
            ACCION = miACCION;
            lblDATO.Text = "Límite de extracción:";
            CODIGO_CUENTA = -1;
            
            ARMA_COMBO();
        }
        public frmCUENTA(MODELO.CUENTA miCUENTA, MODELO.ACCION miACCION )
        {
            InitializeComponent();
            oBANCO = MODELO.BANCO.OBTENER_INSTANCIA();
            oCUENTA = miCUENTA;
            ACCION = miACCION;

            ARMA_COMBO();

            if (ACCION != MODELO.ACCION.AGREGAR)
            {
                txtCODIGO.Text = oCUENTA.CODIGO.ToString();
                CODIGO_CUENTA = oCUENTA.CODIGO;
                cmbTITULAR.SelectedItem = oCUENTA.TITULAR;
                txtSALDO.Text = oCUENTA.SALDO.ToString();
                if (oCUENTA.GetType().Name == "CAJA_AHORRO")
                {
                    lblDATO.Text = "Límite de extracción:";
                    txtVALOR.Text = ((MODELO.CAJA_AHORRO)oCUENTA).LIMITE_EXTRACCION.ToString();
                    rbCAJA_AHORRO.Checked = true;
                } else
                {
                    lblDATO.Text = "Límite en descubierto:";
                    txtVALOR.Text = ((MODELO.CUENTA_CORRIENTE)oCUENTA).LIMITE_DESCUBIERTO.ToString();
                    rbCUENTA_CORRIENTE.Checked = true;
                }
                gbTIPO_CUENTA.Enabled = false;

                if (ACCION == MODELO.ACCION.CONSULTAR)
                {
                    btnGUARDAR.Enabled = false;
                    btnAGREGAR_CLIENTE.Enabled = false;
                }
            }

        }
        #endregion
        private void ARMA_COMBO()
        {
            cmbTITULAR.DataSource = null;
            cmbTITULAR.DataSource = oBANCO.CLIENTES;
            cmbTITULAR.DisplayMember = "NOMBRE";
        }

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnGUARDAR_Click(object sender, EventArgs e)
        {
            int CODIGO;
            if (!int.TryParse(txtCODIGO.Text, out CODIGO))
            {
                MessageBox.Show("Debe ingresar un código de cuenta válido");
                return;
            }
            /* PARA VERIFICAR QUE SEA UNICO EL CODIGO DE CUENTA SE VERIFICAN 3 SITUACIONES 
                a) Cuenta nueva: CODIGO_CUENTA = -1, por lo tanto se busca si el código está asignado a otra cuenta
                b) Modificar cuenta sin cambiar el código, en este caso no se cumple la primer condición del if, no es necesario revisar
                c) Modifica cuenta con un código nuevo, en esta caso necesito validar el código en las cuentas existentes
             */
            if (CODIGO != CODIGO_CUENTA && oBANCO.CUENTAS.Count(_ => _.CODIGO == CODIGO) > 0)
            {
                MessageBox.Show("El código de cuenta ya se encuentra registrado");
                return;
            }
            if (cmbTITULAR.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un titular para la cuenta");
                return;
            }
            Decimal VALOR;
            if (!decimal.TryParse(txtVALOR.Text, out VALOR)) {
                if (rbCAJA_AHORRO.Checked)
                {
                    MessageBox.Show("Debe ingresar el valor del límite de extracción correctamente");
                } else
                {
                    MessageBox.Show("Debe ingresar el valor del límite en descubierto correctamente");
                }
                return;
            }

            if (ACCION == MODELO.ACCION.AGREGAR)
            {
                if (rbCAJA_AHORRO.Checked)
                {
                    oCUENTA = new MODELO.CAJA_AHORRO();
                } else
                {
                    oCUENTA = new MODELO.CUENTA_CORRIENTE();
                }
            }
            
            oCUENTA.CODIGO = CODIGO;
            oCUENTA.TITULAR = (MODELO.CLIENTE)cmbTITULAR.SelectedItem;
            //si es caja de ahorro debería establecer el límite de extracción, en caso de cuenta corriente debería asignar
            // el límite en descubierto
            if (rbCAJA_AHORRO.Checked)
            {
                ((MODELO.CAJA_AHORRO)oCUENTA).LIMITE_EXTRACCION = VALOR;
            } else
            {
                ((MODELO.CUENTA_CORRIENTE)oCUENTA).LIMITE_DESCUBIERTO = VALOR;
            }

                if (ACCION == MODELO.ACCION.AGREGAR)
            {
                oBANCO.CUENTAS.Add(oCUENTA);
            }

            this.DialogResult = DialogResult.OK;
        }

        private void btnAGREGAR_CLIENTE_Click(object sender, EventArgs e)
        {
            frmCLIENTE formCLIENTE = new frmCLIENTE(new MODELO.CLIENTE(), MODELO.ACCION.AGREGAR);
            DialogResult resultado = formCLIENTE.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                ARMA_COMBO();
            }
        }

        private void rbCAJA_AHORRO_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCAJA_AHORRO.Checked)
            {
                lblDATO.Text = "Límite de extracción:";
            }
        }

        private void rbCUENTA_CORRIENTE_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCUENTA_CORRIENTE.Checked)
            {
                lblDATO.Text = "Límite en descubierto:";
            }
        }
    }
}
