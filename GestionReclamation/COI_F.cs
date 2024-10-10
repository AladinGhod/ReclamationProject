using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionReclamation
{
    public partial class COI_F : Form
    {
        MyConnection db = new MyConnection();
        private RECGenerator RECGenerator = new RECGenerator();
        

        // Importation de la fonction nécessaire pour déplacer la fenêtre sans bordure
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        // Constantes pour la manipulation de la fenêtre
        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x2;

        private void YourForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        public COI_F()
        {
            InitializeComponent();

            btnMinimize.Click += btnMinimize_Click;
            btnClose.Click += btnClose_Click;
            RECGenerator.FillTableEncours(dGviewInter);
            RECGenerator.UpdateRowCountLabel(lblRowCount);
            pictureBox4.Visible = false;
          
        }



        private void COI_F_Load(object sender, EventArgs e)
        {
            //this.reclamationTableAdapter.Fill(this.dSReclamV1.Reclamation);
        }

        private void dGviewInter_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dGviewInter.SelectedRows.Count > 0 && dGviewInter.CurrentRow != null)
            {
                textBox7.Text = dGviewInter.SelectedRows[0].Cells[4].Value.ToString();
                textBox1.Text = dGviewInter.SelectedRows[0].Cells[0].Value.ToString();

                DataGridViewRow currentRow = dGviewInter.CurrentRow;
                //Code pour afficher les images
                //if (currentRow.Cells.Count > 4 && currentRow.Cells[13].Value != DBNull.Value)
                //{
                //    byte[] imgData = (byte[])currentRow.Cells[13].Value;
                //    MemoryStream ms = new MemoryStream(imgData);
                //    pictureBox2.Image = Image.FromStream(ms);
                //}
                //else
                //{
                //    pictureBox2.Image = null;
                //}
            }
            fillReclamationFromDB();
            FillDetailsFromDb();
            DureeReclamation();
           
        }

        private string EtatReclamation;

        private void buttonTerminé_CheckedChanged(object sender, EventArgs e)
        {
            EtatReclamation = "Terminé";
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
                //buttonTerminé.Visible = true;

                string status = da1.GetString(9); // Assuming the 8th column is the status column
                if (status == "Terminé")
                {
                    pictureBox4.Visible = true;
                    //buttonTerminé.Hide();
                }
                else
                {
                    
                    pictureBox4.Visible = false;
                }
               
                string text = "" ;
                text += (!da1.IsDBNull(10) && !string.IsNullOrEmpty(da1.GetString(10))) ? "ACCESSOIRES: " + da1.GetString(10) + "\n" : "";
                text += (!da1.IsDBNull(11) && !string.IsNullOrEmpty(da1.GetString(11))) ? "TISSU: " + da1.GetString(11) + "\n" : "";
                text += (!da1.IsDBNull(12) && !string.IsNullOrEmpty(da1.GetString(12))) ? "COUPE: " + da1.GetString(12) + "\n" : "";
                text += (!da1.IsDBNull(13) && !string.IsNullOrEmpty(da1.GetString(13))) ? "FINITION: " + da1.GetString(13) + "\n" : "";
                text += (!da1.IsDBNull(14) && !string.IsNullOrEmpty(da1.GetString(14))) ? "RECOUPAGE: " + da1.GetString(14) + "\n" : "";
                text += (!da1.IsDBNull(15) && !string.IsNullOrEmpty(da1.GetString(15))) ? "NOTE: " + da1.GetString(15) + "\n" : "";


                label11.Text = text;
                //textBox9.Text = text;
                labelRecl.Text = status; // Setting the label text to the status
                textBox7.Text = da1.GetValue(7).ToString();
                textBox8.Text = da1.GetValue(8).ToString();
            }

            db.conn.Close();
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

          

                textBox3.Text = da.GetValue(2).ToString();
                textBox6.Text = da.GetValue(3).ToString();
                textBox4.Text = da.GetValue(5).ToString();
                textBox13.Text = da.GetValue(7).ToString();
                textBox5.Text = da.GetValue(14).ToString();



            }
            db.conn.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                fillReclamationFromDB();
                FillDetailsFromDb();
               
            }

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            db.conn.Open();

            string dateTraitement = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("UPDATE [SSISDB].[dbo].[ReclamationNew] Set [EtatReclamation]=@EtatReclamation , [DateTraitement]=@DateTraitement where [NrOF] = @NrOF", db.conn);

            cmd.Parameters.AddWithValue("@NrOF", textBox1.Text);
            cmd.Parameters.AddWithValue("@EtatReclamation", EtatReclamation);
            cmd.Parameters.AddWithValue("@DateTraitement", dateTraitement);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Update Done");
            db.conn.Close();

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            labelRecl.Text = "";
            textBox13.Clear();
            //buttonTerminé.Checked = false;
            label11.Text = "";
            pictureBox2.Image = null;
            //RECGenerator.FillTable();
            RECGenerator.UpdateRowCountLabel(lblRowCount);
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            RECGenerator.ExportExcel(dGviewInter);
        }

        private void btnRecAtel_Click(object sender, EventArgs e)
        {

            LISTE_COI_F Atl1 = new LISTE_COI_F();
            Atl1.TopLevel = false;
            AddPanelReclam.Controls.Add(Atl1);
            Atl1.BringToFront();
            Atl1.Show();

        }


        public void DureeReclamation()
        {
            try
            {
                DateTime dateReclamation = DateTime.ParseExact(textBox7.Text, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
                DateTime dateTraitement;

                if (string.IsNullOrWhiteSpace(textBox8.Text))
                {
                    dateTraitement = DateTime.Now;
                }
                else
                {
                    dateTraitement = DateTime.ParseExact(textBox8.Text, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
                }

                TimeSpan difference = dateTraitement - dateReclamation;

                int daysDifference = difference.Days;
                int hoursDifference = difference.Hours;
                int minutesDifference = difference.Minutes;

                string differenceString = "";

                if (daysDifference != 0)
                {
                    differenceString += $"{daysDifference} Jours ";
                }

                if (hoursDifference != 0 || daysDifference != 0)
                {
                    differenceString += $"{hoursDifference} Heures ";
                }

                if (minutesDifference != 0 || hoursDifference != 0 || daysDifference != 0)
                {
                    differenceString += $"{minutesDifference} Minutes";
                }

                label13.Text = differenceString;
            }
            catch (FormatException)
            {
                label13.Text = "";
            }
            catch (Exception ex)
            {
                label13.Text = $"Une erreur s'est produite : {ex.Message}";
            }
        }



        private void pictureBox3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            labelRecl.Text = "";
            textBox13.Clear();
            //buttonTerminé.Checked = false;
            label11.Text = "";
            pictureBox2.Image = null;
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            RECGenerator.FillTableEncours(dGviewInter);
            RECGenerator.UpdateRowCountLabel(lblRowCount);
        }
    }
}
    
