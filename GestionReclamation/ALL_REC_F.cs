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
    public partial class ALL_REC_F : Form
    {
        private RECGenerator RECGenerator = new RECGenerator();

        public ALL_REC_F()
        {
            InitializeComponent();
            RECGenerator.FillTableEncours(dataGridView1);
            RECGenerator.FillTableRejete(DataGridView);
            RECGenerator.UpdateRowCountLabel(lbReclCount);

            RECGenerator.UpdateRowCountLabelRejet(label1);
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            RECGenerator.ExportExcel(dataGridView1);
        }

        

        private void dataGridView1_SortStringChanged(object sender, Zuby.ADGV.AdvancedDataGridView.SortEventArgs e)
        {
            //this.vReclamNonTerminéBindingSource1.Sort = this.dataGridView1.SortString;
        }

        private void dataGridView1_FilterStringChanged(object sender, Zuby.ADGV.AdvancedDataGridView.FilterEventArgs e)
        {
            //this.vReclamNonTerminéBindingSource1.Filter = this.dataGridView1.FilterString;
        }

        private void vReclamNonTerminéBindingSource1_ListChanged(object sender, ListChangedEventArgs e)
        {
            //lbReclCount.Text = string.Format("Reclamation ouvert :{0}", this.vReclamNonTerminéBindingSource1.List.Count);
        }

        private void DataGridView_FilterStringChanged(object sender, Zuby.ADGV.AdvancedDataGridView.FilterEventArgs e)
        {
            //this.vReclamRejeteBindingSource.Filter = this.DataGridView.FilterString;
        }

        private void DataGridView_SortStringChanged(object sender, Zuby.ADGV.AdvancedDataGridView.SortEventArgs e)
        {
            //this.vReclamRejeteBindingSource.Sort = this.DataGridView.SortString;
        }

        private void vReclamRejeteBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            //label1.Text = string.Format("Reclamation Rejetee :{0}", this.vReclamRejeteBindingSource.List.Count);

        }

        private void btnExcelRej_Click(object sender, EventArgs e)
        {
            RECGenerator.ExportExcel(DataGridView);
        }
    }
}
