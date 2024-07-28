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
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Nuevobtn = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombredelEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumerodelEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombredelCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumerodelCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Menu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ubicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.NombredelEmpleado,
            this.NumerodelEmpleado,
            this.NombredelCliente,
            this.NumerodelCliente,
            this.Menu,
            this.Calificacion,
            this.Ubicacion});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(841, 363);
            this.dataGridView1.TabIndex = 0;
            // 
            // Nuevobtn
            // 
            this.Nuevobtn.Location = new System.Drawing.Point(751, 441);
            this.Nuevobtn.Name = "Nuevobtn";
            this.Nuevobtn.Size = new System.Drawing.Size(102, 30);
            this.Nuevobtn.TabIndex = 1;
            this.Nuevobtn.Text = "Nuevo";
            this.Nuevobtn.UseVisualStyleBackColor = true;
            this.Nuevobtn.Click += new System.EventHandler(this.Nuevobtn_Click);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Width = 125;
            // 
            // NombredelEmpleado
            // 
            this.NombredelEmpleado.DataPropertyName = "nomEmptxt";
            this.NombredelEmpleado.HeaderText = "Nombre del Empleado";
            this.NombredelEmpleado.MinimumWidth = 6;
            this.NombredelEmpleado.Name = "NombredelEmpleado";
            this.NombredelEmpleado.Width = 125;
            // 
            // NumerodelEmpleado
            // 
            this.NumerodelEmpleado.DataPropertyName = "NumEmptxt";
            this.NumerodelEmpleado.HeaderText = "Numero del empleado";
            this.NumerodelEmpleado.MinimumWidth = 6;
            this.NumerodelEmpleado.Name = "NumerodelEmpleado";
            this.NumerodelEmpleado.Width = 125;
            // 
            // NombredelCliente
            // 
            this.NombredelCliente.DataPropertyName = "NombClientxt";
            this.NombredelCliente.HeaderText = "Nombre del Cliente";
            this.NombredelCliente.MinimumWidth = 6;
            this.NombredelCliente.Name = "NombredelCliente";
            this.NombredelCliente.Width = 125;
            // 
            // NumerodelCliente
            // 
            this.NumerodelCliente.DataPropertyName = "NumClientxt";
            this.NumerodelCliente.HeaderText = "Numero del Cliente";
            this.NumerodelCliente.MinimumWidth = 6;
            this.NumerodelCliente.Name = "NumerodelCliente";
            this.NumerodelCliente.Width = 125;
            // 
            // Menu
            // 
            this.Menu.HeaderText = "Menu";
            this.Menu.MinimumWidth = 6;
            this.Menu.Name = "Menu";
            this.Menu.Width = 125;
            // 
            // Calificacion
            // 
            this.Calificacion.HeaderText = "Calificacion";
            this.Calificacion.MinimumWidth = 6;
            this.Calificacion.Name = "Calificacion";
            this.Calificacion.Width = 125;
            // 
            // Ubicacion
            // 
            this.Ubicacion.DataPropertyName = "Ubicaciontxt";
            this.Ubicacion.HeaderText = "Ubicacion";
            this.Ubicacion.MinimumWidth = 6;
            this.Ubicacion.Name = "Ubicacion";
            this.Ubicacion.Width = 125;
            // 
            // ListadeCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 483);
            this.Controls.Add(this.Nuevobtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ListadeCuentas";
            this.Text = "Lista de Cuentas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Nuevobtn;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombredelEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumerodelEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombredelCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumerodelCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Menu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ubicacion;
    }
}

