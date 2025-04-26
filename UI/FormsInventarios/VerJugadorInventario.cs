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

namespace _2doParcial_Aranza.UI.FormsInventarios
{
    public partial class VerJugadorInventario : Form
    {
        private readonly InventarioService _inventarioService;
        private readonly JugadorService _jugadorService;
        private readonly BloqueService _bloqueService;

        public VerJugadorInventario()
        {
            InitializeComponent();
            var dbManager = new DatabaseManager();
            _jugadorService = new JugadorService(dbManager);
            _bloqueService = new BloqueService(dbManager);
            _inventarioService = new InventarioService(dbManager, _jugadorService, _bloqueService);

            Load += VerJugadorInventario_Load;
        }

        private void VerJugadorInventario_Load(object sender, EventArgs e)
        {
            try
            {
                var jugadores = _jugadorService.ObtenerTodos();

                dataGridJugadores.Columns.Clear();
                dataGridJugadores.Rows.Clear();

                dataGridJugadores.Columns.Add("Id", "ID");
                dataGridJugadores.Columns.Add("Nombre", "Nombre");
                dataGridJugadores.Columns.Add("Nivel", "Nivel");
                dataGridJugadores.Columns.Add("FechaCreacion", "Fecha de Creación");

                foreach (var jugador in jugadores)
                {
                    dataGridJugadores.Rows.Add(
                        jugador.Id,
                        jugador.Nombre,
                        jugador.Nivel,
                        jugador.FechaCreacion.ToString("yyyy-MM-dd HH:mm:ss")
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los jugadores:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridJugadores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificamos que sea la columna ID
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                int jugadorId = Convert.ToInt32(dataGridJugadores.Rows[e.RowIndex].Cells["Id"].Value);
                string nombre = dataGridJugadores.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                string nivel = dataGridJugadores.Rows[e.RowIndex].Cells["Nivel"].Value.ToString();

                var inventario = _inventarioService.ObtenerPorJugador(jugadorId);

                if (inventario.Count == 0)
                {
                    MessageBox.Show($"El jugador {nombre} no tiene bloques en su inventario.", "Inventario vacío", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var sb = new StringBuilder();
                sb.AppendLine($"Inventario de {nombre} (Nivel {nivel}):");

                int totalBloques = 0;
                foreach (var item in inventario)
                {
                    sb.AppendLine($"- {item.Cantidad} {item.NombreBloque}");
                    totalBloques += item.Cantidad;
                }

                sb.AppendLine($"\nTotal de bloques: {totalBloques}");
                sb.AppendLine($"Total de tipos de bloques: {inventario.Count}");

                MessageBox.Show(sb.ToString(), "Inventario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}