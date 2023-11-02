
namespace Proyecto_Final___Wingo
{
    partial class Personalización___perfil
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
            this.panel_wheel = new System.Windows.Forms.Panel();
            this.lbl_selec_color = new System.Windows.Forms.Label();
            this.lbl_color_seleccionado = new System.Windows.Forms.Label();
            this.panel_muestra = new System.Windows.Forms.Panel();
            this.lbl_red = new System.Windows.Forms.Label();
            this.lbl_green = new System.Windows.Forms.Label();
            this.lbl_blue = new System.Windows.Forms.Label();
            this.bt_resetear = new System.Windows.Forms.Button();
            this.bt_apagado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel_wheel
            // 
            this.panel_wheel.BackColor = System.Drawing.Color.Transparent;
            this.panel_wheel.Location = new System.Drawing.Point(0, 122);
            this.panel_wheel.Name = "panel_wheel";
            this.panel_wheel.Size = new System.Drawing.Size(375, 375);
            this.panel_wheel.TabIndex = 0;
            this.panel_wheel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_wheel_Paint);
            this.panel_wheel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel_wheel_MouseClick);
            this.panel_wheel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_wheel_MouseDown);
            this.panel_wheel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_wheel_MouseMove);
            this.panel_wheel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_wheel_MouseUp);
            // 
            // lbl_selec_color
            // 
            this.lbl_selec_color.AutoSize = true;
            this.lbl_selec_color.Location = new System.Drawing.Point(12, 85);
            this.lbl_selec_color.Name = "lbl_selec_color";
            this.lbl_selec_color.Size = new System.Drawing.Size(92, 13);
            this.lbl_selec_color.TabIndex = 1;
            this.lbl_selec_color.Text = "Seleccionar color:";
            // 
            // lbl_color_seleccionado
            // 
            this.lbl_color_seleccionado.AutoSize = true;
            this.lbl_color_seleccionado.Location = new System.Drawing.Point(98, 54);
            this.lbl_color_seleccionado.Name = "lbl_color_seleccionado";
            this.lbl_color_seleccionado.Size = new System.Drawing.Size(100, 13);
            this.lbl_color_seleccionado.TabIndex = 2;
            this.lbl_color_seleccionado.Text = "Color seleccionado:";
            // 
            // panel_muestra
            // 
            this.panel_muestra.BackColor = System.Drawing.Color.Transparent;
            this.panel_muestra.Location = new System.Drawing.Point(254, 1);
            this.panel_muestra.Name = "panel_muestra";
            this.panel_muestra.Size = new System.Drawing.Size(121, 121);
            this.panel_muestra.TabIndex = 3;
            // 
            // lbl_red
            // 
            this.lbl_red.AutoSize = true;
            this.lbl_red.Location = new System.Drawing.Point(12, 516);
            this.lbl_red.Name = "lbl_red";
            this.lbl_red.Size = new System.Drawing.Size(33, 13);
            this.lbl_red.TabIndex = 4;
            this.lbl_red.Text = "Red: ";
            // 
            // lbl_green
            // 
            this.lbl_green.AutoSize = true;
            this.lbl_green.Location = new System.Drawing.Point(125, 516);
            this.lbl_green.Name = "lbl_green";
            this.lbl_green.Size = new System.Drawing.Size(39, 13);
            this.lbl_green.TabIndex = 5;
            this.lbl_green.Text = "Green:";
            // 
            // lbl_blue
            // 
            this.lbl_blue.AutoSize = true;
            this.lbl_blue.Location = new System.Drawing.Point(277, 516);
            this.lbl_blue.Name = "lbl_blue";
            this.lbl_blue.Size = new System.Drawing.Size(31, 13);
            this.lbl_blue.TabIndex = 6;
            this.lbl_blue.Text = "Blue:";
            // 
            // bt_resetear
            // 
            this.bt_resetear.Location = new System.Drawing.Point(15, 12);
            this.bt_resetear.Name = "bt_resetear";
            this.bt_resetear.Size = new System.Drawing.Size(75, 23);
            this.bt_resetear.TabIndex = 7;
            this.bt_resetear.Text = "Reset";
            this.bt_resetear.UseVisualStyleBackColor = true;
            this.bt_resetear.Click += new System.EventHandler(this.bt_resetear_Click);
            // 
            // bt_apagado
            // 
            this.bt_apagado.Location = new System.Drawing.Point(146, 12);
            this.bt_apagado.Name = "bt_apagado";
            this.bt_apagado.Size = new System.Drawing.Size(75, 23);
            this.bt_apagado.TabIndex = 8;
            this.bt_apagado.Text = "Apagado";
            this.bt_apagado.UseVisualStyleBackColor = true;
            this.bt_apagado.Click += new System.EventHandler(this.bt_apagado_Click);
            // 
            // Personalización___perfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(375, 551);
            this.Controls.Add(this.bt_apagado);
            this.Controls.Add(this.bt_resetear);
            this.Controls.Add(this.lbl_blue);
            this.Controls.Add(this.lbl_green);
            this.Controls.Add(this.lbl_red);
            this.Controls.Add(this.panel_muestra);
            this.Controls.Add(this.lbl_color_seleccionado);
            this.Controls.Add(this.lbl_selec_color);
            this.Controls.Add(this.panel_wheel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Personalización___perfil";
            this.Text = "Personalización___perfil";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_wheel;
        private System.Windows.Forms.Label lbl_selec_color;
        private System.Windows.Forms.Label lbl_color_seleccionado;
        public System.Windows.Forms.Panel panel_muestra;
        private System.Windows.Forms.Label lbl_red;
        private System.Windows.Forms.Label lbl_green;
        private System.Windows.Forms.Label lbl_blue;
        private System.Windows.Forms.Button bt_resetear;
        private System.Windows.Forms.Button bt_apagado;
    }
}