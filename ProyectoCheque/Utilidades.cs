using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCheque
{
    internal class Utilidades
    {
        private static string[] nombres_0_19 = {"","uno","dos","tres","cuatro", "cinco", "seis", "siete", "ocho"
          , "nueve", "diez","once","doce","trece","catorce", "quince", "dieciseis", "diecisiete", "dieciocho"
          , "diecinueve" };

        // wtf porque esto es {} y no [] ah olvidalo estamos en C
        private static string[] nombres_20_90 = {"","diez","veinte","treinta","cuarenta", "cincuenta", "sesenta", "setenta", "ochenta"
          , "noventa"};
        
        private static string[] nombres_100_900 = {"","ciento","doscientos","trescientos","cuatrocientos", "quinientos", "seiscientos", "setecientos", "ochocientos"
          , "novecientos"};

        // tiene que llegar a 9 999 999 no?
        public static string obtener_nombre_0_19(int num)
        {
            return nombres_0_19[num];
        }
        public static string obtener_nombre_20_99(int num)
        {
            string nombre = nombres_20_90[num / 10];
            int unidad = num % 10;
            if (unidad > 0)
            {
                string nombre_unidad = obtener_nombre_0_19(unidad);
                string buffer = nombre == "" ? string.Format("{0}", nombre_unidad) : string.Format("{0} y {1}", nombre, nombre_unidad);
                nombre = string.Copy(buffer);
            }
            return nombre;
        }

        public static string obtener_nombre_100_999(int num)
        {
            string nombre = nombres_100_900[num / 100];
            int resto = num % 100;
            if(resto > 0)
            {
                string nombre_resto = obtener_nombre_20_99(resto);
                string buffer = string.Format("{0} {1}", nombre, nombre_resto);
                nombre = string.Copy(buffer);
            }
            return nombre;
        }

        public static string obtener_nombre_1000_999999(int num)
        {
            int miles = num / 1000;
            string nombre_miles = obtener_nombre_100_999(miles);
            string buffer = string.Format("{0} mil", nombre_miles);
            string nombre = string.Copy(buffer);
            int resto = num % 1000;
            if (resto > 0)
            {
                string nombre_resto = obtener_nombre_100_999(resto);
                buffer = string.Format("{0} {1}", nombre, nombre_resto);
                nombre = string.Copy(buffer);
            }
            return nombre;
        }

        public static string obtener_nombre_1000000_9999999(int num)
        {
            int millones = num / 1000000;
            string nombre_millones = obtener_nombre_100_999(millones); 
            string buffer = string.Format(millones == 1 ? "un millón" : "{0} millones", nombre_millones);
            string nombre = string.Copy(buffer);
            int resto = num % 1000000;
            if(resto > 0)
            {
                string nombre_resto = obtener_nombre_1000_999999(resto);
                buffer = string.Format("{0} {1}", nombre, nombre_resto);
                nombre = string.Copy(buffer);
            }
            return nombre;
        }

        public static string obtenerNombre(int num)
        {
            if(num < 20)
            {
                return obtener_nombre_0_19(num);
            }else if(num < 100)
            {
                return obtener_nombre_20_99(num);
            }else if( num < 1000)
            {
                return obtener_nombre_100_999(num);
            }else if( num < 1000000)
            {
                return obtener_nombre_1000_999999(num);
            }
            else
            {
                return obtener_nombre_1000000_9999999(num);
            }
        }

      
    }
}
