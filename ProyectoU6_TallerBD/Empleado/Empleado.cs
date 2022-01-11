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

namespace ProyectoU6_TallerBD.Empleado
{
    public partial class Empleado : Form
    {
        public Empleado()
        {
            InitializeComponent();
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Conexion.Conexion.Conectar();
            //consulta
            String AltaEmpleado = "INSERT INTO EMPLEADO(cod_empleado,nombre_empleado,puestro,horario) VALUES (@cod_empleado,@nombre_empleado,@puestro,@horario)";
            SqlCommand cmd1 = new SqlCommand(AltaEmpleado,Conexion.Conexion.Conectar());
            cmd1.Parameters.AddWithValue("@cod_empleado", txt_codEmp.Text);
            cmd1.Parameters.AddWithValue("@nombre_empleado", txt_nombreEmp.Text);
            cmd1.Parameters.AddWithValue("@puestro", txt_puestoEmp.Text);
            cmd1.Parameters.AddWithValue("@horario", txt_horarioEmp.Text);

            cmd1.ExecuteNonQuery();
            MessageBox.Show("Empleado dado de alta exitosamente!!");

            dgvEmpleados.DataSource = llenar_grid();

            txt_codEmp.Text = "";
            txt_nombreEmp.Text = "";
            txt_puestoEmp.Text = "";
            txt_horarioEmp.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Conexion.Conexion.Conectar();
            //consulta
            String BajaEmpleado = "DELETE FROM EMPLEADO WHERE cod_empleado = @cod_empleado";
            SqlCommand cmd3 = new SqlCommand(BajaEmpleado, Conexion.Conexion.Conectar());
            cmd3.Parameters.AddWithValue("@cod_empleado", txt_codEmp.Text);

            cmd3.ExecuteNonQuery();
            MessageBox.Show("Empleado eliminado exitosamente.");

            dgvEmpleados.DataSource = llenar_grid();

            txt_codEmp.Text = "";
            txt_nombreEmp.Text = "";
            txt_puestoEmp.Text = "";
            txt_horarioEmp.Text = "";
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Conexion.Conexion.Conectar();
            //consulta
            var ModEmpleado = "UPDATE EMPLEADO set cod_empleado = @cod_empleado, nombre_empleado = @nombre_empleado, puestro = @puestro, horario = @horario WHERE cod_empleado = @cod_empleado";
            SqlCommand cmd2 = new SqlCommand(ModEmpleado, Conexion.Conexion.Conectar());
            cmd2.Parameters.AddWithValue("@cod_empleado", txt_codEmp.Text);
            cmd2.Parameters.AddWithValue("@nombre_empleado", txt_nombreEmp.Text);
            cmd2.Parameters.AddWithValue("@puestro", txt_puestoEmp.Text);
            cmd2.Parameters.AddWithValue("@horario", txt_horarioEmp.Text);

            cmd2.ExecuteNonQuery();
            MessageBox.Show("Empleado modificado exitosamente!!");

            dgvEmpleados.DataSource = llenar_grid();

            txt_codEmp.Text = "";
            txt_nombreEmp.Text = "";
            txt_puestoEmp.Text = "";
            txt_horarioEmp.Text = "";
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 formPrincipal = new Form1();
            formPrincipal.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_codEmp.Text = dgvEmpleados.CurrentRow.Cells[0].Value.ToString();
            txt_nombreEmp.Text = dgvEmpleados.CurrentRow.Cells[1].Value.ToString();
            txt_puestoEmp.Text = dgvEmpleados.CurrentRow.Cells[2].Value.ToString();
            txt_horarioEmp.Text = dgvEmpleados.CurrentRow.Cells[3].Value.ToString();

        }

        private void Empleado_Load(object sender, EventArgs e)
        {
            dgvEmpleados.DataSource = llenar_grid();
        }

        public DataTable llenar_grid() {
            Conexion.Conexion.Conectar();
            DataTable dt = new DataTable();
            //consulta
            String consulta = "SELECT * FROM EMPLEADO";
            SqlCommand cmd = new SqlCommand(consulta, Conexion.Conexion.Conectar());

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);
            return dt;
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
