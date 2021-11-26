
namespace MEmpleadosWF
{
    partial class WFListarEmpleados
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
            this.lblListarEmpleado = new System.Windows.Forms.Label();
            this.dgvListarEmpleados = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechadeNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechadeIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Antiguedad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalarioporHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdicionalAlSalario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // lblListarEmpleado
            // 
            this.lblListarEmpleado.AutoSize = true;
            this.lblListarEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListarEmpleado.Location = new System.Drawing.Point(256, 29);
            this.lblListarEmpleado.Name = "lblListarEmpleado";
            this.lblListarEmpleado.Size = new System.Drawing.Size(354, 39);
            this.lblListarEmpleado.TabIndex = 0;
            this.lblListarEmpleado.Text = "Listado de Empleados";
            // 
            // dgvListarEmpleados
            // 
            this.dgvListarEmpleados.AllowUserToAddRows = false;
            this.dgvListarEmpleados.AllowUserToDeleteRows = false;
            this.dgvListarEmpleados.AllowUserToOrderColumns = true;
            this.dgvListarEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListarEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.FechadeNacimiento,
            this.FechadeIngreso,
            this.Código,
            this.Antiguedad,
            this.SalarioporHora,
            this.AdicionalAlSalario});
            this.dgvListarEmpleados.Location = new System.Drawing.Point(44, 107);
            this.dgvListarEmpleados.Name = "dgvListarEmpleados";
            this.dgvListarEmpleados.ReadOnly = true;
            this.dgvListarEmpleados.Size = new System.Drawing.Size(879, 292);
            this.dgvListarEmpleados.TabIndex = 1;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre completo";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 125;
            // 
            // FechadeNacimiento
            // 
            this.FechadeNacimiento.DataPropertyName = "Fecha_nacimiento";
            this.FechadeNacimiento.HeaderText = "Fecha de Nacimiento";
            this.FechadeNacimiento.Name = "FechadeNacimiento";
            this.FechadeNacimiento.ReadOnly = true;
            this.FechadeNacimiento.Width = 140;
            // 
            // FechadeIngreso
            // 
            this.FechadeIngreso.DataPropertyName = "Fecha_ingreso";
            this.FechadeIngreso.HeaderText = "Fecha de Ingreso";
            this.FechadeIngreso.Name = "FechadeIngreso";
            this.FechadeIngreso.ReadOnly = true;
            this.FechadeIngreso.Width = 115;
            // 
            // Código
            // 
            this.Código.DataPropertyName = "Codigo";
            this.Código.HeaderText = "Código";
            this.Código.Name = "Código";
            this.Código.ReadOnly = true;
            this.Código.Width = 75;
            // 
            // Antiguedad
            // 
            this.Antiguedad.DataPropertyName = "Antiguedad_En_Años";
            this.Antiguedad.HeaderText = "Antiguedad (en años)";
            this.Antiguedad.Name = "Antiguedad";
            this.Antiguedad.ReadOnly = true;
            this.Antiguedad.Width = 140;
            // 
            // SalarioporHora
            // 
            this.SalarioporHora.DataPropertyName = "Salarioxhora";
            this.SalarioporHora.HeaderText = "Salario por Hora ( $ )";
            this.SalarioporHora.Name = "SalarioporHora";
            this.SalarioporHora.ReadOnly = true;
            this.SalarioporHora.Width = 127;
            // 
            // AdicionalAlSalario
            // 
            this.AdicionalAlSalario.DataPropertyName = "Adicional_Al_Salario";
            this.AdicionalAlSalario.HeaderText = "Adicional";
            this.AdicionalAlSalario.Name = "AdicionalAlSalario";
            this.AdicionalAlSalario.ReadOnly = true;
            this.AdicionalAlSalario.Width = 70;
            // 
            // WFListarEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 468);
            this.Controls.Add(this.dgvListarEmpleados);
            this.Controls.Add(this.lblListarEmpleado);
            this.Name = "WFListarEmpleados";
            this.Text = "WFListarEmpleados";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblListarEmpleado;
        private System.Windows.Forms.DataGridView dgvListarEmpleados;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechadeNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechadeIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Antiguedad;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalarioporHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdicionalAlSalario;
    }
}