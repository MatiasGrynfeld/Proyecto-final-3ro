using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Proyecto_Final___Wingo
{
    public partial class Personalización___perfil : Form
    {
        //Variables

        int red = 0;
        int green = 0;
        int blue = 0;
        bool mouse_apretado = false;
        Color color_leds;
        public Color color_default;

        //Funciones

        void color_picker(Graphics graphs, int wid, int hgt)
        {
            Rectangle perimetro = new Rectangle(0, 0, wid, hgt);
            GraphicsPath camino = new GraphicsPath();
            camino.AddEllipse(perimetro);
            camino.Flatten();

            int num_pts = (camino.PointCount - 1) / 3;
            Color[] surround_colors = new Color[camino.PointCount];
            float r = 255, g = 0, b = 0;
            float dr, dg, db;
            dr = -255 / num_pts;
            db = 255 / num_pts;
            for (int i = 0; i < num_pts; i++)
            {
                surround_colors[i] =
                    Color.FromArgb(255, (int)r, (int)g, (int)b);
                r += dr;
                b += db;
            }

            r = 0; g = 0; b = 255;
            dg = 255 / num_pts;
            db = -255 / num_pts;
            for (int i = num_pts; i < 2 * num_pts; i++)
            {
                surround_colors[i] =
                    Color.FromArgb(255, (int)r, (int)g, (int)b);
                g += dg;
                b += db;
            }

            r = 0; g = 255; b = 0;
            dr = 255 / (camino.PointCount - 2 * num_pts);
            dg = -255 / (camino.PointCount - 2 * num_pts);
            for (int i = 2 * num_pts; i < camino.PointCount; i++)
            {
                surround_colors[i] =
                    Color.FromArgb(255, (int)r, (int)g, (int)b);
                r += dr;
                g += dg;
            }

            PathGradientBrush path_brush = new PathGradientBrush(camino);
            path_brush.CenterColor = Color.White;
            path_brush.SurroundColors = surround_colors;
            graphs.FillEllipse(path_brush, perimetro);
        }

        Color obtener_color_pixel(Point lugar_clickeado)
        {
            Point centro = new Point(panel_wheel.Width / 2, panel_wheel.Height / 2);
            Bitmap perimetro = new Bitmap(panel_wheel.Width, panel_wheel.Height);
            panel_wheel.DrawToBitmap(perimetro, panel_wheel.ClientRectangle);

            double radio = panel_wheel.Width / 2;
            double distancia = CalcularDistancia(centro.X,centro.Y,lugar_clickeado.X,lugar_clickeado.Y);

            if (distancia <= radio)
            {
                Color color_pixel = perimetro.GetPixel(lugar_clickeado.X, lugar_clickeado.Y);
                red = color_pixel.R;
                green = color_pixel.G;
                blue = color_pixel.B;
                panel_muestra.BackColor = Color.FromArgb(red, green, blue);
                color_leds = Color.FromArgb(red, green, blue);
                lbl_red.Visible = true;
                lbl_red.Text = $"Red: {red}.";
                lbl_green.Visible = true;
                lbl_green.Text = $"Green: {green}.";
                lbl_blue.Visible = true;
                lbl_blue.Text = $"Blue: {blue}.";
                bt_resetear.Visible = true;
                lbl_color_seleccionado.Visible = true;
                return color_leds;
            }
            else
            {
                return color_leds;
            }
        }
        double CalcularDistancia(int x1, int y1, int x2, int y2)
        {
            double diferenciaX = x2 - x1;
            double diferenciaY = y2 - y1;
            double distance = Math.Sqrt(diferenciaX * diferenciaX + diferenciaY * diferenciaY);
            return distance;
        }

        public Color Color_del_panel()
        {
            color_leds = panel_muestra.BackColor;
            return color_leds;
        }

        public void resetear()
        {
            panel_muestra.BackColor = color_default;
            bt_resetear.Visible = false;
            lbl_color_seleccionado.Visible = false;
            lbl_red.Visible = false;
            lbl_green.Visible = false;
            lbl_blue.Visible = false;
        }

        //Load
        public Personalización___perfil()
        {
            InitializeComponent();
            lbl_blue.Visible = false;
            lbl_green.Visible = false;
            lbl_red.Visible = false;
            bt_resetear.Visible = false;
            lbl_color_seleccionado.Visible = false;
            color_default = panel_muestra.BackColor;
            Funciones funciones = new Funciones();
            funciones.initializePanels(this);
            funciones.initializeLabels(this);
            funciones.initializeButtons(this);
        }

        //Events

        private void panel_wheel_Paint(object sender, PaintEventArgs e)
        {
            Graphics Graphs = e.Graphics;
            color_picker(Graphs, 375, 375);
        }
        private void panel_wheel_MouseClick(object sender, MouseEventArgs e)
        {
            color_leds=obtener_color_pixel(e.Location);
        }
        private void panel_wheel_MouseDown(object sender, MouseEventArgs e)
        {
            mouse_apretado = true;
        }
        private void panel_wheel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouse_apretado)
            {
                color_leds = obtener_color_pixel(e.Location);
            }
        }
        private void panel_wheel_MouseUp(object sender, MouseEventArgs e)
        {
            mouse_apretado = false;
        }

        private void bt_resetear_Click(object sender, EventArgs e)
        {
            resetear();
        }

        private void bt_apagado_Click(object sender, EventArgs e)
        {
            panel_muestra.BackColor = Color.Black;
            bt_resetear.Visible = true;
            lbl_blue.Text = "Blue: 255";
            lbl_green.Text = "Green: 255";
            lbl_red.Text = "Red: 255";
        }
    }
}
