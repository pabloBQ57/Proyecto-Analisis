namespace Presentación.Administración
{
    partial class EliminarEmpleados
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
            this.lbleliminarempleados = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbleliminarempleados
            // 
            this.lbleliminarempleados.AutoSize = true;
            this.lbleliminarempleados.Font = new System.Drawing.Font("Impact", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbleliminarempleados.ForeColor = System.Drawing.Color.White;
            this.lbleliminarempleados.Location = new System.Drawing.Point(333, 9);
            this.lbleliminarempleados.Name = "lbleliminarempleados";
            this.lbleliminarempleados.Size = new System.Drawing.Size(303, 42);
            this.lbleliminarempleados.TabIndex = 0;
            this.lbleliminarempleados.Text = "ELIMINAR EMPLEADOS";
            // 
            // EliminarEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(974, 526);
            this.Controls.Add(this.lbleliminarempleados);
            this.Name = "EliminarEmpleados";
            this.Text = "EliminarEmpleados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbleliminarempleados;
    }
}