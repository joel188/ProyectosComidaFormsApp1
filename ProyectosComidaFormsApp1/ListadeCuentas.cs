using ProyectosComidaFormsApp1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrodePedidoFormsApp1
{
    public partial class ListadeCuentas : Form
    {
        private List<Cuenta> cuentas;

        public ListadeCuentas()
        {
            InitializeComponent();
            cuentas = new List<Cuenta>();

            this.bindingSource1.DataSource = cuentas;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Nuevobtn_Click(object sender, EventArgs e)
        {
            FrmCuenta frmCuenta = new FrmCuenta();
            frmCuenta.ShowDialog();

            if (frmCuenta.IsConfirmed == true)
            {
                Cuenta Nuevo = new Cuenta(
                this.cuentas.Count + 1,
                frmCuenta.CuentNomEmptxt,
                frmCuenta.CuentNumEmptxt,
                frmCuenta.CuentNombClientxt,
                frmCuenta.CuentNumClientxt,
                frmCuenta.CuentComboMenu,
                frmCuenta.CuentUbicaciontxt1,
                frmCuenta.CuentComboCalificacion
                );
                this.cuentas.Add( Nuevo );
            }
            this.bindingSource1.DataSource = this.cuentas;
            frmCuenta = null;
        }
    }
}
