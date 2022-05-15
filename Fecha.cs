using System;
using System.Collections.Generic;
using System.Text;

namespace Fecha
{
    class Fecha
    {

        public Años fechas;
        //TODO validar los valores introducidos
        /// <summary>
        /// Constructor de Fecha sin parámetros
        /// Se establecen los valores a 1
        /// </summary>
        public Fecha()
        {
            fechas.Año = 1;
            fechas.Mes = 1;
            fechas.Dia = 1;
        }
        

        

        /// <summary>
        /// Constructor de Fecha con 3 parámetros
        /// Si algún parámetro no es correcto se establece a 1
        /// </summary>
        /// <param name="mes">Mes</param>
        /// <param name="anyo">Anyo (entre 1 y 2500)</param>
        /// <param name="dia">Dia</param>
        /// <param name="bi">Indica si es bisiesto</param>
        public Fecha(int mes, int anyo, int dia, bool bi)
        {
            if (anyo >= 1 && anyo <= 2500)
            {
                this.fechas.Año = anyo;
            }
            else
            {
                this.fechas.Año = 1;
            }
            bool bisiesto;
            if ((fechas.Año % 400 == 0) || ((fechas.Año % 4 == 0) && (fechas.Año % 100 != 0)))
                bisiesto = true;
            else 
                bisiesto = false;
            if (mes >= 1 && mes <= 12)
                this.fechas.Mes = mes;
            else
                this.fechas.Mes = 1;
            int diasMes = 0;
            switch (mes)
            {
                case 1:
                case 2: // verificación de año bisiesto
                    if (bisiesto)
                        diasMes = 29;
                    else
                        diasMes = 28;
                    break;
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                case 11:
                    diasMes = 30;
                    break;
                case 12:
                    diasMes = 31;
                    break;
            }
            if (dia >= 1 && dia <= diasMes)
                this.fechas.Dia = dia;
            else
                this.fechas.Dia = 1;
        }

        public bool EsBisiesto()
        {
            bool bisiesto = false;
            if ((fechas.Año % 400 == 0) || ((fechas.Año % 4 == 0) && (fechas.Año % 100 != 0)))
                bisiesto = true;
            else 
                bisiesto = false;
            return bisiesto;
        }

        /// <summary>
        /// Devuelve un string con la fecha en formato dia/mes/anyo
        /// </summary>
        /// <remarks> la palabra clave override indica que se sobreescribe el metodo ToString</remarks>
        /// <returns>un string con la fecha en formato dia/mes/anyo</returns>
        public override string ToString()
        {

            return fechas.Dia + "/" + fechas.Mes + "/" + fechas.Año;
        }
    }
}
