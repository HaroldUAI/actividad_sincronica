using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class Banco
    {
        // Esta variable va a representar el objeto banco que voy a utilizar
        private static Banco instancia;

        // Patrón Singleton
        public static Banco ObtenerInstancia()
        {
            // Verificar que la instancia esté vacía para crear una nueva
            if (instancia == null)
                instancia = new Banco();

            // Devuelvo la instancia de la clase creada
            return instancia;
        }

        private Banco()
        {
            Clientes = new List<CLIENTE>();
            Cuentas = new List<CUENTA>();
            Operaciones = new List<OPERACION>();
        }

        public List<CLIENTE> Clientes { get; set; }
        public List<CUENTA> Cuentas { get; set; }
        public List<OPERACION> Operaciones { get; set; }

        public int CantidadCuentasCliente(CLIENTE cliente)
        {
            // c => c.TITULAR es una expresión lambda que representa cada titular de las cuentas del banco
            return Cuentas.Count(c => c.TITULAR == cliente);
        }

        public System.Collections.IEnumerable ObtenerOperaciones(int dni, int cuenta, FILTRO_FECHA filtroFecha)
        {
            var operaciones = from operacion in Operaciones
                              where (dni > 0 ? operacion.CUENTA.TITULAR.DNI == dni : true)
                              && (cuenta > 0 ? operacion.CUENTA.CODIGO == cuenta : true)
                              && (filtroFecha.APLICA_FILTRO && filtroFecha.FECHA_DESDE != DateTime.MinValue ? operacion.FECHA.Date >= filtroFecha.FECHA_DESDE.Date : true)
                              && (filtroFecha.APLICA_FILTRO && filtroFecha.FECHA_HASTA != DateTime.MinValue ? operacion.FECHA.Date <= filtroFecha.FECHA_HASTA.Date : true)
                              select new
                              {
                                  Codigo = operacion.CODIGO,
                                  Fecha = operacion.FECHA,
                                  CuentaNumero = operacion.CUENTA.CODIGO,
                                  Titular = operacion.CUENTA.TITULAR.NOMBRE,
                                  Edad = operacion.CUENTA.TITULAR.CALCULAR_EDAD(),
                                  Tipo = operacion.TIPO,
                                  Importe = operacion.IMPORTE
                              };

            return operaciones.ToList();
        }

        public List<CUENTA> ObtenerCuentas(int dni)
        {
            var cuentas = from cuenta in Cuentas
                          where (dni != 0 ? cuenta.TITULAR.DNI == dni : true)
                          select cuenta;
            return cuentas.ToList();
        }
    }
}
