using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCheque
{
    internal class Utilidades
    {
        private static string[] unidades = {"cero","uno","dos","tres","cuatro", "cinco", "seis", "siete", "ocho"
          , "nueve", "diez","once","doce","trece","catorce", "quince", "dieciseis", "diecisiete", "dieciocho"
          , "diecinueve" };

        private static string[] decenas = {"cero","diez","veinte","treinta","cuarenta", "cincuenta", "sesenta", "setenta", "ochenta"
          , "noventa"};
        
        private static string[] centenas = {"cero","cien","doscientos","trescientos","cuatrocientos", "quinientos", "seiscientos", "setecientos", "ochocientos"
          , "novecientos"};

        public static string getUnidades(int num)
        {
            string aux = "";
            aux = unidades[num];

            return aux;
        }

        public static string getDecenas(int num)
        {
            string aux = "";
            int x = num / 10;
            int resto = num % 10;

            if (num < 20)
                aux = getUnidades(num);
            else
            {
                string uni = resto == 0 ? "" : "y" + getUnidades(resto);
                aux = decenas[x]+uni;
            }

            return aux;
        }

        public static string getCentenas(int num)
        {
            string aux = "";
            int x = num / 100;
            int resto = num % 10;
            int resto1 = resto % 10;

            if (num < 20)
            {
                aux = getUnidades(num);
            }
            else if (num <= 90)
            {
                string uni = resto == 0 ? "" : " y " + getUnidades(resto);
                aux = decenas[x] + uni;
                //aux = getDecenas(num);
            }
            else
            {
                aux = centenas[x];
            }

            return aux;
        }
    }
}
