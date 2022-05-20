using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MANTENEDORCLIENTE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string conexion = "Data Source=DESKTOP-A1OPPUQ\\SQLEXPRESS;Initial Catalog=Ventas2022;Integrated Security=True";

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(conexion))
            {
                SqlCommand cmd = new SqlCommand("insert into Cliente(idCliente,nombreCliente,apellidoCliente,ciudadCliente,direccionCliente,celularCliente,estadoCliente) values(" + int.Parse(txtCodigo.Text) + ", '" + txtNombre.Text + "', '" + txtapellido.Text + "', '"+ txtciudad.Text + "', '"+ txtdireccion.Text + "', " + int.Parse(txtcelular.Text) + ", '"+ txtestado.Text +"')", con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                cmd.ExecuteNonQuery();
            }

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(conexion))
            {
                SqlCommand cmd = new SqlCommand("update Cliente set nombreCliente = '" + txtNombre.Text + "', apellidoCliente = '" + txtapellido.Text + "', ciudadCliente = '" + txtciudad.Text + "', direccionCliente = '" + txtdireccion.Text + "',celularCliente = " + int.Parse(txtcelular.Text) + " , estadoCliente = '" + txtestado.Text + "' where idCliente = " + int.Parse(txtCodigo.Text) + "", con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(conexion))
            {
                SqlCommand cmd = new SqlCommand(" delete Cliente  where idCliente = " + int.Parse(txtCodigo.Text), con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
