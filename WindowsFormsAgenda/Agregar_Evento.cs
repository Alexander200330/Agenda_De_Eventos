using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAgenda
{
    public partial class Agregar_Evento : Form
    {
        
        public Agregar_Evento()
        {
            InitializeComponent();
        }

        private void fecha_ValueChanged(object sender, EventArgs e)
        {
            DateTime Fecha = fecha.Value;
        }

        // Historia de usuario HU 1,  Crear eventos
        public void btnAceptar_Click(object sender, EventArgs e)
        {

            if (txtEvento.Text != "") //Criterio de completar los campos requeridos
            {
                DateTime Fecha = fecha.Value;
                string evento = txtEvento.Text;
                string fecha1 = Fecha.ToString("dd MMMM yyy"); //Criterio formato de fecha

                txtEvento.Text = "";
                MessageBox.Show("Se ha agregado el evento"); //Criterio de mostrar mensaje

                //HU 4: Mostrar eventos
                DataGridViewRow fila = new DataGridViewRow();
                fila.CreateCells(dgv);
                fila.Cells[0].Value = evento;
                fila.Cells[1].Value = fecha1;

                dgv.Rows.Add(fila);
            }
            else
            {
                MessageBox.Show("Debes completar todos los campos");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        int posicion;


        //HU 3: Editar eventos
        private void btnEditar_Click(object sender, EventArgs e)
        {
            DateTime Fecha = fecha.Value;
            string evento = txtEvento.Text;
            string fecha1 = Fecha.ToString("dd MMMM yyy");
            posicion = dgv.CurrentRow.Index;

            dgv[0, posicion].Value = evento;
            dgv[1, posicion].Value = fecha1;

            MessageBox.Show("Mensaje editado con éxito"); //Criterio de mensaje
        }

        //HU 2: Eliminar eventos
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            dgv.Rows.Remove(dgv.CurrentRow);

        }
    }
}
