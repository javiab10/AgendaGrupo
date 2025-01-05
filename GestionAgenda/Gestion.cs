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

        public List<Grupos> DevolverTodosLosGrupos()
        {
            return agendaEntities.Grupos.ToList();
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
                Console.Write(nuevoGrupo.IdGrupo);
                agendaEntities.Grupos.Add(nuevoGrupo);
                agendaEntities.SaveChanges();

                return $"Grupo '{nombreGrupo}' añadido correctamente.";
            }
            catch (Exception ex)
            {
                return $"Error al agregar el grupo: {ex.Message}";
            }
        }

        public void EditarGrupo(int idGrupo,string nuevoNombre, out string errores) {


            errores = "";
            if (String.IsNullOrWhiteSpace(nuevoNombre))
            {
                errores = "EL NOMBRE NO PUEDE ESTAR VACIO";
                return;
            }

            if (!agendaEntities.Grupos.Any(grp => grp.IdGrupo == idGrupo))
            {
                errores = "EL GRUPO NO EXISTE";
                return;
            }


            var grupo = agendaEntities.Grupos.Find(idGrupo);
            grupo.NombreGrupo = nuevoNombre;

            try
            {
                agendaEntities.SaveChanges();
            }
            catch (Exception exc)
            {
                errores = exc.Message;
            }
        }

        public void EditarTelefono(string numTelef, string descripcion, out string errores)
        {


            errores = "";
            if (String.IsNullOrWhiteSpace(numTelef))
            {
                errores = "EL TELEFONO NO PUEDE ESTAR VACIO";
                return;
            }
            if (String.IsNullOrWhiteSpace(descripcion))
            {
                errores = "LA DESCRIPCIÓN NO PUEDE ESTAR VACIA";
                return;
            }

            if (!agendaEntities.Telefonos.Any(tel => tel.Numero == numTelef))
            {
                errores = "ESE TELÉFONO YA EXISTE";
                return;
            }

            Telefono telef = new Telefono();
            telef.Numero = numTelef;
            telef.Descripcion = descripcion;

            try
            {
                agendaEntities.SaveChanges();
            }
            catch (Exception exc)
            {
                errores = exc.Message;
            }
        }


        public void BorrarGrupo(int idGrupo, out string errores) {
            errores = "";
            try
            {
                Grupos grupo = agendaEntities.Grupos.Find(idGrupo);

                if (grupo == null)
                {
                    errores = $"No se encontró el grupo con ID {idGrupo}.";
                    return;
                }

                agendaEntities.Grupos.Remove(grupo);
                agendaEntities.SaveChanges();
            }
            catch (Exception exc)
            {
                errores = exc.Message;
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

            if (contacto.Telefonos.Contains(new Telefono (telefonoStr,"")))
            {
                errores = "EL CONTACTO YA TIENE ESE NUMERO AGENDADO";
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
        public List<Telefono> DevolverListaTelefonos()
        {
            return agendaEntities.Telefonos.ToList();
        }

        public void CrearContacto(Contacto contacto,out String errores) {
            errores = "";


            if (contacto.IdGrupo != null && agendaEntities.Grupos.FirstOrDefault(grupo => grupo.IdGrupo == contacto.IdGrupo) == null)
            {
                errores = "EL GRUPO SELECCIONADO NO EXISTE";
                return;
            }


            if (agendaEntities.Contactos.Any(contact => contact.Nombre.Equals(contacto.Nombre,StringComparison.OrdinalIgnoreCase)))
            {
                errores = "YA EXISTE UN CONTACTO CON ESE NOMBRE";
                return;

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


        public Contacto ContactoById(int identificador, out string mensaje)
        {
            mensaje = "";

            try
            {
                Contacto contacto = agendaEntities.Contactos.Find(identificador);

                if (contacto != null)
                {
                    if (contacto.IdGrupo == null)
                    {
                        mensaje = "Teléfonos del contacto: '" + contacto.Nombre + "' , no tiene grupo.";
                        return contacto;
                    }

                    mensaje = "Teléfonos del contacto: '" + contacto.Nombre + "' del grupo: '" + contacto.Grupos.NombreGrupo + "'";
                    return contacto;
                }
            }
            catch (Exception exc)
            {
                mensaje = exc.Message;
            }

            mensaje = "No existe ningún contacto con identificador '" + identificador + "'";
            return null;
        }

        public List<Contacto> DevolverContactosPorTelefono(String numeroTelefonoStr, out String errores)
        {
            errores = "";

            if (!int.TryParse(numeroTelefonoStr, out int numeroTelefono))
            {
                errores = "EL NUMERO DE TELEFONO TIENE QUE SER NUMERICO";
                return null;
            }

            if (numeroTelefonoStr.Length < 3)
            {
                errores = "EL NUMERO DE TELEFONO TIENE QUE SER DE 3 O MAS DIGITOS";
                return null;
            }


           return agendaEntities.Contactos.Where(contacto => contacto.Telefonos.Any(telf => telf.Numero == numeroTelefonoStr)).ToList();

        }


        public bool BorrarContacto(int idContacto, out string mensaje)
        {
            mensaje = "";
            try
            {
                Contacto contactoABorrar = agendaEntities.Contactos.Find(idContacto);
                contactoABorrar.Telefonos.Clear();
                string nombreContactoABorrar = contactoABorrar.Nombre;

                agendaEntities.Contactos.Remove(contactoABorrar);
                int numeroAfectados = agendaEntities.SaveChanges();

                if (numeroAfectados > 0)
                {
                    mensaje = $"Contacto {nombreContactoABorrar} borrado con éxito! CRIS filas affect: {numeroAfectados}";
                    return true;
                }
            }
            catch (Exception exc)
            {
                mensaje = exc.Message;
            }

            return false;
        }
    }
}
