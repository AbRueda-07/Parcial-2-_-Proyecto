using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MinecraftManager.Models;
using MinecraftManager.Services;
using MinecraftManager.Utils;

namespace _2doParcial_Aranza.UI.FormsBloques
{
    public partial class FormBloques : Form
    {
        private readonly BloqueService _servicio;

        public FormBloques(bool cargarDatos = true)
        {
            InitializeComponent();
            _servicio = new BloqueService(new DatabaseManager());

            // Solo carga datos si se desea (por defecto es true)
            if (cargarDatos)
            {
                CargarDatos();
            }
        }

        private void CargarDatos()
        {
            dgvDatosBloque.DataSource = _servicio.ObtenerTodos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var bloque = new Bloque
            {
                Nombre = txtNombreBloque.Text,
                Tipo = cmbTipo.Text,
                Rareza = cmbRareza.Text,
                FechaCreacion = DateTime.Now
            };
            _servicio.Insertar(bloque);
            CargarDatos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            var bloque = new Bloque
            {
                Id = int.Parse(txtIdBloqueRegistrado.Text),
                Nombre = txtNombreBloque.Text,
                Tipo = cmbTipo.Text,
                Rareza = cmbRareza.Text
            };
            _servicio.Actualizar(bloque);
            CargarDatos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtIdBloqueRegistrado.Text);
            _servicio.Eliminar(id);
            CargarDatos();
        }

        private void btnBuscarID_Click(object sender, EventArgs e)
        {
            var bloque = _servicio.BuscarPorId(int.Parse(txtID.Text));
            dgvDatosBloque.DataSource = bloque != null ? new[] { bloque } : null;
        }

        private void btnBuscarTipo_Click(object sender, EventArgs e)
        {
            dgvDatosBloque.DataSource = _servicio.BuscarPorTipo(txtTipo.Text);
        }

        private void btnBuscarRareza_Click(object sender, EventArgs e)
        {
            dgvDatosBloque.DataSource = _servicio.BuscarPorRareza(txtRareza.Text);
        }

        private void btnVerBloques_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
