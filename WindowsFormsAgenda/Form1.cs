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
    public partial class FormAgenda : Form
    {
        private int xClick;
        private int yClick;

        public FormAgenda()
        {
            InitializeComponent();
        }
        
            private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState=FormWindowState.Minimized;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AbrirFormEnPanel(object formhija)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();

        }

        private void btnVerEventos_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Agregar_Evento());
        }


        private void BarraTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            { xClick = e.X; yClick = e.Y; }
            else
            { this.Left = this.Left + (e.X - xClick); this.Top = this.Top + (e.Y - yClick); }
        }

        private void MenuVertical_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            { xClick = e.X; yClick = e.Y; }
            else
            { this.Left = this.Left + (e.X - xClick); this.Top = this.Top + (e.Y - yClick); }
        }

        private void panelContenedor_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            { xClick = e.X; yClick = e.Y; }
            else
            { this.Left = this.Left + (e.X - xClick); this.Top = this.Top + (e.Y - yClick); }
        }

        private void FormAgenda_Load(object sender, EventArgs e)
        {
            btnInicio_Click(null, e);
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Inicio());
        }

        private void btnAgregarEventos_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Agregar_Evento());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnMinimizar_MouseHover(object sender, EventArgs e)
        {
            Color newColor = Color.FromArgb(40, Color.White);
            btnMinimizar.BackColor = newColor;
             
        }

        private void btnMinimizar_MouseLeave(object sender, EventArgs e)
        {
            btnMinimizar.BackColor = Color.Transparent;
        }

        private void btnMaximizar_MouseHover(object sender, EventArgs e)
        {
            Color newColor = Color.FromArgb(60, Color.White);
            btnMaximizar.BackColor = newColor;
        }

        private void btnMaximizar_MouseLeave(object sender, EventArgs e)
        {
            btnMaximizar.BackColor = Color.Transparent;
        }

        private void btnRestaurar_MouseHover(object sender, EventArgs e)
        {
            Color newColor = Color.FromArgb(60, Color.White);
            btnRestaurar.BackColor = newColor;
        }

        private void btnRestaurar_MouseLeave(object sender, EventArgs e)
        {
            btnRestaurar.BackColor = Color.Transparent;
        }

        private void btnCerrar_MouseHover(object sender, EventArgs e)
        {
            Color newColor = Color.FromArgb(60, Color.White);
            btnCerrar.BackColor = newColor;
        }

        private void btnCerrar_MouseLeave(object sender, EventArgs e)
        {
            btnCerrar.BackColor = Color.Transparent;
        }

        private void btnSalir_MouseHover(object sender, EventArgs e)
        {
            Color newColor = Color.FromArgb(40, Color.White);
            btnSalir.BackColor = newColor;
        }

        private void btnSalir_MouseLeave(object sender, EventArgs e)
        {
            btnSalir.BackColor = Color.Transparent;
        }
    }
}
