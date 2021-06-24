using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio4.Arreglos
{
    public partial class FormEjercicio4 : Form
    {
        public FormEjercicio4()
        {
            InitializeComponent();
        }

        ArrayList datos = new ArrayList();

        private void ingresarbutton_Click(object sender, EventArgs e)
        {
            if (NombretextBox.Text == "")
            {
                errorProvider1.SetError(NombretextBox, "Debe Ingresar El Nombre Del Estudiante");
                NombretextBox.Focus();
                return;
            }
            else if (EdadtextBox.Text == "")
            {
                errorProvider1.SetError(EdadtextBox, "Debe Ingresar La Edad Del Estudiante");
                EdadtextBox.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(NombretextBox, "");
                errorProvider1.SetError(EdadtextBox, "");
            }
            MessageBox.Show("Estudiante Guardado");
            datos.Add(NombretextBox.Text + " | " + EdadtextBox.Text);
            EdadtextBox.Text = "";
            NombretextBox.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < datos.Count; i++)
            {
                MuestracomboBox.Items.Add(datos[i]);   
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MuestracomboBox.Items.Clear();
            for (int i = 0; i < datos.Count; i++)
            {
                datos.Sort();
                MuestracomboBox.Items.Add(datos[i]);             
            }
            MessageBox.Show("Nombres De Estudiantes de Forma Ascendentes");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MuestracomboBox.Items.Clear();
            for (int i = 0; i < datos.Count; i++)
            {
                datos.Sort();
                datos.Reverse();
                MuestracomboBox.Items.Add(datos[i]);
                
            }
            MessageBox.Show("Nombres De Estudiante de Forma Descendentes");
        }
    }
}
