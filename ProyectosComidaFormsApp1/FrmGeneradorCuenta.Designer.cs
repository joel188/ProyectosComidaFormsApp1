namespace ProyectosComidaFormsApp1
{
    partial class FrmGeneradorCuenta
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nomEmptxt = new System.Windows.Forms.TextBox();
            this.NumEmptxt = new System.Windows.Forms.TextBox();
            this.NumClientxt = new System.Windows.Forms.TextBox();
            this.Ubicaciontxt = new System.Windows.Forms.TextBox();
            this.comboMenu = new System.Windows.Forms.ComboBox();
            this.comboCalificacion = new System.Windows.Forms.ComboBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.NombClientxt = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datos del restaraunte";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero del empleado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numero de cliente";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Menu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nombre del empleado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ubicacion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 332);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Calificacion";
            // 
            // nomEmptxt
            // 
            this.nomEmptxt.Location = new System.Drawing.Point(223, 73);
            this.nomEmptxt.Name = "nomEmptxt";
            this.nomEmptxt.Size = new System.Drawing.Size(250, 22);
            this.nomEmptxt.TabIndex = 7;
            // 
            // NumEmptxt
            // 
            this.NumEmptxt.Location = new System.Drawing.Point(223, 115);
            this.NumEmptxt.Name = "NumEmptxt";
            this.NumEmptxt.Size = new System.Drawing.Size(250, 22);
            this.NumEmptxt.TabIndex = 8;
            // 
            // NumClientxt
            // 
            this.NumClientxt.Location = new System.Drawing.Point(223, 199);
            this.NumClientxt.Name = "NumClientxt";
            this.NumClientxt.Size = new System.Drawing.Size(250, 22);
            this.NumClientxt.TabIndex = 9;
            // 
            // Ubicaciontxt
            // 
            this.Ubicaciontxt.Location = new System.Drawing.Point(223, 285);
            this.Ubicaciontxt.Name = "Ubicaciontxt";
            this.Ubicaciontxt.Size = new System.Drawing.Size(250, 22);
            this.Ubicaciontxt.TabIndex = 10;
            // 
            // comboMenu
            // 
            this.comboMenu.FormattingEnabled = true;
            this.comboMenu.Items.AddRange(new object[] {
            "Filete Miñon",
            "Langosta",
            "Hamburguesa",
            "Sopa de hongos de Miso",
            "Pescado Frito"});
            this.comboMenu.Location = new System.Drawing.Point(223, 241);
            this.comboMenu.Name = "comboMenu";
            this.comboMenu.Size = new System.Drawing.Size(250, 24);
            this.comboMenu.TabIndex = 11;
            // 
            // comboCalificacion
            // 
            this.comboCalificacion.FormattingEnabled = true;
            this.comboCalificacion.Items.AddRange(new object[] {
            "1. Estrella",
            "2. Estrellas",
            "3. Estrellas",
            "4. Estrellas",
            "5. Estrellas"});
            this.comboCalificacion.Location = new System.Drawing.Point(223, 327);
            this.comboCalificacion.Name = "comboCalificacion";
            this.comboCalificacion.Size = new System.Drawing.Size(250, 24);
            this.comboCalificacion.TabIndex = 12;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirmar.Location = new System.Drawing.Point(611, 395);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(82, 33);
            this.btnConfirmar.TabIndex = 13;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Nombre de cliente";
            // 
            // NombClientxt
            // 
            this.NombClientxt.Location = new System.Drawing.Point(223, 157);
            this.NombClientxt.Name = "NombClientxt";
            this.NombClientxt.Size = new System.Drawing.Size(250, 22);
            this.NombClientxt.TabIndex = 15;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(506, 395);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(69, 34);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // FrmGeneradorCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 451);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.NombClientxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.comboCalificacion);
            this.Controls.Add(this.comboMenu);
            this.Controls.Add(this.Ubicaciontxt);
            this.Controls.Add(this.NumClientxt);
            this.Controls.Add(this.NumEmptxt);
            this.Controls.Add(this.nomEmptxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmGeneradorCuenta";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nomEmptxt;
        private System.Windows.Forms.TextBox NumEmptxt;
        private System.Windows.Forms.TextBox NumClientxt;
        private System.Windows.Forms.TextBox Ubicaciontxt;
        private System.Windows.Forms.ComboBox comboMenu;
        private System.Windows.Forms.ComboBox comboCalificacion;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox NombClientxt;
        private System.Windows.Forms.Button btnCancelar;
    }
}

