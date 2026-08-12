using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public enum TIPO_OPERACION
    {
        DEPOSITO,
        EXTRACCION
    }

    public enum ACCION
    {
        AGREGAR,
        MODIFICAR, 
        CONSULTAR
    }

    public class FILTRO_FECHA
    {
        public bool APLICA_FILTRO { get; set; }
        public DateTime FECHA_DESDE { get; set; }
        public DateTime FECHA_HASTA { get; set; }
    }
}
