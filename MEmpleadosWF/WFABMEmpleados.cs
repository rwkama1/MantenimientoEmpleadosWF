using MEmpleadosWF.modelo;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEmpleadosWF
{
    public partial class WFABMEmpleados : Form
    {
        public WFABMEmpleados()
        {
            InitializeComponent();

        }
        private void WFABMEmpleados_Load(object sender, EventArgs e)
        {

        }

        private void habilitarControles()
        {
            mcFechaI.Enabled = true;
            mcFechaN.Enabled = true;
            mtxtsalario.Enabled = true;
            txtNombre.Enabled = true;
        }
        private void desabilitarControles()
        {
            mcFechaI.Enabled = false;
            mcFechaN.Enabled = false;
            mtxtsalario.Enabled = false;
            txtNombre.Enabled = false;
        }
        private void limpiarCampos()
        {
          
            mtxtsalario.Text = "0000.00";
            txtNombre.Text = "";
            mcFechaI.SelectionStart = DateTime.Now;
            mcFechaN.SelectionStart = DateTime.Now;
            mcFechaI.SelectionEnd = DateTime.Now;
            mcFechaN.SelectionEnd = DateTime.Now;


        }

        //----------------------------------------------------------------------------------------------
       
        private void btnagregar_Click(object sender, EventArgs e)
        {
            try
            {

                string codigotexto = mtxtcodigo.Text;
                if (string.IsNullOrEmpty(codigotexto))
                {
                    MessageBox.Show("Debe ingresar un codigo");
                }
                else
                {
                    string nombretexto = txtNombre.Text;
                    string salariotexto = mtxtsalario.Text;
                    decimal salario = decimal.Parse(salariotexto);
                    short codigo = short.Parse(codigotexto);
                    Empleado empBaja = LogicaEmpleado.GetInstancia().buscarEmpleado(codigo);
                    if (empBaja != null)
                    {
                        string agregarempnaja = LogicaEmpleado.GetInstancia().agregarEmpleado(empBaja);
                        MessageBox.Show(agregarempnaja);
                    }
                    else
                    {
                        DateTime fechai = mcFechaI.SelectionStart;
                        DateTime fechan = mcFechaN.SelectionStart;
                        Empleado emp = new Empleado(codigo, nombretexto, fechan, fechai, salario, false);
                        string agregaremp = LogicaEmpleado.GetInstancia().agregarEmpleado(emp);
                        MessageBox.Show(agregaremp);
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                string codigotexto = mtxtcodigo.Text;
                if (string.IsNullOrEmpty(codigotexto))
                {
                    MessageBox.Show("Debe ingresar un codigo");
                }
                else
                {
                    string nombretexto = txtNombre.Text;
                    string salariotexto = mtxtsalario.Text;
                    decimal salario = decimal.Parse(salariotexto);
                    short codigo = short.Parse(codigotexto);
                    DateTime fechai = mcFechaI.SelectionStart;
                    DateTime fechan = mcFechaN.SelectionStart;
                    Empleado emp = new Empleado(codigo, nombretexto, fechan, fechai, salario, false);
                    string modificarEmpleado = LogicaEmpleado.GetInstancia().modificarEmpleado(emp);
                    MessageBox.Show(modificarEmpleado);
                    desabilitarControles();
                    limpiarCampos();
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnagregar.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {

                string codigotexto = mtxtcodigo.Text;
                if (string.IsNullOrEmpty(codigotexto))
                {
                    MessageBox.Show("Debe ingresar un codigo");
                }
                else
                {
                    short codigo = short.Parse(codigotexto);
                    string eliminarEmpleado = LogicaEmpleado.GetInstancia().bajaEmpleado(codigo);
                    MessageBox.Show(eliminarEmpleado);
                    desabilitarControles();
                    limpiarCampos();
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnagregar.Enabled = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            desabilitarControles();
            limpiarCampos();
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            btnagregar.Enabled = false;
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string codigotexto = mtxtcodigo.Text;
                if(string.IsNullOrEmpty(codigotexto))
                {
                    MessageBox.Show("Debe ingresar un codigo");
                }
                else
                { 
                short codigo = short.Parse(codigotexto);
                Empleado emp = LogicaEmpleado.GetInstancia().buscarEmpleadosinBaja(codigo);
                if (emp == null)
                {
                    limpiarCampos();

                    habilitarControles();
                    btnagregar.Enabled = true;
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = false;

                }
                else
                {
                    habilitarControles();
                    btnagregar.Enabled = false;
                    btnModificar.Enabled = true;
                    btnEliminar.Enabled = true;

                    txtNombre.Text = emp.Nombre;
                    string decimalString = string.Format("{0:0000.00}", emp.Salarioxhora);
                    mtxtsalario.Text = decimalString;

                    mcFechaI.SelectionStart = emp.Fecha_ingreso;
                    mcFechaI.SelectionEnd = emp.Fecha_ingreso;

                    mcFechaN.SelectionStart = emp.Fecha_nacimiento;
                    mcFechaN.SelectionEnd = emp.Fecha_nacimiento;

                }
               }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }


        }

        
        private void btnlistaremp_Click(object sender, EventArgs e)
        {
            Form _unForm = new WFListarEmpleados();
            _unForm.ShowDialog();
        }
    }
}
