namespace Presentación.Administración
{
    partial class Donaciones
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
            this.lbldonaciones = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbldonaciones
            // 
            this.lbldonaciones.AutoSize = true;
            this.lbldonaciones.Font = new System.Drawing.Font("Impact", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldonaciones.ForeColor = System.Drawing.Color.White;
            this.lbldonaciones.Location = new System.Drawing.Point(396, 9);
            this.lbldonaciones.Name = "lbldonaciones";
            this.lbldonaciones.Size = new System.Drawing.Size(182, 41);
            this.lbldonaciones.TabIndex = 0;
            this.lbldonaciones.Text = "DONACIONES";
            // 
            // Donaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(974, 526);
            this.Controls.Add(this.lbldonaciones);
            this.Name = "Donaciones";
            this.Text = "Donaciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbldonaciones;
    }
}