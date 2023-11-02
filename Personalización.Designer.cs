
namespace Proyecto_Final___Wingo
{
    partial class Personalización
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button2 = new System.Windows.Forms.Button();
            this.panel_nom = new System.Windows.Forms.Panel();
            this.bt_enviar_nombre = new System.Windows.Forms.Button();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.panel_wheel = new System.Windows.Forms.Panel();
            this.panel_perfil = new System.Windows.Forms.Panel();
            this.bt_reset_cols = new FontAwesome.Sharp.IconButton();
            this.lbl_mod = new System.Windows.Forms.Label();
            this.lbl_ang = new System.Windows.Forms.Label();
            this.panel_derecha = new System.Windows.Forms.Panel();
            this.lbl_len_der = new System.Windows.Forms.Label();
            this.trackBar_der = new System.Windows.Forms.TrackBar();
            this.lbl_med_der = new System.Windows.Forms.Label();
            this.lbl_selec_velocidad_der = new System.Windows.Forms.Label();
            this.lbl_rap_der = new System.Windows.Forms.Label();
            this.panel_izquierda = new System.Windows.Forms.Panel();
            this.lbl_len_izq = new System.Windows.Forms.Label();
            this.trackBar_izq = new System.Windows.Forms.TrackBar();
            this.lbl_med_izq = new System.Windows.Forms.Label();
            this.lbl_selec_velocidad_izq = new System.Windows.Forms.Label();
            this.lbl_rap_izq = new System.Windows.Forms.Label();
            this.comb_angulo = new System.Windows.Forms.ComboBox();
            this.Comb_tipos_personalizados = new System.Windows.Forms.ComboBox();
            this.panel_arriba = new System.Windows.Forms.Panel();
            this.lbl_len_arr = new System.Windows.Forms.Label();
            this.trackBar_arr = new System.Windows.Forms.TrackBar();
            this.lbl_med_arr = new System.Windows.Forms.Label();
            this.lbl_selec_velocidad_arr = new System.Windows.Forms.Label();
            this.lbl_rap_arr = new System.Windows.Forms.Label();
            this.bt_cambiar_nombre = new System.Windows.Forms.Button();
            this.bt_enviar_configuraciones = new System.Windows.Forms.Button();
            this.bt_manejo = new System.Windows.Forms.Button();
            this.panel_perfs = new System.Windows.Forms.Panel();
            this.bt_perfil2 = new FontAwesome.Sharp.IconButton();
            this.bt_perfil1 = new FontAwesome.Sharp.IconButton();
            this.bt_cerrar = new FontAwesome.Sharp.IconButton();
            this.lbl_pers = new System.Windows.Forms.Label();
            this.bt_mouse = new FontAwesome.Sharp.IconButton();
            this.bt_paint = new FontAwesome.Sharp.IconButton();
            this.panel_nom.SuspendLayout();
            this.panel_perfil.SuspendLayout();
            this.panel_derecha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_der)).BeginInit();
            this.panel_izquierda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_izq)).BeginInit();
            this.panel_arriba.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_arr)).BeginInit();
            this.panel_perfs.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 207);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(0, 0);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel_nom
            // 
            this.panel_nom.Controls.Add(this.bt_enviar_nombre);
            this.panel_nom.Controls.Add(this.txt_nombre);
            this.panel_nom.Controls.Add(this.lbl_nombre);
            this.panel_nom.Location = new System.Drawing.Point(18, 672);
            this.panel_nom.Name = "panel_nom";
            this.panel_nom.Size = new System.Drawing.Size(240, 65);
            this.panel_nom.TabIndex = 0;
            // 
            // bt_enviar_nombre
            // 
            this.bt_enviar_nombre.Location = new System.Drawing.Point(152, 16);
            this.bt_enviar_nombre.Name = "bt_enviar_nombre";
            this.bt_enviar_nombre.Size = new System.Drawing.Size(75, 40);
            this.bt_enviar_nombre.TabIndex = 2;
            this.bt_enviar_nombre.Text = "Enviar";
            this.bt_enviar_nombre.UseVisualStyleBackColor = true;
            this.bt_enviar_nombre.Click += new System.EventHandler(this.bt_enviar_nombre_Click);
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(6, 36);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(100, 20);
            this.txt_nombre.TabIndex = 1;
            this.txt_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombre_KeyPress);
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(3, 10);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(89, 13);
            this.lbl_nombre.TabIndex = 0;
            this.lbl_nombre.Text = "Nombre del perfil:\r\n";
            // 
            // panel_wheel
            // 
            this.panel_wheel.Location = new System.Drawing.Point(875, 67);
            this.panel_wheel.Name = "panel_wheel";
            this.panel_wheel.Size = new System.Drawing.Size(380, 551);
            this.panel_wheel.TabIndex = 5;
            // 
            // panel_perfil
            // 
            this.panel_perfil.Controls.Add(this.bt_reset_cols);
            this.panel_perfil.Controls.Add(this.lbl_mod);
            this.panel_perfil.Controls.Add(this.lbl_ang);
            this.panel_perfil.Controls.Add(this.panel_derecha);
            this.panel_perfil.Controls.Add(this.panel_izquierda);
            this.panel_perfil.Controls.Add(this.comb_angulo);
            this.panel_perfil.Controls.Add(this.Comb_tipos_personalizados);
            this.panel_perfil.Controls.Add(this.panel_arriba);
            this.panel_perfil.Controls.Add(this.bt_cambiar_nombre);
            this.panel_perfil.Location = new System.Drawing.Point(150, 0);
            this.panel_perfil.Name = "panel_perfil";
            this.panel_perfil.Size = new System.Drawing.Size(700, 666);
            this.panel_perfil.TabIndex = 3;
            // 
            // bt_reset_cols
            // 
            this.bt_reset_cols.IconChar = FontAwesome.Sharp.IconChar.Rotate;
            this.bt_reset_cols.IconColor = System.Drawing.Color.Black;
            this.bt_reset_cols.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_reset_cols.Location = new System.Drawing.Point(624, 4);
            this.bt_reset_cols.Name = "bt_reset_cols";
            this.bt_reset_cols.Size = new System.Drawing.Size(58, 58);
            this.bt_reset_cols.TabIndex = 10;
            this.bt_reset_cols.UseVisualStyleBackColor = true;
            this.bt_reset_cols.Click += new System.EventHandler(this.bt_reset_cols_Click);
            // 
            // lbl_mod
            // 
            this.lbl_mod.AutoSize = true;
            this.lbl_mod.Location = new System.Drawing.Point(38, 35);
            this.lbl_mod.Name = "lbl_mod";
            this.lbl_mod.Size = new System.Drawing.Size(114, 13);
            this.lbl_mod.TabIndex = 9;
            this.lbl_mod.Text = "Seleccionar modalidad";
            // 
            // lbl_ang
            // 
            this.lbl_ang.AutoSize = true;
            this.lbl_ang.Location = new System.Drawing.Point(38, 9);
            this.lbl_ang.Name = "lbl_ang";
            this.lbl_ang.Size = new System.Drawing.Size(98, 13);
            this.lbl_ang.TabIndex = 8;
            this.lbl_ang.Text = "Seleccionar ángulo";
            // 
            // panel_derecha
            // 
            this.panel_derecha.BackColor = System.Drawing.Color.Transparent;
            this.panel_derecha.Controls.Add(this.lbl_len_der);
            this.panel_derecha.Controls.Add(this.trackBar_der);
            this.panel_derecha.Controls.Add(this.lbl_med_der);
            this.panel_derecha.Controls.Add(this.lbl_selec_velocidad_der);
            this.panel_derecha.Controls.Add(this.lbl_rap_der);
            this.panel_derecha.Location = new System.Drawing.Point(0, 217);
            this.panel_derecha.Name = "panel_derecha";
            this.panel_derecha.Size = new System.Drawing.Size(700, 574);
            this.panel_derecha.TabIndex = 3;
            this.panel_derecha.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_derecha_Paint);
            this.panel_derecha.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_derecha_MouseDown);
            this.panel_derecha.MouseLeave += new System.EventHandler(this.panel_derecha_MouseLeave);
            this.panel_derecha.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_derecha_MouseMove);
            this.panel_derecha.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_derecha_MouseUp);
            // 
            // lbl_len_der
            // 
            this.lbl_len_der.AutoSize = true;
            this.lbl_len_der.Location = new System.Drawing.Point(116, 414);
            this.lbl_len_der.Name = "lbl_len_der";
            this.lbl_len_der.Size = new System.Drawing.Size(34, 13);
            this.lbl_len_der.TabIndex = 6;
            this.lbl_len_der.Text = "Lenta";
            // 
            // trackBar_der
            // 
            this.trackBar_der.Location = new System.Drawing.Point(60, 55);
            this.trackBar_der.Maximum = 1000;
            this.trackBar_der.Minimum = 1;
            this.trackBar_der.Name = "trackBar_der";
            this.trackBar_der.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar_der.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.trackBar_der.Size = new System.Drawing.Size(45, 400);
            this.trackBar_der.TabIndex = 1;
            this.trackBar_der.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar_der.Value = 1;
            this.trackBar_der.Visible = false;
            this.trackBar_der.Scroll += new System.EventHandler(this.trackBar_der_Scroll);
            // 
            // lbl_med_der
            // 
            this.lbl_med_der.AutoSize = true;
            this.lbl_med_der.Location = new System.Drawing.Point(121, 217);
            this.lbl_med_der.Name = "lbl_med_der";
            this.lbl_med_der.Size = new System.Drawing.Size(36, 13);
            this.lbl_med_der.TabIndex = 5;
            this.lbl_med_der.Text = "Media";
            // 
            // lbl_selec_velocidad_der
            // 
            this.lbl_selec_velocidad_der.AutoSize = true;
            this.lbl_selec_velocidad_der.Location = new System.Drawing.Point(57, 24);
            this.lbl_selec_velocidad_der.Name = "lbl_selec_velocidad_der";
            this.lbl_selec_velocidad_der.Size = new System.Drawing.Size(176, 13);
            this.lbl_selec_velocidad_der.TabIndex = 0;
            this.lbl_selec_velocidad_der.Text = "Seleccionar la velocidad del efecto:";
            // 
            // lbl_rap_der
            // 
            this.lbl_rap_der.AutoSize = true;
            this.lbl_rap_der.Location = new System.Drawing.Point(116, 55);
            this.lbl_rap_der.Name = "lbl_rap_der";
            this.lbl_rap_der.Size = new System.Drawing.Size(41, 13);
            this.lbl_rap_der.TabIndex = 4;
            this.lbl_rap_der.Text = "Rápida";
            // 
            // panel_izquierda
            // 
            this.panel_izquierda.BackColor = System.Drawing.Color.Transparent;
            this.panel_izquierda.Controls.Add(this.lbl_len_izq);
            this.panel_izquierda.Controls.Add(this.trackBar_izq);
            this.panel_izquierda.Controls.Add(this.lbl_med_izq);
            this.panel_izquierda.Controls.Add(this.lbl_selec_velocidad_izq);
            this.panel_izquierda.Controls.Add(this.lbl_rap_izq);
            this.panel_izquierda.Location = new System.Drawing.Point(19, 138);
            this.panel_izquierda.Name = "panel_izquierda";
            this.panel_izquierda.Size = new System.Drawing.Size(700, 574);
            this.panel_izquierda.TabIndex = 2;
            this.panel_izquierda.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_izquierda_Paint);
            this.panel_izquierda.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_izquierda_MouseDown);
            this.panel_izquierda.MouseLeave += new System.EventHandler(this.panel_izquierda_MouseLeave);
            this.panel_izquierda.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_izquierda_MouseMove);
            this.panel_izquierda.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_izquierda_MouseUp);
            // 
            // lbl_len_izq
            // 
            this.lbl_len_izq.AutoSize = true;
            this.lbl_len_izq.Location = new System.Drawing.Point(542, 35);
            this.lbl_len_izq.Name = "lbl_len_izq";
            this.lbl_len_izq.Size = new System.Drawing.Size(34, 13);
            this.lbl_len_izq.TabIndex = 9;
            this.lbl_len_izq.Text = "Lenta";
            // 
            // trackBar_izq
            // 
            this.trackBar_izq.Location = new System.Drawing.Point(60, 55);
            this.trackBar_izq.Maximum = 1000;
            this.trackBar_izq.Minimum = 1;
            this.trackBar_izq.Name = "trackBar_izq";
            this.trackBar_izq.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar_izq.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.trackBar_izq.Size = new System.Drawing.Size(45, 400);
            this.trackBar_izq.TabIndex = 2;
            this.trackBar_izq.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar_izq.Value = 1;
            this.trackBar_izq.Visible = false;
            this.trackBar_izq.Scroll += new System.EventHandler(this.trackBar_izq_Scroll);
            // 
            // lbl_med_izq
            // 
            this.lbl_med_izq.AutoSize = true;
            this.lbl_med_izq.Location = new System.Drawing.Point(434, 35);
            this.lbl_med_izq.Name = "lbl_med_izq";
            this.lbl_med_izq.Size = new System.Drawing.Size(36, 13);
            this.lbl_med_izq.TabIndex = 8;
            this.lbl_med_izq.Text = "Media";
            // 
            // lbl_selec_velocidad_izq
            // 
            this.lbl_selec_velocidad_izq.AutoSize = true;
            this.lbl_selec_velocidad_izq.Location = new System.Drawing.Point(70, 23);
            this.lbl_selec_velocidad_izq.Name = "lbl_selec_velocidad_izq";
            this.lbl_selec_velocidad_izq.Size = new System.Drawing.Size(176, 13);
            this.lbl_selec_velocidad_izq.TabIndex = 1;
            this.lbl_selec_velocidad_izq.Text = "Seleccionar la velocidad del efecto:";
            // 
            // lbl_rap_izq
            // 
            this.lbl_rap_izq.AutoSize = true;
            this.lbl_rap_izq.Location = new System.Drawing.Point(289, 35);
            this.lbl_rap_izq.Name = "lbl_rap_izq";
            this.lbl_rap_izq.Size = new System.Drawing.Size(41, 13);
            this.lbl_rap_izq.TabIndex = 7;
            this.lbl_rap_izq.Text = "Rápida";
            // 
            // comb_angulo
            // 
            this.comb_angulo.FormattingEnabled = true;
            this.comb_angulo.Items.AddRange(new object[] {
            "Arriba",
            "Lado izquierdo",
            "Lado derecho"});
            this.comb_angulo.Location = new System.Drawing.Point(234, 9);
            this.comb_angulo.Name = "comb_angulo";
            this.comb_angulo.Size = new System.Drawing.Size(173, 21);
            this.comb_angulo.TabIndex = 6;
            this.comb_angulo.SelectionChangeCommitted += new System.EventHandler(this.comb_angulo_SelectionChangeCommitted);
            // 
            // Comb_tipos_personalizados
            // 
            this.Comb_tipos_personalizados.FormattingEnabled = true;
            this.Comb_tipos_personalizados.Items.AddRange(new object[] {
            "Independiente",
            "Rainbow",
            "Apagado"});
            this.Comb_tipos_personalizados.Location = new System.Drawing.Point(234, 37);
            this.Comb_tipos_personalizados.Name = "Comb_tipos_personalizados";
            this.Comb_tipos_personalizados.Size = new System.Drawing.Size(173, 21);
            this.Comb_tipos_personalizados.TabIndex = 4;
            this.Comb_tipos_personalizados.SelectedIndexChanged += new System.EventHandler(this.Comb_tipos__personalizados_SelectedIndexChanged);
            // 
            // panel_arriba
            // 
            this.panel_arriba.BackColor = System.Drawing.Color.Transparent;
            this.panel_arriba.Controls.Add(this.lbl_len_arr);
            this.panel_arriba.Controls.Add(this.trackBar_arr);
            this.panel_arriba.Controls.Add(this.lbl_med_arr);
            this.panel_arriba.Controls.Add(this.lbl_selec_velocidad_arr);
            this.panel_arriba.Controls.Add(this.lbl_rap_arr);
            this.panel_arriba.Location = new System.Drawing.Point(38, 67);
            this.panel_arriba.Name = "panel_arriba";
            this.panel_arriba.Size = new System.Drawing.Size(700, 574);
            this.panel_arriba.TabIndex = 1;
            this.panel_arriba.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_arriba_Paint);
            this.panel_arriba.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_arriba_MouseDown);
            this.panel_arriba.MouseLeave += new System.EventHandler(this.panel_arriba_MouseLeave);
            this.panel_arriba.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_arriba_MouseMove);
            this.panel_arriba.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_arriba_MouseUp);
            // 
            // lbl_len_arr
            // 
            this.lbl_len_arr.AutoSize = true;
            this.lbl_len_arr.Location = new System.Drawing.Point(541, 35);
            this.lbl_len_arr.Name = "lbl_len_arr";
            this.lbl_len_arr.Size = new System.Drawing.Size(34, 13);
            this.lbl_len_arr.TabIndex = 9;
            this.lbl_len_arr.Text = "Lenta";
            // 
            // trackBar_arr
            // 
            this.trackBar_arr.Location = new System.Drawing.Point(60, 55);
            this.trackBar_arr.Maximum = 1000;
            this.trackBar_arr.Minimum = 1;
            this.trackBar_arr.Name = "trackBar_arr";
            this.trackBar_arr.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar_arr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.trackBar_arr.Size = new System.Drawing.Size(45, 400);
            this.trackBar_arr.TabIndex = 3;
            this.trackBar_arr.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar_arr.Value = 1;
            this.trackBar_arr.Visible = false;
            this.trackBar_arr.Scroll += new System.EventHandler(this.trackBar_arr_Scroll);
            // 
            // lbl_med_arr
            // 
            this.lbl_med_arr.AutoSize = true;
            this.lbl_med_arr.Location = new System.Drawing.Point(415, 35);
            this.lbl_med_arr.Name = "lbl_med_arr";
            this.lbl_med_arr.Size = new System.Drawing.Size(36, 13);
            this.lbl_med_arr.TabIndex = 8;
            this.lbl_med_arr.Text = "Media";
            // 
            // lbl_selec_velocidad_arr
            // 
            this.lbl_selec_velocidad_arr.AutoSize = true;
            this.lbl_selec_velocidad_arr.Location = new System.Drawing.Point(51, 12);
            this.lbl_selec_velocidad_arr.Name = "lbl_selec_velocidad_arr";
            this.lbl_selec_velocidad_arr.Size = new System.Drawing.Size(176, 13);
            this.lbl_selec_velocidad_arr.TabIndex = 2;
            this.lbl_selec_velocidad_arr.Text = "Seleccionar la velocidad del efecto:";
            // 
            // lbl_rap_arr
            // 
            this.lbl_rap_arr.AutoSize = true;
            this.lbl_rap_arr.Location = new System.Drawing.Point(299, 35);
            this.lbl_rap_arr.Name = "lbl_rap_arr";
            this.lbl_rap_arr.Size = new System.Drawing.Size(41, 13);
            this.lbl_rap_arr.TabIndex = 7;
            this.lbl_rap_arr.Text = "Rápida";
            // 
            // bt_cambiar_nombre
            // 
            this.bt_cambiar_nombre.Location = new System.Drawing.Point(448, 3);
            this.bt_cambiar_nombre.Name = "bt_cambiar_nombre";
            this.bt_cambiar_nombre.Size = new System.Drawing.Size(147, 58);
            this.bt_cambiar_nombre.TabIndex = 0;
            this.bt_cambiar_nombre.Text = "Cambiar nombre";
            this.bt_cambiar_nombre.UseVisualStyleBackColor = true;
            this.bt_cambiar_nombre.Click += new System.EventHandler(this.bt_cambiar_nombre_Click_1);
            // 
            // bt_enviar_configuraciones
            // 
            this.bt_enviar_configuraciones.Location = new System.Drawing.Point(0, 539);
            this.bt_enviar_configuraciones.Name = "bt_enviar_configuraciones";
            this.bt_enviar_configuraciones.Size = new System.Drawing.Size(144, 60);
            this.bt_enviar_configuraciones.TabIndex = 8;
            this.bt_enviar_configuraciones.Text = "Enviar configuraciones";
            this.bt_enviar_configuraciones.UseVisualStyleBackColor = true;
            this.bt_enviar_configuraciones.Click += new System.EventHandler(this.bt_enviar_configuraciones_Click);
            // 
            // bt_manejo
            // 
            this.bt_manejo.Location = new System.Drawing.Point(0, 386);
            this.bt_manejo.Name = "bt_manejo";
            this.bt_manejo.Size = new System.Drawing.Size(144, 60);
            this.bt_manejo.TabIndex = 9;
            this.bt_manejo.Text = "Ir a manejo";
            this.bt_manejo.UseVisualStyleBackColor = true;
            this.bt_manejo.Click += new System.EventHandler(this.bt_manejo_Click);
            // 
            // panel_perfs
            // 
            this.panel_perfs.Controls.Add(this.bt_perfil2);
            this.panel_perfs.Controls.Add(this.bt_perfil1);
            this.panel_perfs.Controls.Add(this.bt_cerrar);
            this.panel_perfs.Controls.Add(this.bt_enviar_configuraciones);
            this.panel_perfs.Controls.Add(this.bt_manejo);
            this.panel_perfs.Location = new System.Drawing.Point(0, 67);
            this.panel_perfs.Name = "panel_perfs";
            this.panel_perfs.Size = new System.Drawing.Size(151, 602);
            this.panel_perfs.TabIndex = 10;
            // 
            // bt_perfil2
            // 
            this.bt_perfil2.IconChar = FontAwesome.Sharp.IconChar.Sliders;
            this.bt_perfil2.IconColor = System.Drawing.Color.Black;
            this.bt_perfil2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_perfil2.IconSize = 40;
            this.bt_perfil2.Location = new System.Drawing.Point(0, 94);
            this.bt_perfil2.Name = "bt_perfil2";
            this.bt_perfil2.Size = new System.Drawing.Size(144, 60);
            this.bt_perfil2.TabIndex = 14;
            this.bt_perfil2.Text = "Nuevo Perfil";
            this.bt_perfil2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_perfil2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_perfil2.UseVisualStyleBackColor = true;
            this.bt_perfil2.Click += new System.EventHandler(this.bt_perf2_Click);
            // 
            // bt_perfil1
            // 
            this.bt_perfil1.IconChar = FontAwesome.Sharp.IconChar.Sliders;
            this.bt_perfil1.IconColor = System.Drawing.Color.Black;
            this.bt_perfil1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_perfil1.IconSize = 40;
            this.bt_perfil1.Location = new System.Drawing.Point(0, 12);
            this.bt_perfil1.Name = "bt_perfil1";
            this.bt_perfil1.Size = new System.Drawing.Size(144, 60);
            this.bt_perfil1.TabIndex = 13;
            this.bt_perfil1.Text = "Nuevo Perfil";
            this.bt_perfil1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_perfil1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_perfil1.UseVisualStyleBackColor = true;
            this.bt_perfil1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // bt_cerrar
            // 
            this.bt_cerrar.IconChar = FontAwesome.Sharp.IconChar.Backward;
            this.bt_cerrar.IconColor = System.Drawing.Color.Blue;
            this.bt_cerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_cerrar.Location = new System.Drawing.Point(0, 452);
            this.bt_cerrar.Name = "bt_cerrar";
            this.bt_cerrar.Size = new System.Drawing.Size(144, 60);
            this.bt_cerrar.TabIndex = 12;
            this.bt_cerrar.UseVisualStyleBackColor = true;
            this.bt_cerrar.Click += new System.EventHandler(this.bt_cerrar_Click);
            // 
            // lbl_pers
            // 
            this.lbl_pers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_pers.AutoEllipsis = true;
            this.lbl_pers.AutoSize = true;
            this.lbl_pers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_pers.Location = new System.Drawing.Point(15, 9);
            this.lbl_pers.Name = "lbl_pers";
            this.lbl_pers.Size = new System.Drawing.Size(36, 26);
            this.lbl_pers.TabIndex = 10;
            this.lbl_pers.Text = "Luces\r\n  RGB";
            this.lbl_pers.Click += new System.EventHandler(this.lbl_pers_Click);
            // 
            // bt_mouse
            // 
            this.bt_mouse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_mouse.IconChar = FontAwesome.Sharp.IconChar.ArrowPointer;
            this.bt_mouse.IconColor = System.Drawing.Color.Black;
            this.bt_mouse.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_mouse.IconSize = 45;
            this.bt_mouse.Location = new System.Drawing.Point(897, 8);
            this.bt_mouse.Name = "bt_mouse";
            this.bt_mouse.Size = new System.Drawing.Size(50, 50);
            this.bt_mouse.TabIndex = 11;
            this.bt_mouse.UseVisualStyleBackColor = true;
            this.bt_mouse.Click += new System.EventHandler(this.bt_mousr_Click);
            // 
            // bt_paint
            // 
            this.bt_paint.IconChar = FontAwesome.Sharp.IconChar.PaintRoller;
            this.bt_paint.IconColor = System.Drawing.Color.Black;
            this.bt_paint.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_paint.Location = new System.Drawing.Point(981, 8);
            this.bt_paint.Name = "bt_paint";
            this.bt_paint.Size = new System.Drawing.Size(50, 50);
            this.bt_paint.TabIndex = 12;
            this.bt_paint.UseVisualStyleBackColor = true;
            this.bt_paint.Click += new System.EventHandler(this.bt_paint_Click);
            // 
            // Personalización
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.bt_paint);
            this.Controls.Add(this.bt_mouse);
            this.Controls.Add(this.lbl_pers);
            this.Controls.Add(this.panel_perfs);
            this.Controls.Add(this.panel_wheel);
            this.Controls.Add(this.panel_nom);
            this.Controls.Add(this.panel_perfil);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Personalización";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personalización";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Personalización_FormClosing);
            this.Load += new System.EventHandler(this.Personalización_Load);
            this.panel_nom.ResumeLayout(false);
            this.panel_nom.PerformLayout();
            this.panel_perfil.ResumeLayout(false);
            this.panel_perfil.PerformLayout();
            this.panel_derecha.ResumeLayout(false);
            this.panel_derecha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_der)).EndInit();
            this.panel_izquierda.ResumeLayout(false);
            this.panel_izquierda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_izq)).EndInit();
            this.panel_arriba.ResumeLayout(false);
            this.panel_arriba.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_arr)).EndInit();
            this.panel_perfs.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel_nom;
        private System.Windows.Forms.Button bt_enviar_nombre;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Panel panel_wheel;
        private System.Windows.Forms.Panel panel_perfil;
        private System.Windows.Forms.Button bt_cambiar_nombre;
        private System.Windows.Forms.Panel panel_arriba;
        private System.Windows.Forms.ComboBox Comb_tipos_personalizados;
        private System.Windows.Forms.ComboBox comb_angulo;
        private System.Windows.Forms.Panel panel_derecha;
        private System.Windows.Forms.Panel panel_izquierda;
        private System.Windows.Forms.Label lbl_selec_velocidad_der;
        private System.Windows.Forms.Label lbl_selec_velocidad_izq;
        private System.Windows.Forms.Label lbl_selec_velocidad_arr;
        private System.Windows.Forms.TrackBar trackBar_der;
        private System.Windows.Forms.TrackBar trackBar_izq;
        private System.Windows.Forms.TrackBar trackBar_arr;
        private System.Windows.Forms.Button bt_enviar_configuraciones;
        private System.Windows.Forms.Label lbl_len_der;
        private System.Windows.Forms.Label lbl_med_der;
        private System.Windows.Forms.Label lbl_rap_der;
        private System.Windows.Forms.Label lbl_len_izq;
        private System.Windows.Forms.Label lbl_med_izq;
        private System.Windows.Forms.Label lbl_rap_izq;
        private System.Windows.Forms.Label lbl_len_arr;
        private System.Windows.Forms.Label lbl_med_arr;
        private System.Windows.Forms.Label lbl_rap_arr;
        private System.Windows.Forms.Button bt_manejo;
        private System.Windows.Forms.Panel panel_perfs;
        private System.Windows.Forms.Label lbl_pers;
        private System.Windows.Forms.Label lbl_mod;
        private System.Windows.Forms.Label lbl_ang;
        private FontAwesome.Sharp.IconButton bt_cerrar;
        private FontAwesome.Sharp.IconButton bt_mouse;
        private FontAwesome.Sharp.IconButton bt_paint;
        private FontAwesome.Sharp.IconButton bt_reset_cols;
        private FontAwesome.Sharp.IconButton bt_perfil1;
        private FontAwesome.Sharp.IconButton bt_perfil2;
    }
}