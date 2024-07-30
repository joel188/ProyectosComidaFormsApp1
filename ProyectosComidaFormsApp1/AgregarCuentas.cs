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
    public partial class AgregarCuentas : Form
    {
        private Cuenta _cuenta;
        public AgregarCuentas()
        {
            InitializeComponent();
            _cuenta = new Cuenta();
        }

        public Cuenta Cuenta { get => _cuenta; set => _cuenta = value; }

        private void AgregarCuentas_Load(object sender, EventArgs e)
        {

        }

        private void bntConfirmar_Click(object sender, EventArgs e)
        {
            _cuenta.NomEmptxt = nomEmptxt.Text;
            _cuenta.NumEmptxt = numEmptxt.Text;
            _cuenta.NombClientxt = nombClientxt.Text;
            _cuenta.NumClientxt = numClientxt.Text;
            _cuenta.ComboMenu = (string) comboMenu.SelectedItem ?? "";
            _cuenta.Ubicaciontxt = ubicaciontxt.Text;
            _cuenta.ComboCalificacion = (string) comboCalificacion.SelectedItem ?? "";
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
