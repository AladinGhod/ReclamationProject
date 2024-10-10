using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionReclamation
{
    public partial class REC_F : Form
    {
        MyConnection db = new MyConnection();
        private RECGenerator RECGenerator = new RECGenerator();


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        

        // Constantes pour la manipulation de la fenêtre
        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x2;


        public REC_F()
        {
            InitializeComponent();
            btnMinimize.Click += btnMinimize_Click;
            btnClose.Click += btnClose_Click;
            int rowCount = RECGenerator.GetRowCountTermine();
            if (rowCount > 0)
            {
                lbNotif.Text = rowCount.ToString();
                lbNotif.Visible = true;
                
            }
            else
            {
                lbNotif.Visible = false;
               
            }


        }

        // Événement de clic de souris pour permettre le déplacement du formulaire
        private void YourForm_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 Logout = new Form2();
            
            Logout.Show();
        }

        public void fillReclamationFromDB(string tbOF)
        {
            db.conn.Open();


            SqlCommand cmd1 = new SqlCommand("SELECT * FROM [SSISDB].[dbo].[ReclamationNew] where [NrOF] = @NrOF and [Atelier]=@Atelier", db.conn);
            cmd1.Parameters.AddWithValue("@NrOF", tbOF);
            cmd1.Parameters.AddWithValue("@Atelier", tbAtelier.Text);

            SqlDataReader da1;
            da1 = cmd1.ExecuteReader();

            while (da1.Read())
            {

                cbAcc.Text = da1.GetValue(10).ToString();
                cbTissu.Text = da1.GetValue(11).ToString();
                cbCoupe.Text = da1.GetValue(12).ToString();
                cbExport.Text = da1.GetValue(13).ToString();
                cbFinition.Text = da1.GetValue(14).ToString();
                tbNote.Text = da1.GetValue(15).ToString();

            }

            db.conn.Close();
        }

        public void fillListeMajoreFromDB(string tbOF)
        {
            db.conn.Open();

            SqlCommand countCmd = new SqlCommand("SELECT COUNT(*) FROM [SSISDB].[dbo].[ListeMajore] WHERE [Nr OF] = @NrOF", db.conn);
            countCmd.Parameters.AddWithValue("@NrOF", tbOF);
            int count = (int)countCmd.ExecuteScalar();

            // If there are duplicates, make the btnNext visible; otherwise, hide it
            btnNext.Visible = count > 1;
            label1.Visible = count > 1;

            // Fetch and display the data
            SqlCommand cmd = new SqlCommand("SELECT * FROM [SSISDB].[dbo].[ListeMajore] WHERE [Nr OF] = @NrOF", db.conn);
            cmd.Parameters.AddWithValue("@NrOF", tbOF);
            SqlDataReader da = cmd.ExecuteReader();

            while (da.Read())
            {
                string atelierText;
                int atelierValue;

                // Try to convert da.GetValue(0) to an integer
                if (int.TryParse(da.GetValue(0).ToString(), out atelierValue))
                {
                    // If the conversion succeeds, use the switch statement
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
                }
                else
                {
                    // If the conversion fails, assign the value as a string
                    atelierText = da.GetValue(0).ToString();
                }


                tbAtelier.Text = atelierText;
                tbBanc.Text = da.IsDBNull(1) ? "" : da.GetString(1);
                tbStatut.Text = da.IsDBNull(2) ? "" : da.GetString(2);
                tbProduit.Text = da.IsDBNull(4) ? "" : da.GetString(4);
                tbQte.Text = da.IsDBNull(6) ? "" : da.GetValue(6).ToString();
                tbLivraison.Text = da.IsDBNull(14) ? "" : da.GetValue(14).ToString();

                string minProdString = da.IsDBNull(13) ? "" : da.GetValue(13).ToString();
                if (minProdString.Contains('.'))
                {
                    minProdString = minProdString.Split('.')[0];
                }
                int minprod = Convert.ToInt32(minProdString);
                int minprod1 = minprod / 100;
                string minProd2 = minprod1.ToString();
                tbMinProd.Text = minProd2;
            }

            da.Close();
            db.conn.Close();
        }


        private void tbOF_TextChanged(object sender, EventArgs e)
        {
            //if (!string.IsNullOrEmpty(tbOF.Text))
            //{
            //    try
            //    {

                    string tbOF1 = tbOF.Text.Replace(" ", "");
                    fillListeMajoreFromDB(tbOF1);

                    fillReclamationFromDB(tbOF1);


                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show("An error occurred: " + ex.Message);
                //    db.conn.Close();
                //}
            //}
        }



        string Urlimage = null;
        private void btnbrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Urlimage = ofd.FileName;
                pictureBox5.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void btnAjout_Click(object sender, EventArgs e)
        {

                String EtatReclamation = "Pas traité";
                if (string.IsNullOrEmpty(tbProduit.Text) || string.IsNullOrEmpty(tbOF.Text))
            {
                MessageBox.Show("Entrer le numero OF correctement..");
                tbOF.Clear();
                cbAcc.SelectedIndex = -1;
                cbCoupe.SelectedIndex = -1;
                cbExport.SelectedIndex = -1;
                cbFinition.SelectedIndex = -1;
                cbTissu.SelectedIndex = -1;
                tbNote.Clear();
                return;
            }

                if ( (string.IsNullOrEmpty(cbAcc.Text)&& string.IsNullOrEmpty(cbCoupe.Text) && string.IsNullOrEmpty(cbExport.Text) && string.IsNullOrEmpty(cbFinition.Text) && string.IsNullOrEmpty(cbTissu.Text)))
                {
                    MessageBox.Show("Entrer le motif necessaire de la reclamation ..");
                
                    cbAcc.SelectedIndex = -1;
                    cbCoupe.SelectedIndex = -1;
                    cbExport.SelectedIndex = -1;
                    cbFinition.SelectedIndex = -1;
                    cbTissu.SelectedIndex = -1;
                    tbNote.Clear();
                    return;
                }
                byte[] arr = null;

                if (pictureBox5.Image != null & Urlimage != null)
                {
                    Image img = pictureBox5.Image;
                    ImageConverter converter = new ImageConverter();
                    arr = (byte[])converter.ConvertTo(img, typeof(byte[]));
                }

                string tbOFapp = tbOF.Text;
                string tbNoteapp = tbNote.Text;
                string cbCoupeapp = cbCoupe.Text;
                string cbAccapp = cbAcc.Text;
                string cbFiniapp = cbFinition.Text;
                string cbTissuapp = cbTissu.Text;
                string cbRecouapp = cbExport.Text;
                string labelapp = label16.Text;
                string tbProduitapp = tbProduit.Text;
                string tbAtelierapp = tbAtelier.Text;
                string tbBancapp = tbBanc.Text;

                string dateReclamation = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                string dateTraitement = "";
                db.conn.Open();

                SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM [SSISDB].[dbo].[ReclamationNew] WHERE NrOF = @NrOF and Atelier = @Atelier", db.conn);
                checkCmd.Parameters.AddWithValue("@NrOF", tbOFapp);
                checkCmd.Parameters.AddWithValue("@Atelier", tbAtelierapp);
                int count = (int)checkCmd.ExecuteScalar();

                if (count > 0)
                {
                    DialogResult result = MessageBox.Show(tbOFapp+" a déja une Reclamation. Voulez vous ajouter une autre ?", "Confirmation", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        RECGenerator.InsertReclamation(tbOFapp, tbNoteapp, tbProduitapp, tbAtelierapp, tbBancapp, arr, dateTraitement, EtatReclamation, Urlimage, cbAccapp, cbTissuapp, cbCoupeapp, cbRecouapp, cbFiniapp);
                        //RECGenerator.SendMail(dataGridView1, tbOFapp, cbCoupeapp, cbAccapp, cbFiniapp, cbRecouapp, cbTissuapp, tbNoteapp, out labelapp);

                    }

                }
                else
                {

                    RECGenerator.InsertReclamation(tbOFapp, tbNoteapp, tbProduitapp, tbAtelierapp, tbBancapp, arr, dateTraitement, EtatReclamation, Urlimage, cbAccapp, cbTissuapp, cbCoupeapp, cbRecouapp, cbFiniapp);
                    //RECGenerator.SendMail(dataGridView1, tbOFapp, cbCoupeapp, cbAccapp, cbFiniapp, cbRecouapp, cbTissuapp, tbNoteapp, out labelapp);
                }

                db.conn.Close();


            ClearAll();


        }

       

        private void btnReclamation_Click(object sender, EventArgs e)
        {
            REC_F rec = new REC_F();

            rec.Show();
            this.Hide();

            int rowCount = RECGenerator.GetRowCountTermine();
            if (rowCount > 0)
            {
                lbNotif.Text = rowCount.ToString();
                lbNotif.Visible = true;
            }
            else
            {
                lbNotif.Visible = false;
            }

        }

        private void btnRecAtel_Click(object sender, EventArgs e)
        {
            LISTE_COI_F Atl1 = new LISTE_COI_F();
            Atl1.TopLevel = false;
            AddPanelReclam.Controls.Add(Atl1);
            Atl1.BringToFront();
            Atl1.Show();

            int rowCount = RECGenerator.GetRowCountTermine();
            if (rowCount > 0)
            {
                lbNotif.Text = rowCount.ToString();
                lbNotif.Visible = true;

            }
            else
            {
                lbNotif.Visible = false;

            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

       public void ClearAll()
        {
            tbOF.Clear();
            tbProduit.Clear();
            tbNote.Clear();
            tbBanc.Clear();
            tbAtelier.Clear();
            tbLivraison.Clear();
            tbMinProd.Clear();
            tbQte.Clear();
            tbStatut.Clear();
            pictureBox5.Image = null;
            cbAcc.SelectedIndex = -1;
            cbCoupe.SelectedIndex = -1;
            cbExport.SelectedIndex = -1;
            cbFinition.SelectedIndex = -1;
            cbTissu.SelectedIndex = -1;
            tbNote.Clear();
            btnNext.Visible = false;
            label1.Visible = false;
        }

        public void ClearAllwithoutOF()
        {
            
            tbProduit.Clear();
            tbNote.Clear();
            tbBanc.Clear();
            tbAtelier.Clear();
            tbLivraison.Clear();
            tbMinProd.Clear();
            tbQte.Clear();
            tbStatut.Clear();
            pictureBox5.Image = null;
            cbAcc.SelectedIndex = -1;
            cbCoupe.SelectedIndex = -1;
            cbExport.SelectedIndex = -1;
            cbFinition.SelectedIndex = -1;
            cbTissu.SelectedIndex = -1;
            tbNote.Clear();
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            cbAcc.SelectedIndex = -1;
            
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            cbTissu.SelectedIndex = -1;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            cbCoupe.SelectedIndex = -1;

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            cbFinition.SelectedIndex = -1;

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            cbExport.SelectedIndex = -1;
        }



        private int currentrow = -1;
        private DataTable dt;


        public void getDatafromDbLM(string tbOF)
        {
            db.conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM [SSISDB].[dbo].[ListeMajore] WHERE [Nr OF] = @NrOF", db.conn);
            cmd.Parameters.AddWithValue("@NrOF", tbOF);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            db.conn.Close();
        }

        public void ShowNextValueLM()

        {
            ClearAllwithoutOF();
            
            DataRow row = dt.Rows[currentrow];

            int atelierValue = Convert.ToInt32(row["Filiale"]);
            string atelierText;

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

            tbAtelier.Text = atelierText;
            tbBanc.Text = row.IsNull("Banc") ? "" : row["Banc"].ToString();
            tbStatut.Text = row.IsNull("Statut") ? "" : row["Statut"].ToString();
            tbProduit.Text = row.IsNull("Produit") ? "" : row["Produit"].ToString();
            tbQte.Text = row.IsNull("Qte OF") ? "" : row["Qte OF"].ToString();
            tbLivraison.Text = row.IsNull("Date Livraison") ? "" : row["Date Livraison"].ToString();

            string minProdString = row.IsNull("Temps Production") ? "" : row["Temps Production"].ToString();
            if (minProdString.Contains('.'))
            {
                minProdString = minProdString.Split('.')[0];
            }
            int minprod = Convert.ToInt32(minProdString);
            int minprod1 = minprod / 100;
            string minProd2 = minprod1.ToString();
            tbMinProd.Text = minProd2;

        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            string tbOF1 = tbOF.Text.Replace(" ", "");
            if (dt == null)
            {
                getDatafromDbLM(tbOF1);
            }

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No data found.");
                return;
            }

            currentrow++;
            if (currentrow > dt.Rows.Count - 1)
            {
                currentrow = 0; 
            }

            ShowNextValueLM();
            fillReclamationFromDB(tbOF1);
        }

        private void btnReception_Click(object sender, EventArgs e)
        {
            int rowCount = RECGenerator.GetRowCountTermine();
            if (rowCount > 0)
            {
                lbNotif.Text = rowCount.ToString();
                lbNotif.Visible = true;

            }
            else
            {
                lbNotif.Visible = false;

            }
            RECEPTION_F Atl1 = new RECEPTION_F();
            Atl1.TopLevel = false;
            AddPanelReclam.Controls.Add(Atl1);
            Atl1.BringToFront();
            Atl1.Show();
        }
    }
}
