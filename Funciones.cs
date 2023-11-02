using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace Proyecto_Final___Wingo
{
    class Funciones
    {
        public string string_a_enviar(string tipo_modalidad, int pers_perfil, int pers_angulo, string pers_modalidad, string delay, Color color, int fila, int columna, string man_tipo_paso, int man_cant_paso)
        {
            string mensaje_final = null;
            string perf="0";
            switch (pers_perfil)
            {
                case 1:
                    perf = "1";
                    break;
                case 2:
                    perf = "2";
                    break;
            }
            if (tipo_modalidad == "personalizacion")
            {
                if (pers_modalidad == "independiente")
                {
                    int led_num = columna + fila * 8 + 64*pers_angulo;
                    mensaje_final = $":{led_num}:{color.R}:{color.G}:{color.B}";
                }
                else
                {
                    if (pers_modalidad == "apagado")
                    {
                        mensaje_final = $"{pers_modalidad}";
                    }
                    else
                    {
                        mensaje_final = $"{pers_modalidad}:{delay}";
                    }
                    switch (pers_angulo)
                    {
                        case 0:
                            mensaje_final = $"s:{perf}:0:{mensaje_final}";
                            break;
                        case 1:
                            mensaje_final = $"s:{perf}:1:{mensaje_final}";
                            break;
                        case 2:
                            mensaje_final = $"s:{perf}:2:{mensaje_final}";
                            break;
                    }
                }
                switch (pers_perfil)
                {
                    case 1:
                        mensaje_final = $"1{mensaje_final}";
                        break;
                    case 2:
                        mensaje_final = $"2{mensaje_final}";
                        break;
                }
                mensaje_final = $"p{mensaje_final}";
                return mensaje_final;
            }
            else
            {
                int pasotipo = -1;
                if (man_tipo_paso == "Avanzar")
                {
                    pasotipo = 0;
                    man_cant_paso *= 1000;
                }
                else if(man_tipo_paso == "Retroceder")
                {
                    pasotipo = 1;
                    man_cant_paso *= 1000;
                }
                else if (man_tipo_paso == "Girar hacia la izquierda")
                {
                    pasotipo = 2;
                }
                else if (man_tipo_paso == "Girar hacia la derecha")
                {
                    pasotipo = 3;
                }
                else if (man_tipo_paso == "Esperar")
                {
                    pasotipo = 4;
                    man_cant_paso *= 1000;
                }
                mensaje_final = $"{pasotipo}:{man_cant_paso}";
                return mensaje_final;
            }
        }
        string pathconfig = Program.pathConfig;
        public void escribir_datos(int linea_a_modificar, string dato_a_modificar)
        {
            string[] lineas = File.ReadAllLines(pathconfig);
            lineas[linea_a_modificar - 1] = dato_a_modificar;
            File.WriteAllLines(pathconfig, lineas);
        }

        public string leer_datos(int linea_a_leer)
        {
            string[] lineas = File.ReadAllLines(pathconfig);
            return lineas[linea_a_leer - 1];
        }

        public void escribir_colores(int linea_a_modificar, Color[,] colores)
        {
            string string_compuesto = "";
            string[] lineas = File.ReadAllLines(pathconfig);

            for (int x = 0; x < 8; x++)
            {
                for (int y = 0; y < 8; y++)
                {
                    Color color = colores[y, x];
                    string rgb_color = $"{color.R}:{color.G}:{color.B}";
                    string_compuesto = $"{string_compuesto}{rgb_color},";
                }
            }

            lineas[linea_a_modificar - 1] = string_compuesto.TrimEnd(',');
            File.WriteAllLines(pathconfig, lineas);
        }

        public (List<Color>, Color[,]) leer_colores(int linea_a_leer, int mx, int my)
        {
            List<Color> rColores = new List<Color>();
            string[] lineas = File.ReadAllLines(pathconfig);
            string colores = lineas[linea_a_leer - 1];
            string[] rgbColors = colores.Split(',');

            for (int i = 0; i < rgbColors.Length; i++)
            {
                string[] rgb = rgbColors[i].Split(':');
                if (rgb.Length == 3 && int.TryParse(rgb[0], out int r) && int.TryParse(rgb[1], out int g) && int.TryParse(rgb[2], out int b))
                {
                    Color color = Color.FromArgb(r, g, b);
                    rColores.Add(color);
                }
            }
            Color[,] rMColores = new Color[mx, my];
            if (rColores.Count > 0)
            {
                for (int x = 0; x < mx; x++)
                {
                    for (int y = 0; y < my; y++)
                    {
                        rMColores[y, x] = rColores[y + x * 8];
                    }
                }
            }

            return (rColores, rMColores);
        }
        public string[] leer_valores(int linea_a_leer)
        {
            string[] lineas = File.ReadAllLines(pathconfig);
            string[] rMods = lineas[linea_a_leer-1].Split(' ');
            return rMods;
        }

        public void escribir_valores(int linea_a_modificar, string dato_a_modificar, int parte_a_modificar)
        {
            string[] lineas = File.ReadAllLines(pathconfig);
            string[] reemplazo = lineas[linea_a_modificar - 1].Split(' ');
            reemplazo[parte_a_modificar] = dato_a_modificar;
            string devolver = reemplazo[0];
            for (int i = 1; i < reemplazo.Length; i++)
            {
                devolver = devolver + " " + reemplazo[i];
            }
            lineas[linea_a_modificar - 1] = devolver;
            File.WriteAllLines(pathconfig, lineas);
        }

        public (List<string>, List<int>) leer_recor(int linea_a_leer)
        {
            string[] lineas = File.ReadAllLines(pathconfig);
            List<string> rTipo = new List<string>();
            List<int> rCant = new List<int>();
            if (lineas[linea_a_leer - 1] != "")
            {
                string[] partes = lineas[linea_a_leer - 1].Split('-');
                foreach (string paso in partes)
                {
                    string[] tipoCant = paso.Split(' ');
                    string tipo = tipoCant[0];
                    if (tipo == "GI")
                    {
                        tipo = "Girar hacia la izquierda";
                    }
                    else if(tipo == "GD")
                    {
                        tipo = "Girar hacia la derecha";
                    }
                    rTipo.Add(tipo);
                    rCant.Add(Convert.ToInt32(tipoCant[1]));
                }
            }
            return (rTipo, rCant);
        }
        public void escribir_recor(int linea_a_escribir, List<string> tipo, List<int> cant)
        {
            List<string> lineas= File.ReadAllLines(pathconfig).ToList();
            for (int i=0;i<tipo.Count; i++)
            {
                string tipo_paso = tipo[i];
                if (tipo_paso == "Girar hacia la izquierda")
                {
                    tipo_paso = "GI";
                }
                else if (tipo_paso == "Girar hacia la derecha")
                {
                    tipo_paso = "GD";
                }
                if (i == 0)
                {
                    lineas[linea_a_escribir - 1] = $"{tipo_paso} {cant[i]}";
                }
                else
                {
                    lineas[linea_a_escribir - 1] = $"{lineas[linea_a_escribir - 1]}-{tipo_paso} {cant[i]}";
                }
            }
            File.WriteAllLines(pathconfig, lineas);
        }

        public string[] reset(int split_index)
        {
            string[] lineas = File.ReadAllLines(pathconfig);
            string[] newTxt = lineas.Skip(split_index).ToArray();
            return newTxt;
        }

        public void escribir_vacio(string[] reemplazo, int split_index)
        {
            string[] lineas = File.ReadAllLines(pathconfig);
            string[] array2 = lineas.Skip(split_index).ToArray();
            File.WriteAllLines(pathconfig, reemplazo.Concat(array2));
        }
        public void initializeButtons(Control form, params Control[] exceptions)
        {
            foreach (Control control in form.Controls)
            {
                if (control is Button button)
                {
                    if (!exceptions.Contains(button))
                    {
                        button.BackColor = Color.Transparent;
                        button.FlatAppearance.BorderSize = 0;
                        button.FlatAppearance.MouseOverBackColor = button.BackColor;
                        button.FlatAppearance.MouseDownBackColor = button.BackColor;
                        button.Cursor = Cursors.Hand;
                        button.FlatStyle = FlatStyle.Flat;
                        button.Font = Program.buttons;
                    }
                }
                else if (control is Panel)
                {
                    initializeButtons(control, exceptions);
                }
            }
        }

        public void initializeLabels(Control form, params Control[] exceptions)
        {
            foreach (Control control in form.Controls)
            {
                if (control is Label label)
                {
                    if (!exceptions.Contains(label))
                    {
                        label.BackColor = Color.Transparent;
                        label.Font = Program.labels;
                    }
                }
                else if (control is Panel)
                {
                    initializeLabels(control,exceptions);
                }
            }
        }
        public void initializePanels(Control form, params Control[] exceptions)
        {
            foreach (Control control in form.Controls)
            {
                if (control is Panel panel)
                {
                    if (!exceptions.Contains(panel))
                    {
                        panel.BackColor = Color.Transparent;
                    }
                    if (panel.Controls.Count > 0)
                    {
                        initializePanels(panel, exceptions);
                    }
                }
            }
        }

        public void btPressed(object sender, Color color, IconButton button, Panel panel, Point panel_location)
        {
            if (sender != null)
            {
                button.TextAlign = ContentAlignment.MiddleCenter;
                button.IconColor = color;
                button.TextImageRelation = TextImageRelation.TextBeforeImage;
                button.ImageAlign = ContentAlignment.MiddleRight;
                panel.BackColor = color;
                panel.Location = panel_location;
                panel.Visible = true;
                panel.BringToFront();
            }
        }

        public void btNotPressed(IconButton button)
        {
            if (button != null)
            {
                button.TextAlign = ContentAlignment.MiddleLeft;
                button.IconColor = Color.Black;
                button.TextImageRelation = TextImageRelation.ImageBeforeText;
                button.ImageAlign = ContentAlignment.MiddleCenter;
            }
        }

    }
}
