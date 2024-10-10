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
    public partial class ATL_F : Form
    {

        MyConnection db = new MyConnection();
        private RECGenerator RECGenerator = new RECGenerator();



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


        public ATL_F()
        {
            InitializeComponent();

            RECGenerator.FillTableEncours(dGview);
            btnMinimize.Click += btnMinimize_Click;
            btnClose.Click += btnClose_Click;
            RECGenerator.UpdateRowCountLabel(lblRowCount);
            pictureBox3.Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ATL_F_Load(object sender, EventArgs e)
        {
           
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
                RECGenerator.ExportExcel(dGview);
        }
        private void dGview_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && dGview.SelectedRows.Count > 0 && dGview.CurrentRow != null)
            {
                textBox7.Text = dGview.SelectedRows[0].Cells[4].Value.ToString();
                textBox1.Text = dGview.SelectedRows[0].Cells[0].Value.ToString();
                DataGridViewRow currentRow = dGview.CurrentRow;

                
            }

            fillReclamationFromDB();
            FillDetailsFromDb();
        }

        private string EtatReclamation;

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            EtatReclamation = "En cours";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            EtatReclamation = "Terminé";
        }

        private void btnRejected_CheckedChanged(object sender, EventArgs e)
        {
            EtatReclamation = "Rejeté";
        }

        private DataTable dt1 = new DataTable();

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
                textBox6.Text = da.GetValue(2).ToString();
                textBox4.Text = da.GetValue(4).ToString();
                textBox13.Text = da.GetValue(6).ToString();
                textBox5.Text = da.GetValue(14).ToString();


                DateTime dateLivraison = DateTime.ParseExact(textBox5.Text, "dd.MM.yy", CultureInfo.InvariantCulture);

                // Check if the date is within the same week as today
                DateTime today = DateTime.Today;
                DateTime startOfWeek = today.AddDays(-(int)today.DayOfWeek);
                DateTime endOfWeek = startOfWeek.AddDays(6);

                if (dateLivraison >= startOfWeek && dateLivraison <= endOfWeek)
                {
                    // Date is within the same week as today
                    pictureBox3.Visible = true;
                    textBox5.BackColor = Color.Yellow;
                }
                else
                {
                    // Date is not within the same week as today
                    pictureBox3.Visible = false;
                    textBox5.BackColor = SystemColors.Window;
                }

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
                label14.Text = da1.GetValue(9).ToString();
            }

            db.conn.Close();
        }

        
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            db.conn.Open();

            string dateTraitement = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            DataTable dt = new DataTable();

            string noteValue = "";

            if (btnRejected.Checked)
            {
                noteValue = "\nCAUSE REJET : " + tbNote.Text;
            }

            SqlCommand cmd = new SqlCommand("UPDATE [SSISDB].[dbo].[ReclamationNew] SET [Note]=[Note]+@Note, [EtatReclamation]=@EtatReclamation, [DateTraitement]=@DateTraitement WHERE [NrOF] = @NrOF and [DateReclamation] =@DateReclamation", db.conn);

            cmd.Parameters.AddWithValue("@NrOF", textBox1.Text);
            cmd.Parameters.AddWithValue("@EtatReclamation", EtatReclamation);
            cmd.Parameters.AddWithValue("@DateTraitement", dateTraitement);
            cmd.Parameters.AddWithValue("@DateReclamation", textBox7.Text);
            cmd.Parameters.AddWithValue("@Note", noteValue);

            if (!radioButton1.Checked && !btnRejected.Checked && !radioButton2.Checked)
            {
                MessageBox.Show("Choisir un Etat");
            }

            else if (btnRejected.Checked && string.IsNullOrEmpty(tbNote.Text))
            {
                MessageBox.Show("Ajouter une note");
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
                textBox6.Clear();
                textBox7.Clear();
                tbNote.Clear();
                label8.Text = "";
                label14.Text = "";
                textBox13.Clear();
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                btnRejected.Checked = false;
                ImgRec.Image = null;

                textBox5.BackColor = SystemColors.Window;
                pictureBox3.Visible = false;
            }

            db.conn.Close();
            RECGenerator.FillTableEncours(dGview);
            RECGenerator.UpdateRowCountLabel(lblRowCount);


        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void btnRecAtel_Click(object sender, EventArgs e)
        {

            ALL_REC_F Atl1 = new ALL_REC_F();
                Atl1.TopLevel = false;
                panel1.Controls.Add(Atl1);
                Atl1.BringToFront();
                Atl1.Show();
            
        }

        

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            tbNote.Clear();
            label8.Text = "";
            label14.Text = "";
            textBox13.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            btnRejected.Checked = false;
            ImgRec.Image = null;

            textBox5.BackColor = SystemColors.Window;
            pictureBox3.Visible = false;
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            RECGenerator.FillTableEncours(dGview);
            RECGenerator.UpdateRowCountLabel(lblRowCount);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            RECGenerator.UpdateRowCountLabel(lblRowCount);
        }
    }
}
