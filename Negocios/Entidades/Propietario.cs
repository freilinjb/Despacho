using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios.Entidades
{
    public class Propietario
    {
        public int IdPropietario;
        public string Nombre;
        public string Apellido;
        public string Apodo;
        public int IdTipoTelefono;
        public string Telefono;
        public string Correo;
        public string Observacion;
        public bool Estado;

        public Propietario(int idPropietario, string nombre, string apellido, string apodo, int idTipoTelefono, string telefono, string correo, string observacion, bool estado)
        {
            IdPropietario = idPropietario;
            Nombre = nombre;
            Apellido = apellido;
            Apodo = apodo;
            IdTipoTelefono = idTipoTelefono;
            Telefono = telefono;
            Correo = correo;
            Observacion = observacion;
            Estado = estado;
        }

        public string guardarRegistro()
        {
            return $"[InsertarPropietario] {IdPropietario}, '{Nombre}', '{Apellido}', '{Apodo}', {IdTipoTelefono}, '{Telefono}', '{Correo}', '{Observacion}', {(Estado ? 1 : 0)}";
        }
    }

}
