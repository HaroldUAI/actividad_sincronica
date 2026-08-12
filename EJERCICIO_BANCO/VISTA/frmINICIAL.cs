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
    public partial class frmINICIAL : Form
    {
        MODELO.BANCO oBANCO;
        public frmINICIAL()
        {
            InitializeComponent();

            oBANCO = MODELO.BANCO.OBTENER_INSTANCIA();
            ACTUALIZAR_DATOS();
        }

        private void ACTUALIZAR_DATOS()
        {
            txtCLIENTES.Text = oBANCO.CLIENTES.Count.ToString();
            txtCUENTAS.Text = oBANCO.CUENTAS.Count.ToString();
        }

        private void miCLIENTES_Click(object sender, EventArgs e)
        {
            frmCLIENTES formCLIENTES = frmCLIENTES.OBTENER_INSTANCIA();
            formCLIENTES.Show();
        }

        private void miCUENTAS_Click(object sender, EventArgs e)
        {
            frmCUENTAS formCUENTAS = frmCUENTAS.OBTENER_INSTANCIA();
            formCUENTAS.Show();
        }

        private void frmINICIAL_Activated(object sender, EventArgs e)
        {
            ACTUALIZAR_DATOS();
        }

        private void miOPERACIONES_Click(object sender, EventArgs e)
        {
            frmOPERACIONES formOPERACIONES = frmOPERACIONES.OBTENER_INSTANCIA();
            formOPERACIONES.Show();
        }
    }
}
