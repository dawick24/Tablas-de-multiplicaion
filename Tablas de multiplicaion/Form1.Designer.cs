
namespace Tablas_de_multiplicaion
{
    partial class Form1
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
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.lblTabla = new System.Windows.Forms.Label();
            this.lblLimite = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtTablaMultiplicacion = new System.Windows.Forms.TextBox();
            this.txtLimiteMultiplicacion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplicar.Location = new System.Drawing.Point(482, 123);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(106, 34);
            this.btnMultiplicar.TabIndex = 0;
            this.btnMultiplicar.Text = "Multiplicar";
            this.btnMultiplicar.UseVisualStyleBackColor = true;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_Click);
            // 
            // lblTabla
            // 
            this.lblTabla.AutoSize = true;
            this.lblTabla.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTabla.Location = new System.Drawing.Point(180, 51);
            this.lblTabla.Name = "lblTabla";
            this.lblTabla.Size = new System.Drawing.Size(45, 18);
            this.lblTabla.TabIndex = 1;
            this.lblTabla.Text = "Tabla";
            // 
            // lblLimite
            // 
            this.lblLimite.AutoSize = true;
            this.lblLimite.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLimite.Location = new System.Drawing.Point(323, 51);
            this.lblLimite.Name = "lblLimite";
            this.lblLimite.Size = new System.Drawing.Size(51, 18);
            this.lblLimite.TabIndex = 2;
            this.lblLimite.Text = "Limite";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(169, 145);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(102, 173);
            this.listBox1.TabIndex = 3;
            // 
            // txtTablaMultiplicacion
            // 
            this.txtTablaMultiplicacion.Location = new System.Drawing.Point(158, 78);
            this.txtTablaMultiplicacion.Name = "txtTablaMultiplicacion";
            this.txtTablaMultiplicacion.Size = new System.Drawing.Size(86, 20);
            this.txtTablaMultiplicacion.TabIndex = 4;
            // 
            // txtLimiteMultiplicacion
            // 
            this.txtLimiteMultiplicacion.Location = new System.Drawing.Point(314, 78);
            this.txtLimiteMultiplicacion.Name = "txtLimiteMultiplicacion";
            this.txtLimiteMultiplicacion.Size = new System.Drawing.Size(85, 20);
            this.txtLimiteMultiplicacion.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtLimiteMultiplicacion);
            this.Controls.Add(this.txtTablaMultiplicacion);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblLimite);
            this.Controls.Add(this.lblTabla);
            this.Controls.Add(this.btnMultiplicar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Label lblTabla;
        private System.Windows.Forms.Label lblLimite;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtTablaMultiplicacion;
        private System.Windows.Forms.TextBox txtLimiteMultiplicacion;
    }
}

