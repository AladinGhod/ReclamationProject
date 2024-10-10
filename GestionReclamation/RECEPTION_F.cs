using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionReclamation
{
    public partial class RECEPTION_F : Form
    {
        MyConnection db = new MyConnection();
        private RECGenerator RECGenerator = new RECGenerator();
        public RECEPTION_F()
        {
            InitializeComponent();
            RECGenerator.FillTableTermine(dataGridView1);
            RECGenerator.UpdateRowCountLabelTermine(lbReclCount);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && dataGridView1.SelectedRows.Count > 0 && dataGridView1.CurrentRow != null)
            {
                textBox7.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                DataGridViewRow currentRow = dataGridView1.CurrentRow;

             
            }

            fillReclamationFromDB();
            FillDetailsFromDb();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                fillReclamationFromDB();
                FillDetailsFromDb();
            }
        }


        public void FillDetailsFromDb()
        {
            db.conn.Open();


            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT * FROM [SSISDB].[dbo].[ListeMajore] where [Nr OF] = @NrOF", db.conn);

            cmd.Parameters.AddWithValue("@NrOF", textBox1.Text);

            SqlDataReader da;

            da = cmd.ExecuteReader();


            while (da.Read())
            {

                object value = da.GetValue(0);
                string atelierText;

                if (!int.TryParse(value.ToString(), out int atelierValue))
                {
                    atelierText = value.ToString();
                }
                else
                {
                    switch (atelierValue)
                    {
                        case 3:
                            atelierText = "WAFA";
                            break;
                        case 4:
                            atelierText = "SOCOSAH";
                            break;
                        case 6:
                            atelierText = "AITICO";
                            break;
                        case 7:
                            atelierText = "SOCONA";
                            break;
                        default:
                            atelierText = atelierValue.ToString();
                            break;
                    }
                    textBox2.Text = atelierText;
                }



                textBox3.Text = da.GetValue(1).ToString();
               
                textBox5.Text = da.GetValue(14).ToString();

            }
            db.conn.Close();
        }

        public void fillReclamationFromDB()
        {

            db.conn.Open();
            SqlCommand cmd1 = new SqlCommand("SELECT * FROM [SSISDB].[dbo].[ReclamationNew] WHERE [NrOF]=@NrOF and [DateReclamation]=@DateReclamation", db.conn);

            cmd1.Parameters.AddWithValue("@NrOF", textBox1.Text);
            cmd1.Parameters.AddWithValue("@DateReclamation", textBox7.Text);


            SqlDataReader da1;
            da1 = cmd1.ExecuteReader();

            while (da1.Read())
            {
                string text = "";
                text += (!da1.IsDBNull(10) && !string.IsNullOrEmpty(da1.GetString(10))) ? "ACCESSOIRES: " + da1.GetString(10) + "\n" : "";
                text += (!da1.IsDBNull(11) && !string.IsNullOrEmpty(da1.GetString(11))) ? "TISSU: " + da1.GetString(11) + "\n" : "";
                text += (!da1.IsDBNull(12) && !string.IsNullOrEmpty(da1.GetString(12))) ? "COUPE: " + da1.GetString(12) + "\n" : "";
                text += (!da1.IsDBNull(13) && !string.IsNullOrEmpty(da1.GetString(13))) ? "FINITION: " + da1.GetString(13) + "\n" : "";
                text += (!da1.IsDBNull(14) && !string.IsNullOrEmpty(da1.GetString(14))) ? "RECOUPAGE: " + da1.GetString(14) + "\n" : "";
                text += (!da1.IsDBNull(15) && !string.IsNullOrEmpty(da1.GetString(15))) ? "NOTE: " + da1.GetString(15) + "\n" : "";


                label8.Text = text;
              
                textBox4.Text = da1.GetValue(8).ToString();
            }

            db.conn.Close();
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
         
            textBox7.Clear();
          
            label8.Text = "";
            btnRejected.Checked = false;
          
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            RECGenerator.FillTableTermine(dataGridView1);
            RECGenerator.UpdateRowCountLabelTermine(lbReclCount);
        }
        private string EtatReclamation;

        private void btnRejected_CheckedChanged(object sender, EventArgs e)
        {
            EtatReclamation = "Réçu";
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            db.conn.Open();

            string dateReception = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            DataTable dt = new DataTable();

            SqlCommand cmd = new SqlCommand("UPDATE [SSISDB].[dbo].[ReclamationNew] SET [EtatReclamation]=@EtatReclamation, [DateReception]=@DateReception WHERE [NrOF] = @NrOF and [DateReclamation] =@DateReclamation", db.conn);

            cmd.Parameters.AddWithValue("@NrOF", textBox1.Text);
            cmd.Parameters.AddWithValue("@EtatReclamation", EtatReclamation);
            cmd.Parameters.AddWithValue("@DateReception", dateReception);
            cmd.Parameters.AddWithValue("@DateReclamation", textBox7.Text);

            if ( !btnRejected.Checked )
            {
                MessageBox.Show("Coucher Réçu");
            }

          
            else
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update Done");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox7.Clear();
               
                label8.Text = "";
               
                btnRejected.Checked = false;
               

                textBox5.BackColor = SystemColors.Window;
              
            }

            db.conn.Close();
            RECGenerator.FillTableTermine(dataGridView1);
            RECGenerator.UpdateRowCountLabelTermine(lbReclCount);
            
        }
    }
}
