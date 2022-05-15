using System;

namespace Fecha
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            
            //Fecha correcta, año bisiesto
            Fecha fecha1 = new Fecha(12, 2012, 4, false);
            Console.WriteLine("Fecha 1: " + fecha1.fechas.Año.ToString());
            //Fecha correcta, año no bisiesto
            Fecha fecha2 = new Fecha(10, 2013, 4, false);
            Console.WriteLine("Fecha 2: " + fecha2.fechas.Año.ToString());
            //Fecha con valores incorrectos
            Fecha fecha3 = new Fecha(13, -4, 4, false);
            Console.WriteLine("Fecha 3: " + fecha3.fechas.Año.ToString());
            //Fecha con asignación incorrecta de valores erroneos
            Fecha fecha4 = new Fecha();
            fecha4.fechas.Dia = 67;
            fecha4.fechas.Mes = 80;
            fecha4.fechas.Año = 3678;
            Console.WriteLine("Fecha 4: " + fecha4.ToString());
            //MAL!!
            Fecha Fechas = fecha1;
            if (Fechas.EsBisiesto())
                Console.WriteLine("El año " + Fechas.fechas.Año + "es bisiesto");
            else
                Console.WriteLine("El año " + Fechas.fechas.Año + "no es bisiesto");

        }
    }
}
