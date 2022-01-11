namespace ProyectoU6_TallerBD.Producto
{
    partial class Producto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Producto));
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.img = new System.Windows.Forms.Panel();
            this.txt_categoria = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_existencias = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.txt_precioC = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txt_precioV = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txt_nombreProd = new System.Windows.Forms.TextBox();
            this.lblCosto = new System.Windows.Forms.Label();
            this.txt_codProd = new System.Windows.Forms.TextBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.txt_proveedor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.Gold;
            this.btnRegresar.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.Color.White;
            this.btnRegresar.Location = new System.Drawing.Point(22, 532);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(945, 46);
            this.btnRegresar.TabIndex = 20;
            this.btnRegresar.Text = "Regresar menu";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.LightSalmon;
            this.btnModificar.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(606, 247);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(349, 56);
            this.btnModificar.TabIndex = 19;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.LightSalmon;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAgregar.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnAgregar.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(263, 247);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(335, 56);
            this.btnAgregar.TabIndex = 16;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblTitulo.Location = new System.Drawing.Point(179, 9);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(288, 46);
            this.lblTitulo.TabIndex = 14;
            this.lblTitulo.Text = "PRODUCTOS";
            // 
            // dgvProductos
            // 
            this.dgvProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos.ColumnHeadersHeight = 29;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProductos.Location = new System.Drawing.Point(22, 311);
            this.dgvProductos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvProductos.MultiSelect = false;
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowHeadersWidth = 51;
            this.dgvProductos.Size = new System.Drawing.Size(933, 213);
            this.dgvProductos.TabIndex = 15;
            this.dgvProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellContentClick);
            // 
            // img
            // 
            this.img.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("img.BackgroundImage")));
            this.img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.img.Location = new System.Drawing.Point(22, 59);
            this.img.Margin = new System.Windows.Forms.Padding(4);
            this.img.Name = "img";
            this.img.Size = new System.Drawing.Size(233, 233);
            this.img.TabIndex = 10;
            // 
            // txt_categoria
            // 
            this.txt_categoria.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_categoria.Location = new System.Drawing.Point(759, 114);
            this.txt_categoria.Margin = new System.Windows.Forms.Padding(4);
            this.txt_categoria.Name = "txt_categoria";
            this.txt_categoria.Size = new System.Drawing.Size(196, 30);
            this.txt_categoria.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(643, 121);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 23);
            this.label2.TabIndex = 56;
            this.label2.Text = "Categoria";
            // 
            // txt_existencias
            // 
            this.txt_existencias.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_existencias.Location = new System.Drawing.Point(759, 160);
            this.txt_existencias.Margin = new System.Windows.Forms.Padding(4);
            this.txt_existencias.Name = "txt_existencias";
            this.txt_existencias.Size = new System.Drawing.Size(196, 30);
            this.txt_existencias.TabIndex = 53;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblStock.Location = new System.Drawing.Point(626, 168);
            this.lblStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(125, 23);
            this.lblStock.TabIndex = 55;
            this.lblStock.Text = "Existencias";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblModelo.Location = new System.Drawing.Point(633, 70);
            this.lblModelo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(118, 23);
            this.lblModelo.TabIndex = 54;
            this.lblModelo.Text = "Proveedor";
            // 
            // txt_precioC
            // 
            this.txt_precioC.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_precioC.Location = new System.Drawing.Point(429, 209);
            this.txt_precioC.Margin = new System.Windows.Forms.Padding(4);
            this.txt_precioC.Name = "txt_precioC";
            this.txt_precioC.Size = new System.Drawing.Size(196, 30);
            this.txt_precioC.TabIndex = 52;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblMarca.Location = new System.Drawing.Point(255, 208);
            this.lblMarca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(166, 23);
            this.lblMarca.TabIndex = 51;
            this.lblMarca.Text = "Precio_Compra";
            // 
            // txt_precioV
            // 
            this.txt_precioV.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_precioV.Location = new System.Drawing.Point(429, 161);
            this.txt_precioV.Margin = new System.Windows.Forms.Padding(4);
            this.txt_precioV.Name = "txt_precioV";
            this.txt_precioV.Size = new System.Drawing.Size(196, 30);
            this.txt_precioV.TabIndex = 50;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblDescripcion.Location = new System.Drawing.Point(275, 160);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(146, 23);
            this.lblDescripcion.TabIndex = 49;
            this.lblDescripcion.Text = "Precio_Venta";
            // 
            // txt_nombreProd
            // 
            this.txt_nombreProd.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombreProd.Location = new System.Drawing.Point(429, 111);
            this.txt_nombreProd.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nombreProd.Name = "txt_nombreProd";
            this.txt_nombreProd.Size = new System.Drawing.Size(196, 30);
            this.txt_nombreProd.TabIndex = 48;
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCosto.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblCosto.Location = new System.Drawing.Point(328, 114);
            this.lblCosto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(93, 23);
            this.lblCosto.TabIndex = 47;
            this.lblCosto.Text = "Nombre";
            // 
            // txt_codProd
            // 
            this.txt_codProd.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codProd.Location = new System.Drawing.Point(429, 63);
            this.txt_codProd.Margin = new System.Windows.Forms.Padding(4);
            this.txt_codProd.Name = "txt_codProd";
            this.txt_codProd.Size = new System.Drawing.Size(196, 30);
            this.txt_codProd.TabIndex = 46;
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClave.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblClave.Location = new System.Drawing.Point(341, 66);
            this.lblClave.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(80, 23);
            this.lblClave.TabIndex = 45;
            this.lblClave.Text = "Codigo";
            // 
            // txt_proveedor
            // 
            this.txt_proveedor.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_proveedor.Location = new System.Drawing.Point(759, 63);
            this.txt_proveedor.Margin = new System.Windows.Forms.Padding(4);
            this.txt_proveedor.Name = "txt_proveedor";
            this.txt_proveedor.Size = new System.Drawing.Size(196, 30);
            this.txt_proveedor.TabIndex = 59;
            // 
            // Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(980, 591);
            this.Controls.Add(this.txt_proveedor);
            this.Controls.Add(this.txt_categoria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_existencias);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.txt_precioC);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.txt_precioV);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.txt_nombreProd);
            this.Controls.Add(this.lblCosto);
            this.Controls.Add(this.txt_codProd);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.img);
            this.Name = "Producto";
            this.Text = "Producto";
            this.Load += new System.EventHandler(this.Producto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Panel img;
        public System.Windows.Forms.TextBox txt_categoria;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txt_existencias;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblModelo;
        public System.Windows.Forms.TextBox txt_precioC;
        private System.Windows.Forms.Label lblMarca;
        public System.Windows.Forms.TextBox txt_precioV;
        private System.Windows.Forms.Label lblDescripcion;
        public System.Windows.Forms.TextBox txt_nombreProd;
        private System.Windows.Forms.Label lblCosto;
        public System.Windows.Forms.TextBox txt_codProd;
        private System.Windows.Forms.Label lblClave;
        public System.Windows.Forms.TextBox txt_proveedor;
    }
}