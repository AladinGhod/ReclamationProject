using System;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace GestionReclamation
{
    public class RECGenerator
    {
        MyConnection db = new MyConnection();
        DtoREC DtoREC = new DtoREC();

        public void FillTable(DataGridView dataGridView1)
        {
            SqlConnection cn;
            SqlDataAdapter da;

            cn = new SqlConnection("Data Source=10.0.200.57;Initial Catalog=SSISDB;Integrated Security=False;User Id=saa;Password=admin");
            cn.Open();

            da = new SqlDataAdapter("SELECT [NrOF],[Produit],[Atelier],[Banc],[DateReclamation],[DateTraitement],[EtatReclamation],[Accessoire],[Tissu],[Coupe],[Recoupage],[Finition],[Note] FROM [SSISDB].[dbo].[ReclamationNew]", cn);
            DataTable dtbl = new DataTable();
            da.Fill(dtbl);

            // Set the DataTable as the DataSource for the DataGridView
            dataGridView1.DataSource = dtbl;

            // Close the SqlConnection
            cn.Close();
        }


        public void FillTablebetweenDate(DataGridView dataGridView1,DateTimePicker dateFrom, DateTimePicker dateTo)
        {
            SqlConnection cn;
            SqlDataAdapter da;

            cn = new SqlConnection("Data Source=10.0.200.57;Initial Catalog=SSISDB;Integrated Security=False;User Id=saa;Password=admin");
            cn.Open();

            string dateFrom1 = dateFrom.Value.ToString("yyyy-MM-dd");
            //string dateTo1 = dateTo.Value.ToString("yyyy-MM-dd");
            string dateTo1 = dateTo.Value.AddDays(1).ToString("yyyy-MM-dd");

            da = new SqlDataAdapter("SELECT [NrOF],[Produit],[Atelier],[Banc],[DateReclamation],[DateTraitement],[EtatReclamation],[Accessoire],[Tissu],[Coupe],[Recoupage],[Finition],[Note] FROM [SSISDB].[dbo].[ReclamationNew] WHERE CAST([DateReclamation] AS datetime) >= CAST(@datefrom AS datetime) AND CAST([DateReclamation] AS datetime) <=  CAST(@dateto AS datetime) ORDER BY CAST([DateReclamation] AS datetime) DESC", cn);

            da.SelectCommand.Parameters.AddWithValue("@datefrom", dateFrom1);
            da.SelectCommand.Parameters.AddWithValue("@dateto", dateTo1);

            DataTable dtbl = new DataTable();
            da.Fill(dtbl);

            // Set the DataTable as the DataSource for the DataGridView
            dataGridView1.DataSource = dtbl;

            // Close the SqlConnection
            cn.Close();
        }



        public void FillTableTermine(DataGridView dataGridView1)
        {
            SqlConnection cn;
            SqlDataAdapter da;

            cn = new SqlConnection("Data Source=10.0.200.57;Initial Catalog=SSISDB;Integrated Security=False;User Id=saa;Password=admin");
            cn.Open();

            da = new SqlDataAdapter("SELECT [NrOF],[Produit],[Atelier],[Banc],[DateReclamation],[DateTraitement],[EtatReclamation],[Accessoire],[Tissu],[Coupe],[Recoupage],[Finition],[Note] FROM [SSISDB].[dbo].[ReclamationNew] where [EtatReclamation]='Terminé' order by CAST([DateReclamation] as datetime) DESC ", cn);
            DataTable dtbl = new DataTable();
            da.Fill(dtbl);
   
            dataGridView1.DataSource = dtbl;

            cn.Close();
        }

        public void FillTableEncours(DataGridView dataGridView1)
        {
            SqlConnection cn;
            SqlDataAdapter da;

            cn = new SqlConnection("Data Source=10.0.200.57;Initial Catalog=SSISDB;Integrated Security=False;User Id=saa;Password=admin");
            cn.Open();

            da = new SqlDataAdapter("SELECT [NrOF],[Produit],[Atelier],[Banc],[DateReclamation],[DateTraitement],[EtatReclamation],[Accessoire],[Tissu],[Coupe],[Recoupage],[Finition],[Note] FROM [SSISDB].[dbo].[ReclamationNew] where [EtatReclamation]='En cours' or [EtatReclamation]='Pas traité' order by CAST([DateReclamation] as datetime) DESC ", cn);
            DataTable dtbl = new DataTable();
            da.Fill(dtbl);

            // Set the DataTable as the DataSource for the DataGridView
            dataGridView1.DataSource = dtbl;

            // Close the SqlConnection
            cn.Close();
        }

        public void FillTableRejete(DataGridView dataGridView1)
        {
            SqlConnection cn;
            SqlDataAdapter da;

            cn = new SqlConnection("Data Source=10.0.200.57;Initial Catalog=SSISDB;Integrated Security=False;User Id=saa;Password=admin");
            cn.Open();

            da = new SqlDataAdapter("SELECT [NrOF],[Produit],[Atelier],[Banc],[DateReclamation],[DateTraitement],[EtatReclamation],[Accessoire],[Tissu],[Coupe],[Recoupage],[Finition],[Note] FROM [SSISDB].[dbo].[ReclamationNew] where [EtatReclamation]='Rejeté'", cn);
            DataTable dtbl = new DataTable();
            da.Fill(dtbl);

            // Set the DataTable as the DataSource for the DataGridView
            dataGridView1.DataSource = dtbl;

            // Close the SqlConnection
            cn.Close();
        }
        public void Search(string nrOF)
        {
            using (db.conn)
            {
                if (db.conn.State == ConnectionState.Closed)
                {
                    db.conn.Open();
                    DataTable dt = new DataTable();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM [SSISDB].[dbo].[ListeMajore] where [Nr OF] = @NrOF", db.conn);

                    cmd.Parameters.AddWithValue("@NrOF", nrOF);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);



                }
            }
        }

        public void FillTablebetweenDateReject(DataGridView dataGridView1, DateTimePicker dateFrom, DateTimePicker dateTo)
        {
            SqlConnection cn;
            SqlDataAdapter da;

            cn = new SqlConnection("Data Source=10.0.200.57;Initial Catalog=SSISDB;Integrated Security=False;User Id=saa;Password=admin");
            cn.Open();

            string dateFrom1 = dateFrom.Value.ToString("yyyy-MM-dd");
            //string dateTo1 = dateTo.Value.ToString("yyyy-MM-dd");
            string dateTo1 = dateTo.Value.AddDays(1).ToString("yyyy-MM-dd");

            da = new SqlDataAdapter("SELECT [NrOF],[Produit],[Atelier],[Banc],[DateReclamation],[DateTraitement],[EtatReclamation],[Accessoire],[Tissu],[Coupe],[Recoupage],[Finition],[Note] FROM [SSISDB].[dbo].[ReclamationNew] WHERE [EtatReclamation]='Rejeté' AND CAST([DateReclamation] AS datetime) >= CAST(@datefrom AS datetime) AND CAST([DateReclamation] AS datetime) <=  CAST(@dateto AS datetime) ORDER BY CAST([DateReclamation] AS datetime) DESC", cn);

            da.SelectCommand.Parameters.AddWithValue("@datefrom", dateFrom1);
            da.SelectCommand.Parameters.AddWithValue("@dateto", dateTo1);

            DataTable dtbl = new DataTable();
            da.Fill(dtbl);

            // Set the DataTable as the DataSource for the DataGridView
            dataGridView1.DataSource = dtbl;

            // Close the SqlConnection
            cn.Close();
        }
        public void UpdateReclamation(string nrOF, string Note, byte[] Photo, String DateTraitement, string EtatReclamation, string UrlPhoto, String Accessoire, String Tissu, String Coupe, String Recoupage, String Finition)
        {
            db.conn.Open();

            string dateReclamation = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                SqlCommand updateCmd = new SqlCommand("UPDATE [SSISDB].[dbo].[ReclamationNew] SET Note = @Note, Photo = @Photo, UrlPhoto = @UrlPhoto, DateTraitement = @DateTraitement, EtatReclamation = @EtatReclamation, Accessoire = @Accessoire, Tissu = @Tissu, Coupe = @Coupe, Recoupage = @Recoupage, Finition = @Finition WHERE NrOF = @NrOF", db.conn);
                updateCmd.Parameters.AddWithValue("@NrOF", nrOF);

                updateCmd.Parameters.AddWithValue("@Note", Note);
           

                if (Photo == null && UrlPhoto == null)
                {
                    updateCmd.Parameters.Add("@Photo", SqlDbType.VarBinary, -1).Value = DBNull.Value;
                    updateCmd.Parameters.AddWithValue("@UrlPhoto", "");
                }
                else
                {
                    updateCmd.Parameters.AddWithValue("@Photo", Photo);
                    updateCmd.Parameters.AddWithValue("@UrlPhoto", UrlPhoto);
                }


                //updateCmd.Parameters.AddWithValue("@DateReclamation", dateReclamation);
                updateCmd.Parameters.AddWithValue("@DateTraitement", DateTraitement);
                updateCmd.Parameters.AddWithValue("@EtatReclamation", EtatReclamation);
                updateCmd.Parameters.AddWithValue("@Accessoire", Accessoire);
                updateCmd.Parameters.AddWithValue("@Tissu", Tissu);
                updateCmd.Parameters.AddWithValue("@Coupe", Coupe);
                updateCmd.Parameters.AddWithValue("@Recoupage", Recoupage);
                updateCmd.Parameters.AddWithValue("@Finition", Finition);

                updateCmd.ExecuteNonQuery();
                MessageBox.Show("Updated");

            db.conn.Close();

        }

        public void InsertReclamation(string nrOF, string Note,string Produit,string Atelier,string Banc, byte[] Photo, String DateTraitement, string EtatReclamation, string UrlPhoto, String Accessoire, String Tissu, String Coupe, String Recoupage, String Finition)
        {
            db.conn.Open();

            string dateReclamation = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            SqlCommand insertCmd = new SqlCommand("INSERT INTO [SSISDB].[dbo].[ReclamationNew](NrOF, Note,Produit,Atelier,Banc, Photo, UrlPhoto, DateReclamation, DateTraitement, EtatReclamation, Accessoire, Tissu, Coupe, Recoupage, Finition) VALUES (@NrOF, @Note, @Produit, @Atelier, @Banc, @Photo, @UrlPhoto, @DateReclamation, @DateTraitement, @EtatReclamation, @Accessoire, @Tissu, @Coupe, @Recoupage, @Finition)", db.conn);

            insertCmd.Parameters.AddWithValue("@NrOF", nrOF);
            insertCmd.Parameters.AddWithValue("@Produit", Produit);
            insertCmd.Parameters.AddWithValue("@Atelier", Atelier);
            insertCmd.Parameters.AddWithValue("@Banc", Banc);
            insertCmd.Parameters.AddWithValue("@Note", Note);
    

            if (Photo == null && UrlPhoto == null)
            {
                insertCmd.Parameters.Add("@Photo", SqlDbType.VarBinary, -1).Value = DBNull.Value;
                insertCmd.Parameters.AddWithValue("@UrlPhoto", "");
            }
            else
            {
                insertCmd.Parameters.AddWithValue("@Photo", Photo);
                insertCmd.Parameters.AddWithValue("@UrlPhoto", UrlPhoto);
            }

            insertCmd.Parameters.AddWithValue("@DateReclamation", dateReclamation);
            insertCmd.Parameters.AddWithValue("@DateTraitement", DateTraitement);
            insertCmd.Parameters.AddWithValue("@EtatReclamation", EtatReclamation);
            insertCmd.Parameters.AddWithValue("@Accessoire", Accessoire);
            insertCmd.Parameters.AddWithValue("@Tissu", Tissu);
            insertCmd.Parameters.AddWithValue("@Coupe", Coupe);
            insertCmd.Parameters.AddWithValue("@Recoupage", Recoupage);
            insertCmd.Parameters.AddWithValue("@Finition", Finition);

            insertCmd.ExecuteNonQuery();
            MessageBox.Show("Inserted");

            db.conn.Close();
        }
     


        public void SendMail(DataGridView dataGridView1 , string tbOFapp,string cbCoupeapp, string cbAccapp,string cbFiniapp,string cbRecouapp,string cbTissuapp,string tbNoteapp, out string labelapp)
        {
            db.conn.Open();
            SqlCommand cmd2 = new SqlCommand("select * FROM [SSISDB].[dbo].[ReclamationNew] ", db.conn);
            DataTable dt1 = new DataTable();
            dt1.Load(cmd2.ExecuteReader());
            dataGridView1.DataSource = dt1;

            db.conn.Close();

            tbOFapp = dt1.Rows[0][0].ToString();
            cbCoupeapp = dt1.Rows[0][9].ToString();
            cbAccapp = dt1.Rows[0][7].ToString();
            cbFiniapp = dt1.Rows[0][11].ToString();
            cbRecouapp = dt1.Rows[0][10].ToString();
            cbTissuapp = dt1.Rows[0][8].ToString();
            tbNoteapp = dt1.Rows[0][12].ToString();

            MailMessage mm = new MailMessage("alaeddine.ghodbane@gmail.com", "gala147@alsico.com");
            mm.Subject = "Notification Reclamation pour l'OF = " + tbOFapp;

            StringBuilder body = new StringBuilder();
            body.Append("Reclamation pour l'OF  " + tbOFapp+ " : \n");

            if (!string.IsNullOrEmpty(cbCoupeapp))
                body.Append("* COUPE = " + cbCoupeapp + "\n");

            if (!string.IsNullOrEmpty(cbAccapp))
                body.Append("* ACCESSOIRES = " + cbAccapp + "\n");

            if (!string.IsNullOrEmpty(cbFiniapp))
                body.Append("* FINITION = " + cbFiniapp + "\n");

            if (!string.IsNullOrEmpty(cbRecouapp))
                body.Append("* RECOUPAGE = " + cbRecouapp + "\n");

            if (!string.IsNullOrEmpty(cbTissuapp))
                body.Append("* TISSU = " + cbTissuapp + "\n");

            if (!string.IsNullOrEmpty(tbNoteapp))
                body.Append("* NOTE = " + tbNoteapp + "\n");

            mm.Body = body.ToString();

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            System.Net.NetworkCredential nc = new NetworkCredential("alaeddine.ghodbane@gmail.com", "whvn grkw fddk xpwe");
            smtp.Credentials = nc;
            smtp.EnableSsl = true;
            smtp.Send(mm);
            MessageBox.Show("Your mail has been sent");
            labelapp = "Your mail has been sent";
        }

        public void ExportExcel(DataGridView dataGrid)
        {
            Microsoft.Office.Interop.Excel.Application excelFile = new Microsoft.Office.Interop.Excel.Application();
            excelFile.Workbooks.Add();

            for (int i = 0; i < dataGrid.Columns.Count; i++)
            {
                excelFile.Cells[1, i + 1] = dataGrid.Columns[i].HeaderText;
            }

            for (int i = 0; i < dataGrid.Rows.Count; i++)
            {
                for (int j = 0; j < dataGrid.Columns.Count; j++)
                {
                    excelFile.Cells[i + 2, j + 1] = dataGrid.Rows[i].Cells[j].Value != null ? dataGrid.Rows[i].Cells[j].Value.ToString() : "";
                }
            }
            excelFile.Columns.AutoFit();
            excelFile.Visible = true;
        }

        public void FillReclamationFromDB(string tOF, out string cAcc, out string cTissu, out string cCoupe, out string cFini, out string cRecoup, out string tNote)
        {
            cAcc = null;
            cTissu = null;
            cCoupe = null;
            cFini = null;
            cRecoup = null;
            tNote = null;

            db.conn.Open();

            SqlCommand cmd1 = new SqlCommand("SELECT * FROM [SSISDB].[dbo].[ReclamationNew] WHERE [NrOF] = @NrOF", db.conn);
            cmd1.Parameters.AddWithValue("@NrOF", tOF);

            SqlDataReader da1 = cmd1.ExecuteReader();

            while (da1.Read())
            {
                cAcc = da1.GetString(10);
                cTissu = da1.GetString(11);
                cCoupe = da1.GetString(12);
                cFini = da1.GetString(13);
                cRecoup = da1.GetString(14);
                tNote = da1.GetString(15);
            }

            db.conn.Close();
        }

        public int GetRowCount()
        {
            int rowCount = 0;
            try
            {
                db.conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM [SSISDB].[dbo].[V_ReclamNonTerminé] ", db.conn);
                rowCount = (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                db.conn.Close();
            }
            return rowCount;
        }
        public void UpdateRowCountLabel(Label label)
        {
            int rowCount = GetRowCount();
            label.Text = "Total Reclamation Ouvert: " + rowCount.ToString();
        }

        public int GetRowCountRejeté()
        {
            int rowCount = 0;
            try
            {
                db.conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM [SSISDB].[dbo].[ReclamationNew] where [EtatReclamation]='Rejeté' ", db.conn);
                rowCount = (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                db.conn.Close();
            }
            return rowCount;
        }
        public void UpdateRowCountLabelRejet(Label label)
        {
            int rowCount = GetRowCountRejeté();
            label.Text = "Total Reclamation Rejet: " + rowCount.ToString();
        }

        public int GetRowCountTermine()
        {
            int rowCount = 0;
            try
            {
                db.conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM [SSISDB].[dbo].[ReclamationNew] where [EtatReclamation]='Terminé' ", db.conn);
                rowCount = (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                db.conn.Close();
            }
            return rowCount;
        }
        public void UpdateRowCountLabelTermine(Label label)
        {
            int rowCount = GetRowCountTermine();
            label.Text = "Total Reclamation Terminé: " + rowCount.ToString();
        }
    }
}
