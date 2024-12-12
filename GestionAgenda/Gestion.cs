using Servidores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAgenda
{
    public class Gestion
    {
        private AgendaEntities agendaEntities;

        public Gestion() 
        {
            try
            {
                string servidor = Servidor.ServidorActual();
                string cadenaConexion = $@"metadata = res://*/ModeloAgenda.csdl|res://*/ModeloAgenda.ssdl|res://*/ModeloAgenda.msl; provider = System.Data.SqlClient;provider connection string= 'data source={servidor};initial catalog=Agenda;integrated security=True;encrypt=True;trustservercertificate=True;MultipleActiveResultSets=True;App=EntityFramework'";
                agendaEntities = new AgendaEntities(cadenaConexion); // Modificar el constructor
            }
            catch (Exception exc)
            {
                // instrucciones ante el error
            }


        }
    }
}
