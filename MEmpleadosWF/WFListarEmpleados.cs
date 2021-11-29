using MEmpleadosWF.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MEmpleadosWF
{
    public partial class WFListarEmpleados : Form
    {
        public WFListarEmpleados()
        {
            InitializeComponent();
           
        }
        private void WFListarEmpleados_Load(object sender, EventArgs e)
        {
            listarEmpleados();
        }


        private void listarEmpleados()
        {
            try
            {
                List<Empleado> listaremp = LogicaEmpleado.GetInstancia().listarEmpleadosSinBaja().ToList();

                
                dgvListarEmpleados.AutoGenerateColumns = false;
                dgvListarEmpleados.DataSource = listaremp;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
          
           
        }
      
    }
}
