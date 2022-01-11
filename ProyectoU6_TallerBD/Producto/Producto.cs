using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoU6_TallerBD.Producto
{
    public partial class Producto : Form
    {
        public Producto()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Conexion.Conexion.Conectar();
            //consulta
            String AltaProducto = "INSERT INTO PRODUCTO(cod_producto,nombre,precio_venta,precio_compra,proveedor,categoria,existencias) " +
            "VALUES (@cod_producto,@nombre,@precio_venta,@precio_compra,@proveedor,@categoria,@existencias)";
            SqlCommand cmd1 = new SqlCommand(AltaProducto, Conexion.Conexion.Conectar());
            cmd1.Parameters.AddWithValue("@cod_producto", txt_codProd.Text);
            cmd1.Parameters.AddWithValue("@nombre", txt_nombreProd.Text);
            cmd1.Parameters.AddWithValue("@precio_venta", txt_precioV.Text);
            cmd1.Parameters.AddWithValue("@precio_compra", txt_precioC.Text);
            cmd1.Parameters.AddWithValue("@proveedor", txt_proveedor.Text);
            cmd1.Parameters.AddWithValue("@categoria", txt_categoria.Text);
            cmd1.Parameters.AddWithValue("@existencias", txt_existencias.Text);

            cmd1.ExecuteNonQuery();
            MessageBox.Show("Producto dado de alta exitosamente!!");

            dgvProductos.DataSource = llenar_grid();

            txt_codProd.Text = "";
            txt_nombreProd.Text = "";
            txt_precioV.Text = "";
            txt_precioC.Text = "";
            txt_proveedor.Text = "";
            txt_categoria.Text = "";
            txt_existencias.Text = "";
        }

        private void Producto_Load(object sender, EventArgs e)
        {
            dgvProductos.DataSource = llenar_grid();
        }

        public DataTable llenar_grid()
        {
            Conexion.Conexion.Conectar();
            DataTable dt = new DataTable();
            //consulta
            String consulta = "SELECT * FROM PRODUCTO";
            SqlCommand cmd = new SqlCommand(consulta, Conexion.Conexion.Conectar());

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);
            return dt;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 formPrincipal = new Form1();
            formPrincipal.Show();
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_codProd.Text = dgvProductos.CurrentRow.Cells[0].Value.ToString();
            txt_nombreProd.Text = dgvProductos.CurrentRow.Cells[1].Value.ToString();
            txt_precioV.Text = dgvProductos.CurrentRow.Cells[2].Value.ToString();
            txt_precioC.Text = dgvProductos.CurrentRow.Cells[3].Value.ToString();
            txt_proveedor.Text = dgvProductos.CurrentRow.Cells[4].Value.ToString();
            txt_categoria.Text = dgvProductos.CurrentRow.Cells[5].Value.ToString();
            txt_existencias.Text = dgvProductos.CurrentRow.Cells[6].Value.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Conexion.Conexion.Conectar();
            //consulta
            String BajaEmpleado = "DELETE FROM PRODUCTO WHERE cod_producto = @cod_producto";
            SqlCommand cmd3 = new SqlCommand(BajaEmpleado, Conexion.Conexion.Conectar());
            cmd3.Parameters.AddWithValue("@cod_producto", txt_codProd.Text);

            cmd3.ExecuteNonQuery();
            MessageBox.Show("Producto eliminado exitosamente.");

            dgvProductos.DataSource = llenar_grid();

            txt_codProd.Text = "";
            txt_nombreProd.Text = "";
            txt_precioV.Text = "";
            txt_precioC.Text = "";
            txt_proveedor.Text = "";
            txt_categoria.Text = "";
            txt_existencias.Text = "";

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Conexion.Conexion.Conectar();
            //consulta
            var ModProd = "UPDATE PRODUCTO set nombre = @nombre, precio_venta = @precio_venta, precio_compra = @precio_compra, proveedor = @proveedor, categoria = @categoria,existencias = @existencias WHERE cod_producto = @cod_producto";
            SqlCommand cmd2 = new SqlCommand(ModProd, Conexion.Conexion.Conectar());
            cmd2.Parameters.AddWithValue("@cod_producto", txt_codProd.Text);
            cmd2.Parameters.AddWithValue("@nombre", txt_nombreProd.Text);
            cmd2.Parameters.AddWithValue("@precio_venta", txt_precioV.Text);
            cmd2.Parameters.AddWithValue("@precio_compra", txt_precioC.Text);
            cmd2.Parameters.AddWithValue("@proveedor", txt_proveedor.Text);
            cmd2.Parameters.AddWithValue("@categoria", txt_categoria.Text);
            cmd2.Parameters.AddWithValue("@existencias", txt_existencias.Text);

            cmd2.ExecuteNonQuery();
            MessageBox.Show("Producto modificado exitosamente!!");

            dgvProductos.DataSource = llenar_grid();

            txt_codProd.Text = "";
            txt_nombreProd.Text = "";
            txt_precioV.Text = "";
            txt_precioC.Text = "";
            txt_proveedor.Text = "";
            txt_categoria.Text = "";
            txt_existencias.Text = "";
        }
    }
}
