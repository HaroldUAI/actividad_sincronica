using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class CLIENTE
    {
        #region PROPIEDADES
        // variable interna de la clase
        private int _DNI;
        // método de tipo property para acceder a la variable interna _DNI
        public int DNI 
        {
            get { return _DNI; }
            set { _DNI = value; }
        }
        // representación simplificada de las propiedades que utiliza la variable interna implícita
        public string NOMBRE { get; set; }
        public int TELEFONO { get; set; }
        public string EMAIL { get; set; }
        public DateTime FECHA_NACIMIENTO { get; set; }
        
        //creo la propiedad de solo léctura sólo para mostrar el resultado de la función que calcula la edad en la grilla
        public int EDAD
        {
            get { return CALCULAR_EDAD(); }
        }
        #endregion

        public override string ToString()
        {
            return NOMBRE; ;
        }
        #region METODOS
        public int CALCULAR_EDAD()
        {
            int EDAD = DateTime.Now.Year - FECHA_NACIMIENTO.Year;
            if (DateTime.Now.Month < FECHA_NACIMIENTO.Month)
                EDAD -= 1;
            if (DateTime.Now.Month == FECHA_NACIMIENTO.Month && DateTime.Now.Day < FECHA_NACIMIENTO.Day)
                EDAD -= 1;

            return EDAD;
        }
        #endregion

    }
}
