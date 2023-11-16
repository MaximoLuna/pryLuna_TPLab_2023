namespace TPLab_Parcial2_Luna_2023
{
    partial class frmListadoEmpleados
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.lblSeleccionarEmpleado = new System.Windows.Forms.Label();
            this.cmbListarEmpleado = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(222, 12);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(315, 170);
            this.treeView1.TabIndex = 5;
            // 
            // lblSeleccionarEmpleado
            // 
            this.lblSeleccionarEmpleado.AutoSize = true;
            this.lblSeleccionarEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccionarEmpleado.Location = new System.Drawing.Point(10, 12);
            this.lblSeleccionarEmpleado.Name = "lblSeleccionarEmpleado";
            this.lblSeleccionarEmpleado.Size = new System.Drawing.Size(204, 17);
            this.lblSeleccionarEmpleado.TabIndex = 4;
            this.lblSeleccionarEmpleado.Text = "Listar código del empleado";
            // 
            // cmbListarEmpleado
            // 
            this.cmbListarEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbListarEmpleado.FormattingEnabled = true;
            this.cmbListarEmpleado.Location = new System.Drawing.Point(13, 48);
            this.cmbListarEmpleado.Name = "cmbListarEmpleado";
            this.cmbListarEmpleado.Size = new System.Drawing.Size(143, 21);
            this.cmbListarEmpleado.TabIndex = 3;
            // 
            // frmListadoEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 207);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.lblSeleccionarEmpleado);
            this.Controls.Add(this.cmbListarEmpleado);
            this.Name = "frmListadoEmpleados";
            this.Text = "Listado de Empleados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label lblSeleccionarEmpleado;
        private System.Windows.Forms.ComboBox cmbListarEmpleado;
    }
}