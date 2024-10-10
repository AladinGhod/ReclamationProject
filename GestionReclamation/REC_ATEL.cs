using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionReclamation
{
    public partial class REC_ATEL : Form
    {
        private RECGenerator RECGenerator = new RECGenerator();

        public REC_ATEL()
        {
            InitializeComponent();
            RECGenerator.FillTable(dataGridView1);
            RECGenerator.FillTableRejete(DataGridView);
            RECGenerator.UpdateRowCountLabel(lbReclCount);
            RECGenerator.UpdateRowCountLabelRejet(label1);
        }

        private void REC_ATEL_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            RECGenerator.ExportExcel(dataGridView1);
        }

        private void btnExcelRej_Click(object sender, EventArgs e)
        {
            RECGenerator.ExportExcel(DataGridView);
        }
    }
}
