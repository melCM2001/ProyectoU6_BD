using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoU6_TallerBD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProyectoU6_TallerBD.Empleado.Empleado FormEmpleado = new Empleado.Empleado();
            FormEmpleado.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProyectoU6_TallerBD.Proveedor.Proveedor FormProv = new Proveedor.Proveedor();
            FormProv.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProyectoU6_TallerBD.Producto.Producto FormProd = new Producto.Producto();
            FormProd.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProyectoU6_TallerBD.Venta.Venta FormVenta = new Venta.Venta();
            FormVenta.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }
    }
}
