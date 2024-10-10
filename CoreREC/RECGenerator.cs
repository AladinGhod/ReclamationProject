using System;
using System.Data;
using System.Data.SqlClient;


namespace CoreREC
{
    public class RECGenerator
    {
        MyConnection db = new MyConnection();
        DtoREC DtoREC = new DtoREC();

        public void FillTable()
        {
            SqlConnection cn;
            SqlDataAdapter da;

            cn = new SqlConnection("Data Source=.;Initial Catalog=TestDB;Integrated Security=True");
            cn.Open();

            da = new SqlDataAdapter("SELECT * FROM[TestDB].[dbo].[TestListeMajore] ", cn);
            DataTable dtbl = new DataTable();
            da.Fill(dtbl);
        }
        public void Search(string nrOF)
        {
            using (db.conn)
            {
                if (db.conn.State == ConnectionState.Closed)
                {
                    db.conn.Open();
                    DataTable dt = new DataTable();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM [TestDB].[dbo].[TestListeMajore] where [Nr OF] = @NrOF", db.conn);

                    cmd.Parameters.AddWithValue("@NrOF", nrOF);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);



                }
            }
        }

    }
}
