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

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void tsbAddContact_Click(object sender, EventArgs e)
        {
            frmAddContacto AddContac = new frmAddContacto();
            AddContac.ShowDialog();
        }

        public void ActualiazaGrilla()
        {
            GrillaContactos.DataSource = ListaContacto;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
