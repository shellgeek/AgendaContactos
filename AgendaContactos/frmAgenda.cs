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

        // leyendo de la BD
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
            // abriendo el form
            frmAddContacto AddContac = new frmAddContacto();
            AddContac.ShowDialog();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

         void CargarGv() {
            //cargando el grid con info de la Db
            GrillaContactos.DataSource = null;
            GrillaContactos.DataSource = db.Contactos;
            }

        private void GrillaContactos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Boton buscar con parametros :) (No funciona sin los botones :))
            try
            {
                foreach (var con in db.Contactos)
                {
                    if (radioButton1.Checked == true)
                    {
                        if (con.Nombres.ToLower() == (txtBuscar.Text).ToLower())
                        {
                            GrillaContactos.DataSource = null;
                            GrillaContactos.DataSource = new List<classContacto>() { con };
                        }
                    }
                    else if (radioButton2.Checked == true)
                    {
                        if (con.Apellidos.ToLower() == (txtBuscar.Text).ToLower())
                        {
                            GrillaContactos.DataSource = null;
                            GrillaContactos.DataSource = new List<classContacto>() { con };
                        }
                    }
                    else if (radioButton3.Checked == true)
                    {
                        if (con.ID == int.Parse(txtBuscar.Text))
                        {
                            GrillaContactos.DataSource = null;
                            GrillaContactos.DataSource = new List<classContacto>() { con };
                        }
                    }
                    CargarGv();
                }
            }
            catch (Exception ex)
            {
                object exe = ex.Message;
                throw ex;
            }
            
            
            
        }
    }
}
