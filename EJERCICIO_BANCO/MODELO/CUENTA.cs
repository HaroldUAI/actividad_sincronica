using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public abstract class CUENTA
    {
        #region PROPIEDADES
        public int CODIGO { get; set; }
        public CLIENTE TITULAR { get; set; }
        public decimal SALDO { get; set; }
        #endregion
        #region METODOS
        public void DEPOSITAR(decimal IMPORTE)
        {
            SALDO += IMPORTE;
        }
        public abstract void EXTRAER(decimal IMPORTE);
        #endregion
    }
    public class CUENTA_CORRIENTE : CUENTA
    {
        public decimal LIMITE_DESCUBIERTO { get; set; }
        public override void EXTRAER(decimal IMPORTE)
        {
            if (IMPORTE <= (SALDO + LIMITE_DESCUBIERTO))
            {
                SALDO -= IMPORTE;
            } else
            {
                throw new Exception("El importe a extraer es superior al permitido por el saldo actual de la cuenta");
            }
        }
    }
    public class CAJA_AHORRO : CUENTA
    {
        public decimal LIMITE_EXTRACCION { get; set; }

        public override void EXTRAER(decimal IMPORTE)
        {
            if (IMPORTE <= SALDO && IMPORTE <= LIMITE_EXTRACCION)
            {
                SALDO -= IMPORTE;
            } else
            {
                throw new Exception("El importe solicitado para la extracción no puede ser mayor que el saldo disponible ni superar el monto máximo de extracción");
            }
        }
    }
}
