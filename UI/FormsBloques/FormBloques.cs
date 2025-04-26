using MinecraftManager.Models;
using MinecraftManager.Services;
using MinecraftManager.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2doParcial_Aranza.UI.FormsBloques
{
    public partial class FormBloques : Form
    {

        public FormBloques(BloqueService servicio)
        {
            InitializeComponent();
        }



        private void txtNombreBloque_TextChanged(object sender, EventArgs e)
        {
            btnGuardarBloque.Enabled = !string.IsNullOrWhiteSpace(txtNombreBloque.Text);
        }

        private void txtIdBloqueRegistrado_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtIdBloqueRegistrado.Text, out int id))
            {
                var bloque = _servicio.BuscarPorId(id);
                if (bloque != null)
                {
                    txtNombreBloque.Text = bloque.Nombre;
                    cmbTipo.Text = bloque.Tipo;
                    cmbRareza.Text = bloque.Rareza;
                }
                else
                {
                    MessageBox.Show("No se encontró el bloque con este ID.");
                }
            }
            else
            {
                txtNombreBloque.Clear();
                cmbTipo.SelectedIndex = -1;
                cmbRareza.SelectedIndex = -1;
            }
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipo.SelectedIndex >= 0)
            {
                string tipoSeleccionado = cmbTipo.SelectedItem.ToString();

                if (tipoSeleccionado == "Madera")
                {
                    cmbRareza.Items.Clear();
                    cmbRareza.Items.Add("Común");
                    cmbRareza.Items.Add("Rara");
                }
                else if (tipoSeleccionado == "Piedra")
                {
                    cmbRareza.Items.Clear();
                    cmbRareza.Items.Add("Común");
                    cmbRareza.Items.Add("Mítica");
                }
                else
                {
                    cmbRareza.Items.Clear();
                    cmbRareza.Items.Add("Común");
                }

                
                MessageBox.Show($"Has seleccionado el tipo: {tipoSeleccionado}");
            }
        }

        private void cmbRareza_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verifica si se ha seleccionado una opción
            if (cmbRareza.SelectedIndex >= 0)
            {
                string rarezaSeleccionada = cmbRareza.SelectedItem.ToString();

                // Dependiendo de la rareza seleccionada, realiza alguna acción
                if (rarezaSeleccionada == "Común")
                {
                    // Si es común, puedes habilitar o actualizar controles
                    MessageBox.Show("Has seleccionado la rareza: Común");
                }
                else if (rarezaSeleccionada == "Rara")
                {
                    // Si es rara, podrías hacer otra cosa
                    MessageBox.Show("Has seleccionado la rareza: Rara");
                }
                else if (rarezaSeleccionada == "Mítica")
                {
                    // Acciones específicas para "Mítica"
                    MessageBox.Show("Has seleccionado la rareza: Mítica");
                }
            }
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            // Verifica si el texto tiene al menos 1 carácter
            if (txtID.Text.Length > 0)
            {
                // Intenta convertir el texto a un número (ID)
                if (int.TryParse(txtID.Text, out int id))
                {
                    // Busca el bloque con el ID especificado
                    var bloque = _servicio.BuscarPorId(id);

                    // Si se encuentra el bloque, actualiza el DataGridView o muestra los detalles
                    if (bloque != null)
                    {
                        dgvDatosBloque.DataSource = new[] { bloque };
                    }
                    else
                    {
                        // Si no se encuentra el bloque, muestra un mensaje o limpia el DataGridView
                        dgvDatosBloque.DataSource = null;
                        MessageBox.Show("No se encontró un bloque con ese ID.", "Bloque no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    // Si no es un número, limpia el DataGridView
                    dgvDatosBloque.DataSource = null;
                }
            }
            else
            {
                // Si el campo está vacío, muestra todos los bloques
                dgvDatosBloque.DataSource = _servicio.ObtenerTodos();
            }
        }

        private void txtTipo_TextChanged(object sender, EventArgs e)
        {
            // Lista de tipos válidos
            var tiposValidos = new List<string> { "Natural", "Construcción", "Mineral", "Madera" };

            // Verifica si el tipo ingresado es válido
            if (tiposValidos.Contains(txtTipo.Text))
            {
                // Si es válido, realiza alguna acción (por ejemplo, buscar)
                dgvDatosBloque.DataSource = _servicio.BuscarPorTipo(txtTipo.Text);
            }
            else
            {
                // Si no es válido, muestra un mensaje o limpia el filtro
                MessageBox.Show("Por favor, ingrese un tipo válido.", "Tipo inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtRareza_TextChanged(object sender, EventArgs e)
        {
            // Lista de rarezas válidas
            var rarezasValidas = new List<string> { "Común", "Raro", "Épico" };

            // Verifica si el texto ingresado está en la lista de rarezas válidas
            if (rarezasValidas.Contains(txtRareza.Text))
            {
                // Si es válido, realiza alguna acción (por ejemplo, filtrar)
                dgvDatosBloque.DataSource = _servicio.BuscarPorRareza(txtRareza.Text);
            }
            else
            {
                // Si no es válido, muestra un mensaje de advertencia
                MessageBox.Show("Por favor, ingrese una rareza válida.", "Rareza inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBuscarBloqueID_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtID.Text, out int id))
            {
                var bloque = _servicio.BuscarPorId(id);

                if (bloque != null)
                {
                    txtNombreBloque.Text = bloque.Nombre;
                    cmbTipo.SelectedItem = bloque.Tipo;
                    cmbRareza.SelectedItem = bloque.Rareza;
                    txtIdBloqueRegistrado.Text = bloque.Id.ToString();

                    dgvDatosBloque.DataSource = new[] { bloque };
                }
                else
                {
                    MessageBox.Show("No se encontró un bloque con ese ID.", "Búsqueda fallida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un ID válido.", "ID inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBuscarT_Click(object sender, EventArgs e)
        {
            var resultado = _servicio.BuscarPorTipo(txtTipo.Text);
            dgvDatosBloque.DataSource = resultado;
        }

        private void btnRareza_Click(object sender, EventArgs e)
        {

            var resultado = _servicio.BuscarPorRareza(txtRareza.Text);
            dgvDatosBloque.DataSource = resultado;
        }

        private void dgvDatosBloque_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvDatosBloque.Rows[e.RowIndex].Cells["Id"].Value != null)
            {
                DataGridViewRow fila = dgvDatosBloque.Rows[e.RowIndex];

                txtIdBloqueRegistrado.Text = fila.Cells["Id"].Value.ToString();
                txtNombreBloque.Text = fila.Cells["Nombre"].Value.ToString();
                cmbTipo.Text = fila.Cells["Tipo"].Value.ToString();
                cmbRareza.Text = fila.Cells["Rareza"].Value.ToString();
            }
        }

        private void btnActualizarBloque_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdBloqueRegistrado.Text))
            {
                MessageBox.Show("Por favor selecciona un bloque para actualizar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var bloque = new Bloque
                {
                    Id = int.Parse(txtIdBloqueRegistrado.Text),
                    Nombre = txtNombreBloque.Text,
                    Tipo = cmbTipo.Text,
                    Rareza = cmbRareza.Text,
                    FechaCreacion = DateTime.Now
                };

                _servicio.Actualizar(bloque);
                MessageBox.Show("Bloque actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el bloque: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVerBloquesdvg_Click(object sender, EventArgs e)
        {
            try
            {
                var bloques = _servicio.ObtenerTodos(); 

                if (bloques != null && bloques.Any())
                {
                    dgvDatosBloque.DataSource = bloques;
                }
                else
                {
                    MessageBox.Show("No se encontraron bloques.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los bloques: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void buttonEliminarBloque_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(txtIdBloqueRegistrado.Text, out int id))
                {
                    var confirmResult = MessageBox.Show("¿Estás segura de eliminar este bloque?",
                                                        "Confirmar eliminación",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Warning);
                    if (confirmResult == DialogResult.Yes)
                    {
                        _servicio.Eliminar(id);
                        MessageBox.Show("Bloque eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvDatosBloque.DataSource = _servicio.ObtenerTodos();
                    }
                }
                else
                {
                    MessageBox.Show("Por favor ingresa un ID válido.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el bloque: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        private void btnSalirBloque_Click(object sender, EventArgs e)
        {
            Close();
        }

       
    }
}
