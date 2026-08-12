using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class BANCO
    {
        //ESTA VARIABLE VA A REPRESENTAR EL OBJETO BANCO QUE VOY A UTILIZAR
        private static BANCO instancia;
        por ejemplo hago este cambio
        //CON ESTE METODO VOY A REVISAR SI TENGO CREADA LA INSTANCIA DE BANCO SOBRE LA VARIABLE instancia
        // PATRON SINGLETON                
        public static BANCO OBTENER_INSTANCIA()
        {
            //verificar que la instancia este vacía para crear una nueva
            if (instancia == null)
                instancia = new BANCO();

            // devuelvo la instancia de la clase creada
            return instancia;
        }
        private BANCO()
        {
            CLIENTES = new List<CLIENTE>();
            CUENTAS = new List<CUENTA>();
            OPERACIONES = new List<OPERACION>();
        }

        public List<CLIENTE> CLIENTES { get; set; }
        public List<CUENTA> CUENTAS { get; set; }
        public List<OPERACION> OPERACIONES { get; set; }
        public int CANTIDAD_CUENTAS_CLIENTE(CLIENTE oCLIENTE)
        {
            // c => c.TITULAR es una expresión lambda que representa cada titular de las cuentas del banco
            return CUENTAS.Count(c => c.TITULAR == oCLIENTE);
        }

        public System.Collections.IEnumerable OBTENER_OPERACIONES(Int32 DNI, Int32 CUENTA, FILTRO_FECHA oFILTRO_FECHA)
        {
            var operaciones = from operacion in OPERACIONES
                              where (DNI > 0 ? operacion.CUENTA.TITULAR.DNI == DNI : true)
                              && (CUENTA > 0 ? operacion.CUENTA.CODIGO == CUENTA : true)
                              && (oFILTRO_FECHA.APLICA_FILTRO && oFILTRO_FECHA.FECHA_DESDE != DateTime.MinValue? operacion.FECHA.Date >= oFILTRO_FECHA.FECHA_DESDE.Date: true)
                              && (oFILTRO_FECHA.APLICA_FILTRO && oFILTRO_FECHA.FECHA_HASTA != DateTime.MinValue ? operacion.FECHA.Date <= oFILTRO_FECHA.FECHA_HASTA.Date : true)
                              select new
                              {
                                  CODIGO = operacion.CODIGO,
                                  FECHA = operacion.FECHA,
                                  CUENTA_NUMERO = operacion.CUENTA.CODIGO,
                                  TITULAR = operacion.CUENTA.TITULAR.NOMBRE,
                                  EDAD = operacion.CUENTA.TITULAR.CALCULAR_EDAD(),
                                  TIPO = operacion.TIPO,
                                  IMPORTE = operacion.IMPORTE
                              };

            return operaciones.ToList();
            /* La condición que se evalua en el where tiene la siguiente sintaxis 
              (condicion?caso para resultado true:caso para resultado false) equivale a =>
              if (condicion) {caso verdadero} else {caso falso}
             */
        }

        public List<CUENTA> OBTENER_CUENTAS (int DNI)
        {
            var cuentas = from cuenta in CUENTAS
                          where (DNI != 0 ? cuenta.TITULAR.DNI == DNI : true)
                          select cuenta;
            return cuentas.ToList();
        }
    }
}
