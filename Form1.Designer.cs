
namespace Proyecto_Final___Wingo
{
    partial class Pantalla_principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pantalla_principal));
            this.bt_cerrar_app = new System.Windows.Forms.Button();
            this.bt_ajustes = new System.Windows.Forms.Button();
            this.lbl_Sally = new System.Windows.Forms.Label();
            this.bt_ir_manejo = new FontAwesome.Sharp.IconButton();
            this.bt_ir_pers = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // bt_cerrar_app
            // 
            this.bt_cerrar_app.Location = new System.Drawing.Point(713, 404);
            this.bt_cerrar_app.Name = "bt_cerrar_app";
            this.bt_cerrar_app.Size = new System.Drawing.Size(75, 23);
            this.bt_cerrar_app.TabIndex = 2;
            this.bt_cerrar_app.Text = "Cerrar";
            this.bt_cerrar_app.UseVisualStyleBackColor = true;
            this.bt_cerrar_app.Click += new System.EventHandler(this.bt_cerrar_app_Click);
            // 
            // bt_ajustes
            // 
            this.bt_ajustes.Location = new System.Drawing.Point(685, 12);
            this.bt_ajustes.Name = "bt_ajustes";
            this.bt_ajustes.Size = new System.Drawing.Size(103, 53);
            this.bt_ajustes.TabIndex = 3;
            this.bt_ajustes.Text = "Configuraciones";
            this.bt_ajustes.UseVisualStyleBackColor = true;
            this.bt_ajustes.Click += new System.EventHandler(this.bt_ajustes_Click);
            // 
            // lbl_Sally
            // 
            this.lbl_Sally.AutoSize = true;
            this.lbl_Sally.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Sally.Location = new System.Drawing.Point(343, 29);
            this.lbl_Sally.Name = "lbl_Sally";
            this.lbl_Sally.Size = new System.Drawing.Size(29, 13);
            this.lbl_Sally.TabIndex = 4;
            this.lbl_Sally.Text = "Sally";
            // 
            // bt_ir_manejo
            // 
            this.bt_ir_manejo.IconChar = FontAwesome.Sharp.IconChar.TruckArrowRight;
            this.bt_ir_manejo.IconColor = System.Drawing.Color.Black;
            this.bt_ir_manejo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_ir_manejo.Location = new System.Drawing.Point(319, 195);
            this.bt_ir_manejo.Name = "bt_ir_manejo";
            this.bt_ir_manejo.Size = new System.Drawing.Size(163, 61);
            this.bt_ir_manejo.TabIndex = 5;
            this.bt_ir_manejo.Text = "Ir a Manejo";
            this.bt_ir_manejo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_ir_manejo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_ir_manejo.UseVisualStyleBackColor = true;
            this.bt_ir_manejo.Click += new System.EventHandler(this.bt_ir_manejo_Click);
            // 
            // bt_ir_pers
            // 
            this.bt_ir_pers.IconChar = FontAwesome.Sharp.IconChar.CarOn;
            this.bt_ir_pers.IconColor = System.Drawing.Color.Black;
            this.bt_ir_pers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_ir_pers.Location = new System.Drawing.Point(319, 95);
            this.bt_ir_pers.Name = "bt_ir_pers";
            this.bt_ir_pers.Size = new System.Drawing.Size(163, 61);
            this.bt_ir_pers.TabIndex = 6;
            this.bt_ir_pers.Text = "Ir a Personalización";
            this.bt_ir_pers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_ir_pers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_ir_pers.UseVisualStyleBackColor = true;
            this.bt_ir_pers.Click += new System.EventHandler(this.bt_ir_pers_Click);
            // 
            // Pantalla_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_Final___Wingo.Properties.Resources.Fondo_principal1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_ir_pers);
            this.Controls.Add(this.bt_ir_manejo);
            this.Controls.Add(this.lbl_Sally);
            this.Controls.Add(this.bt_ajustes);
            this.Controls.Add(this.bt_cerrar_app);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pantalla_principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Pantalla_principal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bt_cerrar_app;
        private System.Windows.Forms.Button bt_ajustes;
        private System.Windows.Forms.Label lbl_Sally;
        private FontAwesome.Sharp.IconButton bt_ir_manejo;
        private FontAwesome.Sharp.IconButton bt_ir_pers;
    }
}

