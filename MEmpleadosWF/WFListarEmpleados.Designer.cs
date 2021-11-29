
using System;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblListarEmpleado = new System.Windows.Forms.Label();
            this.dgvListarEmpleados = new System.Windows.Forms.DataGridView();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechadeNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechadeIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalarioporHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Antiguedad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdicionalAlSalario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // lblListarEmpleado
            // 
            this.lblListarEmpleado.AutoSize = true;
            this.lblListarEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListarEmpleado.Location = new System.Drawing.Point(213, 29);
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
            this.dgvListarEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListarEmpleados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvListarEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListarEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.Nombre,
            this.FechadeNacimiento,
            this.FechadeIngreso,
            this.SalarioporHora,
            this.Antiguedad,
            this.AdicionalAlSalario});
            this.dgvListarEmpleados.Location = new System.Drawing.Point(29, 107);
            this.dgvListarEmpleados.Name = "dgvListarEmpleados";
            this.dgvListarEmpleados.ReadOnly = true;
            this.dgvListarEmpleados.Size = new System.Drawing.Size(725, 316);
            this.dgvListarEmpleados.TabIndex = 1;
            // 
            // Código
            // 
            this.Código.DataPropertyName = "Codigo";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Código.DefaultCellStyle = dataGridViewCellStyle1;
            this.Código.HeaderText = "Código";
            this.Código.Name = "Código";
            this.Código.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre completo";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // FechadeNacimiento
            // 
            this.FechadeNacimiento.DataPropertyName = "Fecha_nacimiento";
            this.FechadeNacimiento.HeaderText = "Fecha de Nacimiento";
            this.FechadeNacimiento.Name = "FechadeNacimiento";
            this.FechadeNacimiento.ReadOnly = true;
            // 
            // FechadeIngreso
            // 
            this.FechadeIngreso.DataPropertyName = "Fecha_ingreso";
            this.FechadeIngreso.HeaderText = "Fecha de Ingreso";
            this.FechadeIngreso.Name = "FechadeIngreso";
            this.FechadeIngreso.ReadOnly = true;
            // 
            // SalarioporHora
            // 
            this.SalarioporHora.DataPropertyName = "Salarioxhora";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.SalarioporHora.DefaultCellStyle = dataGridViewCellStyle2;
            this.SalarioporHora.HeaderText = "Salario por Hora ( $ )";
            this.SalarioporHora.Name = "SalarioporHora";
            this.SalarioporHora.ReadOnly = true;
            // 
            // Antiguedad
            // 
            this.Antiguedad.DataPropertyName = "Antiguedad_En_Años";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Antiguedad.DefaultCellStyle = dataGridViewCellStyle3;
            this.Antiguedad.HeaderText = "Antiguedad (en años)";
            this.Antiguedad.Name = "Antiguedad";
            this.Antiguedad.ReadOnly = true;
            // 
            // AdicionalAlSalario
            // 
            this.AdicionalAlSalario.DataPropertyName = "Adicional_Al_Salario";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.AdicionalAlSalario.DefaultCellStyle = dataGridViewCellStyle4;
            this.AdicionalAlSalario.HeaderText = "Adicional";
            this.AdicionalAlSalario.Name = "AdicionalAlSalario";
            this.AdicionalAlSalario.ReadOnly = true;
            // 
            // WFListarEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 468);
            this.Controls.Add(this.dgvListarEmpleados);
            this.Controls.Add(this.lblListarEmpleado);
            this.Name = "WFListarEmpleados";
            this.Text = "WFListarEmpleados";
            this.Load += new System.EventHandler(this.WFListarEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       
        #endregion

        private System.Windows.Forms.Label lblListarEmpleado;
        private System.Windows.Forms.DataGridView dgvListarEmpleados;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechadeNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechadeIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalarioporHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Antiguedad;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdicionalAlSalario;
    }
}