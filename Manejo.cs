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
using System.Threading;

namespace Proyecto_Final___Wingo
{
    public partial class Manejo : Form
    {
        // Variables generales

        string unidad;
        string nueva_unidad;
        int x = 220;
        int recor_seleccionado;
        bool validado_seguido = false;
        bool cambia_nombre = false;
        bool isNaming = false;
        int nomR1 = 23;
        int R1 = 24;
        int R2 = 29;
        int R3 = 34;
        int nomR2 = 28;
        int nomR3 = 33;

        // Funciones

        bool comprobar_si_es_num(string texto_a_analizar)
        {
            for (int i = 0; i < texto_a_analizar.Length; i++)
            {
                char letra = texto_a_analizar[i];
                if (char.IsDigit(letra))
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
        bool abrir_ventana(string nombre_previo, int x, int y)
        {
            bool abrir_seguido = false;
            if (string.IsNullOrEmpty(nombre_previo))
            {
                panel_nom.Location = new Point(x, y);
                panel_nom.Visible = true;
                isNaming = true;
                abrir_seguido = true;
                return abrir_seguido;
            }
            else
            {
                panel_pasos.Visible = true;
                lbl_tipo_de_paso.Visible = false;
                lbl_cant_paso.Visible = false;
                comb_tipo_paso.Visible = false;
                txt_cant_paso.Visible = false;
                bt_enviar_paso.Visible = false;
                switch (recor_seleccionado)
                {
                    case 1:
                        if (paso_recor_1.Count == 0)
                        {
                            comb_pasos_hechos_recor1.Visible = false;
                            comb_pasos_hechos_recor2.Visible = false;
                            comb_pasos_hechos_recor3.Visible = false;
                            lbl_pasos_hechos.Visible = false;
                        }
                        else
                        {
                            comb_pasos_hechos_recor1.Visible = true;
                            comb_pasos_hechos_recor2.Visible = false;
                            comb_pasos_hechos_recor3.Visible = false;
                            lbl_pasos_hechos.Visible = true;
                        }
                        break;
                    case 2:
                        if (paso_recor_2.Count == 0)
                        {
                            comb_pasos_hechos_recor1.Visible = false;
                            comb_pasos_hechos_recor2.Visible = false;
                            comb_pasos_hechos_recor3.Visible = false;
                            lbl_pasos_hechos.Visible = false;
                        }
                        else
                        {
                            comb_pasos_hechos_recor1.Visible = false;
                            comb_pasos_hechos_recor2.Visible = true;
                            comb_pasos_hechos_recor3.Visible = false;
                            lbl_pasos_hechos.Visible = true;
                        }
                        break;
                    case 3:
                        if (paso_recor_3.Count == 0)
                        {
                            comb_pasos_hechos_recor1.Visible = false;
                            comb_pasos_hechos_recor2.Visible = false;
                            comb_pasos_hechos_recor3.Visible = false;
                            lbl_pasos_hechos.Visible = false;
                        }
                        else
                        {
                            comb_pasos_hechos_recor1.Visible = false;
                            comb_pasos_hechos_recor2.Visible = false;
                            comb_pasos_hechos_recor3.Visible = true;
                            lbl_pasos_hechos.Visible = true;
                        }
                        break;
                }
                bt_mod_paso.Visible = false;
                bt_el_paso.Visible = false;
                panel_modificar_paso.Visible = false;
                abrir_seguido = false;
                return abrir_seguido;
            }
        }
        (bool, string) validar_nombre(string nombre)
        {
            if (nombre == "")
            {
                MessageBox.Show("Por favor, ingresar un nombre.", "Error");
                txt_nom.Text = "";
                return (false, "");
            }
            else
            {
                panel_nom.Visible = false;
                txt_nom.Text = "";
                return (true, nombre);
            }
        }
        (bool, string, string, string) enviar_y_verificar_paso(string tipo_paso_ingresado, string cant_paso_ingresado)
        {
            if (tipo_paso_ingresado == "")
            {
                MessageBox.Show("Por favor, seleccionar el tipo de paso que quiere realizar.", "Error");
                return (false, "", "", "");
            }
            else if (cant_paso_ingresado == "")
            {
                MessageBox.Show("Por favor, agregar la cantidad del paso que quiere realizar.", "Error");
                return (false, "", "", "");
            }
            else if ((tipo_paso_ingresado== "Girar hacia la izquierda" || tipo_paso_ingresado=="Girar hacia la derecha") && Convert.ToInt32(cant_paso_ingresado) > 90)
            {
                MessageBox.Show("Por favor, no ingresar una cantidad mayor de 90 grados.", "Error");
                return (false, "", "", "");
            }
            else
            {
                bool es_num = comprobar_si_es_num(cant_paso_ingresado);
                if (!es_num)
                {
                    MessageBox.Show("Por favor, no ingresar ninguna letra o símbolo en el número", "Error");
                    txt_cant_paso.Text = "";
                    return (false, "", "", "");
                }
                else
                {
                    string paso_hecho = tipo_paso_ingresado + ", " + cant_paso_ingresado;
                    lbl_tipo_de_paso.Visible = false;
                    lbl_cant_paso.Visible = false;
                    comb_tipo_paso.Visible = false;
                    txt_cant_paso.Visible = false;
                    bt_enviar_paso.Visible = false;
                    comb_tipo_paso.Text = "";
                    return (true, tipo_paso_ingresado, cant_paso_ingresado, paso_hecho);
                }
            }
        }
        (bool, string, string, string) cambiar_y_verificar_paso(string tipo_paso_modificado, string cant_paso_modificado)
        {
            if (tipo_paso_modificado == "")
            {
                MessageBox.Show("Por favor, seleccionar el tipo de paso que quiere realizar.", "Error");
                return (false, "", "", "");
            }
            else if (cant_paso_modificado == "")
            {
                MessageBox.Show("Por favor, agregar la cantidad del paso que quiere realizar.", "Error");
                return (false, "", "", "");
            }
            else if ((tipo_paso_modificado == "Girar hacia la izquierda" || cant_paso_modificado == "Girar hacia la derecha") && Convert.ToInt32(cant_paso_modificado) > 90)
            {
                MessageBox.Show("Por favor, no ingresar una cantidad mayor de 90 grados.", "Error");
                return (false, "", "", "");
            }
            else
            {
                bool es_num = comprobar_si_es_num(cant_paso_modificado);
                if (!es_num)
                {
                    MessageBox.Show("Por favor, no ingresar ninguna letra o símbolo en el número", "Error");
                    txt_cant_paso.Text = "";
                    return (false, "", "", "");
                }
                else
                {
                    panel_modificar_paso.Visible = false;
                    comb_nuevo_tipo_paso.Text = "";
                    string new_paso_hecho = tipo_paso_modificado + ", " + cant_paso_modificado;
                    return (true, tipo_paso_modificado, cant_paso_modificado, new_paso_hecho);
                }
            }
        }
        void bt_enviarR()
        {
            Funciones funciones = new Funciones();
            isNaming = false;
            var (validado, nombre) = validar_nombre(txt_nom.Text);
            if (validado)
            {
                switch (recor_seleccionado)
                {
                    case 1:
                        nombre_recor1 = nombre;
                        bt_recor1.Text = nombre_recor1;
                        funciones.escribir_datos(nomR1, nombre);
                        if (validado_seguido || cambia_nombre)
                        {
                            validado_seguido = abrir_ventana(nombre_recor1, x, y1);
                        }
                        cambia_nombre = false;
                        return;
                    case 2:
                        nombre_recor2 = nombre;
                        bt_recor2.Text = nombre_recor2;
                        funciones.escribir_datos(nomR2, nombre);
                        if (validado_seguido || cambia_nombre)
                        {
                            validado_seguido = abrir_ventana(nombre_recor2, x, y2);
                        }
                        cambia_nombre = false;
                        return;
                    case 3:
                        nombre_recor3 = nombre;
                        bt_recor3.Text = nombre_recor3;
                        funciones.escribir_datos(nomR3, nombre);
                        if (validado_seguido || cambia_nombre)
                        {
                            validado_seguido = abrir_ventana(nombre_recor3, x, y3);
                        }
                        cambia_nombre = false;
                        return;

                }
            }
        }
        void enter(bool tecla_enter)
        {
            if (tecla_enter && isNaming)
            {
                bt_enviarR();
            }
        }

        string saberUnidad(string tipo_paso)
        {
            if (tipo_paso=="Girar hacia la izquierda" || tipo_paso == "Girar hacia la derecha")
            {
                return "grados";
            }
            else
            {
                return "segundos";
            }
        }

        // Form

        Panel panel_borde;
        public Manejo()
        {
            InitializeComponent();
            panel_borde = new Panel();
            panel_borde.Size = new Size(7, bt_recor1.Height);
            panel_recors.Controls.Add(panel_borde);
            y1 = bt_recor1.Location.Y;
            y2 = bt_recor2.Location.Y;
            y3 = bt_recor3.Location.Y;
            Point punto_combo = new Point(760, 71);
            comb_pasos_hechos_recor1.Location = punto_combo;
            comb_pasos_hechos_recor2.Location = punto_combo;
            comb_pasos_hechos_recor3.Location = punto_combo;
            lbl_crear_recor.Font = Program.titles;
            Funciones funciones = new Funciones();
            funciones.initializeLabels(this, lbl_crear_recor);
            funciones.initializePanels(this, panel_nom);
            funciones.initializeButtons(this);
        }
        private void Manejo_Load(object sender, EventArgs e)
        {
            Funciones funciones = new Funciones();
            panel_nom.Visible = false;
            panel_borde.Visible = false;
            panel_pasos.Visible = false;
            panel_modificar_paso.Visible = false;
            (paso_recor_1, cant_paso_recor_1) = funciones.leer_recor(R1);
            (paso_recor_2, cant_paso_recor_2) = funciones.leer_recor(R3);
            (paso_recor_3, cant_paso_recor_3) = funciones.leer_recor(R3);
            nombre_recor1 = funciones.leer_datos(nomR1);
            nombre_recor2 = funciones.leer_datos(nomR2);
            nombre_recor3 = funciones.leer_datos(nomR3);
            if (nombre_recor1 != "")
            {
                bt_recor1.Text = nombre_recor1;
            }
            else
            {
                bt_recor1.Text = "Nuevo Recorrido";
            }
            if (nombre_recor2 != "")
            {
                bt_recor2.Text = nombre_recor2;
            }
            else
            {
                bt_recor2.Text = "Nuevo Recorrido";
            }
            if (nombre_recor3 != "")
            {
                bt_recor3.Text = nombre_recor3;
            }
            else
            {
                bt_recor3.Text = "Nuevo Recorrido";
            }
            if (paso_recor_1.Count > 0)
            {
                for (int i = 0; i < paso_recor_1.Count; i++)
                {
                    comb_pasos_hechos_recor1.Items.Add($"{paso_recor_1[i]}, {cant_paso_recor_1[i]} {saberUnidad(paso_recor_1[i])}");
                }
            }
            if (paso_recor_2.Count > 0)
            {
                for (int i = 0; i < paso_recor_2.Count; i++)
                {
                    comb_pasos_hechos_recor2.Items.Add($"{paso_recor_2[i]}, {cant_paso_recor_2[i]} {saberUnidad(paso_recor_2[i])}");
                }
            }
            if (paso_recor_3.Count > 0)
            {
                for (int i = 0; i < paso_recor_3.Count; i++)
                {
                    comb_pasos_hechos_recor3.Items.Add($"{paso_recor_3[i]}, {cant_paso_recor_3[i]} {saberUnidad(paso_recor_3[i])}");
                }
            }
        }

        // Recor 1

        string nombre_recor1;
        int y1 = 72;
        List<string> paso_recor_1 = new List<string>();
        List<int> cant_paso_recor_1 = new List<int>();
        private void bt_recor1_Click(object sender, EventArgs e)
        {
            recor_seleccionado = 1;
            panel_nom.Visible = false;
            panel_pasos.Visible = false;
            comb_tipo_paso.Text = "";
            txt_cant_paso.Text = "";
            txt_nom.Text = "";
            lbl_pasos_hechos_recor1.Text = "";
            validado_seguido = abrir_ventana(nombre_recor1, x, y1);
            bt_recor1.Enabled = false;
            bt_recor2.Enabled = true;
            bt_recor3.Enabled = true;
            Funciones funciones = new Funciones();
            funciones.btPressed(sender, Color.Black, bt_recor1, panel_borde, new Point(0, bt_recor1.Location.Y));
            funciones.btNotPressed(bt_recor2);
            funciones.btNotPressed(bt_recor3);
        }

        // Recor 2

        string nombre_recor2;
        int y2 = 154;
        List<string> paso_recor_2 = new List<string>();
        List<int> cant_paso_recor_2 = new List<int>();
        private void bt_recor2_Click(object sender, EventArgs e)
        {
            recor_seleccionado = 2;
            panel_nom.Visible = false;
            panel_pasos.Visible = false;
            comb_tipo_paso.Text = "";
            txt_cant_paso.Text = "";
            txt_nom.Text = "";
            lbl_pasos_hechos_recor1.Text = "";
            validado_seguido = abrir_ventana(nombre_recor2, x, y2);
            bt_recor1.Enabled = true;
            bt_recor2.Enabled = false;
            bt_recor3.Enabled = true;
            Funciones funciones = new Funciones();
            funciones.btPressed(sender, Color.Black, bt_recor2, panel_borde, new Point(0, bt_recor2.Location.Y));
            funciones.btNotPressed(bt_recor1);
            funciones.btNotPressed(bt_recor3);
        }

        // Recor 3

        string nombre_recor3;
        int y3 = 233;
        List<string> paso_recor_3 = new List<string>();
        List<int> cant_paso_recor_3 = new List<int>();
        private void bt_recor3_Click(object sender, EventArgs e)
        {
            recor_seleccionado = 3;
            panel_nom.Visible = false;
            panel_pasos.Visible = false;
            comb_tipo_paso.Text = "";
            txt_cant_paso.Text = "";
            txt_nom.Text = "";
            lbl_pasos_hechos_recor1.Text = "";
            validado_seguido = abrir_ventana(nombre_recor3, x, y3);
            bt_recor1.Enabled = true;
            bt_recor2.Enabled = true;
            bt_recor3.Enabled = false;
            Funciones funciones = new Funciones();
            funciones.btPressed(sender, Color.Black, bt_recor3, panel_borde, new Point(0, bt_recor3.Location.Y));
            funciones.btNotPressed(bt_recor1);
            funciones.btNotPressed(bt_recor2);
        }

        // Eventos
        private void bt_enviar_nom_recor_1_Click(object sender, EventArgs e)
        {
            bt_enviarR();
        }

        private void bt_cambiar_nombre_recor1_Click(object sender, EventArgs e)
        {
            switch (recor_seleccionado)
            {
                case 1:
                    panel_nom.Location = new System.Drawing.Point(x, y1);
                    break;
                case 2:
                    panel_nom.Location = new System.Drawing.Point(x, y2);
                    break;
                case 3:
                    panel_nom.Location = new System.Drawing.Point(x, y3);
                    break;
            }
            panel_pasos.Visible = false;
            panel_nom.Visible = true;
            cambia_nombre = true;
            isNaming = true;
        }

        private void bt_nuevo_paso_Click(object sender, EventArgs e)
        {
            lbl_tipo_de_paso.Visible = true;
            comb_tipo_paso.Visible = true;
        }

        private void cb_tipo_paso_recor1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comb_tipo_paso.SelectedIndex == 2 || comb_tipo_paso.SelectedIndex == 3)
            {
                lbl_cant_paso.Text = "¿Cuántos grados va a girar?";
                unidad = "grados";
                lbl_cant_paso.Visible = true;
                txt_cant_paso.Visible = true;
                bt_enviar_paso.Visible = true;
            }
            else
            {
                lbl_cant_paso.Text = "¿Cuántos segundos va a durar la acción?";
                unidad = "segundos";
                lbl_cant_paso.Visible = true;
                txt_cant_paso.Visible = true;
                bt_enviar_paso.Visible = true;
            }

        }

        private void bt_enviar_paso_recor1_Click(object sender, EventArgs e)
        {
            Funciones funciones = new Funciones();
            var (verificado, tipo_paso, cant_paso, paso_hecho) = enviar_y_verificar_paso(comb_tipo_paso.Text, txt_cant_paso.Text);
            if (verificado)
            {
                switch (recor_seleccionado)
                {
                    case 1:
                        paso_recor_1.Add(tipo_paso);
                        cant_paso_recor_1.Add(Convert.ToInt32(cant_paso));
                        comb_pasos_hechos_recor1.Items.Add($"{paso_hecho} {unidad}.");
                        txt_cant_paso.Text = "";
                        comb_pasos_hechos_recor1.Visible = true;
                        lbl_pasos_hechos.Visible = true;
                        funciones.escribir_recor(R1, paso_recor_1,cant_paso_recor_1);
                        return;
                    case 2:
                        paso_recor_2.Add(tipo_paso);
                        cant_paso_recor_2.Add(Convert.ToInt32(cant_paso));
                        comb_pasos_hechos_recor2.Items.Add($"{paso_hecho}");
                        txt_cant_paso.Text = "";
                        comb_pasos_hechos_recor2.Visible = true;
                        lbl_pasos_hechos.Visible = true;
                        funciones.escribir_recor(R2, paso_recor_2, cant_paso_recor_2);
                        return;
                    case 3:
                        paso_recor_3.Add(tipo_paso);
                        cant_paso_recor_3.Add(Convert.ToInt32(cant_paso));
                        comb_pasos_hechos_recor3.Items.Add($"{paso_hecho}");
                        txt_cant_paso.Text = "";
                        comb_pasos_hechos_recor3.Visible = true;
                        lbl_pasos_hechos.Visible = true;
                        funciones.escribir_recor(R3, paso_recor_3, cant_paso_recor_3);
                        return;
                }

            }
        }

        private void comb_pasos_hechos_recor1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bt_mod_paso.Visible = true;
            bt_el_paso.Visible = true;
        }
        private void bt_mod_paso_Click(object sender, EventArgs e)
        {
            if (comb_pasos_hechos_recor1.SelectedIndex != -1 || comb_pasos_hechos_recor2.SelectedIndex != -1 || comb_pasos_hechos_recor3.SelectedIndex != -1)
            {
                panel_modificar_paso.Visible = true;
                bt_enviar_nuevo_paso.Visible = false;
                lbl_nuevo_cant_paso.Visible = false;
                txt_nuevo_cant_paso.Visible = false;
            }
        }

        private void comb_nuevo_tipo_paso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comb_nuevo_tipo_paso.SelectedIndex == 3 || comb_nuevo_tipo_paso.SelectedIndex == 4)
            {
                nueva_unidad = "grados";
                bt_enviar_nuevo_paso.Visible = true;
                lbl_nuevo_cant_paso.Visible = true;
                txt_nuevo_cant_paso.Text = "";
                txt_nuevo_cant_paso.Visible = true;
            }
            else
            {
                nueva_unidad = "segundos";
                bt_enviar_nuevo_paso.Visible = true;
                lbl_nuevo_cant_paso.Visible = true;
                txt_nuevo_cant_paso.Text = "";
                txt_nuevo_cant_paso.Visible = true;
            }

        }
        private void bt_enviar_nuevo_paso_Click(object sender, EventArgs e)
        {
            Funciones funciones = new Funciones();
            var (nuevo_paso_verificado, nuevo_tipo_paso, nuevo_cant_paso, nuevo_paso_hecho) = cambiar_y_verificar_paso(comb_nuevo_tipo_paso.Text, txt_nuevo_cant_paso.Text);
            if (nuevo_paso_verificado)
            {
                switch (recor_seleccionado)
                {
                    case 1:
                        paso_recor_1[comb_pasos_hechos_recor1.SelectedIndex] = nuevo_tipo_paso;
                        cant_paso_recor_1[comb_pasos_hechos_recor1.SelectedIndex] = Convert.ToInt32(nuevo_cant_paso);
                        comb_pasos_hechos_recor1.Items[comb_pasos_hechos_recor1.SelectedIndex] = $"{nuevo_paso_hecho} {nueva_unidad}.";
                        txt_nuevo_cant_paso.Text = "";
                        funciones.escribir_recor(R1, paso_recor_1, cant_paso_recor_1);
                        return;
                    case 2:
                        paso_recor_2[comb_pasos_hechos_recor2.SelectedIndex] = nuevo_tipo_paso;
                        cant_paso_recor_2[comb_pasos_hechos_recor2.SelectedIndex] = Convert.ToInt32(nuevo_cant_paso);
                        comb_pasos_hechos_recor2.Items[comb_pasos_hechos_recor2.SelectedIndex] = $"{nuevo_paso_hecho} {nueva_unidad}.";
                        txt_nuevo_cant_paso.Text = "";
                        funciones.escribir_recor(R2, paso_recor_2, cant_paso_recor_2);
                        return;
                    case 3:
                        paso_recor_3[comb_pasos_hechos_recor3.SelectedIndex] = nuevo_tipo_paso;
                        cant_paso_recor_3[comb_pasos_hechos_recor3.SelectedIndex] = Convert.ToInt32(nuevo_cant_paso);
                        comb_pasos_hechos_recor3.Items[comb_pasos_hechos_recor3.SelectedIndex] = $"{nuevo_paso_hecho} {nueva_unidad}.";
                        txt_nuevo_cant_paso.Text = "";
                        funciones.escribir_recor(R3, paso_recor_3, cant_paso_recor_3);
                        return;
                }
            }
        }

        private void bt_personalizacion_Click(object sender, EventArgs e)
        {
            Personalización personalización = new Personalización();
            personalización.Show();
            this.Close();
        }

        private void bt_el_paso_Click(object sender, EventArgs e)
        {
            Funciones funciones = new Funciones();
            if (comb_pasos_hechos_recor1.SelectedIndex != -1 || comb_pasos_hechos_recor2.SelectedIndex != -1 || comb_pasos_hechos_recor3.SelectedIndex != -1)
            {
                switch (recor_seleccionado)
                {
                    case 1:
                        paso_recor_1.RemoveAt(comb_pasos_hechos_recor1.SelectedIndex);
                        cant_paso_recor_1.RemoveAt(comb_pasos_hechos_recor1.SelectedIndex);
                        comb_pasos_hechos_recor1.Items.RemoveAt(comb_pasos_hechos_recor1.SelectedIndex);
                        comb_pasos_hechos_recor1.Text = "";
                        funciones.escribir_recor(R1, paso_recor_1, cant_paso_recor_1);
                        break;
                    case 2:
                        paso_recor_2.RemoveAt(comb_pasos_hechos_recor2.SelectedIndex);
                        cant_paso_recor_2.RemoveAt(comb_pasos_hechos_recor2.SelectedIndex);
                        comb_pasos_hechos_recor2.Items.RemoveAt(comb_pasos_hechos_recor2.SelectedIndex);
                        comb_pasos_hechos_recor2.Text = "";
                        funciones.escribir_recor(R2, paso_recor_2, cant_paso_recor_2);
                        break;
                    case 3:
                        paso_recor_3.RemoveAt(comb_pasos_hechos_recor3.SelectedIndex);
                        cant_paso_recor_3.RemoveAt(comb_pasos_hechos_recor3.SelectedIndex);
                        comb_pasos_hechos_recor3.Items.RemoveAt(comb_pasos_hechos_recor3.SelectedIndex);
                        comb_pasos_hechos_recor3.Text = "";
                        funciones.escribir_recor(R3, paso_recor_3, cant_paso_recor_3);
                        break;
                }
            }
        }

        private void comb_pasos_hechos_recor3_SelectedIndexChanged(object sender, EventArgs e)
        {
            bt_mod_paso.Visible = true;
            bt_el_paso.Visible = true;
        }

        private void comb_pasos_hechos_recor2_SelectedIndexChanged(object sender, EventArgs e)
        {
            bt_mod_paso.Visible = true;
            bt_el_paso.Visible = true;
        }

        private void txt_nom_KeyPress(object sender, KeyPressEventArgs e)
        {
            enter(e.KeyChar == (char)Keys.Enter);
        }

        //Enviar

        List<string> ultimos_msgs = new List<string>();

        private void bt_enviar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_delay_carga.Text))
            {
                MessageBox.Show("Por favor, ingresar un delay para empezar el recorrido.", "Error");
            }
            else if (!int.TryParse(txt_delay_carga.Text, out int num))
            {
                MessageBox.Show("El delay tiene que ser un número y no puede incluir ninguna letra o símbolo.", "Error");
            }
            else
            {
                Funciones funciones = new Funciones();
                List<string> mensajes = new List<string>();
                switch (recor_seleccionado)
                {
                    case 1:
                        for (int i = 0; i < paso_recor_1.Count; i++)
                        {
                            mensajes.Add(funciones.string_a_enviar("manejo", -1, -1, "", "", Color.White, -1, -1, paso_recor_1[i], cant_paso_recor_1[i]));
                        }
                        break;
                    case 2:
                        for (int i = 0; i < paso_recor_2.Count; i++)
                        {
                            mensajes.Add(funciones.string_a_enviar("manejo", -1, -1, "", "", Color.White, -1, -1, paso_recor_2[i], cant_paso_recor_2[i]));
                        }
                        break;
                    case 3:
                        for (int i = 0; i < paso_recor_3.Count; i++)
                        {
                            mensajes.Add(funciones.string_a_enviar("manejo", -1, -1, "", "", Color.White, -1, -1, paso_recor_3[i], cant_paso_recor_3[i]));
                        }
                        break;
                }
                string[] port_names = SerialPort.GetPortNames();
                if (port_names.Contains(funciones.leer_datos(1)))
                {
                    SerialPort arduino = new SerialPort();
                    arduino.PortName = funciones.leer_datos(1);
                    arduino.BaudRate = 9600;
                    arduino.Parity = Parity.None;
                    try
                    {
                        DialogResult result = MessageBox.Show("¿Desea enviar todos los recorridos desde cero? NOTA: puede tardar más tiempo", "Enviando", MessageBoxButtons.YesNoCancel);
                        if (result != DialogResult.Cancel)
                        {
                            ultimos_msgs = mensajes;
                            arduino.Open();
                            ProgressBar progressBar = new ProgressBar();
                            progressBar.cant_msgs = 0;
                            progressBar.cant_msgs = mensajes.Count;
                            progressBar.BackColor = Color.FromArgb(190,21,3);
                            progressBar.Show();
                            int num_mensaje = 0;
                            arduino.WriteLine($"m:{mensajes.Count}:{Convert.ToInt16(txt_delay_carga.Text)*1000}" + '\n');
                            foreach (string mensaje in mensajes)
                            {
                                bool distinto = false;
                                if (result == DialogResult.Yes)
                                {
                                    arduino.WriteLine(mensaje + '\n');
                                }
                                else
                                {
                                    if (mensaje != ultimos_msgs[num_mensaje])
                                    {
                                        arduino.WriteLine(mensaje + '\n');
                                        distinto = true;
                                    }
                                }
                                if (num_mensaje >= progressBar.onePercent * progressBar.progressBar_subiendo.Value)
                                {
                                    progressBar.progressBar_subiendo.Value++;
                                }
                                num_mensaje++;
                                if (distinto || result == DialogResult.Yes)
                                {
                                    Thread.Sleep(150);
                                }
                            }
                            progressBar.Close();
                            arduino.Close();
                            MessageBox.Show("Mensajes enviados exitosamente, el recorrido debería estarse ejecutando", "Enviado");
                        }
                    }
                    catch
                    {
                        MessageBox.Show($"Error, vuelva a intentarlo.", "Error");
                        arduino.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Error al seleccionar el puerto del auto. Vaya a configuración y seleccionar el puerto correcto.", "Error");
                }
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Pantalla_principal mostrar0 = new Pantalla_principal();
            mostrar0.Show();
            this.Close();
        }

        private void lbl_crear_recor_Click(object sender, EventArgs e)
        {
            panel_pasos.Visible = false;
            panel_borde.Visible = false;
            panel_nom.Visible = false;
            panel_modificar_paso.Visible = false;
            Funciones funciones = new Funciones();
            funciones.btNotPressed(bt_recor3);
            funciones.btNotPressed(bt_recor2);
            funciones.btNotPressed(bt_recor1);
            bt_recor1.Enabled = true; 
            bt_recor2.Enabled = true;
            bt_recor3.Enabled = true;
            comb_pasos_hechos_recor1.SelectedItem = null;
            comb_pasos_hechos_recor2.SelectedItem = null;
            comb_pasos_hechos_recor3.SelectedItem = null;
            txt_delay_carga.Text = "";
            txt_cant_paso.Text = "";
            txt_nom.Text = "";
            txt_nuevo_cant_paso.Text = "";
        }
    }
}

