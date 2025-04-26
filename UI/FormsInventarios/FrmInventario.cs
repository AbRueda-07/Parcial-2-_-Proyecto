using _2doParcial_Aranza.UI.FormsJugadores;
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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _2doParcial_Aranza.UI.FormsInventarios
{
    public partial class FrmInventario : Form
    {
        private readonly InventarioService _inventarioService;
        private readonly JugadorService _jugadorService;
        private readonly BloqueService _bloqueService;

        //variables globales de bandera
        private bool mostrandoJugadores = false;
        private bool mostrandoBloques = false;
        private string jugadorSeleccionado = "";
        private string bloqueSeleccionado = "";
        private bool inventarioCargado = false;

        public FrmInventario()
        {
            InitializeComponent();

            var dbManager = new DatabaseManager();
            _jugadorService = new JugadorService(dbManager);
            _bloqueService = new BloqueService(dbManager);
            _inventarioService = new InventarioService(dbManager, _jugadorService, _bloqueService);
        }

        private void btnVerInventario_Click(object sender, EventArgs e)
        {
            try
            {
                // Llama al método del servicio que obtiene todos los jugadores
                var inventarios = _inventarioService.ObtenerTodos();

                // Limpia columnas y filas anteriores
                dataGriedInventario.Columns.Clear();
                dataGriedInventario.Rows.Clear();

                // Agrega columnas
                dataGriedInventario.Columns.Add("Id", "Id");
                dataGriedInventario.Columns.Add("Nombre", "Nombre");
                dataGriedInventario.Columns.Add("Bloque", "Bloque");
                dataGriedInventario.Columns.Add("Cantidad", "Cantidad");


                foreach (var inventario in inventarios)
                {
                    dataGriedInventario.Rows.Add(
                        inventario.Id,
                        inventario.NombreJugador,
                        inventario.BloqueId,
                        inventario.Cantidad
                    );
                }

                inventarioCargado = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el inventario:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAgregarInventario_Click(object sender, EventArgs e)
        {
            string jugador = txtIDJugador.Text.Trim();
            string bloque = txtIDBloque.Text.Trim();
            string cantidad = txtCantidad.Text.Trim();

            if (string.IsNullOrEmpty(jugador))
            {
                var formJugadores = new VerJugadorInventario();
                formJugadores.ShowDialog(); // Solo mostramos la lista por ahora
                return; // detenemos aquí para que el usuario revise el ID
            }

            if (string.IsNullOrEmpty(bloque))
            {
                var formBloques = new VerBloquesInventario();
                formBloques.ShowDialog(); // Solo mostramos la lista por ahora
                return; // detenemos aquí para que el usuario revise el ID
            }

            if (string.IsNullOrEmpty(cantidad))
            {
                MessageBox.Show("Debe ingresar una cantidad", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var inventario = new Inventario
                {
                    JugadorId = Convert.ToInt32(jugador),
                    BloqueId = Convert.ToInt32(bloque),
                    Cantidad = Convert.ToInt32(cantidad)
                };

                _inventarioService.Agregar(inventario);

                MessageBox.Show("Inventario agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);


                txtIDJugador.Clear();
                txtIDBloque.Clear();
                txtCantidad.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al agregar el inventario:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizarCantidad_Click(object sender, EventArgs e)
        {
            string idInventario = txtIDInventario.Text.Trim();
            string bloque = txtIDBloque.Text.Trim();
            string cantidad = txtCantidad.Text.Trim();

            if (!int.TryParse(idInventario, out int id))
            {
                MessageBox.Show("Vea el Inventario para ver el ID a actualizar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(cantidad, out int totalCantidad))
            {
                MessageBox.Show("Ingrese la cantidad para actualizar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                var inventario = new Inventario
                {
                    Id = Convert.ToInt32(id),
                    // BloqueId = Convert.ToInt32(idBloque),
                    Cantidad = Convert.ToInt32(totalCantidad)
                };

                _inventarioService.Actualizar(inventario);

                MessageBox.Show("Inventario actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);


                txtIDJugador.Clear();
                txtIDBloque.Clear();
                txtCantidad.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el inventario:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarInventario_Click(object sender, EventArgs e)
        {

            string idInventario = txtIDInventario.Text.Trim();

            if (!int.TryParse(idInventario, out int id))
            {
                MessageBox.Show("Vea el Inventario para ver el ID a Eliminar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmacion = MessageBox.Show("¿Estás seguro de que deseas eliminar este registro del inventario?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion != DialogResult.Yes)
            {
                return; // El usuario canceló
            }

            try
            {
                _inventarioService.Eliminar(id);

                MessageBox.Show("Inventario eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtIDJugador.Clear();
                txtIDBloque.Clear();
                txtCantidad.Clear();
                txtIDInventario.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el inventario:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (!inventarioCargado)
            {
                MessageBox.Show("Primero presionar 'Ver Inventario' para asegurarte de que estás exportando la información correcta.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dataGriedInventario.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos en el inventario para exportar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV (*.csv)|*.csv";
            saveFileDialog.Title = "Guardar Inventario como CSV";
            saveFileDialog.FileName = "inventario.csv";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName, false, Encoding.UTF8))
                    {
                        // Escribe los encabezados
                        for (int i = 0; i < dataGriedInventario.Columns.Count; i++)
                        {
                            sw.Write(dataGriedInventario.Columns[i].HeaderText);
                            if (i < dataGriedInventario.Columns.Count - 1) sw.Write(",");
                        }
                        sw.WriteLine();

                        // Escribe las filas
                        foreach (DataGridViewRow row in dataGriedInventario.Rows)
                        {
                            if (!row.IsNewRow)
                            {
                                for (int i = 0; i < dataGriedInventario.Columns.Count; i++)
                                {
                                    sw.Write(row.Cells[i].Value?.ToString());
                                    if (i < dataGriedInventario.Columns.Count - 1) sw.Write(",");
                                }
                                sw.WriteLine();
                            }
                        }
                    }

                    MessageBox.Show("Inventario exportado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al exportar:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
