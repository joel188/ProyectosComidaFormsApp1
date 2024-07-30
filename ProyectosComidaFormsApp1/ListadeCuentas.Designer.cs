namespace RegistrodePedidoFormsApp1
{
    partial class ListadeCuentas
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NombredelEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumerodelEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombredelCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumerodelCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Menu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ubicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saveDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombredelEmpleado,
            this.NumerodelEmpleado,
            this.NombredelCliente,
            this.NumerodelCliente,
            this.Menu,
            this.Calificacion,
            this.Ubicacion});
            this.dataGridView1.DataSource = this.bindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(950, 363);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // NombredelEmpleado
            // 
            this.NombredelEmpleado.DataPropertyName = "nomEmptxt";
            this.NombredelEmpleado.HeaderText = "Nombre del Empleado";
            this.NombredelEmpleado.MinimumWidth = 6;
            this.NombredelEmpleado.Name = "NombredelEmpleado";
            this.NombredelEmpleado.ReadOnly = true;
            this.NombredelEmpleado.Width = 125;
            // 
            // NumerodelEmpleado
            // 
            this.NumerodelEmpleado.DataPropertyName = "numEmptxt";
            this.NumerodelEmpleado.HeaderText = "Numero del empleado";
            this.NumerodelEmpleado.MinimumWidth = 6;
            this.NumerodelEmpleado.Name = "NumerodelEmpleado";
            this.NumerodelEmpleado.ReadOnly = true;
            this.NumerodelEmpleado.Width = 125;
            // 
            // NombredelCliente
            // 
            this.NombredelCliente.DataPropertyName = "nombClientxt";
            this.NombredelCliente.HeaderText = "Nombre del Cliente";
            this.NombredelCliente.MinimumWidth = 6;
            this.NombredelCliente.Name = "NombredelCliente";
            this.NombredelCliente.ReadOnly = true;
            this.NombredelCliente.Width = 125;
            // 
            // NumerodelCliente
            // 
            this.NumerodelCliente.DataPropertyName = "numClientxt";
            this.NumerodelCliente.HeaderText = "Numero del Cliente";
            this.NumerodelCliente.MinimumWidth = 6;
            this.NumerodelCliente.Name = "NumerodelCliente";
            this.NumerodelCliente.ReadOnly = true;
            this.NumerodelCliente.Width = 125;
            // 
            // Menu
            // 
            this.Menu.DataPropertyName = "comboMenu";
            this.Menu.HeaderText = "Menu";
            this.Menu.MinimumWidth = 6;
            this.Menu.Name = "Menu";
            this.Menu.ReadOnly = true;
            this.Menu.Width = 125;
            // 
            // Calificacion
            // 
            this.Calificacion.DataPropertyName = "comboCalificacion";
            this.Calificacion.HeaderText = "Calificacion";
            this.Calificacion.MinimumWidth = 6;
            this.Calificacion.Name = "Calificacion";
            this.Calificacion.ReadOnly = true;
            this.Calificacion.Width = 125;
            // 
            // Ubicacion
            // 
            this.Ubicacion.DataPropertyName = "ubicaciontxt";
            this.Ubicacion.HeaderText = "Ubicacion";
            this.Ubicacion.MinimumWidth = 6;
            this.Ubicacion.Name = "Ubicacion";
            this.Ubicacion.ReadOnly = true;
            this.Ubicacion.Width = 125;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(869, 22);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(79, 29);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(869, 438);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(93, 33);
            this.btnNuevo.TabIndex = 3;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // ListadeCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 483);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ListadeCuentas";
            this.Text = "Lista de Cuentas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSource;
        private System.Windows.Forms.SaveFileDialog saveDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombredelEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumerodelEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombredelCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumerodelCliente;
        private new System.Windows.Forms.DataGridViewTextBoxColumn Menu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ubicacion;
        private System.Windows.Forms.Button btnNuevo;
    }
}

