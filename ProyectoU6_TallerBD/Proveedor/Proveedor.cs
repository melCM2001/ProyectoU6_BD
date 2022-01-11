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

namespace ProyectoU6_TallerBD.Proveedor
{
    public partial class Proveedor : Form
    {
        public Proveedor()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 formPrincipal = new Form1();
            formPrincipal.Show();
        }

        private void Proveedor_Load(object sender, EventArgs e)
        {
            dgvProveedor.DataSource = llenar_grid();
        }

        public DataTable llenar_grid()
        {
            Conexion.Conexion.Conectar();
            DataTable dt = new DataTable();
            //consulta
            String consulta = "SELECT * FROM PROVEEDOR";
            SqlCommand cmd = new SqlCommand(consulta, Conexion.Conexion.Conectar());

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);
            return dt;
        }

        private void dgvProveedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_codProveedor.Text = dgvProveedor.CurrentRow.Cells[0].Value.ToString();
            txt_codProducto.Text = dgvProveedor.CurrentRow.Cells[1].Value.ToString();
            txt_nombreProveedor.Text = dgvProveedor.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Conexion.Conexion.Conectar();
            //consulta
            String AltaP = "INSERT INTO PROVEEDOR(cod_proveedor,cod_producto,nombre_proveedor)VALUES(@cod_proveedor, @cod_producto, @nombre_proveedor)";
            SqlCommand cmd1 = new SqlCommand(AltaP, Conexion.Conexion.Conectar());
            cmd1.Parameters.AddWithValue("@cod_proveedor", txt_codProveedor.Text);
            cmd1.Parameters.AddWithValue("@cod_producto", txt_codProducto.Text);
            cmd1.Parameters.AddWithValue("@nombre_proveedor", txt_nombreProveedor.Text);

            cmd1.ExecuteNonQuery();
            MessageBox.Show("Proveedor dado de alta exitosamente!!");

            dgvProveedor.DataSource = llenar_grid();

            txt_codProveedor.Text = "";
            txt_codProducto.Text = "";
            txt_nombreProveedor.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Conexion.Conexion.Conectar();
            //consulta
            String BajaP = "DELETE FROM PROVEEDOR WHERE cod_proveedor = @cod_proveedor";
            SqlCommand cmd3 = new SqlCommand(BajaP, Conexion.Conexion.Conectar());
            cmd3.Parameters.AddWithValue("@cod_proveedor", txt_codProveedor.Text);

            cmd3.ExecuteNonQuery();
            MessageBox.Show("Proveedor eliminado!");

            dgvProveedor.DataSource = llenar_grid();

            txt_codProveedor.Text = "";
            txt_codProducto.Text = "";
            txt_nombreProveedor.Text = "";
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Conexion.Conexion.Conectar();
            //consulta
            var ModProd = "UPDATE PROVEEDOR set cod_proveedor = @cod_proveedor,cod_producto = @cod_producto,nombre_proveedor = @nombre_proveedor WHERE cod_proveedor = @cod_proveedor";
            SqlCommand cmd2 = new SqlCommand(ModProd, Conexion.Conexion.Conectar());
            cmd2.Parameters.AddWithValue("@cod_proveedor", txt_codProveedor.Text);
            cmd2.Parameters.AddWithValue("@cod_producto", txt_codProducto.Text);
            cmd2.Parameters.AddWithValue("@nombre_proveedor", txt_nombreProveedor.Text);

            cmd2.ExecuteNonQuery();
            MessageBox.Show("Proveedor modificado!");

            dgvProveedor.DataSource = llenar_grid();

            txt_codProveedor.Text = "";
            txt_codProducto.Text = "";
            txt_nombreProveedor.Text = "";
        }
    }
}
