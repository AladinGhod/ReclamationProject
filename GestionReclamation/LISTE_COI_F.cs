using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionReclamation
{
    public partial class LISTE_COI_F : Form
    {

        MyConnection db = new MyConnection();

        private RECGenerator RECGenerator = new RECGenerator();

        public LISTE_COI_F()
        {
            InitializeComponent();
          
            //RECGenerator.FillTable(dataGridView1);
            //RECGenerator.FillTableRejete(DataGridView);
            RECGenerator.UpdateRowCountLabel(lbReclCount);
            RECGenerator.UpdateRowCountLabelRejet(label1);
            //UpdateRowCountLabel();
        }

        private void LISTE_COI_F_Load(object sender, EventArgs e)
        {
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {

            RECGenerator.FillTablebetweenDate(dataGridView1, dateFrom, dateTo);
            RECGenerator.ExportExcel(dataGridView1);
        }

      


        private void btnExcelRej_Click(object sender, EventArgs e)
        {
            RECGenerator.FillTablebetweenDateReject(DataGridView, dateFrom, dateTo);
            RECGenerator.ExportExcel(DataGridView);
        }

        private void btnAfficher_Click(object sender, EventArgs e)
        {
            RECGenerator.FillTablebetweenDate(dataGridView1, dateFrom, dateTo);
        }

        private void btnAffReject_Click(object sender, EventArgs e)
        {
            RECGenerator.FillTablebetweenDateReject(DataGridView, dateFrom, dateTo);
        }
    }
}
