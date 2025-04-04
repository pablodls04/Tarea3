using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaNegocio
{
    public class ContactoBL
    {
        private ContactoDAL contactoDAL = new ContactoDAL();

        public void Insertar(Contacto contacto)
        {
            if (string.IsNullOrWhiteSpace(contacto.Nombre) || string.IsNullOrWhiteSpace(contacto.Telefono))
            {
                throw new ArgumentException("El nombre y el teléfono son obligatorios.");
            }

            contactoDAL.Insertar(contacto);
        }

        public void Modificar(Contacto contacto)
        {
            if (contacto.Id <= 0)
            {
                throw new ArgumentException("ID de contacto no válido.");
            }

            if (string.IsNullOrWhiteSpace(contacto.Nombre) || string.IsNullOrWhiteSpace(contacto.Telefono))
            {
                throw new ArgumentException("El nombre y el teléfono son obligatorios.");
            }

            contactoDAL.Modificar(contacto);
        }

        public void Eliminar(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("ID de contacto no válido.");
            }

            contactoDAL.Eliminar(id);
        }

        public List<Contacto> Buscar(string nombre)
        {
            return contactoDAL.Buscar(nombre);
        }

        public List<Contacto> ObtenerTodos()
        {
            return contactoDAL.Buscar(""); 
        }
    }
}