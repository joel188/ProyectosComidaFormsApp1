using ProyectosComidaFormsApp1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace RegistrodePedidoFormsApp1
{
    public partial class ListadeCuentas : Form
    {
      
            public List<Cuenta> cuentas;
            
            public ListadeCuentas()
            {
                InitializeComponent();
                cuentas = new List<Cuenta>();
            
                cuentas.Add(new Cuenta(
                    "kevin ordoñes", "2547-9963","jessica nevera","4725-8801","Langosta","Choluteca","3. Estrellas"
                    ));
                bindingSource.DataSource = cuentas;
            }

        internal List<Cuenta> Cuentas { get => cuentas; set => cuentas = value; }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        /**
        NomEmptxt = nomEmptxt;
            NumEmptxt = numEmptxt;
            NombClientxt = nombClientxt;
            NumClientxt = numClientxt;
            ComboMenu = comboMenu;
            Ubicaciontxt = ubicaciontxt;
            ComboCalificacion = comboCalificacion;
        **/


        

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                String ArchivoGuardar = saveDialog.FileName;
                XmlSerializer serializador = new XmlSerializer(
                    typeof(List<Cuenta>)
                );
                StreamWriter guardador = new StreamWriter(ArchivoGuardar);
                serializador.Serialize(guardador, cuentas);
                MessageBox.Show("Archivo Guardardo Exictosamente");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            AgregarCuentas frmAgregar = new AgregarCuentas();
            if(frmAgregar.ShowDialog() == DialogResult.OK)
            {
                bindingSource.Add(
                    new Cuenta(
                        frmAgregar.Cuenta.NomEmptxt,
                        frmAgregar.Cuenta.NumEmptxt,
                        frmAgregar.Cuenta.NombClientxt,
                        frmAgregar.Cuenta.NumClientxt,
                        frmAgregar.Cuenta.ComboMenu,
                        frmAgregar.Cuenta.Ubicaciontxt,
                        frmAgregar.Cuenta.ComboCalificacion)
                );
               frmAgregar = null;
            }
        }
    }
}
