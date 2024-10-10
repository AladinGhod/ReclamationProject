using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionReclamation
{
    public partial class Form2 : Form
    {

        // Importation de la fonction nécessaire pour déplacer la fenêtre sans bordure
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        // Constantes pour la manipulation de la fenêtre
        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x2;

        public Form2()
        {
            InitializeComponent();

            btnMinimize.Click += btnMinimize_Click;
            btnClose.Click += btnClose_Click;
        }

        private void YourForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbUser.Text == "Atelier" && tbPsd.Text == "atelier")
            {
                ATL_F atl = new ATL_F();
               
                atl.Show();
                this.Hide();
            }
            else if (tbUser.Text == "COI" && tbPsd.Text == "coi")
            {
                COI_F atl = new COI_F();
              
                atl.Show();
                this.Hide();
            }
            else if (tbUser.Text == "REC" && tbPsd.Text == "rec")
            {
                REC_F rec = new REC_F();
                
                rec.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Verifier le mdp ou le username");
                tbPsd.Clear();
                tbUser.Clear();
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
