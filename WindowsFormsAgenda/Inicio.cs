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
    public partial class Inicio : Form
    {
        private int xClick;
        private int yClick;

        public Inicio()
        {
            InitializeComponent();
        }

        //HU 5: Pantalla de inicio
        private void Inicio_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            { xClick = e.X; yClick = e.Y; }
            else
            { this.Left = this.Left + (e.X - xClick); this.Top = this.Top + (e.Y - yClick); }
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void horafecha_Tick(object sender, EventArgs e)
        {
            //lblHora.Text = DateTime.Now.ToLongTimeString(); Fecha larga
            //lblHora.Text = DateTime.Now.ToShortTimeString(); Fecha corta
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
            //lblFecha.Text = DateTime.Now.ToLongDateString();
            lblFecha.Text = DateTime.Now.ToString("dd MMMM yyy");
        }
    }
}
