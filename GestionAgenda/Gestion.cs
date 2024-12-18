﻿using Entidades;
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

        public Gestion(out String errores) 
        {
            errores = "";
            try
            {
                string servidor = Servidor.ServidorActual();
                string cadenaConexion = $@"metadata = res://*/AgendaModel.csdl|res://*/AgendaModel.ssdl|res://*/AgendaModel.msl; provider = System.Data.SqlClient;provider connection string= 'data source={servidor};initial catalog=Agenda;integrated security=True;encrypt=True;trustservercertificate=True;MultipleActiveResultSets=True;App=EntityFramework'";

                agendaEntities = new AgendaEntities(cadenaConexion);
            }
            catch (Exception exc)
            {
                errores = "HA HABIDO UN PROBLEMA" + exc.Message;
            }


        }

       public List<Contacto> DevolverTodosLosContactos()
       {
            return agendaEntities.Contactos.ToList();
       }

        public List<Contacto> DevolverContactosPorNombre()
        {
            List<Contacto> todosLosContactos = DevolverTodosLosContactos();

            var contactosPorNombre = todosLosContactos.OrderBy(con => con.Nombre).ToList();

            return contactosPorNombre;
        }
    }
}
