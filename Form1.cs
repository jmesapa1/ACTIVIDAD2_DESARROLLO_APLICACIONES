using actividad_2_plataformas_de_desarrollo.entidades;
using actividad_2_plataformas_de_desarrollo.frames;
using actividad_2_plataformas_de_desarrollo.utilidades;
using System.Collections.Generic;
using System.Drawing.Drawing2D;

namespace actividad_2_plataformas_de_desarrollo;

public partial class Form1 : Form
{
    private Dictionary<String, String> sucursales = new Dictionary<String, String>();

    public Form1()
    {
        sucursales.Add("Primaria", "Calle de la Rosa #28");
        sucursales.Add("Secundaria", "Calle de la Rosa #28");
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void label3_Click(object sender, EventArgs e)
    {

    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
    {

    }

    private void limpiarFormulario(object sender, EventArgs e)
    {
        cantidadTxt.Clear();
        nombreTxt.Clear();
        tipoSelect.SelectedIndex = -1;
        sucursalSelect.SelectedIndex = -1;
        provedorSelect.SelectedIndex = -1;
    }



    private void confirmarPedido(object sender, EventArgs e)
    {
        Validador validador = new Validador();

        String nombre = nombreTxt.Text;
        String cantidad = cantidadTxt.Text;
        String tipo; 
        if(tipoSelect.SelectedIndex < 0) { tipo = ""; } else {
            tipo = tipoSelect.Items[tipoSelect.SelectedIndex].ToString();
        }
        String sucursal; 
        if (sucursalSelect.SelectedIndex < 0) { sucursal = ""; }
        else
        {
            sucursal = sucursalSelect.Items[sucursalSelect.SelectedIndex].ToString();
        }

        String provedor;
        if (provedorSelect.SelectedIndex < 0) { provedor = ""; }
        else
        {
            provedor = provedorSelect.Items[provedorSelect.SelectedIndex].ToString();
        }

        String validacion = validador.validarPedido(nombre, cantidad, tipo, sucursal, provedor);
        if ("" == validacion)
        {
            Medicamento m = new Medicamento(nombre, tipo);
            Sucursal s = new Sucursal(sucursal, sucursales[sucursal]);
            Pedido p = new Pedido(m, int.Parse(cantidad), provedor, s);
            ResumenPedidoForm resumen = new ResumenPedidoForm(p);
        }
        else
        {
            MessageBox.Show(validacion, "ERROR");
        }
    }
}