using Entidades;
using Servidores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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

        public string AgregarGrupo(string nombreGrupo)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(nombreGrupo))
                {
                    return "El nombre del grupo no puede estar vacío.";
                }

                bool existeGrupo = agendaEntities.Grupos.Any(g => g.NombreGrupo == nombreGrupo);

                if (existeGrupo)
                {
                    return $"El grupo '{nombreGrupo}' ya existe.";
                }

                Grupos nuevoGrupo = new Grupos
                {
                    NombreGrupo = nombreGrupo
                };

                agendaEntities.Grupos.Add(nuevoGrupo);

                return $"Grupo '{nombreGrupo}' añadido correctamente.";
            }
            catch (Exception ex)
            {
                return $"Error al agregar el grupo: {ex.Message}";
            }
        }

        public void AnadirTelefonoAContacto(String telefono, String descripcion, Contacto contacto, out string errores)
        {
            errores = "";

            try
            {
                agendaEntities.Telefonos.Add(new Telefono(contacto.IdContacto, telefono, descripcion, contacto));
                agendaEntities.SaveChanges();
            }
            catch (Exception exc)
            {

                errores = exc.Message;
            }
        }

        
    }
}
