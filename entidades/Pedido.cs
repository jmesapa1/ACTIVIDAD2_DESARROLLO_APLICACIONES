using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace actividad_2_plataformas_de_desarrollo.entidades
{
    public class Pedido
    {

        public Medicamento medicamento;
        public int cantidad;
        public String proovedor;
        public Sucursal sucursal;

        public Pedido(Medicamento medicamento, int cantidad, String proovedor, Sucursal sucursal)
        {
            this.medicamento = medicamento;
            this.cantidad = cantidad;
            this.proovedor = proovedor;
            this.sucursal = sucursal;
        }

        public Medicamento getMedicamento()
        {
            return medicamento;
        }

        public void setMedicamento(Medicamento medicamento)
        {
            this.medicamento = medicamento;
        }

        public int getCantidad()
        {
            return cantidad;
        }

        public void setCantidad(int cantidad)
        {
            this.cantidad = cantidad;
        }

        public String getProovedor()
        {
            return proovedor;
        }

        public void setProovedor(String proovedor)
        {
            this.proovedor = proovedor;
        }

        public Sucursal getSucursal()
        {
            return sucursal;
        }

        public void setSucursal(Sucursal sucursal)
        {
            this.sucursal = sucursal;
        }


    }
}
