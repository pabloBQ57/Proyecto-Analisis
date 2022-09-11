using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;

namespace Presentación.MedicoGeneral
{
    public partial class VerFicha : Form
    {
       // CrudMedicoDominio crudMedicoDominio = new CrudMedicoDominio();
        public VerFicha()
        {
            InitializeComponent();
        }

        private void VerFicha_Load(object sender, EventArgs e)
        {
            MostrarFichamedica();
            alternar(dataGridView1);
            
        }


        private void MostrarFichamedica()
        {
            CrudMedicoDominio crudMedicoDominio = new CrudMedicoDominio();
            dataGridView1.DataSource = crudMedicoDominio.MostrarFicha();

        }

        public void alternar(DataGridView dvg)
        {
            dvg.ForeColor = Color.White;
            dvg.RowsDefaultCellStyle.BackColor = Color.Black;
            dvg.AlternatingRowsDefaultCellStyle.BackColor = Color.DimGray;
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            MostrarFichamedica();
        }
    }
}
