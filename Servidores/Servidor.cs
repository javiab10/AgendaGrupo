using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace Servidores
{
    public static class Servidor
    {
        private static string carpetaFicheros = "./FicheroServidores";
        private static string ubicacionFicheros = "./FicheroServidores/Servidores.txt";

        public static string ServidorActual() {

            if (!Directory.Exists(carpetaFicheros))
            {
                Directory.CreateDirectory(carpetaFicheros);
            }

            if (!File.Exists(ubicacionFicheros))
            {
                File.WriteAllText(ubicacionFicheros, "4V-PRO-948*4V-PRO-948\\SQLEXPRESS\nISCO2*ISCO2\\SQLEXPRESS\nLAPTOP-BCBR8QSP\\SQLEXPRESS\nDESKTOP-OM1M5LR\\SQLEXPRESS");

                
            }



            String[] resultadoTxt = File.ReadAllLines(ubicacionFicheros);
            List<String> corregidoList = new List<String>();
            Boolean error = false;
            for (int i = 0; i < resultadoTxt.Length; i++)
            {
                String[] datosLinea = resultadoTxt[i].Split('*');
                if (datosLinea.Length == 2)
                {
                    corregidoList.Add(resultadoTxt[i]);
                }
                else
                {
                    error = true;
                }
            }

            if (!corregidoList.Contains("4V-PRO-948*4V-PRO-948\\SQLEXPRESS",StringComparer.OrdinalIgnoreCase)){
                corregidoList.Add("4V-PRO-948*4V-PRO-948\\SQLEXPRESS");
                error = true;
            }

            if (!corregidoList.Contains("ISCO2*ISCO2\\SQLEXPRESS", StringComparer.OrdinalIgnoreCase))
            {
                corregidoList.Add("ISCO2*ISCO2\\SQLEXPRESS");
                error = true;
            }

            if (!corregidoList.Contains("LAPTOP-BCBR8QSP\\SQLEXPRESS", StringComparer.OrdinalIgnoreCase))
            {
                corregidoList.Add("LAPTOP-BCBR8QSP\\SQLEXPRESS");
                error = true;
            }

            if (!corregidoList.Contains("DESKTOP-OM1M5LR\\SQLEXPRESS", StringComparer.OrdinalIgnoreCase))
            {
                corregidoList.Add("DESKTOP-OM1M5LR\\SQLEXPRESS");
                error = true;
            }

            if (error)
            {
                File.WriteAllLines(ubicacionFicheros,corregidoList);
            }

            String[] servidorActual = null;

            foreach (var servidorStr in corregidoList)
            {
                String[] servidor = servidorStr.Split('*');
                if (String.Compare(Environment.MachineName, servidor[0], true) == 0)
                {
                    servidorActual = new string[] { servidor[0], servidor[1] };
                    break;
                    
                }
            }

            


            if (servidorActual != null) {
                return servidorActual[1];
            }


            return ".";
        }

    }
}
