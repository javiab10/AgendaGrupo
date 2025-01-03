using Entidades;
using Servidores;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Configuration;
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
        //TODO: SOLUCIONAR ERROR DE OUTOFMEMORYEXCEPTION
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
                Console.Write(nuevoGrupo.IdGrupo);
                agendaEntities.Grupos.Add(nuevoGrupo);
                agendaEntities.SaveChanges();

                // TODO : FALTA GUARDAR EN BBDD

                return $"Grupo '{nombreGrupo}' añadido correctamente.";
            }
            catch (Exception ex)
            {
                return $"Error al agregar el grupo: {ex.Message}";
            }
        }

        public void AnadirTelefonoAContacto(String telefonoStr, String descripcion, Contacto contacto, out string errores)
        {
            errores = "";

            if (agendaEntities.Contactos.FirstOrDefault(contactoLista => contactoLista.IdContacto == contacto.IdContacto) == null)
            {
                errores = "El contacto no existe";
                return;
            }

            if (String.IsNullOrWhiteSpace(telefonoStr) && String.IsNullOrWhiteSpace(descripcion))
            {
                errores = "LOS CAMPOS NO PUEDEN ESTAR VACIOS";
                return;
            }

            if (!int.TryParse(telefonoStr, out int telefono))
            {
                errores = "TIENE QUE SER UN TELEFONO NUMERICO";
                return;
            }

            if (telefonoStr.Length < 3)
            {
                errores = "EL NUMERO DE TELEFONO TIENE QUE SER DE 3 O MAS DIGITOS";
                return;
            }

            try
            {
                agendaEntities.Telefonos.Add(new Telefono(contacto.IdContacto, telefonoStr, descripcion, contacto));
                agendaEntities.SaveChanges();
            }
            catch (Exception exc)
            {

                errores = exc.Message;
            }
        }

        public string BorrarTelefono(int idContacto, string numeroTelefono)
        {
            try
            {
                var contacto = agendaEntities.Contactos.Find(idContacto);

                if (contacto == null)
                {
                    return $"No se encontró el contacto con ID {idContacto}.";
                }

                var telefono = contacto.Telefonos.FirstOrDefault(t => t.Numero == numeroTelefono);

                if (telefono == null)
                {
                    return $"El contacto no tiene el teléfono {numeroTelefono}.";
                }

                contacto.Telefonos.Remove(telefono);
                agendaEntities.SaveChanges();

                return $"Teléfono {numeroTelefono} borrado correctamente del contacto {contacto.Nombre}.";
            }
            catch (Exception ex)
            {
                return $"Error al borrar el teléfono: {ex.Message}";
            }
        }

        public List<Grupos> DevolverListaGrupos() { 
            return agendaEntities.Grupos.ToList();
        }

        public void CrearContacto(Contacto contacto,out String errores) {
            errores = "";


            if (contacto.IdGrupo != null && agendaEntities.Grupos.FirstOrDefault(grupo => grupo.IdGrupo == contacto.IdGrupo) == null)
            {
                errores = "EL GRUPO SELECCIONADO NO EXISTE";
            }

            

            try
            {
                agendaEntities.Contactos.Add(contacto);
                agendaEntities.SaveChanges();
            }
            catch (Exception)
            {
                errores = "HA HABIDO ALGUN PROBLEMA A LA HORA DE CREAR EL CONTACTO. POR FAVOR INTENTELO MÁS TARDE";
            }
            
        }

        public Contacto DevolverContactoPorId(int id)
        {
            List<Contacto> contactos = DevolverTodosLosContactos();

            var contactoPorId = contactos.Find(contacto => contacto.IdContacto == id);

            return contactoPorId;
        }


    }
}
