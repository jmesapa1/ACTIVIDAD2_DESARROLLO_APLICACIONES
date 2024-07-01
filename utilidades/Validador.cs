using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace actividad_2_plataformas_de_desarrollo.utilidades
{
    internal class Validador
    {

        public Validador()
        {
        }

        public String validarPedido(String nombre, String cantidad, String tipo, String sucursal, String provedor)
        {
            if (nombre.Equals(""))
            {
                return "Existe un error en el campo Nombre, debe ingresar un valor";
            }
            else if (!Regex.IsMatch(nombre, @"^[a-zA-Z]+$"))
            {
                return "Existe un error en el campo NOMBRE, no se permiten caracteres especiales";
            }

            if (cantidad.Equals(""))
            {
                return "Existe un error en el campo CANTIDAD, debe ingresar un valor";
            }
            else if (!Regex.IsMatch(cantidad, "^[0-9]*$"))
            {
                return "Existe un error en el campo CANTIDAD, debe ser mayor a 0 y solo contener numeros";
            }
            if (tipo.Equals(""))
            {
                return "Debe elegir un valor de TIPO";
            }
            if (sucursal.Equals(""))
            {
                return "Debe elegir un valor de SUCURSAL";
            }
            if (provedor.Equals(""))
            {
                return "Debe elegir un valor de PROVEDOR";
            }
            return "";
        }
    }
}
