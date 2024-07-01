using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace actividad_2_plataformas_de_desarrollo.entidades
{
    public class Sucursal
    {
        public String nombre;
        public String direccion;

        public Sucursal(String nombre, String direccion)
        {
            this.nombre = nombre;
            this.direccion = direccion;
        }

        public String getNombre()
        {
            return this.nombre;
        }

        public void setNombre(String nombre)
        {
            this.nombre = nombre;
        }

        public String getDireccion()
        {
            return this.direccion;
        }

        public void setDireccion(String tipo)
        {
            this.direccion = tipo;
        }

    }
}
