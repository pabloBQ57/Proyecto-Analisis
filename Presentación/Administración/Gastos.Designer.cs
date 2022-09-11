namespace Presentación.Administración
{
    partial class Gastos
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
            this.lblgastos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblgastos
            // 
            this.lblgastos.AutoSize = true;
            this.lblgastos.Font = new System.Drawing.Font("Impact", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgastos.ForeColor = System.Drawing.Color.White;
            this.lblgastos.Location = new System.Drawing.Point(428, 9);
            this.lblgastos.Name = "lblgastos";
            this.lblgastos.Size = new System.Drawing.Size(125, 42);
            this.lblgastos.TabIndex = 0;
            this.lblgastos.Text = "GASTOS";
            // 
            // Gastos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(974, 526);
            this.Controls.Add(this.lblgastos);
            this.Name = "Gastos";
            this.Text = "Gastos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblgastos;
    }
}