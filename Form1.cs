using _2doParcial_Aranza.UI.FormsBloques;
using _2doParcial_Aranza.UI.FormsInventarios;
using _2doParcial_Aranza.UI.FormsJugadores;
using MinecraftManager.Models;

namespace _2doParcial_Aranza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFrmJugador_Click(object sender, EventArgs e)
        {
            var formAgregarJugador = new Jugadores();
            formAgregarJugador.ShowDialog();
        }

        private void btnFrmInventario_Click(object sender, EventArgs e)
        {
            var formInventario = new FrmInventario();
            formInventario.ShowDialog();
        }

        private void btnFrmBloques_Click(object sender, EventArgs e)
        {
            FormBloques formBloques = new FormBloques();
            formBloques.ShowDialog();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
