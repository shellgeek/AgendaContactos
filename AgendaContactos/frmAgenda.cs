using AgendaContactos.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaContactos
{
    public partial class frmAgenda : Form
    {
        public frmAgenda()
        {
            InitializeComponent();
        }

        public List<classContacto> ListaContacto = new List<classContacto>();
        dataBaseContext db = new dataBaseContext();
        private void Form1_Load(object sender, EventArgs e)
        {
            CargarGv();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void tsbAddContact_Click(object sender, EventArgs e)
        {
            frmAddContacto AddContac = new frmAddContacto();
            AddContac.ShowDialog();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

         void CargarGv() {
            GrillaContactos.DataSource = null;
            GrillaContactos.DataSource = db.Contactos;
            }

        private void GrillaContactos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
