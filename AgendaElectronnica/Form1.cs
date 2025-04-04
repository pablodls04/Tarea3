using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;

namespace AgendaElectronnica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Contacto nuevoContacto = new Contacto
            {
                Nombre = txtNombre.Text,
                Telefono = txtTelefono.Text,
                Email = txtEmail.Text,
                Direccion = txtDireccion.Text
            };

            try
            {
                ContactoBL contactoBL = new ContactoBL();
                contactoBL.Insertar(nuevoContacto);
                MessageBox.Show("Contacto insertado correctamente.");
                CargarContactos(); // Actualiza la lista de contactos en el DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar el contacto: " + ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Contacto contacto = new Contacto
            {
                Id = int.Parse(txtId.Text),
                Nombre = txtNombre.Text,
                Telefono = txtTelefono.Text,
                Email = txtEmail.Text,
                Direccion = txtDireccion.Text
            };

            try
            {
                ContactoBL contactoBL = new ContactoBL();
                contactoBL.Modificar(contacto);
                MessageBox.Show("Contacto modificado correctamente.");
                CargarContactos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el contacto: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);

            try
            {
                ContactoBL contactoBL = new ContactoBL();
                contactoBL.Eliminar(id);
                MessageBox.Show("Contacto eliminado correctamente.");
                CargarContactos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el contacto: " + ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;

            try
            {
                ContactoBL contactoBL = new ContactoBL();
                List<Contacto> contactos = contactoBL.Buscar(nombre);
                dataGridView1.DataSource = contactos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar contactos: " + ex.Message);
            }
        }

        private void CargarContactos()
        {
            try
            {
                ContactoBL contactoBL = new ContactoBL();
                List<Contacto> contactos = contactoBL.ObtenerTodos();
                dataGridView1.DataSource = contactos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar contactos: " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
