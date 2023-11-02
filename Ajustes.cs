using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;

namespace Proyecto_Final___Wingo
{
    public partial class Ajustes : Form
    {
        public Ajustes()
        {
            InitializeComponent();
            Funciones funciones = new Funciones();
            funciones.initializeLabels(this);
            funciones.initializeButtons(this);
        }

        private void Ajustes_Load(object sender, EventArgs e)
        {
            string[] nombres_puertos = SerialPort.GetPortNames();
            if (nombres_puertos.Length == 0)
            {
                er_puerto.SetError(Comb_puertos, "Ningún puerto detectado. Conectá el auto, cerrá y volve a entrar a configuraciones");
                er_puerto.BlinkRate = 750;
            }
            else
            {
                er_puerto.BlinkRate = 0;
                for (int i = 0; i < nombres_puertos.Length; i++)
                {
                    Comb_puertos.Items.Add(nombres_puertos[i]);
                }
            }
            try
            {
                Comb_puertos.SelectedItem = Proyecto_Final___Wingo.Properties.Settings.Default.puertoCOM;
            }
            catch
            {
                throw;
            }

        }

        void cerrar(bool close = false, bool shown=false) 
        {
            Pantalla_principal mostrar0 = new Pantalla_principal();
            Funciones funciones = new Funciones();
            if (Comb_puertos.SelectedItem != null)
            {
                Proyecto_Final___Wingo.Properties.Settings.Default.puertoCOM=Comb_puertos.SelectedItem.ToString();
                funciones.escribir_datos(1, Comb_puertos.SelectedItem.ToString());
            }
            if (!shown)
            {
                mostrar0.Show();
            }
            
            if (close)
            {
                this.Close();
            }
        }
        private void bt_aceptar_Click(object sender, EventArgs e)
        {
            cerrar(true,false);
        }

        private void Ajustes_FormClosed(object sender, FormClosedEventArgs e)
        {
            cerrar(false,true);
        }
        private void bt_reset_config_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro que queres resetear las configuraciones?", "Aviso", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Funciones funciones = new Funciones();
                string[] emptyTxt = funciones.reset(35);
                funciones.escribir_vacio(emptyTxt, 35);
            }
        }
    }
}
