using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace EFSmarBisnessPro
{
    public partial class FrmProductos : Form
    {
        public FrmProductos()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                using (var context = new SmartBusinessContext())
                {
                    var productos = context.Productos
                        .Include(p => p.Categoria)
                        .Select(p => new
                        {
                            p.Nombre,
                            p.Precio,
                            p.Stock,
                            p.Activo,
                            Categoria = p.Categoria.Nombre
                        })
                        .ToList();

                    // Reemplaza 'dataGridView1' por el nombre real de tu DataGridView si le pusiste otro
                    dataGridView1.DataSource = productos;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error de conexión: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
