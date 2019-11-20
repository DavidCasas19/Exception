using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excepcion
{
    public partial class Frm1 : Form
    {
        public Frm1()
        {
            InitializeComponent();
        }

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            if (txtMatricula.Text == "")

                Ep.SetError(txtMatricula, "No ha ingresado matricula");


            if (txtNombre.Text == "")

                Ep.SetError(txtNombre, "No ha ingresado Nombre");

            if (txtSemestre.Text == "")

                Ep.SetError(txtSemestre, "No ha ingresado semestre");

            if (txtSemestre.Text == "")

                Ep.SetError(txtCarrera, "No ha ingresado Carrera");

            if (txtTelefono.Text == "")
                Ep.SetError(txtTelefono, "No ha ingresado telefono");


            try
            {
                Alumno Al = new Alumno();
                Al.Matricula = txtMatricula.Text;
                Al.Nombre = txtNombre.Text;
                Al.Semestre = Convert.ToInt32(txtSemestre.Text);
                Al.carrera = txtCarrera.Text;
                Al.Telefono = Convert.ToDouble(txtTelefono.Text);

                //throw new ExepcionEspecial("su alumno se creo exitosamente");
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error en registrar alumno" + ex.Message);
               
            }

            catch (Excepcion_Especial espex)
            {
                MessageBox.Show(espex.Message);
            }
            finally
            {
                Ep.Clear();
            }
        }

        private void Txtcal_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                int cal = Convert.ToInt32(Txtcal.Text);
                if (cal < 1 || cal > 10)
                {
                    MessageBox.Show("Ingrese una calificacion del 1 al 10", "Error");
                }
            }
            catch (Exception ex)

            {

                MessageBox.Show("Error en la entrada de datos", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

            }
        }
    }
}
