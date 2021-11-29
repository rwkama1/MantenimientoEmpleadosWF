
namespace MEmpleadosWF
{
    partial class WFABMEmpleados
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
            this.lblABMEmpleado = new System.Windows.Forms.Label();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblfechan = new System.Windows.Forms.Label();
            this.lblfechai = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mtxtsalario = new System.Windows.Forms.MaskedTextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.mcFechaN = new System.Windows.Forms.MonthCalendar();
            this.mcFechaI = new System.Windows.Forms.MonthCalendar();
            this.mtxtcodigo = new System.Windows.Forms.MaskedTextBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btnlistaremp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblABMEmpleado
            // 
            this.lblABMEmpleado.AutoSize = true;
            this.lblABMEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblABMEmpleado.Location = new System.Drawing.Point(284, 39);
            this.lblABMEmpleado.Name = "lblABMEmpleado";
            this.lblABMEmpleado.Size = new System.Drawing.Size(318, 39);
            this.lblABMEmpleado.TabIndex = 0;
            this.lblABMEmpleado.Text = "ABM de Empleados";
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcodigo.Location = new System.Drawing.Point(44, 131);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(56, 17);
            this.lblcodigo.TabIndex = 1;
            this.lblcodigo.Text = "Código:";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.Location = new System.Drawing.Point(44, 230);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(123, 17);
            this.lblnombre.TabIndex = 2;
            this.lblnombre.Text = "Nombre completo:";
            // 
            // lblfechan
            // 
            this.lblfechan.AutoSize = true;
            this.lblfechan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfechan.Location = new System.Drawing.Point(44, 296);
            this.lblfechan.Name = "lblfechan";
            this.lblfechan.Size = new System.Drawing.Size(145, 17);
            this.lblfechan.TabIndex = 3;
            this.lblfechan.Text = "Fecha de Nacimiento:";
            // 
            // lblfechai
            // 
            this.lblfechai.AutoSize = true;
            this.lblfechai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfechai.Location = new System.Drawing.Point(334, 296);
            this.lblfechai.Name = "lblfechai";
            this.lblfechai.Size = new System.Drawing.Size(122, 17);
            this.lblfechai.TabIndex = 4;
            this.lblfechai.Text = "Fecha de Ingreso:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(334, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Salario por Hora:";
            // 
            // mtxtsalario
            // 
            this.mtxtsalario.Enabled = false;
            this.mtxtsalario.Location = new System.Drawing.Point(456, 230);
            this.mtxtsalario.Mask = "0000.00";
            this.mtxtsalario.Name = "mtxtsalario";
            this.mtxtsalario.Size = new System.Drawing.Size(100, 20);
            this.mtxtsalario.TabIndex = 15;
            this.mtxtsalario.Text = "000000";
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(173, 230);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(128, 20);
            this.txtNombre.TabIndex = 16;
            // 
            // btnagregar
            // 
            this.btnagregar.Enabled = false;
            this.btnagregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregar.Location = new System.Drawing.Point(642, 158);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(77, 34);
            this.btnagregar.TabIndex = 17;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Enabled = false;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(642, 229);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(77, 34);
            this.btnModificar.TabIndex = 18;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(642, 296);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(77, 34);
            this.btnEliminar.TabIndex = 19;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(642, 464);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(77, 34);
            this.btnLimpiar.TabIndex = 20;
            this.btnLimpiar.Text = "Resetear";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // mcFechaN
            // 
            this.mcFechaN.Enabled = false;
            this.mcFechaN.Location = new System.Drawing.Point(46, 336);
            this.mcFechaN.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.mcFechaN.Name = "mcFechaN";
            this.mcFechaN.TabIndex = 21;
            // 
            // mcFechaI
            // 
            this.mcFechaI.Enabled = false;
            this.mcFechaI.Location = new System.Drawing.Point(337, 336);
            this.mcFechaI.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.mcFechaI.Name = "mcFechaI";
            this.mcFechaI.TabIndex = 22;
            // 
            // mtxtcodigo
            // 
            this.mtxtcodigo.Location = new System.Drawing.Point(127, 131);
            this.mtxtcodigo.Mask = "0000";
            this.mtxtcodigo.Name = "mtxtcodigo";
            this.mtxtcodigo.Size = new System.Drawing.Size(100, 20);
            this.mtxtcodigo.TabIndex = 11;
            this.mtxtcodigo.Text = "0000";
            // 
            // btnbuscar
            // 
            this.btnbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.Location = new System.Drawing.Point(248, 131);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(77, 34);
            this.btnbuscar.TabIndex = 23;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // btnlistaremp
            // 
            this.btnlistaremp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlistaremp.Location = new System.Drawing.Point(642, 367);
            this.btnlistaremp.Name = "btnlistaremp";
            this.btnlistaremp.Size = new System.Drawing.Size(77, 34);
            this.btnlistaremp.TabIndex = 24;
            this.btnlistaremp.Text = "Listar";
            this.btnlistaremp.UseVisualStyleBackColor = true;
            this.btnlistaremp.Click += new System.EventHandler(this.btnlistaremp_Click);
            // 
            // WFABMEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 529);
            this.Controls.Add(this.btnlistaremp);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.mcFechaI);
            this.Controls.Add(this.mcFechaN);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.mtxtsalario);
            this.Controls.Add(this.mtxtcodigo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblfechai);
            this.Controls.Add(this.lblfechan);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.lblcodigo);
            this.Controls.Add(this.lblABMEmpleado);
            this.Name = "WFABMEmpleados";
            this.Text = "WFABMEmpleados";
            this.Load += new System.EventHandler(this.WFABMEmpleados_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblABMEmpleado;
        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblfechan;
        private System.Windows.Forms.Label lblfechai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mtxtsalario;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.MonthCalendar mcFechaN;
        private System.Windows.Forms.MonthCalendar mcFechaI;
        private System.Windows.Forms.MaskedTextBox mtxtcodigo;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button btnlistaremp;
    }
}