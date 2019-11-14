using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios.Entidades
{
    public class Vehiculo
    {
        public string Placa;
        public int IdPropietario;
        public float Capacidad;
        public string Descripcion;
        public string Observacion;
        public bool Estado;

        public Vehiculo(string placa, int idPropietario, float capacidad, string descripcion, string observacion, bool estado)
        {
            Placa = placa;
            IdPropietario = idPropietario;
            Capacidad = capacidad;
            Descripcion = descripcion;
            Observacion = observacion;
            Estado = estado;
        }

        public string guardarRegistro()
        {
            return $"EXEC [InsertarVehiculo] '{Placa}',{IdPropietario},{Capacidad},'{Descripcion}','{Observacion}',{(Estado ? 1 : 0)}";
        }
    }

}
