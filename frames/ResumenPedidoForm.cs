using actividad_2_plataformas_de_desarrollo.entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace actividad_2_plataformas_de_desarrollo.frames
{
    public partial class ResumenPedidoForm : Form
    {
        public ResumenPedidoForm(Pedido p)
        {
            InitializeComponent();
            distribuidorLbl.Text = p.getProovedor();
            this.Text = p.getProovedor();
            resumenLbl.Text = p.getCantidad() + " unidades del " + p.getMedicamento().getTipo() + " - " + p.getMedicamento().getNombre();
            detalleLbl.Text = "Para la farmacia situada en " + p.getSucursal().getNombre() + " : " + p.getSucursal().getDireccion();
            ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ResumenPedidoForm_Load(object sender, EventArgs e)
        {

        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void enviarBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Pedido enviado");
            Close();
        }
    }
}
