
namespace Proyecto_Final___Wingo
{
    partial class Ajustes
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
            this.components = new System.ComponentModel.Container();
            this.lbl_puerto_com = new System.Windows.Forms.Label();
            this.Comb_puertos = new System.Windows.Forms.ComboBox();
            this.bt_aceptar = new System.Windows.Forms.Button();
            this.er_puerto = new System.Windows.Forms.ErrorProvider(this.components);
            this.bt_reset_config = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.er_puerto)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_puerto_com
            // 
            this.lbl_puerto_com.AutoSize = true;
            this.er_puerto.SetIconAlignment(this.lbl_puerto_com, System.Windows.Forms.ErrorIconAlignment.TopRight);
            this.lbl_puerto_com.Location = new System.Drawing.Point(156, 71);
            this.lbl_puerto_com.Name = "lbl_puerto_com";
            this.lbl_puerto_com.Size = new System.Drawing.Size(140, 26);
            this.lbl_puerto_com.TabIndex = 0;
            this.lbl_puerto_com.Text = "Seleccionar el puerto donde\r\nestá conectado el auto:";
            this.lbl_puerto_com.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Comb_puertos
            // 
            this.Comb_puertos.FormattingEnabled = true;
            this.Comb_puertos.Location = new System.Drawing.Point(133, 143);
            this.Comb_puertos.Name = "Comb_puertos";
            this.Comb_puertos.Size = new System.Drawing.Size(252, 21);
            this.Comb_puertos.TabIndex = 1;
            // 
            // bt_aceptar
            // 
            this.bt_aceptar.BackgroundImage = global::Proyecto_Final___Wingo.Properties.Resources.bt_ajustes;
            this.bt_aceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_aceptar.Location = new System.Drawing.Point(198, 297);
            this.bt_aceptar.Name = "bt_aceptar";
            this.bt_aceptar.Size = new System.Drawing.Size(119, 70);
            this.bt_aceptar.TabIndex = 2;
            this.bt_aceptar.Text = "Aceptar y aplicar";
            this.bt_aceptar.UseVisualStyleBackColor = true;
            this.bt_aceptar.Click += new System.EventHandler(this.bt_aceptar_Click);
            // 
            // er_puerto
            // 
            this.er_puerto.ContainerControl = this;
            // 
            // bt_reset_config
            // 
            this.bt_reset_config.BackgroundImage = global::Proyecto_Final___Wingo.Properties.Resources.bt_ajustes;
            this.bt_reset_config.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_reset_config.IconChar = FontAwesome.Sharp.IconChar.TrashRestore;
            this.bt_reset_config.IconColor = System.Drawing.Color.Black;
            this.bt_reset_config.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_reset_config.Location = new System.Drawing.Point(133, 170);
            this.bt_reset_config.Name = "bt_reset_config";
            this.bt_reset_config.Size = new System.Drawing.Size(252, 105);
            this.bt_reset_config.TabIndex = 4;
            this.bt_reset_config.Text = "Resetear Configuraciones";
            this.bt_reset_config.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_reset_config.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_reset_config.UseVisualStyleBackColor = true;
            this.bt_reset_config.Click += new System.EventHandler(this.bt_reset_config_Click);
            // 
            // Ajustes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_Final___Wingo.Properties.Resources.Fondo_ajustes;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(519, 379);
            this.Controls.Add(this.bt_reset_config);
            this.Controls.Add(this.bt_aceptar);
            this.Controls.Add(this.Comb_puertos);
            this.Controls.Add(this.lbl_puerto_com);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ajustes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajustes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Ajustes_FormClosed);
            this.Load += new System.EventHandler(this.Ajustes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.er_puerto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_puerto_com;
        private System.Windows.Forms.Button bt_aceptar;
        public System.Windows.Forms.ComboBox Comb_puertos;
        private System.Windows.Forms.ErrorProvider er_puerto;
        private FontAwesome.Sharp.IconButton bt_reset_config;
    }
}