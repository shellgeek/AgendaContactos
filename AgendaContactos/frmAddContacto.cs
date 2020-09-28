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
    public partial class frmAddContacto : Form
    {
        public frmAddContacto()
        {
            InitializeComponent();
        }

        dataBaseContext db = new dataBaseContext();
        private void frmAddContacto_Load(object sender, EventArgs e)
        {
            CargarGV();
        }

        private void txtAgregarMod_Click(object sender, EventArgs e)
        {
            LimpiarErrores();
            if(ValidarCampos())
            {
                //Agregar
                classContacto ObjContact = new classContacto();
                ObjContact.Id = int.Parse(txtID.Text);
                ObjContact.Nombres = txtNombre.Text;
                ObjContact.Apellidos = txtApellidos.Text;
                string sexo = "";
                if (rdoMas.Checked == true) sexo = "MASCULINO";
                if (rdoFem.Checked == true) sexo = "FEMENINO";
                if (rdoOtros.Checked == true) sexo = "OTROS";
                ObjContact.Sexo = sexo;
                ObjContact.Direccion = txtDireccion.Text;
                ObjContact.Ciudad = txtCiudad.Text;
                ObjContact.Pais = txtPais.Text;
                ObjContact.TelefonoMovil = txtTelefono.Text;
                ObjContact.Email = txtEmail.Text;

                db.Contactos.Add(ObjContact);
                CargarGV();
            }
            
        }

        void LimpiarTextbox()
        {
            txtNombre.Clear();
            txtApellidos.Clear();
            txtDireccion.Clear();
            txtCiudad.Clear();
            txtPais.Clear();
            txtTelefono.Clear();
            txtID.Clear();
            txtEmail.Clear();
        }

        public void CargarGV() {
            //Cargar grid cuando inicie el proyecto
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = db.Contactos;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private bool ValidarCampos()
        {
            bool Valido = true;

            if (txtID.Text == "")
            {
                Valido = false;
                ErrorPro.SetError(txtID, "Debe ingresar un ID!");
            }
            if (txtNombre.Text == "")
            {
                Valido = false;
                ErrorPro.SetError(txtNombre, "Debe Ingrear un Nombre!");
            }
            if (txtApellidos.Text == "")
            {
                Valido = false;
                ErrorPro.SetError(txtApellidos, "Debe Ingrear un Apellido!");
            }
            if (txtTelefono.Text == "")
            {
                Valido = false;
                ErrorPro.SetError(txtTelefono, "Debe Ingrear un Telefono!");
            }

            return Valido;
        }

        void LimpiarErrores()
        {
            ErrorPro.SetError(txtID, "");
            ErrorPro.SetError(txtNombre, "");
            ErrorPro.SetError(txtApellidos, "");
            ErrorPro.SetError(txtTelefono, "");

        }

    }
}
