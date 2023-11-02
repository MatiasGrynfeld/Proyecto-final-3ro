using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

namespace Proyecto_Final___Wingo
{
    public partial class Personalización : Form
    {

        // Variables

        int x = 151;
        int perfil_seleccionado;
        int angulo_seleccionado;
        bool Modo_dibujo = false;
        bool Dibujando = false;
        bool isNaming = false;
        Color color_pincel_inicial;
        Personalización___perfil color_wheel;
        Rectangle[,] ellipses = new Rectangle[8, 8];
        Pen pen = new Pen(Color.Black);
        bool validado_seguido = false;
        bool cambia_nombre = false;
        bool reseteando = false;
        int linea_nom_perf1 = 3;
        int linea_nom_perf2 = 13;
        int mod_1a = 4;
        int lin_1a = 5;
        int mod_1i = 6;
        int lin_1i = 7;
        int mod_1d = 8;
        int lin_1d = 9;

        int mod_2a = 14;
        int lin_2a = 15;
        int mod_2i = 16;
        int lin_2i = 17;
        int mod_2d = 18;
        int lin_2d = 19;

        //Form

        Panel panel_borde;
        public Personalización()
        {
            InitializeComponent();
            panel_borde = new Panel();
            panel_borde.Size = new Size(7, bt_perfil1.Height);
            panel_perfs.Controls.Add(panel_borde);
            lbl_pers.Font = Program.titles;
            color_wheel = new Personalización___perfil() { TopLevel = false, Dock = DockStyle.Fill };
            Funciones funciones = new Funciones();
            nombre_perfil_1 = funciones.leer_datos(linea_nom_perf1);
            nombre_perfil_2 = funciones.leer_datos(linea_nom_perf2);
            if (nombre_perfil_1 != "")
            {
                bt_perfil1.Text = nombre_perfil_1;
            }
            else
            {
                bt_perfil1.Text = "Nuevo Perfil";
            }
            if (nombre_perfil_2 != "")
            {
                bt_perfil2.Text = nombre_perfil_2;
            }
            else
            {
                bt_perfil2.Text = "Nuevo Perfil";
            }
            funciones.initializeLabels(this,lbl_pers);
            funciones.initializeButtons(this);
            funciones.initializePanels(this, panel_nom);
        }
        private void Personalización_Load(object sender, EventArgs e)
        {
            Point panel_location = new System.Drawing.Point(0, 67);
            bt_reset_cols.Visible = false;
            panel_nom.Visible = false;
            panel_perfil.Visible = false;
            panel_wheel.Visible = false;
            bt_paint.Visible = false;
            bt_mouse.Visible = false;
            panel_arriba.Location = panel_location;
            panel_izquierda.Location = panel_location;
            panel_derecha.Location = panel_location;
            bt_enviar_configuraciones.Visible = false;
            int lastAngulo = Proyecto_Final___Wingo.Properties.Settings.Default.lastAngulo;
            int lastPerf = Proyecto_Final___Wingo.Properties.Settings.Default.lastPerf;
            Funciones funciones = new Funciones();
            if (lastPerf == 1)
            {
                perfil_seleccionado = lastPerf;
                bool validado = abrir_ventana(nombre_perfil_1, x, y1, lastPerf);
                if (validado_seguido)
                {
                    validado_seguido = abrir_ventana(nombre_perfil_1, x, y1, lastPerf);
                }
                switch (lastAngulo)
                {
                    case 0:
                        comb_angulo.SelectedIndex = lastAngulo;
                        comb_angulo_change();
                        string[] mod_value10 = funciones.leer_valores(mod_1a);
                        Comb_tipos_personalizados.SelectedItem = mod_value10[0];
                        break;
                    case 1:
                        comb_angulo.SelectedIndex = lastAngulo;
                        comb_angulo_change();
                        string[] mod_value11 = funciones.leer_valores(mod_1i);
                        Comb_tipos_personalizados.SelectedItem = mod_value11[0];
                        break;
                    case 2:
                        comb_angulo.SelectedIndex = lastAngulo;
                        comb_angulo_change();
                        string[] mod_value12 = funciones.leer_valores(mod_1a);
                        Comb_tipos_personalizados.SelectedItem = mod_value12[0];
                        break;
                    default:
                        break;
                }
            }
            else if (lastPerf == 2)
            {
                perfil_seleccionado = lastPerf;
                bool validado = abrir_ventana(nombre_perfil_2, x, y2, lastPerf);
                if (validado_seguido)
                {
                    validado_seguido = abrir_ventana(nombre_perfil_2, x, y2, lastPerf);
                }
                switch (lastAngulo)
                {
                    case 0:
                        comb_angulo.SelectedIndex = lastAngulo;
                        comb_angulo_change();
                        string[] mod_value10 = funciones.leer_valores(mod_1a);
                        Comb_tipos_personalizados.SelectedItem = mod_value10[0];
                        break;
                    case 1:
                        comb_angulo.SelectedIndex = lastAngulo;
                        comb_angulo_change();
                        string[] mod_value11 = funciones.leer_valores(mod_1i);
                        Comb_tipos_personalizados.SelectedItem = mod_value11[0];
                        break;
                    case 2:
                        comb_angulo.SelectedIndex = lastAngulo;
                        comb_angulo_change();
                        string[] mod_value12 = funciones.leer_valores(mod_1a);
                        Comb_tipos_personalizados.SelectedItem = mod_value12[0];
                        break;
                    default:
                        break;
                }
            }
            angulo_seleccionado = lastAngulo;
        }
        private void Personalización_FormClosing(object sender, FormClosingEventArgs e)
        {
            Proyecto_Final___Wingo.Properties.Settings.Default.lastPerf = perfil_seleccionado;
            Proyecto_Final___Wingo.Properties.Settings.Default.lastAngulo = angulo_seleccionado;
        }
        // Funciones

        void open_form()
        {
            panel_wheel.Visible = true;
            panel_wheel.Controls.Add(color_wheel);
            color_wheel.Show();
            color_pincel_inicial = color_wheel.color_default;
            color_wheel.panel_muestra.BackColor = color_pincel_inicial;
        }
        bool abrir_ventana(string nombre_previo, int x, int y, int perfil_selec)
        {
            bool abrir_seguido = false;
            if (nombre_previo == "")
            {
                panel_perfil.Visible = false;
                panel_nom.Location = new Point(x, y);
                panel_nom.Visible = true;
                isNaming = true;
                bt_paint.Visible = false;
                bt_mouse.Visible = false;
                panel_wheel.Visible = false;
                panel_arriba.Visible = false;
                panel_izquierda.Visible = false;
                panel_derecha.Visible = false;
                abrir_seguido = true;
                return abrir_seguido;
            }
            else
            {
                comb_angulo.SelectedItem = null;
                Comb_tipos_personalizados.SelectedItem = null;
                panel_perfil.Visible = true;
                panel_arriba.Visible = false;
                panel_izquierda.Visible = false;
                panel_derecha.Visible = false;
                Comb_tipos_personalizados.Visible = false;
                lbl_mod.Visible = false;
                lbl_mod.Visible = false;
                lbl_mod.Visible = false;
                bt_mouse.Visible = false;
                bt_paint.Visible = false;
                bt_mouse.Enabled = false;
                bt_paint.Enabled = true;
                Modo_dibujo = false;
                if (perfil_selec == 1)
                {
                    bt_perfil1.Enabled = false;
                    bt_perfil2.Enabled = true;
                }
                else
                {
                    bt_perfil1.Enabled = true;
                    bt_perfil2.Enabled = false;
                }
                abrir_seguido = false;
                return abrir_seguido;
            }
        }
        (bool, string) validar_nombre(string nombre)
        {
            if (nombre == "")
            {
                MessageBox.Show("Por favor, ingresar un nombre.", "Error");
                txt_nombre.Text = "";
                return (false, "");
            }
            else
            {
                panel_nom.Visible = false;
                txt_nombre.Text = "";
                return (true, nombre);
            }
        }
        void crear_ellipses(int panelwidth, int panelheight, int numcellshor, int numcellsver)
        {
            int cell_width = panelwidth / numcellshor;
            int cell_height = panelheight / numcellsver;

            int startpositioninx = panelwidth / 2 - cell_width * 4;
            int startpositioniny = panelheight / 2 - cell_height * 4;

            for (int arriba = 0; arriba < 8; arriba++)
            {
                for (int horizontalmente = 0; horizontalmente < 8; horizontalmente++)
                {
                    int x = startpositioninx + horizontalmente * cell_width;
                    int y = startpositioniny + arriba * cell_height;
                    Rectangle ellip = new Rectangle(x, y, cell_width, cell_height);
                    ellipses[horizontalmente, arriba] = ellip;
                }
            }
        }

        (bool, int, int, SolidBrush color) coloreando(bool dibujando, bool modo_dibujo, Color color_inicial, Color nuevo_color, Point punto, Graphics g)
        {
            SolidBrush color = new SolidBrush(nuevo_color);
            int arriba_devuelve = -1;
            int horizontalmente_devuelve = -1;
            bool validado = false;

            if (!dibujando || !modo_dibujo)
            {
                return (validado, arriba_devuelve, horizontalmente_devuelve, color);
            }

            if (nuevo_color == color_inicial)
            {
                MessageBox.Show("Por favor, seleccioná un color", "Error");
                return (validado, arriba_devuelve, horizontalmente_devuelve, color);
            }

            for (int arriba = 0; arriba < 8; arriba++)
            {
                for (int horizontalmente = 0; horizontalmente < 8; horizontalmente++)
                {
                    Rectangle rectangle = ellipses[horizontalmente, arriba];
                    if (rectangle.Contains(punto))
                    {
                        g.FillEllipse(color, rectangle);
                        validado = true;
                        arriba_devuelve = arriba;
                        horizontalmente_devuelve = horizontalmente;
                        return (validado, arriba_devuelve, horizontalmente_devuelve, color);
                    }
                }
            }

            return (validado, arriba_devuelve, horizontalmente_devuelve, color);
        }

        void asignar_modalidad(int perf_selec, int ang_selec, string modalidad)
        {
            switch (perf_selec)
            {
                case 1:
                    modalidad_angulos_perfil1[ang_selec] = modalidad; return;
                case 2:
                    modalidad_angulos_perfil2[ang_selec] = modalidad; return;
            }
        }

        void bt_enviar()
        {
            isNaming = false;
            Funciones funciones = new Funciones();
            var (validado, nombre) = validar_nombre(txt_nombre.Text);
            if (validado)
            {
                switch (perfil_seleccionado)
                {
                    case 1:
                        nombre_perfil_1 = nombre;
                        bt_perfil1.Text = nombre;
                        funciones.escribir_datos(linea_nom_perf1, nombre);
                        if (validado_seguido || cambia_nombre)
                        {
                            validado_seguido = abrir_ventana(nombre_perfil_1, x, y1, perfil_seleccionado);
                        }
                        cambia_nombre = false;
                        return;
                    case 2:
                        nombre_perfil_2 = nombre;
                        bt_perfil2.Text = nombre;
                        funciones.escribir_datos(linea_nom_perf2, nombre);
                        if (validado_seguido || cambia_nombre)
                        {
                            validado_seguido = abrir_ventana(nombre_perfil_2, x, y2, perfil_seleccionado);
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
                bt_enviar();
            }
        }

        //Perfil 1

        string nombre_perfil_1 = "";
        int y1 = 70;
        string[] modalidad_angulos_perfil1 = new string[3];
        string[] values_angulo_perfil1 = new string[3];
        Color[,] colores_arriba_perfil1 = new Color[8, 8];
        Color[,] colores_izq_perfil1 = new Color[8, 8];
        Color[,] colores_der_perfil1 = new Color[8, 8];

        int filas_arr = 8;
        int columnas_arr = 8;
        int filas_izq = 8;
        int columnas_izq = 8;
        int filas_der = 8;
        int columnas_der = 8;
        private void iconButton1_Click(object sender, EventArgs e)
        {
            bt_perfil2.Enabled = true;
            bt_paint.Visible = false;
            bt_mouse.Visible = false;
            perfil_seleccionado = 0;
            panel_nom.Visible = false;
            panel_perfil.Visible = false;
            panel_wheel.Visible = false;
            perfil_seleccionado = 1;
            validado_seguido = abrir_ventana(nombre_perfil_1, x, y1, perfil_seleccionado);
            Funciones funciones = new Funciones();
            funciones.btPressed(sender, Color.Red, bt_perfil1, panel_borde,new Point(0,bt_perfil1.Location.Y));
            funciones.btNotPressed(bt_perfil2);
        }

        //Perfil 2

        string nombre_perfil_2 = "";
        int y2 = 141;
        string[] modalidad_angulos_perfil2 = new string[3];
        string[] values_angulo_perfil2 = new string[3];
        Color[,] colores_arriba_perfil2 = new Color[8, 8];
        Color[,] colores_izq_perfil2 = new Color[8, 8];
        Color[,] colores_der_perfil2 = new Color[8, 8];
        private void bt_perf2_Click(object sender, EventArgs e)
        {
            bt_perfil1.Enabled = true;
            bt_paint.Visible = false;
            bt_mouse.Visible = false;
            perfil_seleccionado = 0;
            panel_nom.Visible = false;
            panel_perfil.Visible = false;
            panel_wheel.Visible = false;
            perfil_seleccionado = 2;
            validado_seguido = abrir_ventana(nombre_perfil_2, x, y2, perfil_seleccionado);
            Funciones funciones = new Funciones();
            funciones.btPressed(sender, Color.Red, bt_perfil2, panel_borde, new Point(0, bt_perfil2.Location.Y));
            funciones.btNotPressed(bt_perfil1);
        }
        //Aplicar iconos a manejo icon:car

        //Eventos nombre

        private void bt_enviar_nombre_Click(object sender, EventArgs e)
        {
            bt_enviar();
        }
        private void bt_cambiar_nombre_Click_1(object sender, EventArgs e)
        {
            isNaming = true;
            panel_perfil.Visible = false;
            panel_wheel.Visible = false;
            bt_mouse.Visible = false;
            bt_paint.Visible = false;
            switch (perfil_seleccionado)
            {
                case 1:
                    panel_nom.Location = new Point(x, y1);
                    break;
                case 2:
                    panel_nom.Location = new Point(x, y2);
                    break;

            }

            panel_nom.Visible = true;
            cambia_nombre = true;
        }
        private void bt_manejo_Click(object sender, EventArgs e)
        {
            Manejo manejo = new Manejo();
            manejo.Show();
            this.Close();
        }
        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            enter(e.KeyChar == (char)Keys.Enter);
        }

        //Eventos modos
        private void bt_mousr_Click(object sender, EventArgs e)
        {
            bt_mouse.Enabled = false;
            bt_paint.Enabled = true;
            Modo_dibujo = false;
        }
        private void bt_paint_Click(object sender, EventArgs e)
        {
            bt_mouse.Enabled = true;
            bt_paint.Enabled = false;
            Modo_dibujo = true;
        }

        //Evento seleccionar angulo

        void reset_paneles()
        {
            if (Comb_tipos_personalizados.SelectedIndex != 0)
            {
                panel_wheel.Visible = false;
            }
            lbl_selec_velocidad_arr.Visible = false;
            lbl_selec_velocidad_izq.Visible = false;
            lbl_selec_velocidad_der.Visible = false;
            lbl_selec_velocidad_arr.Location = new Point(110, 30);
            lbl_selec_velocidad_izq.Location = new Point(110, 30);
            lbl_selec_velocidad_der.Location = new Point(110, 30);
            int x_velocidades = 160;
            int y_rap = 75;
            int y_len = 414;
            int y_med = 217;
            lbl_rap_arr.Visible = false;
            lbl_rap_izq.Visible = false;
            lbl_rap_der.Visible = false;
            lbl_med_arr.Visible = false;
            lbl_med_izq.Visible = false;
            lbl_med_der.Visible = false;
            lbl_len_arr.Visible = false;
            lbl_len_izq.Visible = false;
            lbl_len_der.Visible = false;
            lbl_rap_arr.Location = new Point(x_velocidades, y_rap);
            lbl_rap_izq.Location = new Point(x_velocidades, y_rap);
            lbl_rap_der.Location = new Point(x_velocidades, y_rap);
            lbl_med_arr.Location = new Point(x_velocidades, y_med);
            lbl_med_izq.Location = new Point(x_velocidades, y_med);
            lbl_med_der.Location = new Point(x_velocidades, y_med);
            lbl_len_arr.Location = new Point(x_velocidades, y_len);
            lbl_len_izq.Location = new Point(x_velocidades, y_len);
            lbl_len_der.Location = new Point(x_velocidades, y_len);
            trackBar_arr.Visible = false;
            trackBar_izq.Visible = false;
            trackBar_der.Visible = false;
            bt_enviar_configuraciones.Visible = true;
            trackBar_arr.Value = trackBar_arr.Minimum;
            trackBar_izq.Value = trackBar_izq.Minimum;
            trackBar_der.Value = trackBar_der.Minimum;
            bt_mouse.Enabled = false;
            bt_paint.Enabled = true;
            Modo_dibujo = false;
            bt_mouse.Visible = false;
            bt_paint.Visible = false;
            bt_reset_cols.Visible = false;
        }

        void comb_angulo_change()
        {
            panel_arriba.Visible = false;
            panel_derecha.Visible = false;
            panel_izquierda.Visible = false;
            panel_wheel.Visible = false;
            Comb_tipos_personalizados.Visible = true;
            lbl_mod.Visible = true;
            bt_enviar_configuraciones.Visible = false;
            bt_mouse.Visible = false;
            bt_paint.Visible = false;
            bt_mouse.Enabled = false;
            bt_reset_cols.Visible = false;
            bt_paint.Enabled = true;
            Modo_dibujo = false;
            angulo_seleccionado = comb_angulo.SelectedIndex;
        }
        private void comb_angulo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comb_angulo_change();
            Comb_tipos_personalizados.SelectedItem = null;
        }

        //Evento seleccionar tipo de iluminación
        private void Comb_tipos__personalizados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Comb_tipos_personalizados.SelectedItem != null)
            {
                Funciones funciones = new Funciones();
                reset_paneles();
                panel_arriba.Invalidate();
                panel_izquierda.Invalidate();
                panel_derecha.Invalidate();
                asignar_modalidad(perfil_seleccionado, angulo_seleccionado, Comb_tipos_personalizados.SelectedItem.ToString().ToLower());
                bt_enviar_configuraciones.Visible = true;
                if (Comb_tipos_personalizados.SelectedItem.ToString().ToLower() == "apagado")
                {
                    SolidBrush xx = new SolidBrush(Color.White);
                    asignar_valores(Comb_tipos_personalizados.SelectedItem.ToString().ToLower(), -1, -1, xx, -1);
                }
                switch (angulo_seleccionado)
                {
                    case 0:
                        panel_arriba.Visible = true; break;
                    case 1:
                        panel_izquierda.Visible = true; break;
                    case 2:
                        panel_derecha.Visible = true; break;
                }
                if (perfil_seleccionado == 1)
                {
                    switch (angulo_seleccionado)
                    {
                        case 0:
                            funciones.escribir_valores(mod_1a, Comb_tipos_personalizados.SelectedItem.ToString(), 0);
                            break;
                        case 1:
                            funciones.escribir_valores(mod_1i, Comb_tipos_personalizados.SelectedItem.ToString(), 0);
                            break;
                        case 2:
                            funciones.escribir_valores(mod_1d, Comb_tipos_personalizados.SelectedItem.ToString(), 0);
                            break;
                    }
                }
                else
                {
                    switch (angulo_seleccionado)
                    {
                        case 0:
                            funciones.escribir_valores(mod_2a, Comb_tipos_personalizados.SelectedItem.ToString(), 0);
                            break;
                        case 1:
                            funciones.escribir_valores(mod_2i, Comb_tipos_personalizados.SelectedItem.ToString(), 0);
                            break;
                        case 2:
                            funciones.escribir_valores(mod_2d, Comb_tipos_personalizados.SelectedItem.ToString(), 0);
                            break;
                    }
                }
            }

        }

        //Funciones paneles
        private void bt_reset_cols_Click(object sender, EventArgs e)
        {
            reseteando = true;
            switch (angulo_seleccionado)
            {
                case 0:
                    panel_arriba.Invalidate();
                    break;
                case 1:
                    panel_izquierda.Invalidate();
                    break;
                case 2:
                    panel_derecha.Invalidate();
                    break;
            }
        }
        Color[,] dibujar_colorear_ellipses(Funciones funciones, int linea_leer, Graphics graph, int x, int y)
        {
            var (colores_ellipses, rColores) = funciones.leer_colores(linea_leer, x, y);
            int color_index = 0;
            foreach (Rectangle rectangle in ellipses)
            {
                graph.DrawEllipse(pen, rectangle);
                if (colores_ellipses.Count > 0 && !reseteando)
                {
                    SolidBrush color = new SolidBrush(colores_ellipses[color_index]);
                    if (color.Color != Color.FromArgb(0, 0, 0))
                    {
                        graph.FillEllipse(color, rectangle);
                    }
                }
                color_index++;
            }
            if (reseteando)
            {
                reseteando = false;
                for (int i = 0; i < x; i++)
                {
                    for (int j = 0; j < y; j++)
                    {
                        rColores[i, j] = Color.FromArgb(0, 0, 0);
                    }
                }
                funciones.escribir_colores(linea_leer, rColores);
            }
            return rColores;
        }
        void panel_paint(string modo_de_luz, Graphics graph)
        {
            SolidBrush a = new SolidBrush(Color.White);
            Funciones funciones = new Funciones();
            if (modo_de_luz == "Independiente")
            {
                open_form();
                crear_ellipses(panel_arriba.Width, panel_arriba.Height, 8, 8);
                bt_paint.Visible = true;
                bt_mouse.Visible = true;
                if (perfil_seleccionado == 1)
                {
                    switch (angulo_seleccionado)
                    {
                        case 0:
                            colores_arriba_perfil1 = dibujar_colorear_ellipses(funciones, lin_1a, graph, columnas_arr, filas_arr);
                            break;
                        case 1:
                            colores_izq_perfil1 = dibujar_colorear_ellipses(funciones, lin_1i, graph, columnas_izq, filas_izq);
                            break;
                        case 2:
                            colores_der_perfil1 = dibujar_colorear_ellipses(funciones, lin_1d, graph, columnas_der, filas_der);
                            break;
                    }
                }
                else
                {
                    switch (angulo_seleccionado)
                    {
                        case 0:
                            colores_arriba_perfil2 = dibujar_colorear_ellipses(funciones, lin_2a, graph, columnas_arr, filas_arr);
                            break;
                        case 1:
                            colores_izq_perfil2 = dibujar_colorear_ellipses(funciones, lin_2i, graph, columnas_izq, filas_izq);
                            break;
                        case 2:
                            colores_der_perfil2 = dibujar_colorear_ellipses(funciones, lin_2d, graph, columnas_der, filas_der);
                            break;
                    }
                }
                bt_reset_cols.Visible = true;
            }
            else if (modo_de_luz == "Apagado")
            {
                asignar_valores(modo_de_luz, -1, -1, a, -1);
            }
            else
            {
                lbl_selec_velocidad_arr.Visible = true;
                lbl_selec_velocidad_izq.Visible = true;
                lbl_selec_velocidad_der.Visible = true;
                switch (angulo_seleccionado)
                {
                    case 0:
                        if (perfil_seleccionado == 1)
                        {
                            string[] mod_value1a = funciones.leer_valores(mod_1a);
                            if (mod_value1a.Length > 1 && mod_value1a[1] != "")
                            {
                                trackBar_arr.Value = Convert.ToInt32(valor_track(Convert.ToInt32(mod_value1a[1])));
                                asignar_valores(mod_value1a[0], -1, -1, a, Convert.ToInt32(valor_track(Convert.ToInt32(mod_value1a[1]))));
                            }
                        }
                        else
                        {
                            string[] mod_value2a = funciones.leer_valores(mod_2a);
                            if (mod_value2a.Length > 1 && mod_value2a[1] != "")
                            {
                                trackBar_arr.Value = Convert.ToInt32(valor_track(Convert.ToInt32(mod_value2a[1])));
                                asignar_valores(mod_value2a[0], -1, -1, a, Convert.ToInt32(valor_track(Convert.ToInt32(mod_value2a[1]))));
                            }
                        }
                        trackBar_arr.Visible = true;
                        lbl_rap_arr.Visible = true;
                        lbl_med_arr.Visible = true;
                        lbl_len_arr.Visible = true;
                        break;
                    case 1:
                        if (perfil_seleccionado == 1)
                        {
                            string[] mod_value1i = funciones.leer_valores(mod_1i);
                            if (mod_value1i.Length > 1 && mod_value1i[1] != "")
                            {
                                trackBar_izq.Value = Convert.ToInt32(valor_track(Convert.ToInt32(mod_value1i[1])));
                                asignar_valores(mod_value1i[0], -1, -1, a, Convert.ToInt32(valor_track(Convert.ToInt32(mod_value1i[1]))));
                            }
                        }
                        else
                        {
                            string[] mod_value2i = funciones.leer_valores(mod_2i);
                            if (mod_value2i.Length > 1 && mod_value2i[1] != "")
                            {
                                trackBar_izq.Value = Convert.ToInt32(valor_track(Convert.ToInt32(mod_value2i[1])));
                                asignar_valores(mod_value2i[0], -1, -1, a, Convert.ToInt32(valor_track(Convert.ToInt32(mod_value2i[1]))));
                            }
                        }
                        trackBar_izq.Visible = true;
                        lbl_rap_izq.Visible = true;
                        lbl_med_izq.Visible = true;
                        lbl_len_izq.Visible = true;
                        break;
                    case 2:
                        if (perfil_seleccionado == 1)
                        {
                            string[] mod_value1d = funciones.leer_valores(mod_1d);
                            if (mod_value1d.Length > 1 && mod_value1d[1] != "")
                            {
                                trackBar_der.Value = Convert.ToInt32(valor_track(Convert.ToInt32(mod_value1d[1])));
                                asignar_valores(mod_value1d[0], -1, -1, a, Convert.ToInt32(valor_track(Convert.ToInt32(mod_value1d[1]))));
                            }
                        }
                        else
                        {
                            string[] mod_value2d = funciones.leer_valores(mod_2d);
                            if (mod_value2d.Length > 1 && mod_value2d[1] != "")
                            {
                                trackBar_der.Value = Convert.ToInt32(valor_track(Convert.ToInt32(mod_value2d[1])));
                                asignar_valores(mod_value2d[0], -1, -1, a, Convert.ToInt32(valor_track(Convert.ToInt32(mod_value2d[1]))));
                            }
                        }
                        trackBar_der.Visible = true;
                        lbl_rap_der.Visible = true;
                        lbl_med_der.Visible = true;
                        lbl_len_der.Visible = true;
                        break;
                }
            }
        }
        void Mouse_down_move(string modo_de_luz, Graphics graph, Point lugar_clickeado, bool Mouse_down)
        {
            if (modo_de_luz == "Independiente")
            {
                if (Mouse_down)
                {
                    Dibujando = true;
                }
                var (validado, arriba, horizontalmente, color) = coloreando(Dibujando, Modo_dibujo, color_pincel_inicial, color_wheel.Color_del_panel(), lugar_clickeado, graph);
                if (validado)
                {
                    asignar_valores(modo_de_luz, horizontalmente, arriba, color, -1);
                }
            }
        }
        void Mouse_leave_up(string modo_de_luz)
        {
            Funciones funciones = new Funciones();
            if (modo_de_luz == "Independiente")
            {
                Dibujando = false;
            }
        }
        string valor_track(int valor_ingresado)
        {
            int valor_final = 1001 - valor_ingresado;
            return valor_final.ToString();
        }
        void asignar_valores(string modo_luz, int horizontalmente, int arriba, SolidBrush color, int trackbar_value)
        {
            Funciones funciones = new Funciones();
            if (modo_luz == "Independiente")
            {
                switch (perfil_seleccionado)
                {
                    case 1:
                        switch (angulo_seleccionado)
                        {
                            case 0:
                                colores_arriba_perfil1[arriba, horizontalmente] = color.Color;
                                values_angulo_perfil1[0] = "independiente";
                                funciones.escribir_datos(mod_1a, "independiente");
                                funciones.escribir_colores(lin_1a, colores_arriba_perfil1);
                                return;
                            case 1:
                                colores_izq_perfil1[arriba, horizontalmente] = color.Color;
                                values_angulo_perfil1[1] = "independiente";
                                funciones.escribir_datos(mod_1i, "independiente");
                                funciones.escribir_colores(lin_1i, colores_izq_perfil1);
                                return;
                            case 2:
                                colores_der_perfil1[arriba, horizontalmente] = color.Color;
                                values_angulo_perfil1[2] = "independiente";
                                funciones.escribir_datos(mod_1d, "independiente");
                                funciones.escribir_colores(lin_1d, colores_der_perfil1);
                                return;
                        }
                        return;
                    case 2:
                        switch (angulo_seleccionado)
                        {
                            case 0:
                                colores_arriba_perfil2[arriba, horizontalmente] = color.Color;
                                values_angulo_perfil2[0] = "independiente";
                                funciones.escribir_datos(mod_2a, "independiente");
                                funciones.escribir_colores(lin_2a, colores_arriba_perfil2);
                                return;
                            case 1:
                                colores_izq_perfil2[arriba, horizontalmente] = color.Color;
                                values_angulo_perfil2[1] = "independiente";
                                funciones.escribir_datos(mod_2i, "independiente");
                                funciones.escribir_colores(lin_2i, colores_izq_perfil2);
                                return;
                            case 2:
                                colores_der_perfil2[arriba, horizontalmente] = color.Color;
                                values_angulo_perfil2[2] = "independiente";
                                funciones.escribir_datos(mod_2d, "independiente");
                                funciones.escribir_colores(lin_2d, colores_der_perfil2);
                                return;
                        }
                        return;
                }
            }
            else if (modo_luz == "Apagado")
            {
                switch (perfil_seleccionado)
                {
                    case 1:
                        switch (angulo_seleccionado)
                        {
                            case 0:
                                values_angulo_perfil1[0] = "apagado";
                                funciones.escribir_datos(mod_1a, "Apagado");
                                return;
                            case 1:
                                values_angulo_perfil1[1] = "apagado";
                                funciones.escribir_datos(mod_1i, "Apagado");
                                return;
                            case 2:
                                values_angulo_perfil1[2] = "apagado";
                                funciones.escribir_datos(mod_1d, "Apagado");
                                return;
                        }
                        return;
                    case 2:
                        switch (angulo_seleccionado)
                        {
                            case 0:
                                values_angulo_perfil2[0] = "apagado";
                                funciones.escribir_datos(mod_2a, "Apagado");
                                return;
                            case 1:
                                values_angulo_perfil2[1] = "apagado";
                                funciones.escribir_datos(mod_2i, "Apagado");
                                return;
                            case 2:
                                values_angulo_perfil2[2] = "apagado";
                                funciones.escribir_datos(mod_2d, "Apagado");
                                return;
                        }
                        return;
                }
            }
            else
            {
                string valor_final = valor_track(trackbar_value);
                switch (perfil_seleccionado)
                {
                    case 1:
                        switch (angulo_seleccionado)
                        {
                            case 0:
                                values_angulo_perfil1[0] = valor_final;
                                funciones.escribir_datos(mod_1a, $"{modo_luz} {valor_final}");
                                return;
                            case 1:
                                values_angulo_perfil1[1] = valor_final;
                                funciones.escribir_datos(mod_1i, $"{modo_luz} {valor_final}");
                                return;
                            case 2:
                                values_angulo_perfil1[2] = valor_final;
                                funciones.escribir_datos(mod_1d, $"{modo_luz} {valor_final}");
                                return;
                        }
                        return;
                    case 2:
                        switch (angulo_seleccionado)
                        {
                            case 0:
                                values_angulo_perfil2[0] = valor_final;
                                funciones.escribir_datos(mod_2a, $"{modo_luz} {valor_final}");
                                return;
                            case 1:
                                values_angulo_perfil2[1] = valor_final;
                                funciones.escribir_datos(mod_2i, $"{modo_luz} {valor_final}");
                                return;
                            case 2:
                                values_angulo_perfil2[2] = valor_final;
                                funciones.escribir_datos(mod_2d, $"{modo_luz} {valor_final}");
                                return;
                        }
                        return;
                }
            }
        }

        //Eventos panel arriba

        Graphics graphs_arriba;
        private void panel_arriba_MouseDown(object sender, MouseEventArgs e)
        {
            Point punto_click = e.Location;
            bool activar_dibujar = true;
            Mouse_down_move(Comb_tipos_personalizados.SelectedItem.ToString(), graphs_arriba, punto_click, activar_dibujar);
        }

        private void panel_arriba_MouseMove(object sender, MouseEventArgs e)
        {
            Point punto_click = e.Location;
            bool activar_dibujar = false;
            Mouse_down_move(Comb_tipos_personalizados.SelectedItem.ToString(), graphs_arriba, punto_click, activar_dibujar);
        }

        private void panel_arriba_MouseUp(object sender, MouseEventArgs e)
        {
            Mouse_leave_up(Comb_tipos_personalizados.SelectedItem.ToString());
        }

        private void panel_arriba_Paint(object sender, PaintEventArgs e)
        {
            graphs_arriba = panel_arriba.CreateGraphics();
            if (Comb_tipos_personalizados.SelectedItem != null)
            {
                panel_paint(Comb_tipos_personalizados.SelectedItem.ToString(), graphs_arriba);
            }
        }

        private void panel_arriba_MouseLeave(object sender, EventArgs e)
        {
            Mouse_leave_up(Comb_tipos_personalizados.SelectedItem.ToString());
        }
        private void trackBar_arr_Scroll(object sender, EventArgs e)
        {
            SolidBrush col = new SolidBrush(Color.White);
            asignar_valores(Comb_tipos_personalizados.SelectedItem.ToString(), -1, -1, col, trackBar_arr.Value);
        }

        //Eventos panel derecha

        Graphics graphs_derecha;

        private void panel_derecha_Paint(object sender, PaintEventArgs e)
        {
            graphs_derecha = panel_derecha.CreateGraphics();
            panel_paint(Comb_tipos_personalizados.SelectedItem.ToString(), graphs_derecha);
        }
        private void panel_derecha_MouseDown(object sender, MouseEventArgs e)
        {
            Point punto_click = e.Location;
            bool activar_dibujar = true;
            Mouse_down_move(Comb_tipos_personalizados.SelectedItem.ToString(), graphs_derecha, punto_click, activar_dibujar);
        }
        private void panel_derecha_MouseMove(object sender, MouseEventArgs e)
        {
            Point punto_click = e.Location;
            bool activar_dibujar = false;
            Mouse_down_move(Comb_tipos_personalizados.SelectedItem.ToString(), graphs_derecha, punto_click, activar_dibujar);
        }
        private void panel_derecha_MouseUp(object sender, MouseEventArgs e)
        {
            Mouse_leave_up(Comb_tipos_personalizados.SelectedItem.ToString());
        }
        private void panel_derecha_MouseLeave(object sender, EventArgs e)
        {
            Mouse_leave_up(Comb_tipos_personalizados.SelectedItem.ToString());
        }
        private void trackBar_der_Scroll(object sender, EventArgs e)
        {
            SolidBrush col = new SolidBrush(Color.White);
            asignar_valores(Comb_tipos_personalizados.SelectedItem.ToString(), -1, -1, col, trackBar_der.Value);
        }

        //Eventos panel izquierda
        Graphics graphs_izq;
        private void panel_izquierda_Paint(object sender, PaintEventArgs e)
        {
            graphs_izq = panel_izquierda.CreateGraphics();
            panel_paint(Comb_tipos_personalizados.SelectedItem.ToString(), graphs_izq);
        }
        private void panel_izquierda_MouseDown(object sender, MouseEventArgs e)
        {
            Point punto_click = e.Location;
            bool activar_dibujar = true;
            Mouse_down_move(Comb_tipos_personalizados.SelectedItem.ToString(), graphs_izq, punto_click, activar_dibujar);
        }
        private void panel_izquierda_MouseMove(object sender, MouseEventArgs e)
        {
            Point punto_click = e.Location;
            bool activar_dibujar = false;
            Mouse_down_move(Comb_tipos_personalizados.SelectedItem.ToString(), graphs_izq, punto_click, activar_dibujar);

        }
        private void panel_izquierda_MouseUp(object sender, MouseEventArgs e)
        {
            Mouse_leave_up(Comb_tipos_personalizados.SelectedItem.ToString());
        }
        private void panel_izquierda_MouseLeave(object sender, EventArgs e)
        {
            Mouse_leave_up(Comb_tipos_personalizados.SelectedItem.ToString());
        }
        private void trackBar_izq_Scroll(object sender, EventArgs e)
        {
            SolidBrush col = new SolidBrush(Color.White);
            asignar_valores(Comb_tipos_personalizados.SelectedItem.ToString(), -1, -1, col, trackBar_izq.Value);
        }

        //Enviar configuraciones

        bool comprobar_msg(string input)
        {
            if (input.Substring(input.Length - 2) != "::")
            {
                return true;
            }
            return false;

        }
        List<string> hacer_mensaje(int angulo, int cant_filas, int cant_columnas, string modalidad, Color[,] matriz_colores1, Color[,] matriz_colores2, int perfil)
        {
            List<string> mensajes = new List<string>();
            Funciones func_enviar = new Funciones();
            string mensaje = null;
            if (modalidad == "independiente")
            {
                switch (perfil)
                {
                    case 1:
                        for (int fila = 0; fila < cant_filas; fila++)
                        {
                            for (int columna = 0; columna < cant_columnas; columna++)
                            {
                                mensaje = func_enviar.string_a_enviar("personalizacion", perfil, angulo, modalidad_angulos_perfil1[angulo], values_angulo_perfil1[angulo], matriz_colores1[fila, columna], fila, columna, "", -1);
                                if (comprobar_msg(mensaje))
                                {
                                    mensajes.Add(mensaje);
                                }
                            }
                        }
                        return mensajes;
                    case 2:
                        for (int fila = 0; fila < cant_filas; fila++)
                        {
                            for (int columna = 0; columna < cant_columnas; columna++)
                            {
                                mensaje = func_enviar.string_a_enviar("personalizacion", perfil, angulo, modalidad_angulos_perfil1[angulo], values_angulo_perfil1[angulo], matriz_colores2[fila, columna], fila, columna, "", -1);
                                if (comprobar_msg(mensaje))
                                {
                                    mensajes.Add(mensaje);
                                }
                            }
                        }
                        return mensajes;
                }
            }
            else
            {
                switch (perfil)
                {
                    case 1:
                        mensaje = func_enviar.string_a_enviar("personalizacion", perfil, angulo, modalidad_angulos_perfil1[angulo], values_angulo_perfil1[angulo], Color.White, -1, -1, "", -1);
                        if (comprobar_msg(mensaje))
                        {
                            mensajes.Add(mensaje);
                        }
                        return mensajes;
                    case 2:
                        mensaje = func_enviar.string_a_enviar("personalizacion", perfil, angulo, modalidad_angulos_perfil2[angulo], values_angulo_perfil2[angulo], Color.White, -1, -1, "", -1);
                        if (comprobar_msg(mensaje))
                        {
                            mensajes.Add(mensaje);
                        }
                        return mensajes;
                }
            }
            if (comprobar_msg(mensaje))
            {
                mensajes.Add(mensaje);
            }
            return mensajes;
        }

        List<string> ultimos_msgs = new List<string>();
        private void bt_enviar_configuraciones_Click(object sender, EventArgs e)
        {
            Funciones funciones = new Funciones();
            List<string> msgs_angulo_arr1 = new List<string>();
            List<string> msgs_angulo_izq1 = new List<string>();
            List<string> msgs_angulo_der1 = new List<string>();
            List<string> msgs_angulo_arr2 = new List<string>();
            List<string> msgs_angulo_izq2 = new List<string>();
            List<string> msgs_angulo_der2 = new List<string>();
            for (int i = 0; i < 3; i++)
            {
                switch (i)
                {
                    case 0:
                        msgs_angulo_arr1 = hacer_mensaje(i, filas_arr, columnas_arr, modalidad_angulos_perfil1[i], colores_arriba_perfil1, colores_arriba_perfil2, 1);
                        msgs_angulo_arr2 = hacer_mensaje(i, filas_arr, columnas_arr, modalidad_angulos_perfil2[i], colores_arriba_perfil1, colores_arriba_perfil2, 2);
                        break;
                    case 1:
                        msgs_angulo_izq1 = hacer_mensaje(i, filas_izq, columnas_izq, modalidad_angulos_perfil1[i], colores_arriba_perfil1, colores_arriba_perfil2, 1);
                        msgs_angulo_izq2 = hacer_mensaje(i, filas_izq, columnas_izq, modalidad_angulos_perfil2[i], colores_arriba_perfil1, colores_arriba_perfil2, 2);
                        break;
                    case 2:
                        msgs_angulo_der1 = hacer_mensaje(i, filas_der, columnas_der, modalidad_angulos_perfil1[i], colores_arriba_perfil1, colores_arriba_perfil2, 1);
                        msgs_angulo_der2 = hacer_mensaje(i, filas_der, columnas_der, modalidad_angulos_perfil2[i], colores_arriba_perfil1, colores_arriba_perfil2, 2);
                        break;
                }
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
                    DialogResult result = MessageBox.Show("¿Desea enviar todos las configuraciones desde cero? NOTA: puede tardar más tiempo", "Enviando", MessageBoxButtons.YesNoCancel);
                    if (result != DialogResult.Cancel)
                    {
                        string[] todos_msgs = msgs_angulo_arr1.Concat(msgs_angulo_arr2).Concat(msgs_angulo_der1).Concat(msgs_angulo_der2).Concat(msgs_angulo_izq1).Concat(msgs_angulo_izq2).ToArray();
                        ultimos_msgs = todos_msgs.ToList();
                        arduino.Open();
                        ProgressBar progressBar = new ProgressBar();
                        progressBar.cant_msgs = 0;
                        progressBar.cant_msgs = todos_msgs.Length;
                        progressBar.Show();
                        int num_mensaje = 0;
                        foreach (string mensaje in todos_msgs)
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
                                Thread.Sleep(100);
                            }
                        }
                        progressBar.Close();
                        arduino.WriteLine("end");
                        arduino.Close();
                        MessageBox.Show("Mensajes enviados exitosamente", "Enviado");
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

        private void bt_cerrar_Click(object sender, EventArgs e)
        {
            Pantalla_principal mostrar0 = new Pantalla_principal();
            mostrar0.Show();
            this.Close();
        }

        private void lbl_pers_Click(object sender, EventArgs e)
        {
            panel_borde.Visible = false;
            panel_nom.Visible = false;
            panel_perfil.Visible = false;
            panel_wheel.Visible = false;
            panel_arriba.Visible = false;
            panel_izquierda.Visible = false;
            panel_derecha.Visible = false;
            Funciones funciones = new Funciones();
            funciones.btNotPressed(bt_perfil1);
            funciones.btNotPressed(bt_perfil2);
            bt_perfil1.Enabled=true;
            bt_perfil2.Enabled=true;
            bt_mouse.Enabled=true;
            bt_mouse.Visible = false;
            bt_paint.Enabled=true;
            bt_paint.Visible = false;
            bt_reset_cols.Visible = false;
        }
    }
}