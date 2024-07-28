using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectosComidaFormsApp1
{
    internal class Cuenta
    {
        private Int32 _id;
        private string _nomEmptxt;
        private string _NumEmptxt;
        private string _NombClientxt;
        private string _NumClientxt;
        private string _comboMenu;
        private string _Ubicaciontxt;
        private string _comboCalificacion;


        public int Id { get => _id; set => _id = value; }
        public string NomEmptxt { get => _nomEmptxt; set => _nomEmptxt = value; }
        public string NumEmptxt { get => _NumEmptxt; set => _NumEmptxt = value; }
        public string NombClientxt { get => _NombClientxt; set => _NombClientxt = value; }
        public string NumClientxt { get => _NumClientxt; set => _NumClientxt = value; }
        public string ComboMenu { get => _comboMenu; set => _comboMenu = value; }
        public string Ubicaciontxt { get => _Ubicaciontxt; set => _Ubicaciontxt = value; }
        public string ComboCalificacion { get => _comboCalificacion; set => _comboCalificacion = value; }

        public Cuenta() {
            _nomEmptxt = "";
            _NumClientxt = "";
            _NombClientxt = "";
            _NumClientxt = "";
            _comboMenu = "";
            _Ubicaciontxt = "";
            _comboCalificacion = "";
        }


        public Cuenta(int id, string nomEmptxt , string NumEmptxt, string NombClientxt, string NumClientxt, string comboMenu, string Ubicaciontxt, string comboCalificacion)
        {
            this.Id = id;
            this.NomEmptxt = nomEmptxt;
            this.NumEmptxt= NumEmptxt;
            this.NombClientxt = NumClientxt;
            this.NumClientxt = NumClientxt;
            this.ComboMenu = comboMenu;
            this.Ubicaciontxt= Ubicaciontxt;
            this.ComboCalificacion= comboCalificacion;


        }

        
    }
}
