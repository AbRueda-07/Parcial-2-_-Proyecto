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
    public partial class VerBloquesInventario : Form
    {

        private readonly BloqueService _bloqueService;
        public VerBloquesInventario()
        {
            InitializeComponent();
            _bloqueService = new BloqueService(new DatabaseManager());

            Load += VerBloquesInventario_Load;
        }
        private void VerBloquesInventario_Load(object sender, EventArgs e)
        {
            try
            {
                var bloques = _bloqueService.ObtenerTodos();

                dataGriedBloqueInventario.Columns.Clear();
                dataGriedBloqueInventario.Rows.Clear();

                dataGriedBloqueInventario.Columns.Add("Id", "Id");
                dataGriedBloqueInventario.Columns.Add("Nombre", "Nombre");
                dataGriedBloqueInventario.Columns.Add("Tipo", "Tipo");
                dataGriedBloqueInventario.Columns.Add("Rareza", "Rareza");

                foreach (var bloque in bloques)
                {
                    dataGriedBloqueInventario.Rows.Add(
                        bloque.Id,
                        bloque.Nombre,
                        bloque.Tipo,
                        bloque.Rareza
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los jugadores:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void datosJugadores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
