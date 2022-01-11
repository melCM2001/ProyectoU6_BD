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

namespace ProyectoU6_TallerBD.Venta
{
    public partial class Venta : Form
    {
        public Venta()
        {
            InitializeComponent();
        }

        private void Venta_Load(object sender, EventArgs e)
        {
            dgvVentas.DataSource = llenar_grid();
        }

        public DataTable llenar_grid()
        {
            Conexion.Conexion.Conectar();
            DataTable dt = new DataTable();
            //consulta
            String consulta = "SELECT * FROM VENTA";
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

        private void dgvVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_codVenta.Text = dgvVentas.CurrentRow.Cells[0].Value.ToString();
            txt_codEmpleado.Text = dgvVentas.CurrentRow.Cells[1].Value.ToString();
            txt_codProducto.Text = dgvVentas.CurrentRow.Cells[2].Value.ToString();
            txt_fecha.Text = dgvVentas.CurrentRow.Cells[3].Value.ToString();
            txt_precio.Text = dgvVentas.CurrentRow.Cells[4].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Conexion.Conexion.Conectar();
            //consulta
            String AltaVenta = "INSERT INTO VENTA(cod_venta,cod_empleado,cod_producto,fecha_venta,precio_venta)VALUES(@cod_venta,@cod_empleado, @cod_producto, @fecha_venta,@precio)";
            SqlCommand cmd1 = new SqlCommand(AltaVenta, Conexion.Conexion.Conectar());
            cmd1.Parameters.AddWithValue("@cod_venta", txt_codVenta.Text);
            cmd1.Parameters.AddWithValue("@cod_empleado", txt_codEmpleado.Text);
            cmd1.Parameters.AddWithValue("@cod_producto", txt_codProducto.Text);
            cmd1.Parameters.AddWithValue("@fecha_venta", txt_fecha.Text);
            cmd1.Parameters.AddWithValue("@precio", txt_precio.Text);

            cmd1.ExecuteNonQuery();
            MessageBox.Show("Venta dado de alta exitosamente!!");

            dgvVentas.DataSource = llenar_grid();

            txt_codVenta.Text = "";
            txt_codEmpleado.Text = "";
            txt_codProducto.Text = "";
            txt_fecha.Text = "";
            txt_precio.Text = "";
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Conexion.Conexion.Conectar();
            //consulta
            var ModV = "update VENTA set cod_venta = @cod_venta, cod_empleado = @cod_empleado, cod_producto = @cod_producto, fecha_venta = @fecha_venta, precio_venta = @precio where cod_venta = @cod_venta";
            SqlCommand cmd2 = new SqlCommand(ModV, Conexion.Conexion.Conectar());
            cmd2.Parameters.AddWithValue("@cod_venta", txt_codVenta.Text);
            cmd2.Parameters.AddWithValue("@cod_empleado", txt_codEmpleado.Text);
            cmd2.Parameters.AddWithValue("@cod_producto", txt_codProducto.Text);
            cmd2.Parameters.AddWithValue("@fecha_venta", txt_fecha.Text);
            cmd2.Parameters.AddWithValue("@precio", txt_precio.Text);

            cmd2.ExecuteNonQuery();
            MessageBox.Show("Venta modificada exitosamente!!");

            dgvVentas.DataSource = llenar_grid();

            txt_codVenta.Text = "";
            txt_codEmpleado.Text = "";
            txt_codProducto.Text = "";
            txt_fecha.Text = "";
            txt_precio.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Conexion.Conexion.Conectar();
            //consulta
            String BajaV = "DELETE FROM VENTA WHERE cod_venta = @cod_venta";
            SqlCommand cmd3 = new SqlCommand(BajaV, Conexion.Conexion.Conectar());
            cmd3.Parameters.AddWithValue("@cod_venta", txt_codVenta.Text);

            cmd3.ExecuteNonQuery();
            MessageBox.Show("Venta eliminada");

            dgvVentas.DataSource = llenar_grid();

            txt_codVenta.Text = "";
            txt_codEmpleado.Text = "";
            txt_codProducto.Text = "";
            txt_fecha.Text = "";
            txt_precio.Text = "";
        }
    }
}
