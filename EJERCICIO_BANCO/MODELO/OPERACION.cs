using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class OPERACION
    {
        public long CODIGO { get; set; }
        public DateTime FECHA { get; set; }
        public CUENTA CUENTA { get; set; }
        public TIPO_OPERACION TIPO { get; set; }
        public decimal IMPORTE { get; set; }
    }
}
