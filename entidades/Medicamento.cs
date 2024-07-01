using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace actividad_2_plataformas_de_desarrollo.entidades
{
    public class Medicamento

    {
        public String nombre;
        public String tipo;

        public Medicamento(String nombre, String tipo)
        {
            this.nombre = nombre;
            this.tipo = tipo;
        }
        public String getNombre() { return nombre; }    
        public String getTipo() { return tipo; }

        public void setNombre(String nombre) { this.nombre = nombre; }
        public void setTipo(String tipo) { this.tipo = tipo; }





    }
}
