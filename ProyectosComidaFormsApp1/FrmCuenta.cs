using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectosComidaFormsApp1
{
    public partial class FrmCuenta : Form
    {
        private string _nomEmptxt;
        private string _NumEmptxt;
        private string _NombClientxt;
        private string _NumClientxt;
        private string _comboMenu;
        private string _Ubicaciontxt;
        private string _comboCalificacion;

        private bool isConfirmed = false;
        public FrmCuenta()
        {
            InitializeComponent();
        }

        public string CuentNomEmptxt { get => _nomEmptxt; set => _nomEmptxt = value; }
        public string CuentNumEmptxt { get => _NumEmptxt; set => _NumEmptxt = value; }
        public string CuentNombClientxt { get => _NombClientxt; set => _NombClientxt = value; }
        public string CuentNumClientxt { get => _NumClientxt; set => _NumClientxt = value; }
        public string CuentComboMenu { get => _comboMenu; set => _comboMenu = value; }
        public string CuentUbicaciontxt1 { get => _Ubicaciontxt; set => _Ubicaciontxt = value; }
        public string CuentComboCalificacion { get => _comboCalificacion; set => _comboCalificacion = value; }
        public bool IsConfirmed { get => isConfirmed; set => isConfirmed = value; }

        private void FrmCuenta_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            isConfirmed = false;
            this.Close();

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            this.CuentNomEmptxt = this.nomEmptxt.Text;
            this.CuentNumEmptxt = this.NumEmptxt.Text;
            this.CuentNombClientxt = this.NumEmptxt.Text;
            this.CuentNumClientxt = this.NumEmptxt.Text;
            this.CuentComboMenu = this.comboMenu.Text;
            this.CuentUbicaciontxt1 = this.Ubicaciontxt.Text;
            this.CuentComboCalificacion = this.comboCalificacion.Text;

            this.isConfirmed = true;
            this.Close();

        }
    }
}
