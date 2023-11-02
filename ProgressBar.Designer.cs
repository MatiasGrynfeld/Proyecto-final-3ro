namespace Proyecto_Final___Wingo
{
    partial class ProgressBar
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
            this.progressBar_subiendo = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // progressBar_subiendo
            // 
            this.progressBar_subiendo.Location = new System.Drawing.Point(159, 32);
            this.progressBar_subiendo.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar_subiendo.Name = "progressBar_subiendo";
            this.progressBar_subiendo.Size = new System.Drawing.Size(300, 81);
            this.progressBar_subiendo.TabIndex = 0;
            // 
            // ProgressBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(600, 153);
            this.Controls.Add(this.progressBar_subiendo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ProgressBar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cargando configuraciones...";
            this.Load += new System.EventHandler(this.ProgressBar_Load);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.ProgressBar progressBar_subiendo;
    }
}