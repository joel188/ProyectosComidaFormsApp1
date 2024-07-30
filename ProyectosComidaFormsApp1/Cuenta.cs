using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectosComidaFormsApp1
{
    public class Cuenta
    {
        private string _nomEmptxt;
        private string _numEmptxt;
        private string _nombClientxt;
        private string _numClientxt;
        private string _comboMenu;
        private string _ubicaciontxt;
        private string _comboCalificacion;
        private bool _isConfirmed = false;

        public string NomEmptxt { get => _nomEmptxt; set => _nomEmptxt = value; }
        public string NumEmptxt { get => _numEmptxt; set => _numEmptxt = value; }
        public string NombClientxt { get => _nombClientxt; set => _nombClientxt = value; }
        public string NumClientxt { get => _numClientxt; set => _numClientxt = value; }
        public string ComboMenu { get => _comboMenu; set => _comboMenu = value; }
        public string Ubicaciontxt { get => _ubicaciontxt; set => _ubicaciontxt = value; }
        public string ComboCalificacion { get => _comboCalificacion; set => _comboCalificacion = value; }
        public bool IsConfirmed { get => _isConfirmed; set => _isConfirmed = value; }

        public Cuenta(){
            _nomEmptxt = "";
            _numEmptxt = "";
            _nombClientxt = "";
            _numClientxt = "";
            _comboMenu = "";
            _ubicaciontxt = "";
            _comboCalificacion = "";
        }

        public Cuenta(
            string nomEmptxt,
            string numEmptxt,
            string nombClientxt, 
            string numClientxt, 
            string comboMenu, 
            string ubicaciontxt, 
            string comboCalificacion
           ) 
        {
            NomEmptxt = nomEmptxt;
            NumEmptxt = numEmptxt;
            NombClientxt = nombClientxt;
            NumClientxt = numClientxt;
            ComboMenu = comboMenu;
            Ubicaciontxt = ubicaciontxt;
            ComboCalificacion = comboCalificacion;
        }

       

        public Cuenta(object nomEmptxt, object numEmptxt, Cuenta cuenta)
        {
        }

        public Cuenta(object nomEmptxt, object numEmptxt, object nombClientxt, object numClientxt, object comboMenu, object ubicaciontxt, object comboCalificacion, string cuentComboCalificacion)
        {
        }
    }   
    
}
